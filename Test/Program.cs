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
            string test = "https://test2.fibertelecom.it/100MB.zip";
            string pdf = "https://ww1.microchip.com/downloads/en/devicedoc/atmel-7766-8-bit-avr-atmega16u4-32u4_datasheet.pdf";
            // Chỉ rõ url, filePath & số thread
            await Client.BeginDownload(pdf, "C:\\Users\\PC\\Desktop\\down\\abc.pdf", 8);
            Console.ReadKey();
        }
    }
}