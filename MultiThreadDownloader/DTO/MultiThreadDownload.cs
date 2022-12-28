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
        TimeSpan totalTime;
        public List<DownloadReport> reports { get; set; } = new List<DownloadReport>();
        private ConcurrentDictionary<int, string> dict;
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
                DateTime timeStart = DateTime.Now;
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
                DateTime timeEnd = DateTime.Now;
                this.totalTime = timeEnd - timeStart;
                fileStream.Close();
            }
            catch (TaskCanceledException e)
            {
                MessageBox.Show(e.ToString());
            }
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
            DownloadReport report = new DownloadReport()
            {
                key = 0,
                maxSpeed = 0,
                isComplete = false,
            };
            report.startTime = DateTime.Now;
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri(url);
            // Xác định phần nội dung cần tải, từ vị trí start đến vị trí end
            if (request.Headers.Contains("Range"))
                request.Headers.Remove("Range");
            request.Headers.Add("Range", $"bytes={range.Start}-{range.End}");
            // Gửi HTTP request, chờ phản hồi từ URL
            var responseMessage = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            // Đọc nội dung của HTTP response
            var stream = await responseMessage.Content.ReadAsStreamAsync();
            // Ghi nội dung vào 1 file nhớ tạm
            var tempFilePath = await LoadStreamToFile(stream, report, range);


            // Gắn ChunkIndex & tempFilePath vào 1 Dictionary
            dict.TryAdd(range.ChunkIndex, tempFilePath);

            report.endTime = DateTime.Now;
            reports.Add(report);
            // Giải phóng
            stream.Close();
            request.Dispose();
            responseMessage.Dispose();
            //httpClient.Dispose();
        }
        private async Task<String> LoadStreamToFile(Stream data,  DownloadReport report, Range range)
        {

            // Tạo file nhớ tạm
            var tempFilePath = Path.GetTempFileName();
            // Biến bộ nhớ đệm, khi đọc đủ kích thước bộ nhớ đệm thì sẽ ghi vào file, rồi tiếp tục đọc
            const int SIZEBUFFER = 4096;
            var buffer = new byte[SIZEBUFFER];
            // Biến đếm byte đã đọc
            int numberByteRead;
            // Xác định file ghis
            var streamWrite = File.OpenWrite(tempFilePath);
            // Vòng lặp đọc & ghi
            do
            {
                DateTime begin = DateTime.Now;
                // Đọc nội dung vào bộ nhớ đệm
                numberByteRead = await data.ReadAsync(buffer, 0, SIZEBUFFER);
                if (numberByteRead > 0)
                {
                    // Ghi dữ liệu bộ nhớ đệm vào file
                    await streamWrite.WriteAsync(buffer, 0, numberByteRead);
                    // Đo bandwidth tức thời (bit/s)
                    TimeSpan time = (DateTime.Now - begin);
                    long currentSpeed = (long)(SIZEBUFFER * 8 / time.TotalSeconds);
                    // Xác định bandwidth lớn nhất
                    if (report.maxSpeed < currentSpeed)
                        report.maxSpeed = currentSpeed;
                    // Đếm số byte đã đọc
                    report.downloadedSize += numberByteRead;
                    progress?.Report(numberByteRead);
                    // Report tiến độ cho UI progress bar
                    progress?.Report(numberByteRead);
                }
            }
            while (numberByteRead > 0);
            streamWrite.Close();
            if (report.downloadedSize == (range.End - range.Start + 1))
                report.isComplete = true;
            //report.endTime = DateTime.Now;
            //this.reports.Add(report);
            return tempFilePath;
        }
        public DowloadMultiThreadReport getReportInfo()
        {
            DowloadMultiThreadReport reportInfo = new DowloadMultiThreadReport()
            {
                isComplete = false,
            };
            long size = 0;
            double totalTime = 0;
     
            foreach(var report in reports)
            {
                size += report.downloadedSize;
            }
            totalTime += reports[reports.Count - 1].totalTime.TotalSeconds + this.totalTime.TotalSeconds;
            reportInfo.totalTime  = TimeSpan.FromSeconds(totalTime);
            long fileSize = 0;
            foreach(Range r in ranges)
            {
                fileSize += r.End - r.Start;
            }
            if(fileSize + this.ranges.Count == size )
                reportInfo.isComplete = true;
            reportInfo.downloadedSize = fileSize + this.ranges.Count;
            return reportInfo;


        }
    }

    
}
