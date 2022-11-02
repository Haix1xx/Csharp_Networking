namespace MultiThreadDownloader
{
    partial class DownloadSettingForm
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
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.settingDownloadLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTextbox = new System.Windows.Forms.RichTextBox();
            this.fileSizeTextbox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.savePathTextbox = new System.Windows.Forms.TextBox();
            this.choseFolderButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeLabel.Location = new System.Drawing.Point(53, 32);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(65, 16);
            this.fileSizeLabel.TabIndex = 0;
            this.fileSizeLabel.Text = "File size";
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePathLabel.Location = new System.Drawing.Point(53, 67);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(77, 16);
            this.savePathLabel.TabIndex = 1;
            this.savePathLabel.Text = "Save path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Thread";
            // 
            // settingDownloadLabel
            // 
            this.settingDownloadLabel.AutoSize = true;
            this.settingDownloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingDownloadLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.settingDownloadLabel.Location = new System.Drawing.Point(149, 9);
            this.settingDownloadLabel.Name = "settingDownloadLabel";
            this.settingDownloadLabel.Size = new System.Drawing.Size(327, 42);
            this.settingDownloadLabel.TabIndex = 3;
            this.settingDownloadLabel.Text = "Download Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // urlTextbox
            // 
            this.urlTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextbox.Location = new System.Drawing.Point(141, 54);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(367, 34);
            this.urlTextbox.TabIndex = 5;
            this.urlTextbox.Text = "";
            // 
            // fileSizeTextbox
            // 
            this.fileSizeTextbox.Location = new System.Drawing.Point(186, 28);
            this.fileSizeTextbox.Name = "fileSizeTextbox";
            this.fileSizeTextbox.ReadOnly = true;
            this.fileSizeTextbox.Size = new System.Drawing.Size(205, 20);
            this.fileSizeTextbox.TabIndex = 6;
            // 
            // savePathTextbox
            // 
            this.savePathTextbox.Location = new System.Drawing.Point(186, 67);
            this.savePathTextbox.Name = "savePathTextbox";
            this.savePathTextbox.Size = new System.Drawing.Size(205, 20);
            this.savePathTextbox.TabIndex = 7;
            // 
            // choseFolderButton
            // 
            this.choseFolderButton.Location = new System.Drawing.Point(415, 65);
            this.choseFolderButton.Name = "choseFolderButton";
            this.choseFolderButton.Size = new System.Drawing.Size(58, 23);
            this.choseFolderButton.TabIndex = 8;
            this.choseFolderButton.Text = "Chose folder\'";
            this.choseFolderButton.UseVisualStyleBackColor = true;
            this.choseFolderButton.Click += new System.EventHandler(this.choseFolderButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.Location = new System.Drawing.Point(53, 103);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(75, 16);
            this.fileNameLabel.TabIndex = 10;
            this.fileNameLabel.Text = "File name";
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Location = new System.Drawing.Point(186, 99);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(205, 20);
            this.fileNameTextbox.TabIndex = 11;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(186, 135);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileSizeTextbox);
            this.groupBox1.Controls.Add(this.numericUpDown);
            this.groupBox1.Controls.Add(this.fileSizeLabel);
            this.groupBox1.Controls.Add(this.fileNameTextbox);
            this.groupBox1.Controls.Add(this.savePathLabel);
            this.groupBox1.Controls.Add(this.fileNameLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.choseFolderButton);
            this.groupBox1.Controls.Add(this.savePathTextbox);
            this.groupBox1.Location = new System.Drawing.Point(52, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Information";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Crimson;
            this.cancelButton.Location = new System.Drawing.Point(108, 338);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 34);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(375, 338);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(115, 34);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // DownloadSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 394);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingDownloadLabel);
            this.Name = "DownloadSettingForm";
            this.Text = "SettingDownloadForm";
            this.Load += new System.EventHandler(this.DownloadSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label settingDownloadLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox urlTextbox;
        private System.Windows.Forms.TextBox fileSizeTextbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox savePathTextbox;
        private System.Windows.Forms.Button choseFolderButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}