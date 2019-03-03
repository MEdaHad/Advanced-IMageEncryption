using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace ImageEncryption
{
    public partial class ImageCry : Form
    {
        private Bitmap bmp = null;

        public ImageCry()
        {
            InitializeComponent();
        }

        private void OpenImageMenuOption_Click(object sender, EventArgs e)
        {
           
        }

        private void SaveImageMenuOption_Click(object sender, EventArgs e)
        {
            
        }

        private void HideMessageButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)MainPictureBox.Image;

            string SecretMessage = SecretMessageBox.Text;

            if (SecretMessage.Equals(""))
            {
                MessageBox.Show("Please Enter Some Text You Want to Hide.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bmp = Stegnography.embedText(SecretMessage, bmp);

            MessageBox.Show("Your Text is now Hidden in the Image.\nUse the Save Image option from Menu.", "Done");
        }

        private void ExtractMessageButton_Click(object sender, EventArgs e)
        {
           
        }

 

        private void ImageCry_Load(object sender, EventArgs e)
        {
            if (MainPictureBox.BackgroundImage.Equals("galaxy_s5-wallpaper-1440x900.jpg")) ;
            SaveImageMenuOption.Enabled=false;
            ExtractMessageButton.Enabled = false;

        }

        private void OpenImageMenuOption_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                MainPictureBox.Image = Image.FromFile(open_dialog.FileName);
                SaveImageMenuOption.Enabled = true;
                ExtractMessageButton.Enabled = true;
            }

        }

        private void SaveImageMenuOption_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "PNG Image|*.png";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(save_dialog.FileName, ImageFormat.Png);
            }
        }

        private void HideMessageButton_Click_1(object sender, EventArgs e)
        {
            bmp = (Bitmap)MainPictureBox.Image;

            string SecretMessage = SecretMessageBox.Text;

            if (SecretMessage.Equals(""))
            {
                MessageBox.Show("Please First Insert the Text and Image \nYou wish  to Combine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bmp = Stegnography.embedText(SecretMessage, bmp);

            MessageBox.Show("Your Text is now Hidden in the Image.\nUse the Save Image Option from Menu.", "Thank You");

        }

        private void ExtractMessageButton_Click_1(object sender, EventArgs e)
        {
            if (bmp != (Bitmap)MainPictureBox.Image)
           
            bmp = (Bitmap)MainPictureBox.Image;

            string SecretMessage = Stegnography.extractText(bmp);

            SecretMessageBox.Text = SecretMessage;

           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mfrm = new MainForm();
            mfrm.Show();
            this.Hide();
        }

        private void MainPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
