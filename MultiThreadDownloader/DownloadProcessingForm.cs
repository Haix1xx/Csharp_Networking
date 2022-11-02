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
using MultiThreadDownloader.BLL;
namespace MultiThreadDownloader
{
    public partial class DownloadProcessingForm : Form
    {
        private Download download;
        public DownloadProcessingForm()
        {
            InitializeComponent();
        }
        public DownloadProcessingForm(Download download)
        {
            InitializeComponent();
            this.download = download;
            this.urlTextbox.Text = download.url;
            this.filePathTextbox.Text = download.filePath;
            this.sizeTextbox.Text = download.ranges.Last().End.ToString();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            await BLLDownloadProcessing.BeginDownload(this.download);
        }
    }
}
