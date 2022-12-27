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
using System.Runtime.CompilerServices;

namespace MultiThreadDownloader
{
    public partial class MultiThreadForm : Form
    {
        //private MultiThreadDownload downloadM;
        //private GoogleDriveDownload downloadG;
        private Download download;
        public delegate void InvokeForm();
        public InvokeForm BackForm { get; set; }
        public InvokeForm CloseForm { get; set; }
        public MultiThreadForm()
        {
            InitializeComponent();            
        }

        public MultiThreadForm(Download download)
        {
            InitializeComponent();
            //this.download = download as MultiThreadDownload;
            this.download = download;
            InitGUI();
        }
        public void InitGUI()
        {
            //this.urlTextbox.Text = download.url;
            //this.filePathTextbox.Text = download.filePath;
            //this.sizeTextbox.Text = download.ranges.Last().End.ToString();
            //progressBar.Maximum = (int)download.ranges.Last().End;
            //var progress = new Progress<int>(ReportProgress);
            //this.download.progress = progress;
            if(download is GoogleDriveDownload)
            {
                GoogleDriveDownload downloadG = (GoogleDriveDownload)download;
                this.urlTextbox.Text = downloadG.Url;
                this.filePathTextbox.Text = downloadG.FilePath;
                //this.sizeTextbox.Text = download.ranges.Last().Ranges.FirstOrDefault().To.ToString();
                progressBar.Maximum = (int)downloadG.Ranges.Last().Ranges.FirstOrDefault().To;
                var progress = new Progress<int>(ReportProgress);
                this.download.Progress = progress;
            }
            else if(download is MultiThreadDownload)
            {
                MultiThreadDownload downloadM = (MultiThreadDownload)download;
                this.urlTextbox.Text = download.Url;
                this.filePathTextbox.Text = download.FilePath;
                this.sizeTextbox.Text = downloadM.Ranges.Last().End.ToString();
                progressBar.Maximum = (int)downloadM.Ranges.Last().End;
                var progress = new Progress<int>(ReportProgress);
                this.download.Progress = progress;
            }

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
                progressBar.Value = 0;
                var task = await BLLDownloadProcessing.BeginDownload(this.download);
                DialogResult dialogResult =  MessageBox.Show("Download done in: " + task);
                if(dialogResult == DialogResult.OK)
                {
                    BackForm = null;
                    CloseForm?.Invoke();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                startButton.Enabled = true;
                //throw ex;                
            }
        }

        private void MultiThreadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackForm?.Invoke();
        }
    }
}
