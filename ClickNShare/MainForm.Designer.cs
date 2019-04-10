namespace ClickNShare
{
    partial class Form1
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
            this.TakeScreenshotBtn = new System.Windows.Forms.Button();
            this.LogTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SetFolderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TakeScreenshotBtn
            // 
            this.TakeScreenshotBtn.Location = new System.Drawing.Point(12, 12);
            this.TakeScreenshotBtn.Name = "TakeScreenshotBtn";
            this.TakeScreenshotBtn.Size = new System.Drawing.Size(386, 23);
            this.TakeScreenshotBtn.TabIndex = 0;
            this.TakeScreenshotBtn.Text = "Screenshot ";
            this.TakeScreenshotBtn.UseVisualStyleBackColor = true;
            this.TakeScreenshotBtn.Click += new System.EventHandler(this.TakeScreenshotBtn_Click);
            // 
            // LogTxtBox
            // 
            this.LogTxtBox.Enabled = false;
            this.LogTxtBox.Location = new System.Drawing.Point(12, 114);
            this.LogTxtBox.Multiline = true;
            this.LogTxtBox.Name = "LogTxtBox";
            this.LogTxtBox.ReadOnly = true;
            this.LogTxtBox.Size = new System.Drawing.Size(386, 105);
            this.LogTxtBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set saving path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "[!] Path not set";
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(12, 70);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(386, 23);
            this.UploadBtn.TabIndex = 5;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 225);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogTxtBox);
            this.Controls.Add(this.TakeScreenshotBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "[#] Click N Share [#v.0.1]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TakeScreenshotBtn;
        private System.Windows.Forms.TextBox LogTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog SetFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UploadBtn;
    }
}

