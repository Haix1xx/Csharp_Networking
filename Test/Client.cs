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
        // Gửi yêu cầu HTTP, nhận Header chứa kích cỡ file định tải
        public static async Task<long> GetFileLength(string url)
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

        public static async Task DownloadStream(string url, string fileName)
        {
            var httpClient = new HttpClient();
            try
            {
                // Gửi HTTP request, chờ phản hồi từ URL
                var responseMessage = await httpClient.GetAsync(url);
                // Đọc nội dung của HTTP response
                var stream = await responseMessage.Content.ReadAsStreamAsync();
                // Biến bộ nhớ đệm, khi đọc đủ kích thước bộ nhớ đệm thì sẽ ghi vào file, rồi tiếp tục đọc
                const int SIZEBUFFER = 500;
                var buffer = new byte[SIZEBUFFER];
                //
                int numberByte = 0;
                // Xác định file ghi
                var streamwrite = File.OpenWrite(fileName);
                // Vòng lặp đọc & ghi
                do
                {
                    // Đọc nội dung vào bộ nhớ đệm
                    numberByte = await stream.ReadAsync(buffer, 0, SIZEBUFFER);
                    // Ghi dữ liệu bộ nhớ đệm vào file
                    await streamwrite.WriteAsync(buffer, 0, numberByte);
                    Console.WriteLine("Downloading");
                }
                while (numberByte > 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static async Task PartialDownload(string url, string fileName, Range range)
        {
            var httpClient = new HttpClient();
            try
            {
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                request.RequestUri = new Uri(url);
                // Xác định phần nội dung cần tải, từ vị trí start đến vị trí end
                if (request.Headers.Contains("Range"))
                    request.Headers.Remove("Range");
                request.Headers.Add("Range", $"bytes={range.Start}-{range.End}");
                // Gửi HTTP request, chờ phản hồi từ URL
                var responseMessage = await httpClient.SendAsync(request);
                // Đọc nội dung của HTTP response
                var stream = await responseMessage.Content.ReadAsStreamAsync();
                // Ghi nội dung vào 1 file nhớ tạm
                string tempFilePath = await createTempFile(stream);
                // to do: Gắn tempFilePath & ChunkIndex vào 1 Dictionary
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Range> CalculateRange(long contentLength, int totalThread)
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
            // Trường hợp hiếm: contentLength/totalThread < 0
            readRanges.Add(new Range
            {
                Start = readRanges.Any() ? readRanges.Last().End + 1 : 0,
                End = contentLength - 1,
                ChunkIndex = readRanges.Count() + 1
            });
            return readRanges;
        }

        public static async Task<string> createTempFile(Stream data)
        {
            // Tạo file nhớ tạm
            var tempFilePath = Path.GetTempFileName();
            // Biến bộ nhớ đệm, khi đọc đủ kích thước bộ nhớ đệm thì sẽ ghi vào file, rồi tiếp tục đọc
            const int SIZEBUFFER = 1024;
            var buffer = new byte[SIZEBUFFER];
            // Biến đếm byte đã đọc
            int numberByteRead = 0;
            // Xác định file ghi
            var streamWrite = File.OpenWrite(tempFilePath);
            // Vòng lặp đọc & ghi
            do
            {
                // Đọc nội dung vào bộ nhớ đệm
                numberByteRead = await data.ReadAsync(buffer, 0, SIZEBUFFER);
                // Ghi dữ liệu bộ nhớ đệm vào file
                await streamWrite.WriteAsync(buffer, 0, numberByteRead);
                // to do: progress counter code
            }
            while (numberByteRead > 0);
            return tempFilePath;
        }
    }
}
