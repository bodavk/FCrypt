using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.OpenSsl;
using System.IO;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;


namespace FCrypt
{
    class ModuleRSA
    {
        private static RSACryptoServiceProvider cspRSA;
        private static RSAParameters publicKey;
        private static RSAParameters privateKey;
        private static bool _optimalAsymmetricEncryptionPadding = false;


        public void SaveKeyXMLString(string filename)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            TextWriter writer = new StreamWriter(filename + "\\PublicRSA");
            string publicKey = RSA.ToXmlString(false);
            writer.Write(publicKey);
            writer.Close();

            writer = new StreamWriter(filename + "\\PrivateRSA");
            string privateKey = RSA.ToXmlString(true);
            writer.Write(privateKey);
            writer.Close();
        }


        public string Encrypt(string plainText, string publicKeyXml)
        {
            string encryptedString;
            byte[] dataByteArray = Encoding.UTF8.GetBytes(plainText);
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                provider.FromXmlString(publicKeyXml);
                byte[] encryptedData = provider.Encrypt(dataByteArray, true);
                encryptedString = Convert.ToBase64String(encryptedData);
                return encryptedString;
            }
        }


        public string Decrypt(string cipherText, string publicAndPrivateKeyXml)
        {
            string plainTextString;
            byte[] dataByteArray = Convert.FromBase64String(cipherText);
            plainTextString = Convert.ToBase64String(dataByteArray);
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                byte[] decryptedData = provider.Decrypt(dataByteArray, true);
                plainTextString = Convert.ToBase64String(decryptedData);
                byte[] bytes = Convert.FromBase64String(plainTextString);
                plainTextString = Encoding.UTF8.GetString(bytes);
                return plainTextString;
            }
        }

 

    }
}
