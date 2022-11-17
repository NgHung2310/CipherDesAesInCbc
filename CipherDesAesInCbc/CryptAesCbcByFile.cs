using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherDesAesInCbc
{
    public class CryptAesCbcByFile
    {
        public static void EncryptTextToFile(string text, string path, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException("text");
            if (path == null || path.Length <= 0)
                throw new ArgumentNullException("path");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("iv");
            try
            {
                // Create or open the specified file.
                using (FileStream fStream = File.Open(path, FileMode.Create))
                // Create a new DES object.
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = iv;
                    aesAlg.Mode = CipherMode.CBC;
                    // Create a DES encryptor from the key and IV
                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                    // Create a CryptoStream using the FileStream and encryptor
                    using (var cStream = new CryptoStream(fStream, encryptor, CryptoStreamMode.Write))
                    {
                        // Convert the provided string to a byte array.
                        byte[] toEncrypt = Encoding.UTF8.GetBytes(text);

                        // Write the byte array to the crypto stream.
                        cStream.Write(toEncrypt, 0, toEncrypt.Length);
                    }
                }
            }
            catch (CryptographicException e)
            {
                MessageBox.Show("A Cryptographic error occurred: {0}", e.Message);
                throw;
            }
        }

        public static string DecryptTextFromFile(string path, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (path == null || path.Length <= 0)
                throw new ArgumentNullException("path");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("iv");
            try
            {
                // Open the specified file
                using (FileStream fStream = File.OpenRead(path))
                // Create a new DES object.
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = iv;
                    aesAlg.Mode = CipherMode.CBC;
                    // Create a DES decryptor from the key and IV
                    using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(key, iv))
                    // Create a CryptoStream using the FileStream and decryptor
                    using (var cStream = new CryptoStream(fStream, decryptor, CryptoStreamMode.Read))
                    // Create a StreamReader to turn the bytes back into text
                    using (StreamReader reader = new StreamReader(cStream, Encoding.UTF8))
                    {
                        // Read back all of the text from the StreamReader, which receives
                        // the decrypted bytes from the CryptoStream, which receives the
                        // encrypted bytes from the FileStream.
                        return reader.ReadToEnd();
                    }
                }
            }
            catch (CryptographicException e)
            {
                MessageBox.Show("A Cryptographic error occurred: {0}", e.Message);
                throw;
            }
        }
    }
}
