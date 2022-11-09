
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleAppTest
{
    internal class EncryptionDecryption
    {
        public void Encrypt()
        {
            try
            {
                string data = "AdheFQ3IFOBD38g76EU-2vWsdwoYU5do-L4MZgUH3s59LB6tWsjGLIK0Ilfz_bSrp1KA43FzfRQsqP3Y";
                using (FileStream fileStream = new FileStream("TestData.txt", FileMode.OpenOrCreate))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] key =
                        {0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16};
                        aes.Key = key;

                        byte[] iv = aes.IV;
                        fileStream.Write(iv, 0, iv.Length);

                        using (CryptoStream cryptoStream = new CryptoStream(
                            fileStream,
                            aes.CreateEncryptor(),
                            CryptoStreamMode.Write))
                        {
                            using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                            {
                                encryptWriter.WriteLine(data);                                
                            }
                        }
                    }
                }
                Console.WriteLine("The file was encrypted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The encryption failed. {ex}");
            }
        }
    }
}
