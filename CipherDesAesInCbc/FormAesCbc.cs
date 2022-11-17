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
    public partial class FormAesCbc : Form
    {
        public FormAesCbc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] key;
            byte[] iv;
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string pathI = openFileDialog1.FileName;
                if(saveFileDialog1.ShowDialog()== DialogResult.OK)
                {
                    using (Aes aesAlg = Aes.Create())
                    {
                        key = aesAlg.Key;
                        iv = aesAlg.IV;
                        string pathO = saveFileDialog1.FileName;
                        CryptAesCbcFileToFile.Decrypt(pathI, pathO, key, iv);
                    }
                }
            }    
        }
    }
}
