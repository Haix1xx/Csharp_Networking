using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader.BLL
{
    public class GoogleDriverHelper
    {
        private static string[] Scopes = new string[] { DriveService.Scope.Drive, DriveService.Scope.DriveReadonly, DriveService.Scope.DriveFile};
        private static string Client_id = @".\asset\client_secret.json";
        private static string CrePath = @".\asset\tokenpath.json";

        public async static Task<UserCredential> GetUserCredential()
        {
            UserCredential credential;
            using(var stream = new FileStream(Client_id, FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(CrePath, true));

                await credential.GetAccessTokenForRequestAsync();
                return credential;
            }
            
        }
        public static string GetLinkId(string link)
        {
            var temp = link.Split('/');
            return temp[5];
        }
        public static string GetDirectDownloadLink(string link)
        {
            string downloadLink = "https://drive.google.com/uc?export=download&id=";
            return downloadLink + GetLinkId(link);
        }
        public static async Task<DriveService> GetService()
        {
            UserCredential user = await GetUserCredential();
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = user,
                ApplicationName = "Downloader"
            });
            return service;
            
        }
        public static bool RemoveService()
        {
            try
            {
                File.Delete(CrePath);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
