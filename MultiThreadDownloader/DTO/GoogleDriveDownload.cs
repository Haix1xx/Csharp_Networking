using Google.Apis.Download;
using Google.Apis.Drive.v3;
using MultiThreadDownloader.BLL;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader.DTO
{
    public class GoogleDriveDownload : Download
    {
        public List<RangeHeaderValue> Ranges { get; set; }
        private ConcurrentDictionary<string, string> dict;
        private DriveService Service { get; set; }

        public GoogleDriveDownload(string url, string filePath, List<RangeHeaderValue> ranges, DriveService service)
        {
            this.Url = url;
            this.FilePath = filePath;
            this.Ranges = ranges;
            this.Service = service;
            this.dict = new ConcurrentDictionary<string, string>();
        }
        public override async Task StartDownload()
        {
            await ParalellDownload();
        }
        public async Task ParalellDownload()
        {
            try
            {
                //Lay id cua file trong googledrive
                string id = GoogleDriverHelper.GetLinkId(this.Url);
                // List các thread
                List<Task> allTask = new List<Task>();
                // Chạy song song các thread
                Parallel.ForEach(Ranges, new ParallelOptions { MaxDegreeOfParallelism = -1 }, range =>
                {
                    Task task = PartialDownload(id, range);
                    task.ConfigureAwait(false);
                    allTask.Add(task);
                });
                // Chờ mọi thread tải xong
                await Task.WhenAll(allTask);
                // Tạo file đích
                FileStream fileStream = new FileStream(FilePath, FileMode.Append);
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
            catch (TaskCanceledException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (Exception e)
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
        private async Task PartialDownload(string id, RangeHeaderValue range)
        {
            var request = Service.Files.Get(id);
            var stream = new MemoryStream();
            request.MediaDownloader.ProgressChanged += progress => 
            {
                switch (progress.Status)
                {
                    case DownloadStatus.Downloading:
                        {
                            //this.Progress?.Report((int)progress.BytesDownloaded);
                            break;
                        }
                    case DownloadStatus.Completed:
                        {
                            this.Progress?.Report((int)progress.BytesDownloaded);
                            break;
                        }
                    case DownloadStatus.Failed:
                        {
                            MessageBox.Show("Fail.");
                            break;
                        }
                }
            };
            await request.DownloadRangeAsync(stream, new RangeHeaderValue(range.Ranges.FirstOrDefault().From, range.Ranges.FirstOrDefault().To));    
            string tempFilePath = LoadStreamToFile(stream);
            //MessageBox.Show(stream.Length.ToString());
            stream.Close();
            dict.TryAdd(range.Unit, tempFilePath);
        }
        private static string LoadStreamToFile(MemoryStream data)
        {
            // Tạo file nhớ tạm
            var tempFilePath = Path.GetTempFileName();
            var streamWrite = File.OpenWrite(tempFilePath);
            data.WriteTo(streamWrite);
            streamWrite.Close();
            return tempFilePath;
        }
    }
}
