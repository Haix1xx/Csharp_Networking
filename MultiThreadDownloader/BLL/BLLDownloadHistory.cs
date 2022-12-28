using MultiThreadDownloader.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadDownloader.BLL
{
    public static class BLLDownloadHistory
    {
        private static readonly string StoragePath = @".\asset\storage.bin";

        public static void SaveTo(DownloadResult result)
        {
            using (var stream = new FileStream(StoragePath, FileMode.Append, FileAccess.Write))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, result);
            }
        }

        public static List<DownloadResult> LoadAll()
        {
            List<DownloadResult> list = new List<DownloadResult>();
            using(var stream = new FileStream(StoragePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                var formatter = new BinaryFormatter();
                while(stream.Position != stream.Length)
                {
                    var item = formatter.Deserialize(stream) as DownloadResult;
                    if (item != null)
                        list?.Add(item);
                }    
            }
            return list;
        }

        public static void ClearHistory()
        {
            using(var stream = File.Open(StoragePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                lock(stream)
                {
                    stream.SetLength(0);
                }    
            }    
        }
    }
}
