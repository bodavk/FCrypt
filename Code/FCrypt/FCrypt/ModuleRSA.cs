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
        private AsymmetricCipherKeyPair keyPair;
        private RsaKeyParameters loadedKeyPair;
        private AsymmetricCipherKeyPair loadedKeyPairDecryption;

        public AsymmetricCipherKeyPair KeyPair
        {
            get;
        }

        public AsymmetricCipherKeyPair LoadedKeyPair
        {
            get;
        }


        public ModuleRSA(int keyLength)
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

        public string LoadKeyAndEncrypt(string keyFileName, string fileName)
        {
            using (var reader = File.OpenText(keyFileName))
                loadedKeyPair = (RsaKeyParameters)new PemReader(reader).ReadObject();

            StreamReader file = new StreamReader(fileName, Encoding.UTF8);
            string fileContent = file.ReadToEnd();
            file.Close();
            byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(fileContent);
            var encryptEngine = new Pkcs1Encoding(new RsaEngine());
            encryptEngine.Init(true, loadedKeyPair);

            int length = bytesToEncrypt.Length;
            int blockSize = encryptEngine.GetInputBlockSize();
            List<byte> cipherTextBytes = new List<byte>();
            for (int chunkPosition = 0;
                chunkPosition < length;
                chunkPosition += blockSize)
            {
                int chunkSize = Math.Min(blockSize, length - chunkPosition);
                cipherTextBytes.AddRange(encryptEngine.ProcessBlock(
                    bytesToEncrypt, chunkPosition, chunkSize
                ));
            }

            var encrypted = Encoding.UTF8.GetString(cipherTextBytes.ToArray());
            return encrypted;
        }

        public string LoadKeyAndDecrypt(string keyFileName, string fileName)
        {
            using (var reader = File.OpenText(keyFileName))
                loadedKeyPairDecryption = (AsymmetricCipherKeyPair) new PemReader(reader).ReadObject();

            StreamReader file = new StreamReader(fileName, Encoding.UTF8);
            string fileContent = file.ReadToEnd();
            file.Close();
            byte[] bytesToDecrypt = Encoding.UTF8.GetBytes(fileContent);
            var decryptEngine = new Pkcs1Encoding(new RsaEngine());
            decryptEngine.Init(false, loadedKeyPairDecryption.Private);

            int length = bytesToDecrypt.Length;
            int blockSize = decryptEngine.GetInputBlockSize();
            List<byte> plainTextBytes = new List<byte>();
            for (int chunkPosition = 0;
                chunkPosition < length;
                chunkPosition += blockSize)
            {
                int chunkSize = Math.Min(blockSize, length - chunkPosition);
                plainTextBytes.AddRange(decryptEngine.ProcessBlock(
                    bytesToDecrypt, chunkPosition, chunkSize
                ));
            }
            
            var decrypted = Encoding.UTF8.GetString(plainTextBytes.ToArray());
            return decrypted;
        }



    }
}
