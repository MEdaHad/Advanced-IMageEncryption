using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEncryption
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public class TextCrypt : Form
        //{
        //    public TextCrypt()
        //    {
        //        Text = "TextCrypt";
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            TextCrypt frm = new TextCrypt();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataCrypt frm = new DataCrypt();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help hlp = new Help();
            hlp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //Image ifrm = new Image();
            //ifrm.Show();
            ImageCry imgc = new ImageCry();
            imgc.Show();
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutMe abx = new AboutMe();
            abx.Show();

        }
    }
}
