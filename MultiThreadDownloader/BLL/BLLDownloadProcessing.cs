using MultiThreadDownloader.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader.BLL
{
    public class BLLDownloadProcessing
    {
        public static async Task<TimeSpan> BeginDownload(Download download)
        {
            var beginTime = DateTime.Now;
            await download.StartDownload();
            var endTime = DateTime.Now;
            var result = new DownloadResult()
            {
                FileName = BLLConverter.GetFileName(download.FilePath),
                FileSize = BLLConverter.FileSizeToString(download.FileSize),
                TimeDownload = beginTime,
                Status = "Complete"
            };
            BLLDownloadHistory.SaveTo(result);
            return endTime - beginTime;
            //MessageBox.Show("Download done in: " + (endTime - beginTime));
        }
    }
}
