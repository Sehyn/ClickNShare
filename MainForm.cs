using Imgur.API;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ClickNShare
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            SavingPath.Text = Properties.Settings.Default.SavingPath.ToString();
            LastScreenLbl.Text = Properties.Settings.Default.LastScreenPath.ToString();
            SizeLbl.Text = Properties.Settings.Default.LastScreenSize.ToString();
            UploadLinkLbl.Text = Properties.Settings.Default.LastUploadLink.ToString();
        //    Thread TH = new Thread(ListenKey);
        //    TH.SetApartmentState(ApartmentState.STA);
        //    CheckForIllegalCrossThreadCalls = false;
        //    TH.Start();

        //}
        //bool isRunning = true;
        //void ListenKey()
        //{
        //    while (isRunning)
        //    {
        //        Thread.Sleep(40);
        //        if (((Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && Keyboard.IsKeyDown(Key.F)))
        //        {
        //            TakeScreenShot();
        //            Thread.Sleep(2000);
        //            UploadImage();

        //        }


        //    }
        }
    

        private void TakeScreenshotBtn_Click(object sender, EventArgs e)
        {
            TakeScreenShot();

        }

        private void SetPathBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = SetFolderPath.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(SetFolderPath.SelectedPath))
            {
                string Path = SetFolderPath.SelectedPath;
                ClickNShare.Properties.Settings.Default.SavingPath = Path;
                ClickNShare.Properties.Settings.Default.Save();
                MessageBox.Show("Path set to: " + Path.ToString(), "Path set!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Path set to: " + Path.ToString() + Environment.NewLine);
                SavingPath.Text = Path.ToString();
            }
            else
            {
                MessageBox.Show("You must select a path in order to save the screenshots", "No path selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void TakeScreenShot()
        {
            try
            {
                if (SavingPath.Text == "")
                {
                    MessageBox.Show("You must specify a path to save your screenshots!", "Path is missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                              Screen.PrimaryScreen.Bounds.Height,
                              PixelFormat.Format32bppArgb);

                    var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

                    gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                    Screen.PrimaryScreen.Bounds.Y,
                                    0,
                                    0,
                                    Screen.PrimaryScreen.Bounds.Size,
                                    CopyPixelOperation.SourceCopy);
                    LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Captured whole monitor." + Environment.NewLine);
                    await Task.Delay(1000);
                    SavingPath.Text = Properties.Settings.Default.SavingPath.ToString();
                    bmpScreenshot.Save(SavingPath.Text + "/Capture-" + DateTime.Now.ToString("yyyy-MM-dd-h-mm-tt") + ".png", ImageFormat.Png);
                    //Console.WriteLine(@label2.Text + "/Capture - " + DateTime.Now.ToString("yyyy - MM - dd - h - mm - tt") + ".png");

                    LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Saved screenshot under name : Capture-" + DateTime.Now.ToString("yyyy-MM-dd-h-mm-tt") + Environment.NewLine);
                    LastScreenLbl.Text = ("Capture-" + DateTime.Now.ToString("yyyy-MM-dd-h-mm-tt"));
                    string fullPath = (SavingPath.Text + "\\" + LastScreenLbl.Text + ".png");
                    //LogTxtBox.AppendText(fullPath); Test
                    long filesize = new FileInfo(fullPath.ToString()).Length / 1024;
                    SizeLbl.Text = filesize.ToString() + " KB";
                    Properties.Settings.Default.LastScreenPath = LastScreenLbl.Text;
                    Properties.Settings.Default.LastScreenSize = SizeLbl.Text;
                    ClickNShare.Properties.Settings.Default.Save();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Oopsie!" + ex.Message);
            }
        }

        #region Upload Image
        private async void UploadImage()
        {

            try
            {
                LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Connecting with Imgur Servers.." + Environment.NewLine);
                await Task.Delay(500);

                //Connect with dev key.
                var client = new ImgurClient("1dd3edbb008eae6", "e25728a4e9c674fe22994462521984d86e0172aa");
                var endpoint = new ImageEndpoint(client);
                //Defines where we will save the file and with which name / extension.
                IImage image;
                using (var fs = new FileStream(SavingPath.Text + "/" + LastScreenLbl.Text + ".png", FileMode.Open))
                {
                    //Uploads the image
                    image = endpoint.UploadImageStreamAsync(fs).GetAwaiter().GetResult();
                    LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Uploading latest screenshot.." + Environment.NewLine);
                    await Task.Delay(500);
                    LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Uploaded!" + Environment.NewLine);
                    UploadLinkLbl.Text = image.Link;
                    Properties.Settings.Default.LastUploadLink = UploadLinkLbl.Text;
                    Properties.Settings.Default.Save();


                }

                Console.WriteLine("[#] Image Link: " + image.Link);
                Console.WriteLine("[#] Opening Uploaded image in default browser");
                if (CopyToClipChk.Checked == true)
                {
                    Clipboard.SetText(image.Link);
                    LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Image uploaded link copied to clipboard." + Environment.NewLine);


                }
                if (OpenLinkChk.Checked == true)
                {
                    Process.Start(image.Link);
                    LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Openned link in default browser." + Environment.NewLine);


                }
                //Console.ReadKey();
            }
            catch (ImgurException imgurEx)
            {
                MessageBox.Show(imgurEx.Message);
                Console.WriteLine("[!] An error occurred uploading an image to Imgur.");
                //Debug.Write(imgurEx.Message);
            }


        }
        #endregion

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            if (SavingPath.Text == "")
            {
                MessageBox.Show("You must specify a path to save & upload your screenshots!", "Path is missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UploadImage();

            }

        }

        private void UploadLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UploadLinkLbl.Text != "No upload link")
            {
                Process.Start(UploadLinkLbl.Text);

            }
            else
            {

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (((Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && Keyboard.IsKeyDown(Key.F)))
            {
                TakeScreenShot();
                //Thread.Sleep(2000);
                UploadImage();

            }
        }

        private void OpenPathFolderBtn_Click(object sender, EventArgs e)
        {
            //Opens the folder where you save the capture
            try
            {
                Process.Start(SavingPath.Text);
                LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Openned saving path folder." + Environment.NewLine);

            }
            catch(Exception)
            {
                LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] You must set a path before opening the saved path folder." + Environment.NewLine);

            }



        }

        private void ResetPathBtn_Click(object sender, EventArgs e)
        {
            //Resets the path where files were used to be saved
            SavingPath.Text = "";
            LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Reseted the saving path." + Environment.NewLine);

        }

        private void CaptureAndUpload_Click(object sender, EventArgs e)
        {

            TakeScreenShot();
            Thread.Sleep(500);

          

            if (SavingPath.Text == "")
            {
                MessageBox.Show("You must specify a path to save & upload your screenshots!", "Path is missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UploadImage();

            }
        }

     
    }
}
