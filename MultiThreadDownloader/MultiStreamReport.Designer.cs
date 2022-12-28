namespace MultiThreadDownloader
{
    partial class MultiStreamReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.TextBox();
            this.downloadedSize = new System.Windows.Forms.TextBox();
            this.maxSpeed = new System.Windows.Forms.TextBox();
            this.averageSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isComplete = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Downloaded size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Max bandwidth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Average bandwidth:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalTime
            // 
            this.totalTime.Location = new System.Drawing.Point(188, 58);
            this.totalTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalTime.Name = "totalTime";
            this.totalTime.ReadOnly = true;
            this.totalTime.Size = new System.Drawing.Size(360, 22);
            this.totalTime.TabIndex = 1;
            // 
            // downloadedSize
            // 
            this.downloadedSize.Location = new System.Drawing.Point(188, 98);
            this.downloadedSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downloadedSize.Name = "downloadedSize";
            this.downloadedSize.ReadOnly = true;
            this.downloadedSize.Size = new System.Drawing.Size(360, 22);
            this.downloadedSize.TabIndex = 1;
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(188, 136);
            this.maxSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.ReadOnly = true;
            this.maxSpeed.Size = new System.Drawing.Size(360, 22);
            this.maxSpeed.TabIndex = 1;
            // 
            // averageSpeed
            // 
            this.averageSpeed.Location = new System.Drawing.Point(188, 174);
            this.averageSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.averageSpeed.Name = "averageSpeed";
            this.averageSpeed.ReadOnly = true;
            this.averageSpeed.Size = new System.Drawing.Size(360, 22);
            this.averageSpeed.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Is completed:";
            // 
            // isComplete
            // 
            this.isComplete.Location = new System.Drawing.Point(188, 19);
            this.isComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isComplete.Name = "isComplete";
            this.isComplete.ReadOnly = true;
            this.isComplete.Size = new System.Drawing.Size(360, 22);
            this.isComplete.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(35, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // MultiStreamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.averageSpeed);
            this.Controls.Add(this.maxSpeed);
            this.Controls.Add(this.downloadedSize);
            this.Controls.Add(this.isComplete);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MultiStreamReport";
            this.Text = "SingleStreamReport";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalTime;
        private System.Windows.Forms.TextBox downloadedSize;
        private System.Windows.Forms.TextBox maxSpeed;
        private System.Windows.Forms.TextBox averageSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isComplete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}