using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    public class Download
    {
        public string url { get; set; }
        public string filePath { get; set; }
        public List<Range> ranges { get; set; }
        // Dictionary chứa các file nhớ tạm
        private ConcurrentDictionary<int, string> dict;
        public Download(string url, string filePath, List<Range> ranges)
        {
            this.url = url;
            this.filePath = filePath;
            this.ranges = ranges;
            dict = new ConcurrentDictionary<int, string>();
        }

        public async Task SingleStreamDownload(string url, string fileName)
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
        
        public async Task ParallelDownload()
        { 
            try
            {
                // List các thread
                List<Task> allTask = new List<Task>();
                // Chạy song song các thread
                Console.WriteLine("Parallel thread");
                Parallel.ForEach(ranges, range => allTask.Add(PartialDownload(url, range)));
                // Chờ mọi thread tải xong
                await Task.WhenAll(allTask);
                // Tạo file đích
                FileStream fileStream = new FileStream(filePath, FileMode.Append);
                // Vòng lặp ghép file
                Console.WriteLine("Join file");
                foreach (var tempFile in dict.OrderBy(a => a.Key))
                {
                    // Chỉ ghép 1 file tại 1 thời điểm
                    lock (fileStream)
                    {
                        Console.WriteLine($"    Key: {tempFile.Key}, Path: {tempFile.Value}");
                        // Đọc file nhớ tạm
                        byte[] tempFileByte = File.ReadAllBytes(tempFile.Value);
                        // Ghi vào file đích
                        fileStream.Write(tempFileByte, 0, tempFileByte.Length);
                        // Xóa file nhớ tạm
                        File.Delete(tempFile.Value);
                    }
                }
                fileStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // Hàm tải từng phần của 1 file
        private async Task PartialDownload(string url, Range range)
        {
            Console.WriteLine($"    Key {range.ChunkIndex} start, Thread ID: {Thread.CurrentThread.ManagedThreadId,3}");
            var httpClient = new HttpClient();
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
            Console.WriteLine($"    Key {range.ChunkIndex} done: " + tempFilePath);
            // Gắn ChunkIndex & tempFilePath vào 1 Dictionary
            dict.TryAdd(range.ChunkIndex, tempFilePath);
            // Giải phóng
            stream.Close();
            request.Dispose();
            httpClient.Dispose();
        }
        private static async Task<string> createTempFile(Stream data)
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
            //Console.WriteLine("Done at: " + DateTime.Now);
            streamWrite.Close();
            return tempFilePath;
        }
    }
}