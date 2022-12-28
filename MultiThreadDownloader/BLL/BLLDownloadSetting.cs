using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MultiThreadDownloader.DTO;
namespace MultiThreadDownloader.BLL
{
    public class BLLDownloadSetting
    {
        public static async Task<long> GetFileLength(string url)
        {
            try
            {
                var httpClient = new HttpClient();
                // Chỉ rõ nội dung của HTTP request: gửi về chỉ phần Header, trong đó chứa kích cỡ file cần tải
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Head;
                request.RequestUri = new Uri(url);
                // Gửi HTTP request
                var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                // Lấy kích cỡ file, nằm ở phần Content-Length
                var result = response.Content.Headers.GetValues("Content-Length");
                return long.Parse(result.FirstOrDefault());
            }
            catch (Exception e)
            {
                throw new Exception("Failed to get file length");
            }
        }
        public static async Task<string> GetFileType(string url)
        {
            try
            {
                var httpClient = new HttpClient();
                // Chỉ rõ nội dung của HTTP request: gửi về chỉ phần Header, trong đó chứa kích cỡ file cần tải
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Head;
                request.RequestUri = new Uri(url);
                // Gửi HTTP request
                var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                // Lấy kích cỡ file, nằm ở phần Content-Length
                var result = response.Content.Headers.GetValues("Content-Type").First();
                return result.Split(';')[0].Split('/')[1];
            }
            catch (Exception e)
            {
                throw new Exception("Failed to get file type");
            }
        }
        public static List<Range> CalculateRange(long contentLength, int totalThread)
        {
            var readRanges = new List<Range>();
            for (var chunk = 0; chunk < totalThread - 1; chunk++)
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
