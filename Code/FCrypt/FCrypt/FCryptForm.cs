using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCrypt
{
    public partial class FCryptForm : Form
    {
        #region variables
        //File controller objects
        OpenFileDialog openFileDialogModule;
        FolderBrowserDialog choseFolderDialogModule;
        FileHandler fileHandlingModule;

        //Keys
        string generatedSymmetricalKey;
        string inputSymmetricalKey;
        string pathToAssymetricalKey;


        //Paths to files
        string pathForOpening;
        string pathForSaving;
        string pathToFile;
        string pathToSignatureFile;

        //Content encrypted/decrypted
        string contentToEncryptOrDecrypt;
        string encryptedContent;
        string decryptedContent;
        string signatureFileContent;

        EncryptionAES encryptorModuleAES;
        DecryptionAES decryptorModuleAES;
        ModuleRSA moduleRSA;
        #endregion

        public FCryptForm()
        {
            InitializeComponent();
            openFileDialogModule = new OpenFileDialog();
            choseFolderDialogModule = new FolderBrowserDialog();
            fileHandlingModule = new FileHandler();
            encryptorModuleAES = new EncryptionAES();
            decryptorModuleAES = new DecryptionAES();
            moduleRSA = new ModuleRSA();
        }

        #region Key generation
        private void actionGenerateSymmetricKey_Click(object sender, EventArgs e)
        {
            if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
            {
                pathForSaving = choseFolderDialogModule.SelectedPath;

                generatedSymmetricalKey = encryptorModuleAES.ReturnKeyAsString();

                fileHandlingModule.SaveContentInFile(pathForSaving,"SymmetricalKey.txt", generatedSymmetricalKey);
            }
        }

        private void actionGenerateAsymmetricKeyPair_Click(object sender, EventArgs e)
        {
            if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
            {
                pathForSaving = choseFolderDialogModule.SelectedPath;
                string fileNamePrivate = pathForSaving + "\\PrivateRSA";
                string fileNamePublic = pathForSaving + "\\PublicRSA";
                moduleRSA.SaveKeyXMLString(pathForSaving);
            }
        }
        #endregion

        #region file choosing
        private void actionChoseFileToEncrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialogModule.ShowDialog() == DialogResult.OK)
            {
                pathToFile = openFileDialogModule.FileName;
                outputFilePath.Text = pathToFile;
                contentToEncryptOrDecrypt = fileHandlingModule.ReturnTextFromFile(pathToFile);
            }
        }

        private void actionChoseKeyFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogModule.ShowDialog() == DialogResult.OK)
            {
                string pathToKeyFile = openFileDialogModule.FileName;
                inputSymmetricalKey = fileHandlingModule.ReturnTextFromFile(pathToKeyFile);
                pathToAssymetricalKey = pathToKeyFile;
                outputKeyPath.Text = pathToKeyFile;
            }
        }
        private void actionChoseSignatureFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogModule.ShowDialog() == DialogResult.OK)
            {
                pathToSignatureFile = openFileDialogModule.FileName;
                outputSignaturePath.Text = pathToSignatureFile;
            }
        }
        #endregion

        #region Encryption
        private void actionEncryptSymmetrical_Click(object sender, EventArgs e)
        {
            if (outputKeyPath.Text != "" && outputFilePath.Text != "")
            {
                if(choseFolderDialogModule.ShowDialog() == DialogResult.OK)
                {
                    pathForSaving = choseFolderDialogModule.SelectedPath;
                    encryptorModuleAES.LoadKeyFromFile(inputSymmetricalKey);
                    encryptedContent = encryptorModuleAES.EncryptWithAES(contentToEncryptOrDecrypt);
                    fileHandlingModule.SaveContentInFile(pathForSaving, "encrypted.txt", encryptedContent);
                }

            }
        }
        #endregion

        #region Decryption
        private void actionDecryptSymmetrical_Click(object sender, EventArgs e)
        {
            if (outputKeyPath.Text != "" && outputFilePath.Text != "")
            {
                if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
                {
                    pathForSaving = choseFolderDialogModule.SelectedPath;
                    decryptorModuleAES.LoadKeyFromFile(inputSymmetricalKey);
                    decryptedContent = decryptorModuleAES.DecryptAES(contentToEncryptOrDecrypt);
                    fileHandlingModule.SaveContentInFile(pathForSaving, "decrypted.txt", decryptedContent);
                }
            }
        }

        #endregion

        private void actionEncryptAsymmetrical_Click(object sender, EventArgs e)
        {
            if (outputKeyPath.Text != "" && outputFilePath.Text != "")
            {
                if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
                {
                    pathForSaving = choseFolderDialogModule.SelectedPath;
                    string loadedXmlRsaKeyString = fileHandlingModule.ReturnTextFromFile(pathToAssymetricalKey);
                    string plainText = fileHandlingModule.ReturnTextFromFile(pathToFile);
                    string cipherText = moduleRSA.Encrypt(plainText, loadedXmlRsaKeyString);
                    fileHandlingModule.SaveContentInFile(pathForSaving, "encryptedASYM.txt", cipherText);
                }
            }
        }

        private void actionDecryptAsymmetrical_Click(object sender, EventArgs e)
        {
            if (outputKeyPath.Text != "" && outputFilePath.Text != "")
            {
                if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
                {
                    pathForSaving = choseFolderDialogModule.SelectedPath;
                    string loadedXmlRsaKeyString = fileHandlingModule.ReturnTextFromFile(pathToAssymetricalKey);
                    string cipherText = fileHandlingModule.ReturnTextFromFile(pathToFile);
                    string plainText = moduleRSA.Decrypt(cipherText, loadedXmlRsaKeyString);
                    fileHandlingModule.SaveContentInFile(pathForSaving, "decryptedASYM.txt", plainText);
                }
            }
        }

        private void actionCalculateFileHash_Click(object sender, EventArgs e)
        {
            if (outputFilePath.Text != "")
            {
                if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
                {
                    pathForSaving = choseFolderDialogModule.SelectedPath;
                    string fileContent = fileHandlingModule.ReturnTextFromFile(pathToFile);
                    string calculatedFileHash = moduleRSA.ReturnHash(fileContent);
                    fileHandlingModule.SaveContentInFile(pathForSaving, "hashedValue.txt", calculatedFileHash);
                    outputHashedValue.Text = calculatedFileHash;
                }
            }
        }

        private void actionDigitalySign_Click(object sender, EventArgs e)
        {
            if (outputKeyPath.Text != "" && outputFilePath.Text != "")
            {
                if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
                {
                    pathForSaving = choseFolderDialogModule.SelectedPath;
                    string loadedXmlRsaKeyString = fileHandlingModule.ReturnTextFromFile(pathToAssymetricalKey);
                    string plainText = fileHandlingModule.ReturnTextFromFile(pathToFile);
                    string cipherText = moduleRSA.DigitalySign(plainText, loadedXmlRsaKeyString);
                    fileHandlingModule.SaveContentInFile(pathForSaving, "signedFile.txt", cipherText);
                }
            }
        }

        private void actionCheckSignature_Click(object sender, EventArgs e)
        {
            if (outputKeyPath.Text != "" && outputFilePath.Text != "" && outputSignaturePath.Text != "")
            {
                pathForSaving = choseFolderDialogModule.SelectedPath;
                string loadedXmlRsaKeyString = fileHandlingModule.ReturnTextFromFile(pathToAssymetricalKey);
                string plainText = fileHandlingModule.ReturnTextFromFile(pathToFile);
                string signatureText = fileHandlingModule.ReturnTextFromFile(pathToSignatureFile);
                bool isVerified = moduleRSA.VerifySignature(plainText, signatureText, loadedXmlRsaKeyString);
                if (isVerified)
                {
                    outputIsVerified.Text = "File intact";
                }
                else
                {
                    outputIsVerified.Text = "File modified";
                }
            }
        }
    }
}
