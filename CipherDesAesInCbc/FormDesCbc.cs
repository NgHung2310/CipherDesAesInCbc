using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherDesAesInCbc
{
    public partial class FormDesCbc : Form
    {
        byte[] key;
        byte[] iv;
        string pathI;
        string pathO;

        public FormDesCbc()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            btnCalc.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textPlain = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathI = openFileDialog1.FileName;
                string[] lines = System.IO.File.ReadAllLines(pathI);
                foreach (var item in lines)
                {
                    textPlain += item + "\n";
                }
            }
            rtbInput.Text = textPlain;
        }

        private void btnBrowseOut_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathO = saveFileDialog1.FileName;
                lbInfomation.Text = "File output has been selected!";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                key = Convert.FromBase64String(tbxKey.Text);
                iv = Convert.FromBase64String(tbxIv.Text);
                if (rbtnEncrypt.Checked == true)
                {
                    List<string> lstStr = rtbInput.Text.Trim().Split('\n').ToList();
                    lstStr = lstStr.Where(x => x.Length > 0).ToList();
                    string result = "";
                    if (saveFileDialog1.FileName.Length > 0)
                    {
                        CryptDesCbcFileToFile.Encrypt(pathI, pathO, key, iv);
                        foreach (var item in lstStr)
                        {
                            result += Convert.ToBase64String(CryptDesCbc.Encrypt(item, key, iv)) + "\n";
                        }
                        rtbOutput.Text = result;
                        lbInfomation.Text = "Cipher text has been saved!";
                    }
                    else
                    {
                        foreach (var item in lstStr)
                        {
                            result += Convert.ToBase64String(CryptDesCbc.Encrypt(item, key, iv)) + "\n";
                        }
                        rtbOutput.Text = result;
                        lbInfomation.Text = "Cipher text has been displayed!";
                    }
                }
                else if (rbtnDecrypt.Checked == true)
                {
                    string result = "";
                    List<string> lstStr = rtbInput.Text.Trim().Split('\n').ToList();
                    List<byte[]> lstByte = lstStr.Where(x => x.Length > 0).Select(x => Convert.FromBase64String(x)).ToList();
                    if (saveFileDialog1.FileName.Length > 0)
                    {
                        CryptDesCbcFileToFile.Decrypt(pathI, pathO, key, iv);
                        foreach (var item in lstByte)
                        {
                            result += CryptDesCbc.Decrypt(item, key, iv) + "\n";
                        }
                        rtbOutput.Text = result;
                        lbInfomation.Text = "Cipher text has been saved!";
                    }
                    else
                    {
                        foreach (var item in lstByte)
                        {
                            result += CryptDesCbc.Decrypt(item, key, iv) + "\n";
                        }
                        rtbOutput.Text = result;
                        lbInfomation.Text = "Cipher text has been displayed!";
                    }
                }
                openFileDialog1.FileName = "";
                saveFileDialog1.FileName = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Key or IV is not valid!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Input text is not valid!");
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            using (DES myAes = DES.Create())
            {
                tbxKey.Text = Convert.ToBase64String(myAes.Key);
                tbxIv.Text = Convert.ToBase64String(myAes.IV);
            }
        }

        private void tbxIv_TextChanged(object sender, EventArgs e)
        {
            if (tbxIv.Text.Length <= 0 || tbxKey.Text.Length <= 0)
            {
                btnCalc.Enabled = false;
            }
            else
            {
                btnCalc.Enabled = true;
            }
        }

        private void tbxKey_TextChanged(object sender, EventArgs e)
        {
            if (tbxIv.Text.Length <= 0 || tbxKey.Text.Length <= 0)
            {
                btnCalc.Enabled = false;
            }
            else
            {
                btnCalc.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            rtbInput.Text = "";
            rtbOutput.Text = "";
            tbxIv.Text = "";
            tbxKey.Text = "";
            lbInfomation.Text = "";
        }
    }
}
