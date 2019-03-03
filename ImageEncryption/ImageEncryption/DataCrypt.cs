using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Security;

namespace ImageEncryption
{
    public partial class DataCrypt : Form
    {
        public DataCrypt()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
            textBox3.MaxLength = 8;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                checkBox2.Enabled = false;
                this.button3.Text = "Encryption";
                this.label2.Text = "Encryption Operation was Choosen";
            }
            else if(checkBox1.Checked==false)
            {
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                this.button3.Text = "Decryption";
                this.label2.Text = "Decryption Operation was Choosen";
            }
            else if (checkBox2.Checked == false)
            {
                checkBox1.Enabled = true;
            }
        }

        private void TextCrypt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 openfile = new openFileDialog1();
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                textBox1.Text = path;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            switch (button3.Text)
            {
                default: break;
                case "Encryption":
                    {
                        try
                        {
                            string password = textBox3.Text;
                            UnicodeEncoding UE = new UnicodeEncoding();
                            byte[] key = UE.GetBytes(password);
                            String cryptedfile = textBox2.Text;
                            FileStream FsCrypt = new FileStream(cryptedfile, FileMode.Create);
                            RijndaelManaged RMCrypt = new RijndaelManaged();
                            CryptoStream CS = new CryptoStream(FsCrypt, RMCrypt.CreateEncryptor(key, key), CryptoStreamMode.Write );
                            FileStream FSIN = new FileStream(textBox1.Text, FileMode.Open);
                            int data;
                            while ((data = FSIN.ReadByte()) != -1)
                                CS.WriteByte((byte)data);
                            FSIN.Close();
                            CS.Close();
                            FsCrypt.Close();
                            MessageBox.Show("Data Encrypted Successfully!","Successfuly Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            label2.Text = "The Encryption Operation Failed";
                            MessageBox.Show("Please Browse the Data You want to Encrypt and Insert  a Valid Password with 8 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        break;
                    }


                case "Decryption":

                    {
                        try
                        {
                            string password = textBox3.Text;
                            UnicodeEncoding UE = new UnicodeEncoding();
                            byte[] key = UE.GetBytes(password);
                            String cryptedfile = textBox1.Text;
                            FileStream FsCrypt = new FileStream(cryptedfile, FileMode.Open);
                            RijndaelManaged RMCrypt = new RijndaelManaged();
                            CryptoStream CS = new CryptoStream(FsCrypt, RMCrypt.CreateDecryptor(key, key), CryptoStreamMode.Read);
                            FileStream FSout = new FileStream(textBox2.Text, FileMode.Create);
                            int data;
                            while ((data = CS.ReadByte()) != -1)
                                FSout.WriteByte((byte)data);
                            FSout.Close();
                            CS.Close();
                            FsCrypt.Close();
                            MessageBox.Show("Data Decrypted Successfully!", "Successfuly Decrypted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception)
                        {
                            label2.Text = "Decryption Operation Failed";
                            MessageBox.Show("Please Browse the Encrypted Data You want to Decrypt and Insert a Valid Password with 8 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;
                    }



            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                textBox2.Text = path;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TextCrypt frm = new TextCrypt();
            //frm.Show();

            MainForm mfrm = new MainForm();
            mfrm.Show();
            this.Hide();

        }
    }
}
