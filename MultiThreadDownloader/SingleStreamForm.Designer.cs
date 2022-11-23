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
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(91, 209);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(582, 23);
            this.progressBar.TabIndex = 16;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(91, 12);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.ReadOnly = true;
            this.urlTextbox.Size = new System.Drawing.Size(202, 51);
            this.urlTextbox.TabIndex = 15;
            this.urlTextbox.Text = "";
            // 
            // sizeTextbox
            // 
            this.sizeTextbox.Location = new System.Drawing.Point(91, 123);
            this.sizeTextbox.Name = "sizeTextbox";
            this.sizeTextbox.ReadOnly = true;
            this.sizeTextbox.Size = new System.Drawing.Size(202, 20);
            this.sizeTextbox.TabIndex = 14;
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Location = new System.Drawing.Point(91, 73);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.ReadOnly = true;
            this.filePathTextbox.Size = new System.Drawing.Size(202, 20);
            this.filePathTextbox.TabIndex = 13;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(15, 125);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(27, 13);
            this.fileSizeLabel.TabIndex = 12;
            this.fileSizeLabel.Text = "Size";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(15, 15);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 11;
            this.urlLabel.Text = "URL";
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(15, 76);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(48, 13);
            this.filePathLabel.TabIndex = 10;
            this.filePathLabel.Text = "File Path";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(352, 271);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // SingleStreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.sizeTextbox);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.startButton);
            this.Name = "SingleStreamForm";
            this.Text = "SingleStreamForm";
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
    }
}