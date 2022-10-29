using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Client
    {
        public static async Task BeginDownload(string url, string fileName, int totalThread)
        {
            var beginTime = DateTime.Now;
            // Lấy file length
            long fileLength = await GetFileLength(url);
            Console.WriteLine($"File length: {fileLength} bytes");
            // Xác định range tải cho từng thread
            List<Range> ranges = CalculateRange(fileLength, totalThread);
            Console.WriteLine("Calculate Range");
            ranges.ForEach(range => Console.WriteLine($"    Key: {range.ChunkIndex}, Range: {range.Start} - {range.End}"));
            // Tạo instance & bắt đầu tải
            Download newDownload = new Download(url, fileName, ranges);
            await newDownload.ParallelDownload();
            var endTime = DateTime.Now;
            Console.WriteLine("Download done in: " + (endTime - beginTime));
        }

        // Gửi yêu cầu HTTP, nhận Header chứa kích cỡ file định tải
        private static async Task<long> GetFileLength(string url)
        {
            var httpClient = new HttpClient();
            // Chỉ rõ nội dung của HTTP request: gửi về chỉ phần Header, trong đó chứa kích cỡ file cần tải
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Head;
            request.RequestUri = new Uri(url);
            // Gửi HTTP request
            var response = await httpClient.SendAsync(request);
            // Lấy kích cỡ file, nằm ở phần Content-Length
            var result = response.Content.Headers.GetValues("Content-Length");
            return long.Parse(result.FirstOrDefault());
        }

        private static List<Range> CalculateRange(long contentLength, int totalThread)
        {
            var readRanges = new List<Range>();
            for (var chunk = 0; chunk < totalThread-1; chunk++)
            {
                var range = new Range
                {
                    Start = chunk * (contentLength / totalThread),
                    End = (chunk + 1) * (contentLength / totalThread) - 1,
                    ChunkIndex = chunk
                };
                readRanges.Add(range);
            }
            // Kích cỡ của range cuối nhỏ hơn các range trước đó
            readRanges.Add(new Range
            {
                Start = readRanges.Any() ? readRanges.Last().End + 1 : 0,
                End = contentLength - 1,
                ChunkIndex = readRanges.Count()
            });
            return readRanges;
        }

    }
}
