namespace MultiThreadDownloader
{
    partial class MainForm
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
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spacePanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.fileNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.urlButton = new System.Windows.Forms.PictureBox();
            this.driveUrlButton = new System.Windows.Forms.PictureBox();
            this.historyButton = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.deleteHistoryButton = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveUrlButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteHistoryButton)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topPanel.ColumnCount = 7;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.topPanel.Controls.Add(this.label5, 4, 1);
            this.topPanel.Controls.Add(this.urlButton, 1, 0);
            this.topPanel.Controls.Add(this.driveUrlButton, 2, 0);
            this.topPanel.Controls.Add(this.label1, 1, 1);
            this.topPanel.Controls.Add(this.label2, 2, 1);
            this.topPanel.Controls.Add(this.historyButton, 3, 0);
            this.topPanel.Controls.Add(this.label3, 3, 1);
            this.topPanel.Controls.Add(this.logoutButton, 5, 0);
            this.topPanel.Controls.Add(this.label4, 5, 1);
            this.topPanel.Controls.Add(this.deleteHistoryButton, 4, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 2;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topPanel.Size = new System.Drawing.Size(709, 100);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Drive URL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spacePanel
            // 
            this.spacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacePanel.Location = new System.Drawing.Point(0, 100);
            this.spacePanel.Name = "spacePanel";
            this.spacePanel.Size = new System.Drawing.Size(709, 10);
            this.spacePanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 110);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(132, 283);
            this.sidePanel.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.listView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(132, 110);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(577, 283);
            this.mainPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "History";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameHeader,
            this.fileSizeHeader,
            this.timeHeader,
            this.statusHeader});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(577, 283);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // fileNameHeader
            // 
            this.fileNameHeader.Text = "File Name";
            this.fileNameHeader.Width = 270;
            // 
            // fileSizeHeader
            // 
            this.fileSizeHeader.Text = "File Size";
            this.fileSizeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileSizeHeader.Width = 85;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time Download";
            this.timeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeHeader.Width = 150;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Status";
            this.statusHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusHeader.Width = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Logout Drive";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urlButton
            // 
            this.urlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlButton.Image = global::MultiThreadDownloader.Properties.Resources.plugs;
            this.urlButton.Location = new System.Drawing.Point(33, 3);
            this.urlButton.Name = "urlButton";
            this.urlButton.Size = new System.Drawing.Size(123, 64);
            this.urlButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.urlButton.TabIndex = 0;
            this.urlButton.TabStop = false;
            this.urlButton.Click += new System.EventHandler(this.urlButton_Click);
            this.urlButton.MouseEnter += new System.EventHandler(this.pictureButton_MouseEnter);
            this.urlButton.MouseLeave += new System.EventHandler(this.pictureButton_MouseLeave);
            // 
            // driveUrlButton
            // 
            this.driveUrlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driveUrlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveUrlButton.Image = global::MultiThreadDownloader.Properties.Resources.drive;
            this.driveUrlButton.Location = new System.Drawing.Point(162, 3);
            this.driveUrlButton.Name = "driveUrlButton";
            this.driveUrlButton.Size = new System.Drawing.Size(123, 64);
            this.driveUrlButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.driveUrlButton.TabIndex = 1;
            this.driveUrlButton.TabStop = false;
            this.driveUrlButton.Click += new System.EventHandler(this.driveUrlButton_Click);
            this.driveUrlButton.MouseEnter += new System.EventHandler(this.pictureButton_MouseEnter);
            this.driveUrlButton.MouseLeave += new System.EventHandler(this.pictureButton_MouseLeave);
            // 
            // historyButton
            // 
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyButton.Image = global::MultiThreadDownloader.Properties.Resources.history;
            this.historyButton.Location = new System.Drawing.Point(291, 3);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(123, 64);
            this.historyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.historyButton.TabIndex = 4;
            this.historyButton.TabStop = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutButton.Image = global::MultiThreadDownloader.Properties.Resources.log_out;
            this.logoutButton.Location = new System.Drawing.Point(549, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(123, 64);
            this.logoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoutButton.TabIndex = 6;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // deleteHistoryButton
            // 
            this.deleteHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteHistoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteHistoryButton.Image = global::MultiThreadDownloader.Properties.Resources.delete;
            this.deleteHistoryButton.Location = new System.Drawing.Point(420, 3);
            this.deleteHistoryButton.Name = "deleteHistoryButton";
            this.deleteHistoryButton.Size = new System.Drawing.Size(123, 64);
            this.deleteHistoryButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deleteHistoryButton.TabIndex = 8;
            this.deleteHistoryButton.TabStop = false;
            this.deleteHistoryButton.Click += new System.EventHandler(this.deleteHistoryButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Delete History";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 393);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.spacePanel);
            this.Controls.Add(this.topPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urlButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveUrlButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteHistoryButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.PictureBox urlButton;
        private System.Windows.Forms.PictureBox driveUrlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel spacePanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox historyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader fileNameHeader;
        private System.Windows.Forms.ColumnHeader fileSizeHeader;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox deleteHistoryButton;
        private System.Windows.Forms.Label label5;
    }
}