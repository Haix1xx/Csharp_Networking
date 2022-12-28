using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadDownloader.DTO
{
    public class DowloadMultiThreadReport
    {
        public long downloadedSize { get; set; }
        
        public bool isComplete { get; set; }
        public TimeSpan totalTime { get; set; }


       
    }
}

    
