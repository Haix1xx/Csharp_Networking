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
using System.Threading;

namespace MultiThreadDownloader
{
    public partial class MultiThreadForm : Form
    {
        private Download download;
        public MultiThreadForm()
        {
            InitializeComponent();            
        }

        public MultiThreadForm(Download download)
        {
            InitializeComponent();
            this.download = download;
            this.urlTextbox.Text = download.url;
            this.filePathTextbox.Text = download.filePath;
            this.sizeTextbox.Text = download.ranges.Last().End.ToString();
            progressBar.Maximum = (int)download.ranges.Last().End;
            var progress = new Progress<int>(ReportProgress);
            this.download.progress = progress;
        }
        public void ReportProgress(int value)
        {
            var currentValue = progressBar.Value + value;
            if (currentValue <= progressBar.Maximum)
            {
                progressBar.Value = currentValue;
                //textLabel.Text = currentValue.ToString();
            }
            else
            {
                progressBar.Value = progressBar.Maximum;
                //textLabel.Text = progressBar1.Maximum.ToString();
            }    
            
        }
        private async void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                startButton.Enabled = false;    
                await BLLDownloadProcessing.BeginDownload(this.download);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                startButton.Enabled = true;
            }
        }

    }
}
