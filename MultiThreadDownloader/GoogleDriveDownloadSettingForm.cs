using Google.Apis.Drive.v3;
using Google.Apis.Http;
using MultiThreadDownloader.BLL;
using MultiThreadDownloader.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader
{
    public partial class GoogleDriveDownloadSettingForm : Form
    {
        private string url;
        private long fileSize;
        public delegate void InvokeForm();
        public InvokeForm Back { get; set; }
        public InvokeForm CloseForm { get; set; }
        public ConfigurableHttpClient httpClient = null;
        public DriveService Service = null;
        public GoogleDriveDownloadSettingForm()
        {
            InitializeComponent();
        }
        public GoogleDriveDownloadSettingForm(string url, DriveService Service)
        {
            InitializeComponent();
            this.url = url;
            this.Service = Service;
        }
        private async void DownloadSettingForm_Load(object sender, EventArgs e)
        {
            confirmButton.Enabled = false;
            numericUpDown.Value = 4;
            urlTextbox.Text = this.url;
            fileSizeTextbox.Text = "Getting file length...";
            try
            {
                string[] response = await BLLDownloadSetting.GetFileLength(this.url, this.Service);
                this.fileSize = long.Parse(response[0]);
                fileNameTextbox.Text = response[1];                
                fileSizeTextbox.Text = BLLConverter.FileSizeToString(fileSize);
                confirmButton.Enabled = true;
            }
            catch (Exception ex)
            {
                fileSizeTextbox.Text = ex.Message;
            }
        }
        private void multiThreadRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Enabled == false)
            {
                numericUpDown.Enabled = true;
            }

        }
        private void singleStreamRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Enabled == true)
            {
                numericUpDown.Enabled = false;
            }
        }
        private void choseFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                savePathTextbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private async void confirmButton_Click(object sender, EventArgs e)
        {
            string filePath = savePathTextbox.Text;
            if (Directory.Exists(filePath))
            {
                if (fileNameTextbox.Text != "")
                {
                    filePath += "\\" + fileNameTextbox.Text;

                    if (multiThreadRadio.Checked)
                    {
                        int totalThread = Convert.ToInt32(numericUpDown.Value);
                        //List<Range> readRanges = BLLDownloadSetting.CalculateRange(fileSize, totalThread);
                        List<RangeHeaderValue> ranges = BLLDownloadSetting.CalculateRangeHeaderValue(fileSize, totalThread);
                        //Download download = new MultiThreadDownload(url, filePath, readRanges);
                        var service = await GoogleDriverHelper.GetService();
                        Download download = new GoogleDriveDownload(this.url, filePath, ranges, service)
                        {
                            FileSize = fileSize,
                        };
                        MultiThreadForm form = new MultiThreadForm(download);
                        form.BackForm = () => this.Show();
                        form.CloseForm = () => DisposeAllForm();
                        this.Hide();
                        form.ShowDialog();
                    }
                    else if (singleStreamRadio.Checked)
                    {
                        Download download = new SingleStreamDownload(url, filePath, fileSize);
                        SingleStreamForm form = new SingleStreamForm(download);
                        form.BackForm = () => this.Show();
                        form.CloseForm = () => DisposeAllForm();
                        this.Hide();
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Thiếu file name");
                }
            }
            else
            {
                MessageBox.Show("Save path không tồn tại");
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Back?.Invoke();
            this.Close();
        }

        public void DisposeAllForm()
        {
            CloseForm?.Invoke();
            this.Dispose();
            this.Close();
        }

        private void DownloadSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Back?.Invoke();
            this.Dispose();
            this.Close();
        }
    }
}
