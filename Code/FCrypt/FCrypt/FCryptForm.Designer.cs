﻿namespace FCrypt
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
            // 
            // actionGenerateAsymmetricKeyPair
            // 
            this.actionGenerateAsymmetricKeyPair.Location = new System.Drawing.Point(171, 29);
            this.actionGenerateAsymmetricKeyPair.Name = "actionGenerateAsymmetricKeyPair";
            this.actionGenerateAsymmetricKeyPair.Size = new System.Drawing.Size(153, 49);
            this.actionGenerateAsymmetricKeyPair.TabIndex = 3;
            this.actionGenerateAsymmetricKeyPair.Text = "Generate aymmetric key pair";
            this.actionGenerateAsymmetricKeyPair.UseVisualStyleBackColor = true;
            this.actionGenerateAsymmetricKeyPair.Click += new System.EventHandler(this.button2_Click);
            // 
            // actionEncryptSymmetrical
            // 
            this.actionEncryptSymmetrical.Location = new System.Drawing.Point(12, 122);
            this.actionEncryptSymmetrical.Name = "actionEncryptSymmetrical";
            this.actionEncryptSymmetrical.Size = new System.Drawing.Size(153, 49);
            this.actionEncryptSymmetrical.TabIndex = 4;
            this.actionEncryptSymmetrical.Text = "Encrypt symmetrical";
            this.actionEncryptSymmetrical.UseVisualStyleBackColor = true;
            // 
            // actionEncryptAsymmetrical
            // 
            this.actionEncryptAsymmetrical.Location = new System.Drawing.Point(171, 122);
            this.actionEncryptAsymmetrical.Name = "actionEncryptAsymmetrical";
            this.actionEncryptAsymmetrical.Size = new System.Drawing.Size(153, 49);
            this.actionEncryptAsymmetrical.TabIndex = 5;
            this.actionEncryptAsymmetrical.Text = "Encrypt asymmetrical";
            this.actionEncryptAsymmetrical.UseVisualStyleBackColor = true;
            // 
            // actionCalculateFileHash
            // 
            this.actionCalculateFileHash.Location = new System.Drawing.Point(12, 273);
            this.actionCalculateFileHash.Name = "actionCalculateFileHash";
            this.actionCalculateFileHash.Size = new System.Drawing.Size(153, 49);
            this.actionCalculateFileHash.TabIndex = 6;
            this.actionCalculateFileHash.Text = "Calculate file hash";
            this.actionCalculateFileHash.UseVisualStyleBackColor = true;
            // 
            // actionDigitalySign
            // 
            this.actionDigitalySign.Location = new System.Drawing.Point(12, 218);
            this.actionDigitalySign.Name = "actionDigitalySign";
            this.actionDigitalySign.Size = new System.Drawing.Size(153, 49);
            this.actionDigitalySign.TabIndex = 7;
            this.actionDigitalySign.Text = "Digitaly sign the file";
            this.actionDigitalySign.UseVisualStyleBackColor = true;
            // 
            // actionCheckSignature
            // 
            this.actionCheckSignature.Location = new System.Drawing.Point(171, 218);
            this.actionCheckSignature.Name = "actionCheckSignature";
            this.actionCheckSignature.Size = new System.Drawing.Size(153, 49);
            this.actionCheckSignature.TabIndex = 8;
            this.actionCheckSignature.Text = "Check the signature";
            this.actionCheckSignature.UseVisualStyleBackColor = true;
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
            this.outputDigitalSignature.Location = new System.Drawing.Point(12, 198);
            this.outputDigitalSignature.Name = "outputDigitalSignature";
            this.outputDigitalSignature.Size = new System.Drawing.Size(117, 17);
            this.outputDigitalSignature.TabIndex = 11;
            this.outputDigitalSignature.Text = "Digital signatures";
            // 
            // FCryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 415);
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
    }
}

