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
    public partial class TextCrypt : Form
    {
        public TextCrypt()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 8;
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 8;
        }

        private void encBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (encBox2.Checked == true)
            {
                decBox2.Enabled = false;
                this.tbutton.Text = "Encryption";
                this.label22.Text = "Encryption Operation was Choosen";
            }
            else if (encBox2.Checked == false)
            {
                decBox2.Enabled = true;
            }
        }

        private void decBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (decBox2.Checked == true)
            {
                encBox2.Enabled = false;
                this.tbutton.Text = "Decryption";
                this.label22.Text = "Decryption operation was Choosen";

            }
            else if (decBox2.Checked == false)
            {
                encBox2.Enabled = true;

            }
        }

        private void tbutton_Click(object sender, EventArgs e)
        {
            string VIkey = "@15sd45defcdr965";
            switch (tbutton.Text)
            {
                default: break;
                case "Encryption":
                    {
                        try
                        {

                            byte[] plaintextbyte = Encoding.UTF8.GetBytes(richTextBox1.Text);
                            byte[] keyBytes = new Rfc2898DeriveBytes(textBox1.Text, Encoding.ASCII.GetBytes(textBox2.Text)).GetBytes(256 / 8);
                            var symmetrickey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                            var encryptor = symmetrickey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIkey));

                            byte[] cipherTextBytes;

                            using (var memoryStream = new MemoryStream())
                            {
                                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                                {
                                    cryptoStream.Write(plaintextbyte, 0, plaintextbyte.Length);
                                    cryptoStream.FlushFinalBlock();
                                    cipherTextBytes = memoryStream.ToArray();
                                    cryptoStream.Close();
                                }

                                memoryStream.Close();

                                richTextBox2.Text = Convert.ToBase64String(cipherTextBytes);


                                label22.Text = "Done";
                                MessageBox.Show("The Encryption Operation was Successful", "Successful Encryption",  MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }

                        catch (Exception)
                        {
                            label22.Text = "The Decryption Operation Failed";
                            MessageBox.Show("Please Insert the Text You want to Encrypt and a Valid Password with 8 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;


                    }

                case "Decryption":

                    {
                        try
                        {
                            byte[] cipherTextBytes = Convert.FromBase64String(richTextBox2.Text);
                            byte[] keyBytes = new Rfc2898DeriveBytes(textBox1.Text, Encoding.ASCII.GetBytes(textBox2.Text)).GetBytes(256 / 8);
                            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };


                            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIkey));
                            var memoryStream = new MemoryStream(cipherTextBytes);
                            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                            byte[] PlainTextBytes = new byte[cipherTextBytes.Length];

                            int decryptedByteCount = cryptoStream.Read(PlainTextBytes, 0, PlainTextBytes.Length);
                            memoryStream.Close();
                            cryptoStream.Close();
                            richTextBox1.Text = Encoding.UTF8.GetString(PlainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());

                            label22.Text = "Done";
                            MessageBox.Show("The Decyption Operation was Successful ", "Successful Decyrption", MessageBoxButtons.OK, MessageBoxIcon.Information );

                        }
                        catch (Exception )
                        {
                            label22.Text = "Decryption Operation Failed";
                            MessageBox.Show("Please Insert the Text you want to Decrypt and a Valid Password with 8 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TextCrypt_Load(object sender, EventArgs e)
        {

        }
    }
}
