using System;
using System.IO;
using System.Text;
using System.Security;
using System.Security.Cryptography;

namespace FCrypt
{
    class EncryptionAES
    {

        private Aes aesObject;
        private byte[] initialisationVector;

        public EncryptionAES()
        {
            aesObject = Aes.Create();
            //aesObject.Padding = PaddingMode.None;
        }

        public string ReturnKeyAsString()
        {
            byte[] keyToReturn = aesObject.Key;
            byte[] initialisationVector = aesObject.IV;
            
            string keyString = Convert.ToBase64String(keyToReturn);
            return keyString;
        }

        public void LoadKeyFromFile(string encodedKey)
        {
            byte[] key = Convert.FromBase64String(encodedKey);
            aesObject.Key = key;
        }

        public string EncryptWithAES(string content)
        {            
            //get IV as string so that it can be concatenated and saved together with text
            initialisationVector = aesObject.IV;
            string initialisationVectorString = Convert.ToBase64String(initialisationVector);

            byte[] encryptedBytes;

            ICryptoTransform encryptor = aesObject.CreateEncryptor();
            // Create the streams used for encryption.
            using (MemoryStream memoryStreamEncrypt = new MemoryStream())
            {
                using (CryptoStream cryptoStreamEncrypt = new CryptoStream(memoryStreamEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter streamWriterEncrypt = new StreamWriter(cryptoStreamEncrypt))
                    {
                        //Write all data to the stream.
                        streamWriterEncrypt.Write(content);
                    }
                    encryptedBytes = memoryStreamEncrypt.ToArray();
                }
            }
            string encryptedContent = Convert.ToBase64String(encryptedBytes);
            string concatenatedContentIV = initialisationVectorString + encryptedContent;
            return concatenatedContentIV;

        }
    }
}


        