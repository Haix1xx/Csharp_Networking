using MultiThreadDownloader.DTO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader.BLL
{
    public class BLLDownloadProcessing
    {
        public static async Task<TimeSpan> BeginDownload(Download download)
        {
            var beginTime = DateTime.Now;
            await download.StartDownload();
            var endTime = DateTime.Now;
            var result = new DownloadResult()
            {
                FileName = BLLConverter.GetFileName(download.FilePath),
                FileSize = BLLConverter.FileSizeToString(download.FileSize),
                TimeDownload = beginTime,
                Status = "Complete"
            };
            BLLDownloadHistory.SaveTo(result);
            return endTime - beginTime;
        }

        public static DataTable GetMultiThreadReport(ConcurrentDictionary<int, DownloadReport> reports)
        {
            DataTable results = new DataTable();
            results.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Thread ID", DataType = typeof(string)},
                new DataColumn {ColumnName = "Downloaded", DataType = typeof(string)},
                new DataColumn {ColumnName = "Total Time", DataType = typeof(string)},
                new DataColumn {ColumnName = "Average Speed", DataType = typeof(string)},
                new DataColumn {ColumnName = "Is Completed", DataType = typeof(bool)}
            });
            foreach (var report in reports.Values)
            {
                results.Rows.Add(
                    report.key.ToString(), 
                    BLLConverter.FileSizeToString(report.downloadedSize),
                    report.totalTime.Hours.ToString() + "h " + report.totalTime.Minutes.ToString() + "m " + report.totalTime.Seconds.ToString() + "s", 
                    BLLConverter.BandWidthToString(report.averageSpeed), 
                    report.isComplete
                );
            }
            return results;
        }
    }
}
