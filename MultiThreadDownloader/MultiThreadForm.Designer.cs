﻿namespace MultiThreadDownloader
{
    partial class MultiThreadForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.sizeTextbox = new System.Windows.Forms.TextBox();
            this.urlTextbox = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.detailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(481, 260);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(44, 94);
            this.filePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(59, 16);
            this.filePathLabel.TabIndex = 1;
            this.filePathLabel.Text = "File Path";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(44, 18);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(34, 16);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(44, 134);
            this.fileSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(33, 16);
            this.fileSizeLabel.TabIndex = 3;
            this.fileSizeLabel.Text = "Size";
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Location = new System.Drawing.Point(145, 90);
            this.filePathTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.ReadOnly = true;
            this.filePathTextbox.Size = new System.Drawing.Size(776, 22);
            this.filePathTextbox.TabIndex = 4;
            // 
            // sizeTextbox
            // 
            this.sizeTextbox.Location = new System.Drawing.Point(145, 132);
            this.sizeTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeTextbox.Name = "sizeTextbox";
            this.sizeTextbox.ReadOnly = true;
            this.sizeTextbox.Size = new System.Drawing.Size(776, 22);
            this.sizeTextbox.TabIndex = 6;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(145, 15);
            this.urlTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.ReadOnly = true;
            this.urlTextbox.Size = new System.Drawing.Size(776, 62);
            this.urlTextbox.TabIndex = 7;
            this.urlTextbox.Text = "";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(145, 204);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 28);
            this.progressBar.TabIndex = 8;
            // 
            // detailButton
            // 
            this.detailButton.Enabled = false;
            this.detailButton.Location = new System.Drawing.Point(356, 260);
            this.detailButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(100, 28);
            this.detailButton.TabIndex = 10;
            this.detailButton.Text = "Detail";
            this.detailButton.UseVisualStyleBackColor = true;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // MultiThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 308);
            this.Controls.Add(this.detailButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.sizeTextbox);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MultiThreadForm";
            this.Text = "MultiThreadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiThreadForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.TextBox sizeTextbox;
        private System.Windows.Forms.RichTextBox urlTextbox;
        internal System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button detailButton;
    }
}