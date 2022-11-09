using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Utility
{
    public partial class Cryptography : UserControl
    {
        const string Password = "Consperate";
        public Cryptography()
        {
            InitializeComponent();
        }

        private async void Encrypt_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = await Encryption(inputTextBox.Text.Trim());
            Clipboard.SetText(outputTextBox.Text);
        }

        private async void Decrypt_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = await Decryption(inputTextBox.Text.Trim());
            Clipboard.SetText(outputTextBox.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
        }

        public static async Task<string> Encryption(string orignalData)
        {
            //High Secure
            //using (Aes aes = Aes.Create())
            //{
            //    byte[] encrypted = await EncryptString(orignalData, aes.Key, aes.IV);
            //    return Convert.ToBase64String(encrypted);
            //}
            //

            //Moderate Secure
            using (PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[] { 0X10, 0X51, 0X97, 0X6E, 0X9D, 0X46, 0X25, 0X73, 0X4F, 0X8C, 0X9D, 0X7A, 0X2B }))
            {
                byte[] encrypted = await EncryptString(orignalData, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
                return Convert.ToBase64String(encrypted);
            }           
        }

        public static async Task<string> Decryption(string encryptedData)
        {
            //using (Aes aes = Aes.Create())
            //{
            //    byte[] cipherText = Convert.FromBase64String(encryptedData);
            //    return await DecryptString(cipherText, aes.Key, aes.IV);
            //}

            using (PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[] { 0X10, 0X51, 0X97, 0X6E, 0X9D, 0X46, 0X25, 0X73, 0X4F, 0X8C, 0X9D, 0X7A, 0X2B }))
            {
                byte[] cipherText = Convert.FromBase64String(encryptedData);
                return await DecryptString(cipherText, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
            }
        }

        public static async Task<byte[]> EncryptString(string orignalData, byte[] Key, byte[] IV)
        {
            if (orignalData == null || orignalData.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            await swEncrypt.WriteAsync(orignalData);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        public static async Task<string> DecryptString(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string orignalData = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            orignalData = await srDecrypt.ReadToEndAsync();
                        }
                    }
                }
            }
            return orignalData;
        }
    }
}
