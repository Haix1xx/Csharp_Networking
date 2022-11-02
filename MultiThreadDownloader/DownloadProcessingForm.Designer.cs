namespace MultiThreadDownloader
{
    partial class DownloadProcessingForm
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
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(369, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(33, 76);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(48, 13);
            this.filePathLabel.TabIndex = 1;
            this.filePathLabel.Text = "File Path";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(33, 15);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(33, 125);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(27, 13);
            this.fileSizeLabel.TabIndex = 3;
            this.fileSizeLabel.Text = "Size";
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Location = new System.Drawing.Point(109, 73);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.ReadOnly = true;
            this.filePathTextbox.Size = new System.Drawing.Size(202, 20);
            this.filePathTextbox.TabIndex = 4;
            // 
            // sizeTextbox
            // 
            this.sizeTextbox.Location = new System.Drawing.Point(109, 123);
            this.sizeTextbox.Name = "sizeTextbox";
            this.sizeTextbox.ReadOnly = true;
            this.sizeTextbox.Size = new System.Drawing.Size(202, 20);
            this.sizeTextbox.TabIndex = 6;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(109, 12);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.ReadOnly = true;
            this.urlTextbox.Size = new System.Drawing.Size(202, 51);
            this.urlTextbox.TabIndex = 7;
            this.urlTextbox.Text = "";
            // 
            // DownloadProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.sizeTextbox);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.startButton);
            this.Name = "DownloadProcessingForm";
            this.Text = "DownloadProcessingForm";
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
    }
}