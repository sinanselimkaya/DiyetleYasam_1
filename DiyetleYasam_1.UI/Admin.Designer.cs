namespace DiyetleYasam_1.UI
{
    partial class Admin
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
            groupBox1 = new GroupBox();
            dgvYemek = new DataGridView();
            btnSil = new Button();
            btnGuncele = new Button();
            btnEkle = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCalori = new TextBox();
            txtTur = new TextBox();
            txtYemek = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYemek).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvYemek);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncele);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCalori);
            groupBox1.Controls.Add(txtTur);
            groupBox1.Controls.Add(txtYemek);
            groupBox1.Location = new Point(4, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dgvYemek
            // 
            dgvYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemek.Location = new Point(24, 130);
            dgvYemek.Name = "dgvYemek";
            dgvYemek.Size = new Size(563, 118);
            dgvYemek.TabIndex = 3;
            dgvYemek.CellClick += dgvYemek_CellClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(396, 101);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(191, 23);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncele
            // 
            btnGuncele.Location = new Point(205, 101);
            btnGuncele.Name = "btnGuncele";
            btnGuncele.Size = new Size(191, 23);
            btnGuncele.TabIndex = 2;
            btnGuncele.Text = "Güncele";
            btnGuncele.UseVisualStyleBackColor = true;
            btnGuncele.Click += btnGuncele_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(24, 101);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(181, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 39);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "Calori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 39);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Türü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Yemek";
            // 
            // txtCalori
            // 
            txtCalori.Location = new Point(396, 57);
            txtCalori.Name = "txtCalori";
            txtCalori.Size = new Size(177, 23);
            txtCalori.TabIndex = 0;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(219, 57);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(177, 23);
            txtTur.TabIndex = 0;
            // 
            // txtYemek
            // 
            txtYemek.Location = new Point(42, 57);
            txtYemek.Name = "txtYemek";
            txtYemek.Size = new Size(177, 23);
            txtYemek.TabIndex = 0;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 272);
            Controls.Add(groupBox1);
            Name = "Admin";
            Text = "Admin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvYemek).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCalori;
        private TextBox txtTur;
        private TextBox txtYemek;
        private Button btnSil;
        private Button btnGuncele;
        private Button btnEkle;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvYemek;
    }
}