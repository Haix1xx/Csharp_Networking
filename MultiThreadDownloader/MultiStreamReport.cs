using MultiThreadDownloader.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader
{
    public partial class MultiStreamReport : Form
    {
        public MultiStreamReport(List<DownloadReport> reports, DowloadMultiThreadReport reportInfo)
        {
            InitializeComponent();
            GUI(reports, reportInfo);
        }
        private void GUI(List<DownloadReport> reports, DowloadMultiThreadReport reportInfo)
        {
            if (reports != null)
            {
                dataGridView1.DataSource = reports;
            }



            this.isComplete.Text = reportInfo.isComplete.ToString();
            this.totalTime.Text = reportInfo.totalTime.Hours.ToString() + "h " + reportInfo.totalTime.Minutes.ToString() + "m " + reportInfo.totalTime.Seconds.ToString() + "s" + reportInfo.totalTime.Milliseconds.ToString() +  " ms";
            this.downloadedSize.Text = reportInfo.downloadedSize.ToString() + " bytes";
            //this.maxSpeed.Text = report.maxSpeed.ToString() + " bit/s";
            //this.averageSpeed.Text = report.averageSpeed.ToString() + " bit/s";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
