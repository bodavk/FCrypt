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

        //Paths to files
        string pathForOpening;
        string pathForSaving;

        //Content encrypted/decrypted
        string contentToEncryptOrDecrypt;
        string encryptedContent;
        string decryptedContent;

        EncryptionAES encryptorModuleAES;
        DecryptionAES decryptorModuleAES;
        KeyGeneratorRSA keyGeneratingModuleRSA;
        #endregion

        public FCryptForm()
        {
            InitializeComponent();
            openFileDialogModule = new OpenFileDialog();
            choseFolderDialogModule = new FolderBrowserDialog();
            fileHandlingModule = new FileHandler();
            encryptorModuleAES = new EncryptionAES();
            decryptorModuleAES = new DecryptionAES();
            keyGeneratingModuleRSA = new KeyGeneratorRSA(2048);
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
                keyGeneratingModuleRSA.SavePrivateKeyToFile(fileNamePrivate);
                keyGeneratingModuleRSA.SavePublicKeyToFile(fileNamePublic);
            }
        }
        #endregion

        #region file choosing
        private void actionChoseFileToEncrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialogModule.ShowDialog() == DialogResult.OK)
            {
                string pathToFile = openFileDialogModule.FileName;
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
                outputKeyPath.Text = pathToKeyFile;
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


    }
}
