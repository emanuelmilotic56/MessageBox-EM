﻿namespace MessageBox_EM
{
    partial class Form1
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
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(451, 177);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(156, 88);
            this.textBoxRezultat.TabIndex = 0;
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(451, 85);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(156, 46);
            this.buttonOtvori.TabIndex = 1;
            this.buttonOtvori.Text = "Otvorite MessageBox";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            this.buttonOtvori.Click += new System.EventHandler(this.buttonOtvori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOtvori);
            this.Controls.Add(this.textBoxRezultat);
            this.Name = "Form1";
            this.Text = "UpotrebaDialogResult enumeracije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.Button buttonOtvori;
    }
}

