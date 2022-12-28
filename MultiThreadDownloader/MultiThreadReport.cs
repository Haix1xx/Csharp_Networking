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
    public partial class MultiThreadReport : Form
    {
        public MultiThreadReport(TimeSpan totalTime, DataTable reports)
        {
            InitializeComponent();
            totalTimeTextBox.Text = totalTime.Hours.ToString() + "h " + totalTime.Minutes.ToString() + "m " + totalTime.Seconds.ToString() + "s";
            dataGridView1.DataSource = reports;
        }
    }
}
