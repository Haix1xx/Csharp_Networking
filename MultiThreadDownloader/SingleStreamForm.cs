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
    public partial class SingleStreamForm : Form
    {
        private SingleStreamDownload download;
        public delegate void InvokeForm();
        public InvokeForm BackForm { get; set; }
        public InvokeForm CloseForm { get; set; }
        public SingleStreamForm(Download download)
        {
            InitializeComponent();
            this.download = download as SingleStreamDownload;
            InitGUI();
        }
        public void InitGUI()
        {
            this.urlTextbox.Text = download.Url;
            this.filePathTextbox.Text = download.FilePath;
            this.sizeTextbox.Text = BLLConverter.FileSizeToString(download.fileLength);
            progressBar.Maximum = (int)download.fileLength;
            var progress = new Progress<int>(ReportProgress);
            this.download.Progress = progress;
        }
        public void ReportProgress(int value)
        {
            var currentValue = progressBar.Value + value;
            if (currentValue <= progressBar.Maximum)
            {
                progressBar.Value = currentValue;
            }
            else
            {
                progressBar.Value = progressBar.Maximum;
            }

        }
        private async void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                detailButton.Enabled = false;
                startButton.Enabled = false;
                progressBar.Value = 0;
                TimeSpan totalTime = await BLLDownloadProcessing.BeginDownload(this.download);
                DialogResult dialogResult = MessageBox.Show("Download done in: " + totalTime.ToString());
                detailButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                startButton.Enabled = true;
            }
        }
        private void SingleStreamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackForm?.Invoke();
        }
        private void detailButton_Click(object sender, EventArgs e)
        {
            SingleStreamReport form = new SingleStreamReport(download.report);
            form.ShowDialog();
        }
    }
}
