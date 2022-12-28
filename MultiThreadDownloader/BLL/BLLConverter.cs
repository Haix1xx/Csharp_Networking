using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadDownloader.BLL
{
    public static class BLLConverter
    {
        public static double TB = Math.Pow(2, 40);
        public static double GB = Math.Pow(2, 30);
        public static double MB = Math.Pow(2, 20);
        public static double KB = Math.Pow(2, 10);
        public static double B = Math.Pow(2, 3);

        public static string FileSizeToString(long fileSize)
        {
            string unit;
            double result;
            if (fileSize >= TB)
            {
                result = (double)fileSize / TB;
                unit = "TB";
            }
            else if (fileSize >= GB)
            {
                result = (double)fileSize / GB;
                unit = "GB";
            }
            else if (fileSize >= MB)
            {
                result = (double)fileSize / MB;
                unit = "MB";
            }
            else if (fileSize >= KB)
            {
                result = (double)fileSize / KB;
                unit = "KB";
            }
            else
            {
                result = (double)fileSize / B;
                unit = "B";
            }    
            return Math.Round(result, 2).ToString() + " " + unit;
        }

        public static string BandWidthToString(long bandwidth)
        {
            string unit;
            double result;
            if (bandwidth >= TB)
            {
                result = (double)bandwidth / TB;
                unit = "Tbps";
            }
            else if (bandwidth >= GB)
            {
                result = (double)bandwidth / GB;
                unit = "Gbps";
            }
            else if (bandwidth >= MB)
            {
                result = (double)bandwidth / MB;
                unit = "Mbps";
            }
            else if (bandwidth >= KB)
            {
                result = (double)bandwidth / KB;
                unit = "Kbps";
            }
            else
            {
                result = (double)bandwidth / B;
                unit = "bps";
            }
            return Math.Round(result, 2).ToString() + " " + unit;
        }

        public static string GetFileName(string path)
        {
            var temp = path.Split('\\');
            return temp[temp.Length - 1];
        }
    }
}
