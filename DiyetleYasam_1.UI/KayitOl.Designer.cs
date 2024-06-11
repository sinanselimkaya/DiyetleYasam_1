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
            txtYas = new TextBox();
            txtKilo = new TextBox();
            btnKayıtOl = new Button();
            pictureBox1 = new PictureBox();
            btnResimEkle = new Button();
            btnBul = new Button();
            llbGirisyap = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // txtYas
            // 
            txtYas.BackColor = SystemColors.ButtonFace;
            txtYas.Location = new Point(374, 344);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(152, 23);
            txtYas.TabIndex = 0;
            // 
            // txtKilo
            // 
            txtKilo.BackColor = SystemColors.ButtonFace;
            txtKilo.Location = new Point(374, 401);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(152, 23);
            txtKilo.TabIndex = 0;
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
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 103);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnResimEkle
            // 
            btnResimEkle.Location = new Point(8, 61);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(26, 23);
            btnResimEkle.TabIndex = 3;
            btnResimEkle.Text = "+";
            btnResimEkle.UseVisualStyleBackColor = true;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // btnBul
            // 
            btnBul.BackgroundImage = (Image)resources.GetObject("btnBul.BackgroundImage");
            btnBul.BackgroundImageLayout = ImageLayout.Center;
            btnBul.Location = new Point(8, 88);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(26, 25);
            btnBul.TabIndex = 3;
            btnBul.UseVisualStyleBackColor = true;
            // 
            // llbGirisyap
            // 
            llbGirisyap.AutoSize = true;
            llbGirisyap.Location = new Point(60, 509);
            llbGirisyap.Name = "llbGirisyap";
            llbGirisyap.Size = new Size(52, 15);
            llbGirisyap.TabIndex = 4;
            llbGirisyap.TabStop = true;
            llbGirisyap.Text = "Giriş Yap";
            llbGirisyap.LinkClicked += llbGirisyap_LinkClicked;
            // 
            // KayitOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(687, 533);
            Controls.Add(llbGirisyap);
            Controls.Add(btnBul);
            Controls.Add(btnResimEkle);
            Controls.Add(pictureBox1);
            Controls.Add(btnKayıtOl);
            Controls.Add(txtKilo);
            Controls.Add(txtYas);
            Controls.Add(txtCinsiyet);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtEMali);
            Name = "KayitOl";
            Text = "Kayıt Ol";
            Load += KayitOl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtYas;
        private TextBox txtKilo;
        private Button btnKayıtOl;
        private PictureBox pictureBox1;
        private Button btnResimEkle;
        private Button btnBul;
        private LinkLabel llbGirisyap;
    }
}