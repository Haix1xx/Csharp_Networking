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
            //var result = await Client.GetFileLength(url);
            //Console.WriteLine(result.ToString());

            //var task1 = new Task(() => Client.DownloadStream(url, "file1.aspx"));
            //var task2 = new Task(() => Client.DownloadStream(url, "file2.aspx"));
            //var task3 = new Task(() => Client.DownloadStream(url, "file3.aspx"));
            //task1.Start();
            //task2.Start();
            //task3.Start();
            //await task1;
            //await task2;
            //await task3;
            var task = await Client.GetFileLength(url1);
            Console.WriteLine(task);
            Console.ReadKey();
        }


    }
}
