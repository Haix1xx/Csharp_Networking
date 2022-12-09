using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadDownloader.DTO
{
    public class DownloadReport
    {
        public int key { get; set; }
        public long downloadedSize { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isComplete { get; set; }
        public long maxSpeed { get; set; }
        public long averageSpeed 
        { 
            get
            {
                return downloadedSize/(endTime-startTime).Seconds;
            }
            private set { } 
        }
        public TimeSpan totalTime 
        { 
            get 
            { 
                return (endTime - startTime);
            }
            private set { }
        }
    }
}
