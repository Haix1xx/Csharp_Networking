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
            return endTime - beginTime;
            //MessageBox.Show("Download done in: " + (endTime - beginTime));
        }
    }
}
