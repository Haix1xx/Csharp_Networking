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
            this.urlButton = new System.Windows.Forms.PictureBox();
            this.driveUrlButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveUrlButton)).BeginInit();
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
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topPanel.Controls.Add(this.urlButton, 1, 0);
            this.topPanel.Controls.Add(this.driveUrlButton, 2, 0);
            this.topPanel.Controls.Add(this.label1, 1, 1);
            this.topPanel.Controls.Add(this.label2, 2, 1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 2;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topPanel.Size = new System.Drawing.Size(568, 100);
            this.topPanel.TabIndex = 0;
            // 
            // urlButton
            // 
            this.urlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlButton.Image = global::MultiThreadDownloader.Properties.Resources.plugs;
            this.urlButton.Location = new System.Drawing.Point(33, 3);
            this.urlButton.Name = "urlButton";
            this.urlButton.Size = new System.Drawing.Size(95, 64);
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
            this.driveUrlButton.Location = new System.Drawing.Point(134, 3);
            this.driveUrlButton.Name = "driveUrlButton";
            this.driveUrlButton.Size = new System.Drawing.Size(95, 64);
            this.driveUrlButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.driveUrlButton.TabIndex = 1;
            this.driveUrlButton.TabStop = false;
            this.driveUrlButton.Click += new System.EventHandler(this.driveUrlButton_Click);
            this.driveUrlButton.MouseEnter += new System.EventHandler(this.pictureButton_MouseEnter);
            this.driveUrlButton.MouseLeave += new System.EventHandler(this.pictureButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Drive URL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 334);
            this.Controls.Add(this.topPanel);
            this.Name = "MainForm";
            this.Text = "Downloader";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driveUrlButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.PictureBox urlButton;
        private System.Windows.Forms.PictureBox driveUrlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}