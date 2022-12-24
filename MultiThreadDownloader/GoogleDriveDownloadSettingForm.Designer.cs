namespace MultiThreadDownloader
{
    partial class GoogleDriveDownloadSettingForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.multiThreadRadio = new System.Windows.Forms.RadioButton();
            this.singleStreamRadio = new System.Windows.Forms.RadioButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileSizeTextbox = new System.Windows.Forms.TextBox();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.choseFolderButton = new System.Windows.Forms.Button();
            this.savePathTextbox = new System.Windows.Forms.TextBox();
            this.urlTextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.multiThreadRadio);
            this.groupBox2.Controls.Add(this.singleStreamRadio);
            this.groupBox2.Controls.Add(this.numericUpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(33, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(507, 114);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download option";
            // 
            // multiThreadRadio
            // 
            this.multiThreadRadio.AutoSize = true;
            this.multiThreadRadio.Checked = true;
            this.multiThreadRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.multiThreadRadio.Location = new System.Drawing.Point(9, 50);
            this.multiThreadRadio.Margin = new System.Windows.Forms.Padding(2);
            this.multiThreadRadio.Name = "multiThreadRadio";
            this.multiThreadRadio.Size = new System.Drawing.Size(184, 20);
            this.multiThreadRadio.TabIndex = 14;
            this.multiThreadRadio.TabStop = true;
            this.multiThreadRadio.Text = "Multi Thread Download";
            this.multiThreadRadio.UseVisualStyleBackColor = true;
            this.multiThreadRadio.CheckedChanged += new System.EventHandler(this.multiThreadRadio_CheckedChanged);
            // 
            // singleStreamRadio
            // 
            this.singleStreamRadio.AutoSize = true;
            this.singleStreamRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.singleStreamRadio.Location = new System.Drawing.Point(9, 16);
            this.singleStreamRadio.Margin = new System.Windows.Forms.Padding(2);
            this.singleStreamRadio.Name = "singleStreamRadio";
            this.singleStreamRadio.Size = new System.Drawing.Size(195, 20);
            this.singleStreamRadio.TabIndex = 13;
            this.singleStreamRadio.Text = "Single Stream Download";
            this.singleStreamRadio.UseVisualStyleBackColor = true;
            this.singleStreamRadio.CheckedChanged += new System.EventHandler(this.singleStreamRadio_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(157, 77);
            this.numericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown.TabIndex = 12;
            this.numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Thread";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(395, 341);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(115, 34);
            this.confirmButton.TabIndex = 21;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Crimson;
            this.cancelButton.Location = new System.Drawing.Point(128, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 34);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileSizeTextbox);
            this.groupBox1.Controls.Add(this.fileSizeLabel);
            this.groupBox1.Controls.Add(this.fileNameTextbox);
            this.groupBox1.Controls.Add(this.savePathLabel);
            this.groupBox1.Controls.Add(this.fileNameLabel);
            this.groupBox1.Controls.Add(this.choseFolderButton);
            this.groupBox1.Controls.Add(this.savePathTextbox);
            this.groupBox1.Location = new System.Drawing.Point(33, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 111);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Information";
            // 
            // fileSizeTextbox
            // 
            this.fileSizeTextbox.Location = new System.Drawing.Point(84, 27);
            this.fileSizeTextbox.Name = "fileSizeTextbox";
            this.fileSizeTextbox.ReadOnly = true;
            this.fileSizeTextbox.Size = new System.Drawing.Size(287, 20);
            this.fileSizeTextbox.TabIndex = 6;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeLabel.Location = new System.Drawing.Point(5, 27);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(65, 16);
            this.fileSizeLabel.TabIndex = 0;
            this.fileSizeLabel.Text = "File size";
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Location = new System.Drawing.Point(84, 84);
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(287, 20);
            this.fileNameTextbox.TabIndex = 11;
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePathLabel.Location = new System.Drawing.Point(5, 57);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(77, 16);
            this.savePathLabel.TabIndex = 1;
            this.savePathLabel.Text = "Save path";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.Location = new System.Drawing.Point(5, 85);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(75, 16);
            this.fileNameLabel.TabIndex = 10;
            this.fileNameLabel.Text = "File name";
            // 
            // choseFolderButton
            // 
            this.choseFolderButton.Location = new System.Drawing.Point(385, 53);
            this.choseFolderButton.Name = "choseFolderButton";
            this.choseFolderButton.Size = new System.Drawing.Size(82, 23);
            this.choseFolderButton.TabIndex = 8;
            this.choseFolderButton.Text = "Choose folder";
            this.choseFolderButton.UseVisualStyleBackColor = true;
            this.choseFolderButton.Click += new System.EventHandler(this.choseFolderButton_Click);
            // 
            // savePathTextbox
            // 
            this.savePathTextbox.Location = new System.Drawing.Point(84, 56);
            this.savePathTextbox.Name = "savePathTextbox";
            this.savePathTextbox.Size = new System.Drawing.Size(287, 20);
            this.savePathTextbox.TabIndex = 7;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextbox.Location = new System.Drawing.Point(85, 9);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.ReadOnly = true;
            this.urlTextbox.Size = new System.Drawing.Size(456, 79);
            this.urlTextbox.TabIndex = 18;
            this.urlTextbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "URL";
            // 
            // GoogleDriveSettingDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.label1);
            this.Name = "GoogleDriveSettingDownloadForm";
            this.Text = "GoogleDriveSettingDownloadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadSettingForm_FormClosing);
            this.Load += new System.EventHandler(this.DownloadSettingForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton multiThreadRadio;
        private System.Windows.Forms.RadioButton singleStreamRadio;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fileSizeTextbox;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button choseFolderButton;
        private System.Windows.Forms.TextBox savePathTextbox;
        private System.Windows.Forms.RichTextBox urlTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}