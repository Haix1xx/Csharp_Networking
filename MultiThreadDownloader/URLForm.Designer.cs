namespace MultiThreadDownloader
{
    partial class URLForm
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
            this.urlLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.urlTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(18, 31);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(46, 20);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL:";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(502, 218);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(112, 35);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(75, 31);
            this.urlTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(538, 127);
            this.urlTextbox.TabIndex = 3;
            this.urlTextbox.Text = "";
            // 
            // URLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 298);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.urlLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "URLForm";
            this.Text = "URLForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.RichTextBox urlTextbox;
    }
}

