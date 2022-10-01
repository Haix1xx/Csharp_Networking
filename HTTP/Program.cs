using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    internal class Program
    {
        static void ShowHeaders(HttpResponseHeaders headers)
        {
            Console.WriteLine("Headers");
            foreach (var header in headers)
            {
                Console.WriteLine($"{header.Key} {header.Value}");
            }
        }
        public async static Task<string> GetWebContent(string url)
        {
            var httpClient = new HttpClient();
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                ShowHeaders(response.Headers);
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "exception";
            }
        }
        public static async Task DownloadStream(string url, string fileName)
        {
            var httpClient = new HttpClient();
            try
            {
                var responseMessage = await httpClient.GetAsync(url);
                var stream = await responseMessage.Content.ReadAsStreamAsync();
                const int SIZEBUFFER = 500;
                var buffer = new byte[SIZEBUFFER];
                int numberByte = 0;
                var streamwrite = File.OpenWrite(fileName);
                do
                {
                    numberByte = await stream.ReadAsync(buffer, 0, SIZEBUFFER);
                    await streamwrite.WriteAsync(buffer, 0,  numberByte);
                    Console.WriteLine("Downloading");
                }
                while (numberByte > 0);
            }
            catch (Exception e)
            {

            }
        }
        static async Task Main(string[] args)
        {
            //var url = "https://www.google.com";
            //var uri = new Uri(url);
            //var ipHostEntry = Dns.GetHostEntry(uri.Host);
            //Console.WriteLine(ipHostEntry.HostName);
            //ipHostEntry.AddressList.ToList().ForEach(ip => {
            //    Console.WriteLine(ip);
            //});
            //var url = "https://www.google.com/search?q=xuanthulab";
            //var task = GetWebContent(url);
            //task.Wait();
            //var content = task.Result;
            //Console.WriteLine(content);
            string url = "https://kenh14cdn.com/thumb_w/620/203336854389633024/2021/6/22/anh-chup-man-hinh-2021-06-18-luc-185739-1624017476541782671842-16243407293961052640072.png";
            string url1 = "data:image/jpeg;base64,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";
            string fileName = "b.png";
            await DownloadStream(url1, fileName);
            Console.ReadKey();
        }
    }
}
