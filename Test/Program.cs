using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url = "http://sv.dut.udn.vn/G_ListCTDT.aspx";
            string url1 = "https://raw.githubusercontent.com/xuanthulabnet/learn-cs-netcore/master/imgs/cs022.png";
            string url3 = "https://gist.github.com/mahen-github/fa575d35885f5519cf3beea1e173e6c0#file-1gb-data-txt";
            // Chỉ rõ url, filePath & số thread
            await Client.BeginDownload("https://test2.fibertelecom.it/512MB.zip", "C:\\Users\\PC\\Desktop\\down\\a.zip", 10);
            Console.ReadKey();
        }
    }
}
