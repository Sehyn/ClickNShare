using System;
using System.Drawing;
using System.Drawing.Imaging;
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
                LogTxtBox.AppendText("["+DateTime.Now.ToShortTimeString() +"] Captured whole monitor." + Environment.NewLine);
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
            //SetFolderPath.SelectedPath.ToString();
        }
    }
}
