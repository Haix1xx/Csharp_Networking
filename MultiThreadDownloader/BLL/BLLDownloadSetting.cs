using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Drive.v3;
using Google.Apis.Http;
using MultiThreadDownloader.DTO;
namespace MultiThreadDownloader.BLL
{
    public class BLLDownloadSetting
    {
        //public static async Task<long> GetFileLength(string url)
        //{
        //    try
        //    {
        //        var httpClient = new HttpClient();
        //        // Chỉ rõ nội dung của HTTP request: gửi về chỉ phần Header, trong đó chứa kích cỡ file cần tải
        //        var request = new HttpRequestMessage();
        //        request.Method = HttpMethod.Head;
        //        request.RequestUri = new Uri(url);
        //        // Gửi HTTP request
        //        var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        //        // Lấy kích cỡ file, nằm ở phần Content-Length
        //        var result = response.Content.Headers.GetValues("Content-Length");
        //        return long.Parse(result.FirstOrDefault());
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("Failed to get file length");
        //    }
        //}
        //public static async Task<string> GetFileType(string url)
        //{
        //    try
        //    {
        //        var httpClient = new HttpClient();
        //        // Chỉ rõ nội dung của HTTP request: gửi về chỉ phần Header, trong đó chứa kích cỡ file cần tải
        //        var request = new HttpRequestMessage();
        //        request.Method = HttpMethod.Head;
        //        request.RequestUri = new Uri(url);
        //        // Gửi HTTP request
        //        var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
        //        // Lấy kích cỡ file, nằm ở phần Content-Length
        //        var result = response.Content.Headers.GetValues("Content-Type").First();
        //        return result.Split(';')[0].Split('/')[1];
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("Failed to get file type");
        //    }
        //}

        public static async Task<string[]> GetFileInfo(string url)
        {
            try
            {
                var httpClient = new HttpClient();
                // Chỉ rõ nội dung của HTTP request: gửi về chỉ phần Header, trong đó chứa kích cỡ file cần tải
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Head,
                    RequestUri = new Uri(url)
                };
                // Gửi HTTP request
                var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                // Lấy kích cỡ file, nằm ở phần Content-Length
                string fileLength = response.Content.Headers.GetValues("Content-Length").FirstOrDefault();
                string fileType = response.Content.Headers.GetValues("Content-Type").FirstOrDefault().Split(';')[0].Split('/')[1];
                return new string[] { fileLength, fileType };
            }
            catch (Exception e)
            {
                throw new Exception("Failed to get file length");
            }
        }
        public static List<Range> CalculateRange(long contentLength, int totalThread)
        {
            var readRanges = new List<Range>();
            for (var chunk = 0; chunk < totalThread - 1; chunk++)
            {
                var range = new Range
                {
                    Start = chunk * (contentLength / totalThread),
                    End = (chunk + 1) * (contentLength / totalThread) - 1,
                    ChunkIndex = chunk
                };
                readRanges.Add(range);
            }
            // Kích cỡ của range cuối nhỏ hơn các range trước đó
            readRanges.Add(new Range
            {
                Start = readRanges.Any() ? readRanges.Last().End + 1 : 0,
                End = contentLength - 1,
                ChunkIndex = readRanges.Count()
            });
            return readRanges;
        }
        
        // Google Drive's
        public static async Task<string[]> GetFileLength(string url, DriveService service)
        {
            try
            {
                string id = GoogleDriverHelper.GetLinkId(url);
                var fileRequest = service.Files.Get(id);
                fileRequest.Fields = "size, fullFileExtension, originalFilename";
                var fileResponse = await fileRequest.ExecuteAsync();
                var size = fileResponse.Size.Value;
                //var fileExtension = fileResponse.FullFileExtension;
                var fileName = fileResponse.OriginalFilename;
                string[] result ={ size.ToString(), fileName };

                // Chỉ rõ nội dung của HTTP request: gửi về chỉ phần Header, trong đó chứa kích cỡ file cần tải
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Head,
                    RequestUri = new Uri(url)
                };
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to get file length");
            }
        }
        public static List<RangeHeaderValue> CalculateRangeHeaderValue(long contentLength, int totalThread)
        {
            var readRanges = new List<RangeHeaderValue>();
            long End = 0;
            long Start;
            for (var chunk = 0; chunk < totalThread - 1; chunk++)
            {
                Start = chunk * (contentLength / totalThread);
                End = (chunk + 1) * (contentLength / totalThread) - 1;
                var range = new RangeHeaderValue(Start, End)
                {
                    Unit = chunk.ToString()
                };
                readRanges.Add(range);
            }
            // Kích cỡ của range cuối nhỏ hơn các range trước đó
            Start = readRanges.Any() ? End + 1 : 0;
            readRanges.Add(new RangeHeaderValue(Start, contentLength - 1)
            {
                Unit = readRanges.Count().ToString()
            });
            return readRanges;
        }
    }
}
