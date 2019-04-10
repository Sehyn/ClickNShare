using Imgur.API;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickNShare
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label2.Text = Properties.Settings.Default.SavingPath.ToString();
            string Path = label2.Text;

        }

        private async void TakeScreenshotBtn_Click(object sender, EventArgs e)
        {
            try
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
                label2.Text = Properties.Settings.Default.SavingPath.ToString();
                bmpScreenshot.Save(@label2.Text + "/Capture-" + DateTime.Now.ToString("yyyy-MM-dd-h-mm-tt") + ".png", ImageFormat.Png);
                //Console.WriteLine(@label2.Text + "/Capture - " + DateTime.Now.ToString("yyyy - MM - dd - h - mm - tt") + ".png");

                LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Saved screenshot under name : Capture-" + DateTime.Now.ToString("yyyy-MM-dd-h-mm-tt") + Environment.NewLine);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Oopsie!" + ex.Message);
            }



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = SetFolderPath.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(SetFolderPath.SelectedPath))
            {
                string Path = SetFolderPath.SelectedPath;
                ClickNShare.Properties.Settings.Default.SavingPath = Path;
                ClickNShare.Properties.Settings.Default.Save();
                MessageBox.Show("Path set to: " + Path.ToString(), "Path set!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Path set to: " + Path.ToString() + Environment.NewLine);

            }
            else
            {
                MessageBox.Show("You must select a path in order to save the screenshots", "No path selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (var fs = new FileStream(@label2.Text + "/Capture-" + DateTime.Now.ToString("yyyy-MM-dd-h-mm-tt") + ".png", FileMode.Open))
                {
                    //Uploads the image
                    image = endpoint.UploadImageStreamAsync(fs).GetAwaiter().GetResult();
                    LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Uploading latest screenshot.." + Environment.NewLine);
                    await Task.Delay(500);


                }
                LogTxtBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Image uploaded link copied to clipboard." + Environment.NewLine);

                Console.WriteLine("[#] Image Link: " + image.Link);
                Console.WriteLine("[#] Opening Uploaded image in default browser");
                Process.Start(image.Link);
                Clipboard.SetText(image.Link);
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
            UploadImage();
        }
    }
}
