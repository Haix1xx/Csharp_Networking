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
            // Chỉ rõ url, filePath & số thread
            await Client.BeginDownload(url1, "C:\\Users\\PC\\Desktop\\abc\\xyz.png", 4);
            Console.WriteLine("done");
            Console.ReadKey();
        }


    }
}
