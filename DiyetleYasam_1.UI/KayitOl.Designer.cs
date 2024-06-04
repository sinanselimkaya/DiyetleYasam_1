namespace DiyetleYasam_1.UI
{
    partial class KayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            txtEMali = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtCinsiyet = new TextBox();
            txtKilo = new TextBox();
            textBox8 = new TextBox();
            btnKayıtOl = new Button();
            SuspendLayout();
            // 
            // txtEMali
            // 
            txtEMali.BackColor = SystemColors.ButtonFace;
            txtEMali.Location = new Point(374, 35);
            txtEMali.Name = "txtEMali";
            txtEMali.Size = new Size(152, 23);
            txtEMali.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.ButtonFace;
            txtSifre.Location = new Point(374, 88);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(152, 23);
            txtSifre.TabIndex = 0;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.BackColor = SystemColors.ButtonFace;
            txtSifreTekrar.Location = new Point(374, 141);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(152, 23);
            txtSifreTekrar.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.ButtonFace;
            txtAd.Location = new Point(374, 185);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(152, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.ButtonFace;
            txtSoyad.Location = new Point(374, 237);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(152, 23);
            txtSoyad.TabIndex = 0;
            // 
            // txtCinsiyet
            // 
            txtCinsiyet.BackColor = SystemColors.ButtonFace;
            txtCinsiyet.Location = new Point(374, 291);
            txtCinsiyet.Name = "txtCinsiyet";
            txtCinsiyet.Size = new Size(152, 23);
            txtCinsiyet.TabIndex = 0;
            // 
            // txtKilo
            // 
            txtKilo.BackColor = SystemColors.ButtonFace;
            txtKilo.Location = new Point(374, 344);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(152, 23);
            txtKilo.TabIndex = 0;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ButtonFace;
            textBox8.Location = new Point(374, 401);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(152, 23);
            textBox8.TabIndex = 0;
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnKayıtOl.Location = new Point(169, 451);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(357, 47);
            btnKayıtOl.TabIndex = 1;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = true;
            // 
            // KayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(687, 533);
            Controls.Add(btnKayıtOl);
            Controls.Add(textBox8);
            Controls.Add(txtKilo);
            Controls.Add(txtCinsiyet);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtEMali);
            Name = "KayitOl";
            Text = "Kayıt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEMali;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtCinsiyet;
        private TextBox txtKilo;
        private TextBox textBox8;
        private Button btnKayıtOl;
    }
}