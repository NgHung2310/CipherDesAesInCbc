using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherDesAesInCbc
{
    public class CryptDesCbcFileToFile
    {
        public static void Encrypt(string pathI, string pathO, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (pathI == null || pathI.Length <= 0)
                throw new ArgumentNullException("path");
            if (pathO == null || pathO.Length <= 0)
                throw new ArgumentNullException("path");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("iv");
            try
            {
                List<byte[]> lstCipher = new List<byte[]>();
                string[] lines = System.IO.File.ReadAllLines(pathI);
                foreach (string linePlain in lines)
                {
                    lstCipher.Add(CryptDesCbc.Encrypt(linePlain, key, iv));
                }
                List<string> lstStr = new List<string>();
                foreach (byte[] byteCipher in lstCipher)
                {
                    lstStr.Add(Convert.ToBase64String(byteCipher));
                }
                System.IO.File.WriteAllLines(pathO, lstStr);
            }
            catch (CryptographicException e)
            {
                MessageBox.Show("A Cryptographic error occurred: {0}", e.Message);
                throw;
            }
        }

        public static void Decrypt(string pathI, string pathO, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (pathI == null || pathI.Length <= 0)
                throw new ArgumentNullException("path");
            if (pathO == null || pathO.Length <= 0)
                throw new ArgumentNullException("path");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("iv");
            List<string> lstCipher = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(pathI);
            foreach (string linePlain in lines)
            {
                byte[] bytePlain = Convert.FromBase64String(linePlain);
                lstCipher.Add(CryptDesCbc.Decrypt(bytePlain, key, iv));
            }
            System.IO.File.WriteAllLines(pathO, lstCipher);
        }
    }
}
