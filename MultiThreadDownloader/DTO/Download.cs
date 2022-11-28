using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader.DTO
{
    public abstract class Download
    {
        public string url { get; set; }
        public string filePath { get; set; }
        protected HttpClient httpClient = new HttpClient() { Timeout = TimeSpan.FromMinutes(10) };
        public IProgress<int> progress { get; set; }

        public abstract Task StartDownload();
    }
}
