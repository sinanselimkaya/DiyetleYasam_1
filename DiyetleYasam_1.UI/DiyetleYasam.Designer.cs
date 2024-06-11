namespace DiyetleYasam_1.UI
{
    partial class DiyetleYasam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetleYasam));
            txtEMail = new TextBox();
            txtSifre = new TextBox();
            linklblKayıt = new LinkLabel();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // txtEMail
            // 
            txtEMail.BackColor = SystemColors.HotTrack;
            txtEMail.Location = new Point(212, 335);
            txtEMail.Name = "txtEMail";
            txtEMail.Size = new Size(150, 23);
            txtEMail.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.HotTrack;
            txtSifre.Location = new Point(212, 387);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(150, 23);
            txtSifre.TabIndex = 0;
            // 
            // linklblKayıt
            // 
            linklblKayıt.AutoSize = true;
            linklblKayıt.Location = new Point(259, 444);
            linklblKayıt.Name = "linklblKayıt";
            linklblKayıt.Size = new Size(46, 15);
            linklblKayıt.TabIndex = 1;
            linklblKayıt.TabStop = true;
            linklblKayıt.Text = "Kayıt ol";
            linklblKayıt.LinkClicked += linklblKayıt_LinkClicked;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGirisYap.Location = new Point(200, 415);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(173, 25);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // DiyetleYasam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(596, 468);
            Controls.Add(btnGirisYap);
            Controls.Add(linklblKayıt);
            Controls.Add(txtSifre);
            Controls.Add(txtEMail);
            Name = "DiyetleYasam";
            Text = "Diyetle Yaşam";
            Load += DiyetleYasam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEMail;
        private TextBox txtSifre;
        private LinkLabel linklblKayıt;
        private Button btnGirisYap;
    }
}