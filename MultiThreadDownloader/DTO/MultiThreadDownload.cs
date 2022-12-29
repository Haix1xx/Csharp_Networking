using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader.DTO
{
    public class MultiThreadDownload : Download
    {
        public List<Range> ranges { get; set; }
        private ConcurrentDictionary<int, string> dict;
        public ConcurrentDictionary<int, DownloadReport> reports; 
        public async override Task StartDownload()
        {
            await ParallelDownload();
        }
        
        public MultiThreadDownload(string url, string filePath, List<Range> ranges)
        {
            this.url = url;
            this.filePath = filePath;
            this.ranges = ranges;
            this.dict = new ConcurrentDictionary<int, string>();
            this.reports = new ConcurrentDictionary<int, DownloadReport>();
            foreach (Range range in ranges)
            {
                reports.TryAdd(range.ChunkIndex, new DownloadReport()
                {
                    key = range.ChunkIndex,
                    isComplete = false,
                });
            }
        }
        public async Task ParallelDownload()
        {
            try
            {
                // List các thread
                List<Task> allTask = new List<Task>();
                // Chạy song song các thread
                Parallel.ForEach(ranges, new ParallelOptions { MaxDegreeOfParallelism = -1 }, range =>
                {
                    Task task = PartialDownload(url, range);
                    task.ConfigureAwait(false);
                    allTask.Add(task); 
                });
                // Chờ mọi thread tải xong
                await Task.WhenAll(allTask);
                // Tạo file đích
                FileStream fileStream = new FileStream(filePath, FileMode.Append);
                // Vòng lặp ghép file
                foreach (var tempFile in dict.OrderBy(a => a.Key))
                {
                    // Chỉ ghép 1 file tại 1 thời điểm
                    lock (fileStream)
                    {
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
            //catch (TaskCanceledException e)
            //{
            //    MessageBox.Show(e.ToString());
            //}
            catch (Exception)
            {
                // Dọn file nhớ tạm
                foreach (var tempFile in dict)
                {
                    File.Delete(tempFile.Value);
                }
                // Ném thông báo lỗi
                throw new Exception("Download failed");
            }
        }
        // Hàm tải từng phần của 1 file
        private async Task PartialDownload(string url, Range range)
        {
            //var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri(url);
            // Xác định phần nội dung cần tải, từ vị trí start đến vị trí end
            if (request.Headers.Contains("Range"))
                request.Headers.Remove("Range");
            request.Headers.Add("Range", $"bytes={range.Start}-{range.End}");
            // Tính thời gian chạy luồng, ban đầu bằng nhau để totalTime = 0
            var time = DateTime.Now;
            reports[range.ChunkIndex].startTime = time;
            reports[range.ChunkIndex].endTime = time;
            // Gửi HTTP request, chờ phản hồi từ URL
            var responseMessage = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            // Đọc nội dung của HTTP response
            var stream = await responseMessage.Content.ReadAsStreamAsync();
            // Ghi nội dung vào 1 file nhớ tạm
            var tempFilePath = await LoadStreamToFile(stream, range.ChunkIndex);
            // Gắn ChunkIndex & tempFilePath vào 1 Dictionary
            dict.TryAdd(range.ChunkIndex, tempFilePath);
            // Giải phóng
            stream.Close();
            request.Dispose();
            responseMessage.Dispose();
            //httpClient.Dispose();
        }
        private async Task<String> LoadStreamToFile(Stream data, int key)
        {
            // Tạo file nhớ tạm
            var tempFilePath = Path.GetTempFileName();
            // Biến bộ nhớ đệm, khi đọc đủ kích thước bộ nhớ đệm thì sẽ ghi vào file, rồi tiếp tục đọc
            const int SIZEBUFFER = 4096;
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
                if (numberByteRead > 0)
                {
                    // Ghi dữ liệu bộ nhớ đệm vào file
                    await streamWrite.WriteAsync(buffer, 0, numberByteRead);
                    // Report tiến độ cho UI progress bar & DownloadReport
                    reports[key].downloadedSize += numberByteRead;
                    progress?.Report(numberByteRead);
                }
            }
            while (numberByteRead > 0);
            streamWrite.Close();
            // Báo cáo trạng thái luồng
            reports[key].isComplete = true;
            reports[key].endTime = DateTime.Now;
            return tempFilePath;
        }
    }
}