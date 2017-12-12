namespace FCrypt
{
    partial class FCryptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.actionGenerateSymmetricKey = new System.Windows.Forms.Button();
            this.actionGenerateAsymmetricKeyPair = new System.Windows.Forms.Button();
            this.actionEncryptSymmetrical = new System.Windows.Forms.Button();
            this.actionEncryptAsymmetrical = new System.Windows.Forms.Button();
            this.actionCalculateFileHash = new System.Windows.Forms.Button();
            this.actionDigitalySign = new System.Windows.Forms.Button();
            this.actionCheckSignature = new System.Windows.Forms.Button();
            this.outputKeyGeneration = new System.Windows.Forms.Label();
            this.outputEncryption = new System.Windows.Forms.Label();
            this.outputDigitalSignature = new System.Windows.Forms.Label();
            this.outputFilePath = new System.Windows.Forms.TextBox();
            this.outputKeyPath = new System.Windows.Forms.TextBox();
            this.actionChoseFileToEncrypt = new System.Windows.Forms.Button();
            this.actionChoseKeyFile = new System.Windows.Forms.Button();
            this.actionDecryptSymmetrical = new System.Windows.Forms.Button();
            this.actionDecryptAsymmetrical = new System.Windows.Forms.Button();
            this.outputHashedValue = new System.Windows.Forms.Label();
            this.actionChoseSignatureFile = new System.Windows.Forms.Button();
            this.outputSignaturePath = new System.Windows.Forms.TextBox();
            this.outputIsVerified = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // actionGenerateSymmetricKey
            // 
            this.actionGenerateSymmetricKey.Location = new System.Drawing.Point(12, 29);
            this.actionGenerateSymmetricKey.Name = "actionGenerateSymmetricKey";
            this.actionGenerateSymmetricKey.Size = new System.Drawing.Size(153, 49);
            this.actionGenerateSymmetricKey.TabIndex = 2;
            this.actionGenerateSymmetricKey.Text = "Generate symmetric key";
            this.actionGenerateSymmetricKey.UseVisualStyleBackColor = true;
            this.actionGenerateSymmetricKey.Click += new System.EventHandler(this.actionGenerateSymmetricKey_Click);
            // 
            // actionGenerateAsymmetricKeyPair
            // 
            this.actionGenerateAsymmetricKeyPair.Location = new System.Drawing.Point(171, 29);
            this.actionGenerateAsymmetricKeyPair.Name = "actionGenerateAsymmetricKeyPair";
            this.actionGenerateAsymmetricKeyPair.Size = new System.Drawing.Size(153, 49);
            this.actionGenerateAsymmetricKeyPair.TabIndex = 3;
            this.actionGenerateAsymmetricKeyPair.Text = "Generate aymmetric key pair";
            this.actionGenerateAsymmetricKeyPair.UseVisualStyleBackColor = true;
            this.actionGenerateAsymmetricKeyPair.Click += new System.EventHandler(this.actionGenerateAsymmetricKeyPair_Click);
            // 
            // actionEncryptSymmetrical
            // 
            this.actionEncryptSymmetrical.Location = new System.Drawing.Point(11, 208);
            this.actionEncryptSymmetrical.Name = "actionEncryptSymmetrical";
            this.actionEncryptSymmetrical.Size = new System.Drawing.Size(153, 49);
            this.actionEncryptSymmetrical.TabIndex = 4;
            this.actionEncryptSymmetrical.Text = "Encrypt symmetrical";
            this.actionEncryptSymmetrical.UseVisualStyleBackColor = true;
            this.actionEncryptSymmetrical.Click += new System.EventHandler(this.actionEncryptSymmetrical_Click);
            // 
            // actionEncryptAsymmetrical
            // 
            this.actionEncryptAsymmetrical.Location = new System.Drawing.Point(176, 208);
            this.actionEncryptAsymmetrical.Name = "actionEncryptAsymmetrical";
            this.actionEncryptAsymmetrical.Size = new System.Drawing.Size(153, 49);
            this.actionEncryptAsymmetrical.TabIndex = 5;
            this.actionEncryptAsymmetrical.Text = "Encrypt asymmetrical";
            this.actionEncryptAsymmetrical.UseVisualStyleBackColor = true;
            this.actionEncryptAsymmetrical.Click += new System.EventHandler(this.actionEncryptAsymmetrical_Click);
            // 
            // actionCalculateFileHash
            // 
            this.actionCalculateFileHash.Location = new System.Drawing.Point(11, 336);
            this.actionCalculateFileHash.Name = "actionCalculateFileHash";
            this.actionCalculateFileHash.Size = new System.Drawing.Size(153, 49);
            this.actionCalculateFileHash.TabIndex = 6;
            this.actionCalculateFileHash.Text = "Calculate file hash";
            this.actionCalculateFileHash.UseVisualStyleBackColor = true;
            this.actionCalculateFileHash.Click += new System.EventHandler(this.actionCalculateFileHash_Click);
            // 
            // actionDigitalySign
            // 
            this.actionDigitalySign.Location = new System.Drawing.Point(176, 336);
            this.actionDigitalySign.Name = "actionDigitalySign";
            this.actionDigitalySign.Size = new System.Drawing.Size(153, 49);
            this.actionDigitalySign.TabIndex = 7;
            this.actionDigitalySign.Text = "Digitaly sign the file";
            this.actionDigitalySign.UseVisualStyleBackColor = true;
            this.actionDigitalySign.Click += new System.EventHandler(this.actionDigitalySign_Click);
            // 
            // actionCheckSignature
            // 
            this.actionCheckSignature.Location = new System.Drawing.Point(11, 476);
            this.actionCheckSignature.Name = "actionCheckSignature";
            this.actionCheckSignature.Size = new System.Drawing.Size(153, 49);
            this.actionCheckSignature.TabIndex = 8;
            this.actionCheckSignature.Text = "Check the signature";
            this.actionCheckSignature.UseVisualStyleBackColor = true;
            this.actionCheckSignature.Click += new System.EventHandler(this.actionCheckSignature_Click);
            // 
            // outputKeyGeneration
            // 
            this.outputKeyGeneration.AutoSize = true;
            this.outputKeyGeneration.Location = new System.Drawing.Point(12, 9);
            this.outputKeyGeneration.Name = "outputKeyGeneration";
            this.outputKeyGeneration.Size = new System.Drawing.Size(104, 17);
            this.outputKeyGeneration.TabIndex = 9;
            this.outputKeyGeneration.Text = "Key generation";
            // 
            // outputEncryption
            // 
            this.outputEncryption.AutoSize = true;
            this.outputEncryption.Location = new System.Drawing.Point(9, 102);
            this.outputEncryption.Name = "outputEncryption";
            this.outputEncryption.Size = new System.Drawing.Size(155, 17);
            this.outputEncryption.TabIndex = 10;
            this.outputEncryption.Text = "Encryption / Decryption";
            // 
            // outputDigitalSignature
            // 
            this.outputDigitalSignature.AutoSize = true;
            this.outputDigitalSignature.Location = new System.Drawing.Point(12, 315);
            this.outputDigitalSignature.Name = "outputDigitalSignature";
            this.outputDigitalSignature.Size = new System.Drawing.Size(117, 17);
            this.outputDigitalSignature.TabIndex = 11;
            this.outputDigitalSignature.Text = "Digital signatures";
            // 
            // outputFilePath
            // 
            this.outputFilePath.Enabled = false;
            this.outputFilePath.Location = new System.Drawing.Point(15, 130);
            this.outputFilePath.Name = "outputFilePath";
            this.outputFilePath.Size = new System.Drawing.Size(241, 22);
            this.outputFilePath.TabIndex = 12;
            // 
            // outputKeyPath
            // 
            this.outputKeyPath.Enabled = false;
            this.outputKeyPath.Location = new System.Drawing.Point(15, 176);
            this.outputKeyPath.Name = "outputKeyPath";
            this.outputKeyPath.Size = new System.Drawing.Size(241, 22);
            this.outputKeyPath.TabIndex = 13;
            // 
            // actionChoseFileToEncrypt
            // 
            this.actionChoseFileToEncrypt.Location = new System.Drawing.Point(262, 126);
            this.actionChoseFileToEncrypt.Name = "actionChoseFileToEncrypt";
            this.actionChoseFileToEncrypt.Size = new System.Drawing.Size(60, 30);
            this.actionChoseFileToEncrypt.TabIndex = 14;
            this.actionChoseFileToEncrypt.Text = "File..";
            this.actionChoseFileToEncrypt.UseVisualStyleBackColor = true;
            this.actionChoseFileToEncrypt.Click += new System.EventHandler(this.actionChoseFileToEncrypt_Click);
            // 
            // actionChoseKeyFile
            // 
            this.actionChoseKeyFile.Location = new System.Drawing.Point(262, 172);
            this.actionChoseKeyFile.Name = "actionChoseKeyFile";
            this.actionChoseKeyFile.Size = new System.Drawing.Size(60, 30);
            this.actionChoseKeyFile.TabIndex = 15;
            this.actionChoseKeyFile.Text = "Key..";
            this.actionChoseKeyFile.UseVisualStyleBackColor = true;
            this.actionChoseKeyFile.Click += new System.EventHandler(this.actionChoseKeyFile_Click);
            // 
            // actionDecryptSymmetrical
            // 
            this.actionDecryptSymmetrical.Location = new System.Drawing.Point(11, 263);
            this.actionDecryptSymmetrical.Name = "actionDecryptSymmetrical";
            this.actionDecryptSymmetrical.Size = new System.Drawing.Size(153, 49);
            this.actionDecryptSymmetrical.TabIndex = 16;
            this.actionDecryptSymmetrical.Text = "Decrypt symmetrical";
            this.actionDecryptSymmetrical.UseVisualStyleBackColor = true;
            this.actionDecryptSymmetrical.Click += new System.EventHandler(this.actionDecryptSymmetrical_Click);
            // 
            // actionDecryptAsymmetrical
            // 
            this.actionDecryptAsymmetrical.Location = new System.Drawing.Point(176, 263);
            this.actionDecryptAsymmetrical.Name = "actionDecryptAsymmetrical";
            this.actionDecryptAsymmetrical.Size = new System.Drawing.Size(153, 49);
            this.actionDecryptAsymmetrical.TabIndex = 17;
            this.actionDecryptAsymmetrical.Text = "Decrypt asymmetrical";
            this.actionDecryptAsymmetrical.UseVisualStyleBackColor = true;
            this.actionDecryptAsymmetrical.Click += new System.EventHandler(this.actionDecryptAsymmetrical_Click);
            // 
            // outputHashedValue
            // 
            this.outputHashedValue.AutoSize = true;
            this.outputHashedValue.Location = new System.Drawing.Point(12, 388);
            this.outputHashedValue.MaximumSize = new System.Drawing.Size(300, 0);
            this.outputHashedValue.Name = "outputHashedValue";
            this.outputHashedValue.Size = new System.Drawing.Size(0, 17);
            this.outputHashedValue.TabIndex = 18;
            // 
            // actionChoseSignatureFile
            // 
            this.actionChoseSignatureFile.Location = new System.Drawing.Point(238, 444);
            this.actionChoseSignatureFile.Name = "actionChoseSignatureFile";
            this.actionChoseSignatureFile.Size = new System.Drawing.Size(91, 30);
            this.actionChoseSignatureFile.TabIndex = 20;
            this.actionChoseSignatureFile.Text = "Signature";
            this.actionChoseSignatureFile.UseVisualStyleBackColor = true;
            this.actionChoseSignatureFile.Click += new System.EventHandler(this.actionChoseSignatureFile_Click);
            // 
            // outputSignaturePath
            // 
            this.outputSignaturePath.Enabled = false;
            this.outputSignaturePath.Location = new System.Drawing.Point(11, 448);
            this.outputSignaturePath.Name = "outputSignaturePath";
            this.outputSignaturePath.Size = new System.Drawing.Size(220, 22);
            this.outputSignaturePath.TabIndex = 21;
            // 
            // outputIsVerified
            // 
            this.outputIsVerified.AutoSize = true;
            this.outputIsVerified.Location = new System.Drawing.Point(188, 492);
            this.outputIsVerified.Name = "outputIsVerified";
            this.outputIsVerified.Size = new System.Drawing.Size(120, 17);
            this.outputIsVerified.TabIndex = 22;
            this.outputIsVerified.Text = "Verification status";
            // 
            // FCryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 542);
            this.Controls.Add(this.outputIsVerified);
            this.Controls.Add(this.outputSignaturePath);
            this.Controls.Add(this.actionChoseSignatureFile);
            this.Controls.Add(this.outputHashedValue);
            this.Controls.Add(this.actionDecryptAsymmetrical);
            this.Controls.Add(this.actionDecryptSymmetrical);
            this.Controls.Add(this.actionChoseKeyFile);
            this.Controls.Add(this.actionChoseFileToEncrypt);
            this.Controls.Add(this.outputKeyPath);
            this.Controls.Add(this.outputFilePath);
            this.Controls.Add(this.outputDigitalSignature);
            this.Controls.Add(this.outputEncryption);
            this.Controls.Add(this.outputKeyGeneration);
            this.Controls.Add(this.actionCheckSignature);
            this.Controls.Add(this.actionDigitalySign);
            this.Controls.Add(this.actionCalculateFileHash);
            this.Controls.Add(this.actionEncryptAsymmetrical);
            this.Controls.Add(this.actionEncryptSymmetrical);
            this.Controls.Add(this.actionGenerateAsymmetricKeyPair);
            this.Controls.Add(this.actionGenerateSymmetricKey);
            this.Name = "FCryptForm";
            this.Text = "FCrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button actionGenerateSymmetricKey;
        private System.Windows.Forms.Button actionGenerateAsymmetricKeyPair;
        private System.Windows.Forms.Button actionEncryptSymmetrical;
        private System.Windows.Forms.Button actionEncryptAsymmetrical;
        private System.Windows.Forms.Button actionCalculateFileHash;
        private System.Windows.Forms.Button actionDigitalySign;
        private System.Windows.Forms.Button actionCheckSignature;
        private System.Windows.Forms.Label outputKeyGeneration;
        private System.Windows.Forms.Label outputEncryption;
        private System.Windows.Forms.Label outputDigitalSignature;
        private System.Windows.Forms.TextBox outputFilePath;
        private System.Windows.Forms.TextBox outputKeyPath;
        private System.Windows.Forms.Button actionChoseFileToEncrypt;
        private System.Windows.Forms.Button actionChoseKeyFile;
        private System.Windows.Forms.Button actionDecryptSymmetrical;
        private System.Windows.Forms.Button actionDecryptAsymmetrical;
        private System.Windows.Forms.Label outputHashedValue;
        private System.Windows.Forms.Button actionChoseSignatureFile;
        private System.Windows.Forms.TextBox outputSignaturePath;
        private System.Windows.Forms.Label outputIsVerified;
    }
}

