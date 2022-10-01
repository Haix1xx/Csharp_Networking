using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Client
    {
        // Gửi yêu cầu HTTP, nhận Header chứa kích cỡ file định tải
        public static async Task<long> GetFileLength(string url)
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Head;
            request.RequestUri = new Uri(url);

            var response = await httpClient.SendAsync(request);
            var result = response.Content.Headers.GetValues("Content-Length");
            return long.Parse(result.FirstOrDefault());
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
                    await streamwrite.WriteAsync(buffer, 0, numberByte);
                    Console.WriteLine("Downloading");
                }
                while (numberByte > 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
