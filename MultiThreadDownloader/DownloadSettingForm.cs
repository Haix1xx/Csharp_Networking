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
    public partial class DownloadSettingForm : Form
    {
        private string url;
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
            numericUpDown.Value = 4;
            urlTextbox.Text = this.url;
            long fileSize = await BLLDownloadSetting.GetFileLength(this.url);
            fileSizeTextbox.Text = fileSize.ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            long fileSize = long.Parse(fileSizeTextbox.Text);
            int totalThread = Convert.ToInt32(numericUpDown.Value);
            List<Range> readRanges = BLLDownloadSetting.CalculateRange(fileSize, totalThread);
            string filePath = savePathTextbox.Text + "\\" + fileNameTextbox.Text;
            Download download = new Download(url, filePath, readRanges);
            //MessageBox.Show(filePath);
            DownloadProcessingForm form = new DownloadProcessingForm(download);
            this.Hide();
            form.ShowDialog();
        }
    }
}
