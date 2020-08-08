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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TakeScreenshotBtn = new System.Windows.Forms.Button();
            this.LogTxtBox = new System.Windows.Forms.TextBox();
            this.SetPathBtn = new System.Windows.Forms.Button();
            this.SetFolderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SavingPath = new System.Windows.Forms.Label();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpenLinkChk = new System.Windows.Forms.CheckBox();
            this.CopyToClipChk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SizeLbl = new System.Windows.Forms.Label();
            this.UploadLinkLbl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.LastScreenLbl = new System.Windows.Forms.Label();
            this.ResetPathBtn = new System.Windows.Forms.Button();
            this.OpenPathFolderBtn = new System.Windows.Forms.Button();
            this.CaptureAndUpload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TakeScreenshotBtn
            // 
            this.TakeScreenshotBtn.Location = new System.Drawing.Point(6, 19);
            this.TakeScreenshotBtn.Name = "TakeScreenshotBtn";
            this.TakeScreenshotBtn.Size = new System.Drawing.Size(125, 23);
            this.TakeScreenshotBtn.TabIndex = 0;
            this.TakeScreenshotBtn.Text = "Capture";
            this.TakeScreenshotBtn.UseVisualStyleBackColor = true;
            this.TakeScreenshotBtn.Click += new System.EventHandler(this.TakeScreenshotBtn_Click);
            // 
            // LogTxtBox
            // 
            this.LogTxtBox.Enabled = false;
            this.LogTxtBox.Location = new System.Drawing.Point(11, 140);
            this.LogTxtBox.Multiline = true;
            this.LogTxtBox.Name = "LogTxtBox";
            this.LogTxtBox.ReadOnly = true;
            this.LogTxtBox.Size = new System.Drawing.Size(398, 105);
            this.LogTxtBox.TabIndex = 1;
            // 
            // SetPathBtn
            // 
            this.SetPathBtn.Location = new System.Drawing.Point(6, 48);
            this.SetPathBtn.Name = "SetPathBtn";
            this.SetPathBtn.Size = new System.Drawing.Size(125, 23);
            this.SetPathBtn.TabIndex = 2;
            this.SetPathBtn.Text = "Set saving path";
            this.SetPathBtn.UseVisualStyleBackColor = true;
            this.SetPathBtn.Click += new System.EventHandler(this.SetPathBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            // 
            // SavingPath
            // 
            this.SavingPath.AutoSize = true;
            this.SavingPath.Location = new System.Drawing.Point(44, 121);
            this.SavingPath.Name = "SavingPath";
            this.SavingPath.Size = new System.Drawing.Size(76, 13);
            this.SavingPath.TabIndex = 4;
            this.SavingPath.Text = "[!] Path not set";
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(6, 77);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(125, 23);
            this.UploadBtn.TabIndex = 5;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CaptureAndUpload);
            this.groupBox1.Controls.Add(this.OpenPathFolderBtn);
            this.groupBox1.Controls.Add(this.ResetPathBtn);
            this.groupBox1.Controls.Add(this.TakeScreenshotBtn);
            this.groupBox1.Controls.Add(this.UploadBtn);
            this.groupBox1.Controls.Add(this.SetPathBtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpenLinkChk);
            this.groupBox2.Controls.Add(this.CopyToClipChk);
            this.groupBox2.Location = new System.Drawing.Point(415, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings: ";
            // 
            // OpenLinkChk
            // 
            this.OpenLinkChk.AutoSize = true;
            this.OpenLinkChk.Location = new System.Drawing.Point(6, 42);
            this.OpenLinkChk.Name = "OpenLinkChk";
            this.OpenLinkChk.Size = new System.Drawing.Size(216, 17);
            this.OpenLinkChk.TabIndex = 1;
            this.OpenLinkChk.Text = "Open link in default browser after upload";
            this.OpenLinkChk.UseVisualStyleBackColor = true;
            // 
            // CopyToClipChk
            // 
            this.CopyToClipChk.AutoSize = true;
            this.CopyToClipChk.Location = new System.Drawing.Point(6, 19);
            this.CopyToClipChk.Name = "CopyToClipChk";
            this.CopyToClipChk.Size = new System.Drawing.Size(186, 17);
            this.CopyToClipChk.TabIndex = 0;
            this.CopyToClipChk.Text = "Copy link to clipboard after upload";
            this.CopyToClipChk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Latest screenshot:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SizeLbl);
            this.groupBox3.Controls.Add(this.UploadLinkLbl);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.LastScreenLbl);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(415, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 105);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last screenshot size:";
            // 
            // SizeLbl
            // 
            this.SizeLbl.AutoSize = true;
            this.SizeLbl.Location = new System.Drawing.Point(109, 58);
            this.SizeLbl.Name = "SizeLbl";
            this.SizeLbl.Size = new System.Drawing.Size(30, 13);
            this.SizeLbl.TabIndex = 12;
            this.SizeLbl.Text = "0 KB";
            // 
            // UploadLinkLbl
            // 
            this.UploadLinkLbl.AutoSize = true;
            this.UploadLinkLbl.Location = new System.Drawing.Point(154, 38);
            this.UploadLinkLbl.Name = "UploadLinkLbl";
            this.UploadLinkLbl.Size = new System.Drawing.Size(75, 13);
            this.UploadLinkLbl.TabIndex = 11;
            this.UploadLinkLbl.TabStop = true;
            this.UploadLinkLbl.Text = "No upload link";
            this.UploadLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UploadLinkLbl_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last uploaded screenshot link:";
            // 
            // LastScreenLbl
            // 
            this.LastScreenLbl.AutoSize = true;
            this.LastScreenLbl.Location = new System.Drawing.Point(99, 16);
            this.LastScreenLbl.Name = "LastScreenLbl";
            this.LastScreenLbl.Size = new System.Drawing.Size(127, 13);
            this.LastScreenLbl.TabIndex = 9;
            this.LastScreenLbl.Text = "No previous screenshots.";
            // 
            // ResetPathBtn
            // 
            this.ResetPathBtn.Location = new System.Drawing.Point(137, 48);
            this.ResetPathBtn.Name = "ResetPathBtn";
            this.ResetPathBtn.Size = new System.Drawing.Size(125, 23);
            this.ResetPathBtn.TabIndex = 6;
            this.ResetPathBtn.Text = "Reset path";
            this.ResetPathBtn.UseVisualStyleBackColor = true;
            this.ResetPathBtn.Click += new System.EventHandler(this.ResetPathBtn_Click);
            // 
            // OpenPathFolderBtn
            // 
            this.OpenPathFolderBtn.Location = new System.Drawing.Point(268, 48);
            this.OpenPathFolderBtn.Name = "OpenPathFolderBtn";
            this.OpenPathFolderBtn.Size = new System.Drawing.Size(125, 23);
            this.OpenPathFolderBtn.TabIndex = 7;
            this.OpenPathFolderBtn.Text = "Open path folder";
            this.OpenPathFolderBtn.UseVisualStyleBackColor = true;
            this.OpenPathFolderBtn.Click += new System.EventHandler(this.OpenPathFolderBtn_Click);
            // 
            // CaptureAndUpload
            // 
            this.CaptureAndUpload.Location = new System.Drawing.Point(137, 19);
            this.CaptureAndUpload.Name = "CaptureAndUpload";
            this.CaptureAndUpload.Size = new System.Drawing.Size(125, 23);
            this.CaptureAndUpload.TabIndex = 8;
            this.CaptureAndUpload.Text = "Capture and Upload";
            this.CaptureAndUpload.UseVisualStyleBackColor = true;
            this.CaptureAndUpload.Click += new System.EventHandler(this.CaptureAndUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 256);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SavingPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "[#] Click N Share [#v.0.2]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TakeScreenshotBtn;
        private System.Windows.Forms.TextBox LogTxtBox;
        private System.Windows.Forms.Button SetPathBtn;
        private System.Windows.Forms.FolderBrowserDialog SetFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SavingPath;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CopyToClipChk;
        private System.Windows.Forms.CheckBox OpenLinkChk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LastScreenLbl;
        private System.Windows.Forms.LinkLabel UploadLinkLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SizeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OpenPathFolderBtn;
        private System.Windows.Forms.Button ResetPathBtn;
        private System.Windows.Forms.Button CaptureAndUpload;
    }
}

