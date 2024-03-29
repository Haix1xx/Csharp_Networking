﻿namespace MultiThreadDownloader
{
    partial class SingleStreamReport
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
            this.label4 = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.TextBox();
            this.downloadedSize = new System.Windows.Forms.TextBox();
            this.averageSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isComplete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Downloaded size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Average bandwidth:";
            // 
            // totalTime
            // 
            this.totalTime.Location = new System.Drawing.Point(211, 72);
            this.totalTime.Name = "totalTime";
            this.totalTime.ReadOnly = true;
            this.totalTime.Size = new System.Drawing.Size(404, 26);
            this.totalTime.TabIndex = 1;
            // 
            // downloadedSize
            // 
            this.downloadedSize.Location = new System.Drawing.Point(211, 122);
            this.downloadedSize.Name = "downloadedSize";
            this.downloadedSize.ReadOnly = true;
            this.downloadedSize.Size = new System.Drawing.Size(404, 26);
            this.downloadedSize.TabIndex = 1;
            // 
            // averageSpeed
            // 
            this.averageSpeed.Location = new System.Drawing.Point(211, 171);
            this.averageSpeed.Name = "averageSpeed";
            this.averageSpeed.ReadOnly = true;
            this.averageSpeed.Size = new System.Drawing.Size(404, 26);
            this.averageSpeed.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Is completed:";
            // 
            // isComplete
            // 
            this.isComplete.Location = new System.Drawing.Point(211, 24);
            this.isComplete.Name = "isComplete";
            this.isComplete.ReadOnly = true;
            this.isComplete.Size = new System.Drawing.Size(404, 26);
            this.isComplete.TabIndex = 1;
            // 
            // SingleStreamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 222);
            this.Controls.Add(this.averageSpeed);
            this.Controls.Add(this.downloadedSize);
            this.Controls.Add(this.isComplete);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SingleStreamReport";
            this.Text = "SingleStreamReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalTime;
        private System.Windows.Forms.TextBox downloadedSize;
        private System.Windows.Forms.TextBox averageSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isComplete;
    }
}