using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadDownloader.DTO
{
    [Serializable]
    public class DownloadResult
    {
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public DateTime TimeDownload { get; set; }
        public string Status { get; set; } = "Incomplete";

    }
}
