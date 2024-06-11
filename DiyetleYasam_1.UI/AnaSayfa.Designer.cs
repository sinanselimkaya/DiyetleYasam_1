namespace DiyetleYasam_1.UI
{
    partial class AnaSayfa
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
            dtpTarih = new DateTimePicker();
            dgvGunluk = new DataGridView();
            cbOgun = new ComboBox();
            txtMiktar = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGüncele = new Button();
            cbYemek = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnProfil = new Button();
            lbluruncesit = new Label();
            lblcalori = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGunluk).BeginInit();
            SuspendLayout();
            // 
            // dtpTarih
            // 
            dtpTarih.CalendarMonthBackground = SystemColors.InactiveCaption;
            dtpTarih.Location = new Point(12, 208);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(173, 23);
            dtpTarih.TabIndex = 0;
            // 
            // dgvGunluk
            // 
            dgvGunluk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGunluk.Location = new Point(9, 41);
            dgvGunluk.Name = "dgvGunluk";
            dgvGunluk.Size = new Size(562, 108);
            dgvGunluk.TabIndex = 2;
            dgvGunluk.CellClick += dgvGunluk_CellClick;
            // 
            // cbOgun
            // 
            cbOgun.FormattingEnabled = true;
            cbOgun.Location = new Point(192, 208);
            cbOgun.Name = "cbOgun";
            cbOgun.Size = new Size(121, 23);
            cbOgun.TabIndex = 3;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(455, 208);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(121, 23);
            txtMiktar.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 248);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(173, 51);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(390, 248);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(169, 51);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncele
            // 
            btnGüncele.Location = new Point(208, 248);
            btnGüncele.Name = "btnGüncele";
            btnGüncele.Size = new Size(162, 51);
            btnGüncele.TabIndex = 6;
            btnGüncele.Text = "Güncele";
            btnGüncele.UseVisualStyleBackColor = true;
            btnGüncele.Click += btnGüncele_Click;
            // 
            // cbYemek
            // 
            cbYemek.FormattingEnabled = true;
            cbYemek.Location = new Point(318, 170);
            cbYemek.Name = "cbYemek";
            cbYemek.Size = new Size(121, 23);
            cbYemek.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 190);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "Tarih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 190);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Öğün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 152);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Yemek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 190);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Miktar";
            // 
            // btnProfil
            // 
            btnProfil.Location = new Point(12, 12);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(75, 23);
            btnProfil.TabIndex = 8;
            btnProfil.Text = "Profilim";
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // lbluruncesit
            // 
            lbluruncesit.AutoSize = true;
            lbluruncesit.BackColor = SystemColors.AppWorkspace;
            lbluruncesit.Location = new Point(320, 196);
            lbluruncesit.Name = "lbluruncesit";
            lbluruncesit.Size = new Size(13, 15);
            lbluruncesit.TabIndex = 9;
            lbluruncesit.Text = "a";
            // 
            // lblcalori
            // 
            lblcalori.AutoSize = true;
            lblcalori.BackColor = SystemColors.AppWorkspace;
            lblcalori.Location = new Point(320, 214);
            lblcalori.Name = "lblcalori";
            lblcalori.Size = new Size(13, 15);
            lblcalori.TabIndex = 9;
            lblcalori.Text = "a";
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 339);
            Controls.Add(lblcalori);
            Controls.Add(lbluruncesit);
            Controls.Add(btnProfil);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGüncele);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtMiktar);
            Controls.Add(cbYemek);
            Controls.Add(cbOgun);
            Controls.Add(dgvGunluk);
            Controls.Add(dtpTarih);
            Name = "AnaSayfa";
            Text = "Ana Sayfa";
            Load += AnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGunluk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpTarih;
        private DataGridView dgvGunluk;
        private ComboBox cbOgun;
        private TextBox txtMiktar;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGüncele;
        private ComboBox cbYemek;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnProfil;
        private Label lbluruncesit;
        private Label lblcalori;
    }
}