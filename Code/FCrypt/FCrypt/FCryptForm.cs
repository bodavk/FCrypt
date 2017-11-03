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
        //File controller objects
        OpenFileDialog openFileDialogModule;
        FolderBrowserDialog choseFolderDialogModule;
        FileHandler fileHandlingModule;

        //Keys
        string generatedSymmetricalKey;
        string generatedPublicKey;
        string generatedPrivateKey;
        string inputSymmetricalKey;

        //Paths to files
        string pathForOpening;
        string pathForSaving;

        //Content encrypted/decrypted
        string contentToEncrypt;
        string encryptedContent;

        EncryptionAES encryptorModuleAES;

        public FCryptForm()
        {
            InitializeComponent();
            openFileDialogModule = new OpenFileDialog();
            choseFolderDialogModule = new FolderBrowserDialog();
            fileHandlingModule = new FileHandler();
            encryptorModuleAES = new EncryptionAES();
        }

        private void actionGenerateSymmetricKey_Click(object sender, EventArgs e)
        {
            if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
            {
                pathForSaving = choseFolderDialogModule.SelectedPath;

                generatedSymmetricalKey = encryptorModuleAES.ReturnKeyAsString();

                fileHandlingModule.SaveContentInFile(pathForSaving,"SymmetricalKey.txt", generatedSymmetricalKey);
            }
        }

        //NOT IMPLEMENTED FULLY YET
        private void actionGenerateAsymmetricKeyPair_Click(object sender, EventArgs e)
        {
            if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
            {
                pathForSaving = choseFolderDialogModule.SelectedPath;
                //A method that generates keypair should be called here
                generatedPrivateKey = "";
                generatedPublicKey = "";
                fileHandlingModule.SaveContentInFile(pathForSaving, "PrivateKey.txt", generatedPrivateKey);
                fileHandlingModule.SaveContentInFile(pathForSaving, "PublicKey.txt", generatedPublicKey);
            }
        }

        private void actionChoseFileToEncrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialogModule.ShowDialog() == DialogResult.OK)
            {
                string pathToFile = openFileDialogModule.FileName;
                outputFilePath.Text = pathToFile;
                contentToEncrypt = fileHandlingModule.ReturnTextFromFile(pathToFile);
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

        private void actionEncryptSymmetrical_Click(object sender, EventArgs e)
        {
            if (outputKeyPath.Text != "" && outputFilePath.Text != "")
            {
                if(choseFolderDialogModule.ShowDialog() == DialogResult.OK)
                {
                    pathForSaving = choseFolderDialogModule.SelectedPath;
                    encryptorModuleAES.LoadKeyFromFile(inputSymmetricalKey);
                    encryptedContent = encryptorModuleAES.EncryptWithAES(contentToEncrypt);
                    fileHandlingModule.SaveContentInFile(pathForSaving, "encrypted.txt", encryptedContent);
                }

            }
        }
    }
}
