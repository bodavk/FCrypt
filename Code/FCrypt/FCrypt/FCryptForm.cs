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
        OpenFileDialog openFileDialogModule;
        FolderBrowserDialog choseFolderDialogModule;
        FileSaver fileSavingModule;
        string generatedSymmetricalKey;
        string generatedPublicKey;
        string generatedPrivateKey;
        string pathForOpening;
        string pathForSaving;

        public FCryptForm()
        {
            InitializeComponent();
            openFileDialogModule = new OpenFileDialog();
            choseFolderDialogModule = new FolderBrowserDialog();
            fileSavingModule = new FileSaver();
        }

        private void actionGenerateSymmetricKey_Click(object sender, EventArgs e)
        {
            if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
            {
                pathForSaving = choseFolderDialogModule.SelectedPath;
                //A method that generates a key should be called here
                generatedSymmetricalKey = "";
                fileSavingModule.SaveContentInFile(pathForSaving,"SymmetricalKey.txt", generatedSymmetricalKey);
            }
        }

        private void actionGenerateAsymmetricKeyPair_Click(object sender, EventArgs e)
        {
            if (choseFolderDialogModule.ShowDialog() == DialogResult.OK)
            {
                pathForSaving = choseFolderDialogModule.SelectedPath;
                //A method that generates keypair should be called here
                generatedPrivateKey = "";
                generatedPublicKey = "";
                fileSavingModule.SaveContentInFile(pathForSaving, "PrivateKey.txt", generatedPrivateKey);
                fileSavingModule.SaveContentInFile(pathForSaving, "PublicKey.txt", generatedPublicKey);
            }
        }
    }
}
