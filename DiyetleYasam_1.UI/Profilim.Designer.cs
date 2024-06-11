namespace DiyetleYasam_1.UI
{
    partial class Profilim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profilim));
            btnGuncele = new Button();
            txtKilo = new TextBox();
            txtYas = new TextBox();
            txtCinsiyet = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtSifreTekrar = new TextBox();
            txtSifre = new TextBox();
            txtEMali = new TextBox();
            btnSil = new Button();
            SuspendLayout();
            // 
            // btnGuncele
            // 
            btnGuncele.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnGuncele.Location = new Point(170, 451);
            btnGuncele.Name = "btnGuncele";
            btnGuncele.Size = new Size(357, 47);
            btnGuncele.TabIndex = 10;
            btnGuncele.Text = "Güncele";
            btnGuncele.UseVisualStyleBackColor = true;
            btnGuncele.Click += btnGuncele_Click;
            // 
            // txtKilo
            // 
            txtKilo.BackColor = SystemColors.ButtonFace;
            txtKilo.Location = new Point(375, 401);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(152, 23);
            txtKilo.TabIndex = 2;
            // 
            // txtYas
            // 
            txtYas.BackColor = SystemColors.ButtonFace;
            txtYas.Location = new Point(375, 344);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(152, 23);
            txtYas.TabIndex = 3;
            // 
            // txtCinsiyet
            // 
            txtCinsiyet.BackColor = SystemColors.ButtonFace;
            txtCinsiyet.Location = new Point(375, 291);
            txtCinsiyet.Name = "txtCinsiyet";
            txtCinsiyet.Size = new Size(152, 23);
            txtCinsiyet.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.ButtonFace;
            txtSoyad.Location = new Point(375, 237);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(152, 23);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.ButtonFace;
            txtAd.Location = new Point(375, 185);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(152, 23);
            txtAd.TabIndex = 6;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.BackColor = SystemColors.ButtonFace;
            txtSifreTekrar.Location = new Point(375, 141);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(152, 23);
            txtSifreTekrar.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.ButtonFace;
            txtSifre.Location = new Point(375, 88);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(152, 23);
            txtSifre.TabIndex = 8;
            // 
            // txtEMali
            // 
            txtEMali.BackColor = SystemColors.ButtonFace;
            txtEMali.Location = new Point(375, 36);
            txtEMali.Name = "txtEMali";
            txtEMali.Size = new Size(152, 23);
            txtEMali.TabIndex = 9;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(0, -1);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(59, 23);
            btnSil.TabIndex = 11;
            btnSil.Text = "btnSil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // Profilim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(699, 532);
            Controls.Add(btnSil);
            Controls.Add(btnGuncele);
            Controls.Add(txtKilo);
            Controls.Add(txtYas);
            Controls.Add(txtCinsiyet);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtEMali);
            Name = "Profilim";
            Text = "Profilim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncele;
        private TextBox txtKilo;
        private TextBox txtYas;
        private TextBox txtCinsiyet;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtSifreTekrar;
        private TextBox txtSifre;
        private TextBox txtEMali;
        private Button btnSil;
    }
}