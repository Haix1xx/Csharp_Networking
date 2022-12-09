namespace MultiThreadDownloader
{
    partial class SingleStreamForm
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.urlTextbox = new System.Windows.Forms.RichTextBox();
            this.sizeTextbox = new System.Windows.Forms.TextBox();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.detailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(136, 255);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(873, 35);
            this.progressBar.TabIndex = 16;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(136, 18);
            this.urlTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.ReadOnly = true;
            this.urlTextbox.Size = new System.Drawing.Size(872, 76);
            this.urlTextbox.TabIndex = 15;
            this.urlTextbox.Text = "";
            // 
            // sizeTextbox
            // 
            this.sizeTextbox.Location = new System.Drawing.Point(136, 169);
            this.sizeTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sizeTextbox.Name = "sizeTextbox";
            this.sizeTextbox.ReadOnly = true;
            this.sizeTextbox.Size = new System.Drawing.Size(872, 26);
            this.sizeTextbox.TabIndex = 14;
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Location = new System.Drawing.Point(136, 112);
            this.filePathTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.ReadOnly = true;
            this.filePathTextbox.Size = new System.Drawing.Size(872, 26);
            this.filePathTextbox.TabIndex = 13;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(22, 172);
            this.fileSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(40, 20);
            this.fileSizeLabel.TabIndex = 12;
            this.fileSizeLabel.Text = "Size";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(22, 23);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(42, 20);
            this.urlLabel.TabIndex = 11;
            this.urlLabel.Text = "URL";
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(22, 117);
            this.filePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(71, 20);
            this.filePathLabel.TabIndex = 10;
            this.filePathLabel.Text = "File Path";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(514, 325);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 35);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // detailButton
            // 
            this.detailButton.Enabled = false;
            this.detailButton.Location = new System.Drawing.Point(381, 325);
            this.detailButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(112, 35);
            this.detailButton.TabIndex = 9;
            this.detailButton.Text = "Detail";
            this.detailButton.UseVisualStyleBackColor = true;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // SingleStreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 395);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.sizeTextbox);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.detailButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SingleStreamForm";
            this.Text = "SingleStreamForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleStreamForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox urlTextbox;
        private System.Windows.Forms.TextBox sizeTextbox;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button detailButton;
    }
}