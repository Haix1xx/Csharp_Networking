using MultiThreadDownloader.BLL;
using MultiThreadDownloader.DTO;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void urlButton_Click(object sender, EventArgs e)
        {
            URLForm form = new URLForm();
            form.Show();
        }

        private void driveUrlButton_Click(object sender, EventArgs e)
        {
            GoogleDriverURLForm form = new GoogleDriverURLForm();
            form.Show();
        }

        private void pictureButton_MouseEnter(object sender, EventArgs e)
        {
            //PictureBox pictureBox = sender as PictureBox;
            //pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void pictureButton_MouseLeave(object sender, EventArgs e)
        {
            //PictureBox pictureBox = sender as PictureBox;
            //pictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
        }
        private void UpdateHistory(List<DownloadResult> list)
        {
            listView.Items.Clear();
            list.ForEach( download =>
            {
                ListViewItem item = new ListViewItem();
                item.Text = download.FileName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = download.FileSize});
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = download.TimeDownload.ToString()});
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = download.Status});
                listView.Items.Add(item);
            });
        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            var list = BLLDownloadHistory.LoadAll();
            if (list.Count == 0)
                MessageBox.Show("Have no downloads recently");
            else
                UpdateHistory(list);
        }
    }
}
