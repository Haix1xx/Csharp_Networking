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
    }
}
