using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.downloadedSize.Text = report.downloadedSize.ToString() + " bytes";
            this.maxSpeed.Text = report.maxSpeed.ToString() + " bit/s";
            this.averageSpeed.Text = report.averageSpeed.ToString() + " bit/s";
        }
    }
}
