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

namespace FCrypt
{
    class KeyGeneratorRSA
    {
        private AsymmetricCipherKeyPair keyPair;
        private AsymmetricCipherKeyPair loadedKeyPair;

        public AsymmetricCipherKeyPair KeyPair
        {
            get;
        }

        public KeyGeneratorRSA(int keyLength)
        {
            GenerateKey(keyLength);
        }

        /// <summary>
        /// This method generates a random new pair of keys
        /// </summary>
        /// <param name="keyLength"></param>
        private void GenerateKey(int keyLength)
        {
            var r = new RsaKeyPairGenerator();
            r.Init(new KeyGenerationParameters(new SecureRandom(), keyLength));
            keyPair = r.GenerateKeyPair();
        }
        
        public void SavePublicKeyToFile(string fileName)
        {
            var textWriter = new StreamWriter(fileName);
            var pemWriter = new PemWriter(textWriter);
            pemWriter.WriteObject(keyPair.Public);
            pemWriter.Writer.Flush();
            textWriter.Close();
        }
        public void SavePrivateKeyToFile(string fileName)
        {
            var textWriter = new StreamWriter(fileName);
            var pemWriter = new PemWriter(textWriter);
            pemWriter.WriteObject(keyPair.Private);
            pemWriter.Writer.Flush();
            textWriter.Close();
        }



















        /// <summary>
        /// This method returns a private key parameter
        /// </summary>
        /// <returns></returns>
        public AsymmetricKeyParameter ReturnPrivateKey ()
        {
            return keyPair.Private;
            /* https://stackoverflow.com/questions/6531054/generate-public-private-key-pair-and-show-them-in-textbox-in-asp-net */
        }

        /// <summary>
        /// This method returns a public key paramater of a keypair
        /// </summary>
        /// <returns></returns>
        public AsymmetricKeyParameter ReturnPublicKey()
        {
            return keyPair.Public;
        }

        
    }
}
