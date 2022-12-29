using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using MultiThreadDownloader.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadDownloader
{
    public partial class GoogleDriverURLForm : Form
    {
        public GoogleDriverURLForm()
        {
            InitializeComponent();
        }

        private async void confirmButton_Click(object sender, EventArgs e)
        {
            string url = urlTextbox.Text;
            var service = await GoogleDriverHelper.GetService();     
            if (url != "" && checkURL(url))
            {
                this.Hide();
                GoogleDriveDownloadSettingForm form = new GoogleDriveDownloadSettingForm(url, service);
                form.Back = () => this.Show();
                form.CloseForm = () => DisposeForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("URL không hợp lệ");
            }
        }
        public void DisposeForm()
        {
            this.Dispose();
            this.Close();
        }
        private bool checkURL(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }
    }
}
