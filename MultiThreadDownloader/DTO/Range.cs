using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadDownloader.DTO
{
    public class Range
    {
        public long Start { get; set; }
        public long End { get; set; }
        public int ChunkIndex { get; set; }
    }
}
