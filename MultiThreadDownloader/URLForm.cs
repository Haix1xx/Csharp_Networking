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
    public partial class URLForm : Form
    {
        public URLForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string url = urlTextbox.Text;
            if (url != "" && checkURL(url))
            {
                this.Hide();
                DownloadSettingForm form = new DownloadSettingForm(url);
                form.Back = () => this.Show();
                form.Show();
            }
            else
            {
                MessageBox.Show("URL không hợp lệ");
            }    
        }

        private bool checkURL(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                return true;
            else
                return false;
        }
    }
}
