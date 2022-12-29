using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Google.Apis.Drive.v3;
using Google.Apis.Http;
using MultiThreadDownloader.BLL;
using MultiThreadDownloader.DTO;
namespace MultiThreadDownloader
{
    public partial class DownloadSettingForm : Form
    {
        private string url;
        private long fileSize;
        private string fileType;
        public delegate void InvokeForm();
        public InvokeForm Back { get; set; }
        public InvokeForm CloseForm { get; set; }
        public ConfigurableHttpClient httpClient = null;
        public DriveService Service = null;
        public DownloadSettingForm()
        {
            InitializeComponent();
        }
        public DownloadSettingForm(string url)
        {
            InitializeComponent();
            this.url = url;            
        }
        public DownloadSettingForm(string url, DriveService Service)
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
            fileSizeTextbox.Text = "Getting file info...";
            try
            {
                //this.fileSize = await BLLDownloadSetting.GetFileLength(this.url);
                //this.fileType = await BLLDownloadSetting.GetFileType(this.url);
                var fileInfo = await BLLDownloadSetting.GetFileInfo(this.url);
                this.fileSize = long.Parse(fileInfo[0]);
                this.fileType = fileInfo[1];
                fileSizeTextbox.Text = BLLConverter.FileSizeToString(fileSize);
                fileTypeTextBox.Text = fileType;
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
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string filePath = savePathTextbox.Text;
            if (Directory.Exists(filePath))
            {
                if (fileNameTextbox.Text != "")
                {
                    filePath += "\\" + fileNameTextbox.Text + "." + fileType;

                    if (multiThreadRadio.Checked)
                    {
                        int totalThread = Convert.ToInt32(numericUpDown.Value);
                        List<Range> readRanges = BLLDownloadSetting.CalculateRange(fileSize, totalThread);
                        Download download = new MultiThreadDownload(url, filePath, readRanges)
                        {
                            FileSize = fileSize,
                        };
                        MultiThreadForm form = new MultiThreadForm(download);
                        form.BackForm = () => this.Show();
                        form.CloseForm = () => DisposeAllForm();
                        this.Hide();
                        form.Show();
                    }
                    else if (singleStreamRadio.Checked)
                    {
                        Download download = new SingleStreamDownload(url, filePath, fileSize)
                        {
                            FileSize = fileSize
                        };
                        SingleStreamForm form = new SingleStreamForm(download);
                        form.BackForm = () => this.Show();
                        form.CloseForm = () => DisposeAllForm();
                        this.Hide();
                        form.Show();
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
