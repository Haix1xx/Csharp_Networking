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
        public static async Task BeginDownload(Download download)
        {
            var beginTime = DateTime.Now;
            await download.StartDownload();
            var endTime = DateTime.Now;
            MessageBox.Show("Download done in: " + (endTime - beginTime));
        }
    }
}
