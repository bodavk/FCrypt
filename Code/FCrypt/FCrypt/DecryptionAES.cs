using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.IO;

namespace FCrypt
{
    class DecryptionAES
    {
        private Aes aesObject;
        private byte[] calculatedInitialisationVector;
        string initialisationVectorString;

        public DecryptionAES()
        {
            aesObject = Aes.Create();
           // aesObject.Padding = PaddingMode.None;
        }

        /// <summary>
        /// From string representation of a file set's the key Value
        /// </summary>
        /// <param name="encodedKey">The string that represents the key found in a file</param>
        public void LoadKeyFromFile(string encodedKey)
        {
            byte[] key = Convert.FromBase64String(encodedKey);
            aesObject.Key = key;
        }

        /// <summary>
        /// Method that converts a string into bytearray necessary for further decryption
        /// </summary>
        /// <param name="encryptedContent"></param>
        /// <returns></returns>
        private byte[] ConvertFromStringToByteArray(string encryptedContent)
        {
            byte[] byteArrayContent = Convert.FromBase64String(encryptedContent);
            return byteArrayContent;
        }

        /// <summary>
        /// This method finds the size of IV in bytes
        /// </summary>
        /// <returns></returns>
        private int FindSizeIV()
        {
            int initialisationVectorSize = aesObject.BlockSize / 8;
            return initialisationVectorSize;

        }

        private int FindIVLength(string stringWholeFile)
        {
            int indexOfDoubleEqualSign = stringWholeFile.IndexOf("=");
            //Increase the index by 2 to get the length of base64 prefix
            indexOfDoubleEqualSign += 2;
            return indexOfDoubleEqualSign;
        }

        /// <summary>
        /// This method finds the IV value and returns it
        /// </summary>
        /// <param name="StringWholeFile"></param>
        /// <returns></returns>
        private string FindInitialisationVector(string stringWholeFile)
        {
            int IVSize = FindSizeIV();
            int indexOfDoubleEqualSign = stringWholeFile.IndexOf("=");
            //Increase the index by 2 to get the length of base64 prefix
            indexOfDoubleEqualSign += 2;
            string initialisationVector = stringWholeFile.Substring(0, indexOfDoubleEqualSign);
            return initialisationVector;
        }

        /// <summary>
        /// A private method that converts string IV into byte array and sets the value of initialisation vector used in decryption of a file
        /// </summary>
        /// <param name="encryptedString"> a whole file </param>
        private void SetInitialisationVector(string encryptedString)
        {
            initialisationVectorString = FindInitialisationVector(encryptedString);
            calculatedInitialisationVector = Convert.FromBase64String(initialisationVectorString);
            aesObject.IV = calculatedInitialisationVector;
        }

        /// <summary>
        /// A method that removes IV from the begining of a file which is parsed as a string
        /// </summary>
        /// <param name="encryptedString">File represented as a string</param>
        /// <returns></returns>
        private string RemoveIVFromEncryptedString(string encryptedString)
        {
            int sizeOfIV = FindIVLength(encryptedString);
            string cutoutString = encryptedString.Remove(0,sizeOfIV);
            return cutoutString;
        }

        public string DecryptAES(string encryptedStringFile)
        {
            SetInitialisationVector(encryptedStringFile);
            string editedString = RemoveIVFromEncryptedString(encryptedStringFile);

            byte[] encryptedContent = ConvertFromStringToByteArray(editedString);
            string decryptedText;
            ICryptoTransform decryptor = aesObject.CreateDecryptor();

            using (MemoryStream memoryStreamDecrypt = new MemoryStream(encryptedContent))
            {
                using (CryptoStream cryptoStreamDecrypt = new CryptoStream(memoryStreamDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReaderDecrypt = new StreamReader(cryptoStreamDecrypt))
                    {
                        decryptedText = streamReaderDecrypt.ReadToEnd();
                    }
                }
            }

            return decryptedText;

        }



    }
}
