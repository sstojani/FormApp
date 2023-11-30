using DirectShowLib;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Test_FormApp
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Get the selected file name and display it in the PictureBox
                        string selectedFile = openFileDialog.FileName;
                        pictureBox1.Image = new System.Drawing.Bitmap(selectedFile);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read the file. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void WebCamRedirect_Click(object sender, EventArgs e)
        {
            WebCam webCam = new WebCam();
            webCam.Show();
        }

        private void ExcelRedirect_Click(object sender, EventArgs e)
        {
            ExcelNew exc = new ExcelNew();
            exc.Show();
        }

        private void USB_Checker_Click(object sender, EventArgs e)
        {
            USB usb = new USB();
            usb.Show();
        }
    }
}