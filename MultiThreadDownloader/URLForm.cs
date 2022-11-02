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
            string url = "";
            if (urlTextbox.Text != "")
            {
                this.Hide();
                //can xu ly link truoc
                url = urlTextbox.Text;
                DownloadSettingForm form = new DownloadSettingForm(url);
                form.Back = () => this.ShowDialog();
                form.ShowDialog();
                
                //this.Visible = false;
            }
            else
            {
                //
            }    
        }
    }
}
