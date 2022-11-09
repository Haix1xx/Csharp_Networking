using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MultiThreadDownloader.BLL;
using MultiThreadDownloader.DTO;
namespace MultiThreadDownloader
{
    public partial class DownloadSettingForm : Form
    {
        private string url;
        private long fileSize;
        public delegate void BackForm();
        public BackForm Back { get; set; }
        public DownloadSettingForm()
        {
            InitializeComponent();
        }
        public DownloadSettingForm(string url)
        {
            InitializeComponent();
            this.url = url;            
        }
        private void choseFolderButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                savePathTextbox.Text = folderBrowserDialog1.SelectedPath;
            }    
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Back?.Invoke();
            this.Close();
        }

        private async void DownloadSettingForm_Load(object sender, EventArgs e)
        {
            confirmButton.Enabled = false;
            numericUpDown.Value = 4;
            urlTextbox.Text = this.url;
            this.fileSize = await BLLDownloadSetting.GetFileLength(this.url);
            fileSizeTextbox.Text = fileSize.ToString();
            confirmButton.Enabled = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string filePath = savePathTextbox.Text; // + "\\" + fileNameTextbox.Text;
            if (Directory.Exists(filePath))
            {
                if (fileNameTextbox.Text != "")
                {
                    filePath += "\\" + fileNameTextbox.Text;
                    int totalThread = Convert.ToInt32(numericUpDown.Value);
                    List<Range> readRanges = BLLDownloadSetting.CalculateRange(fileSize, totalThread);

                    Download download = new Download(url, filePath, readRanges);
                    DownloadProcessingForm form = new DownloadProcessingForm(download);
                    this.Hide();
                    form.ShowDialog();
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

        private void multiThreadRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Enabled == false)
            {
                numericUpDown.Enabled = true;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Enabled == true)
            {
                numericUpDown.Enabled = false;
            }
        }
    }
}
