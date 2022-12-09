using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiThreadDownloader.BLL;
using MultiThreadDownloader.DTO;

namespace MultiThreadDownloader
{
    public partial class SingleStreamReport : Form
    {
        public SingleStreamReport(DownloadReport report)
        {
            InitializeComponent();
            GUI(report);
        }

        private void GUI(DownloadReport report)
        {
            this.isComplete.Text = report.isComplete.ToString();
            this.totalTime.Text = report.totalTime.Hours.ToString() + "h " + report.totalTime.Minutes.ToString() + "m " + report.totalTime.Seconds.ToString() + "s";
            this.downloadedSize.Text = BLLConverter.FileSizeToString(report.downloadedSize);
            this.maxSpeed.Text = BLLConverter.BandWidthToString(report.maxSpeed);
            this.averageSpeed.Text = BLLConverter.BandWidthToString(report.averageSpeed);
        }
    }
}
