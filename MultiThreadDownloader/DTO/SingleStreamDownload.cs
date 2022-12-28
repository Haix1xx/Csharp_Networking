using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadDownloader.DTO
{
    public class SingleStreamDownload : Download
    {
        public DownloadReport report { get; set; }
        public long fileLength { get; set; }
        public SingleStreamDownload(string url, string filePath, long fileLength)
        {
            this.url = url;
            this.filePath = filePath;
            this.fileLength = fileLength;
            this.report = new DownloadReport()
            {
                key = 0,
                isComplete = false,
            };
        }
        public async override Task StartDownload()
        {
            await Download();
        }
        public async Task Download()
        {
            try
            {
                report.startTime = DateTime.Now;
                // Gửi HTTP request, chờ phản hồi từ URL
                var responseMessage = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                // Đọc nội dung của HTTP response
                var stream = await responseMessage.Content.ReadAsStreamAsync();
                // Biến bộ nhớ đệm, khi đọc đủ kích thước bộ nhớ đệm thì sẽ ghi vào file, rồi tiếp tục đọc
                const int SIZEBUFFER = 4096;
                var buffer = new byte[SIZEBUFFER];
                
                int numberByteRead = 0;
                // Xác định file ghi
                var streamWrite = File.OpenWrite(filePath);
                // Vòng lặp đọc & ghi
                do
                {
                    // Đọc nội dung vào bộ nhớ đệm
                    numberByteRead = await stream.ReadAsync(buffer, 0, SIZEBUFFER);
                    // Ghi dữ liệu bộ nhớ đệm vào file
                    await streamWrite.WriteAsync(buffer, 0, numberByteRead);
                    // Đếm số byte đã đọc
                    report.downloadedSize += numberByteRead;
                    progress?.Report(numberByteRead);
                }
                while (numberByteRead > 0);
                streamWrite.Close();
                if (report.downloadedSize == fileLength)
                    report.isComplete = true;
                report.endTime = DateTime.Now;
                // Truyền report lên?
            }
            catch (Exception)
            {
                File.Delete(filePath);
                // Ném thông báo lỗi
                throw new Exception("Download failed");
            }
        }
    }
}
