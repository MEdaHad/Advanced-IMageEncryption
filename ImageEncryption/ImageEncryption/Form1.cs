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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
