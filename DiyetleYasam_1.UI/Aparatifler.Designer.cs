﻿namespace DiyetleYasam_1.UI
{
    partial class Aparatifler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aparatifler));
            dgvYemek = new DataGridView();
            BtnEkle = new Button();
            btnAra = new Button();
            cbYemek = new ComboBox();
            cbMiktarCesit = new ComboBox();
            txtMikar = new TextBox();
            txtAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvYemek).BeginInit();
            SuspendLayout();
            // 
            // dgvYemek
            // 
            dgvYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemek.Location = new Point(25, 187);
            dgvYemek.Name = "dgvYemek";
            dgvYemek.Size = new Size(705, 110);
            dgvYemek.TabIndex = 12;
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(773, 178);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(102, 119);
            BtnEkle.TabIndex = 11;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            btnAra.BackgroundImage = (Image)resources.GetObject("btnAra.BackgroundImage");
            btnAra.BackgroundImageLayout = ImageLayout.Stretch;
            btnAra.Location = new Point(411, 55);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(21, 23);
            btnAra.TabIndex = 10;
            btnAra.UseVisualStyleBackColor = true;
            // 
            // cbYemek
            // 
            cbYemek.FormattingEnabled = true;
            cbYemek.Location = new Point(237, 109);
            cbYemek.Name = "cbYemek";
            cbYemek.Size = new Size(197, 23);
            cbYemek.TabIndex = 8;
            // 
            // cbMiktarCesit
            // 
            cbMiktarCesit.FormattingEnabled = true;
            cbMiktarCesit.Location = new Point(457, 55);
            cbMiktarCesit.Name = "cbMiktarCesit";
            cbMiktarCesit.Size = new Size(197, 23);
            cbMiktarCesit.TabIndex = 9;
            // 
            // txtMikar
            // 
            txtMikar.Location = new Point(680, 55);
            txtMikar.Name = "txtMikar";
            txtMikar.Size = new Size(195, 23);
            txtMikar.TabIndex = 7;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(237, 55);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(168, 23);
            txtAra.TabIndex = 6;
            // 
            // Aparatifler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(886, 310);
            Controls.Add(dgvYemek);
            Controls.Add(BtnEkle);
            Controls.Add(btnAra);
            Controls.Add(cbYemek);
            Controls.Add(cbMiktarCesit);
            Controls.Add(txtMikar);
            Controls.Add(txtAra);
            Name = "Aparatifler";
            Text = "Aparatifler";
            ((System.ComponentModel.ISupportInitialize)dgvYemek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvYemek;
        private Button BtnEkle;
        private Button btnAra;
        private ComboBox cbYemek;
        private ComboBox cbMiktarCesit;
        private TextBox txtMikar;
        private TextBox txtAra;
    }
}