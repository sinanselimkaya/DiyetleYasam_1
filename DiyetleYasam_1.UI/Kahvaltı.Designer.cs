namespace DiyetleYasam_1.UI
{
    partial class Kahvaltı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kahvaltı));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtAra = new TextBox();
            txtMikar = new TextBox();
            cbMiktarCesit = new ComboBox();
            cbYemek = new ComboBox();
            btnAra = new Button();
            BtnEkle = new Button();
            dgvYemek = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvYemek).BeginInit();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Location = new Point(236, 55);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(168, 23);
            txtAra.TabIndex = 0;
            // 
            // txtMikar
            // 
            txtMikar.Location = new Point(679, 55);
            txtMikar.Name = "txtMikar";
            txtMikar.Size = new Size(195, 23);
            txtMikar.TabIndex = 1;
            // 
            // cbMiktarCesit
            // 
            cbMiktarCesit.FormattingEnabled = true;
            cbMiktarCesit.Location = new Point(456, 55);
            cbMiktarCesit.Name = "cbMiktarCesit";
            cbMiktarCesit.Size = new Size(197, 23);
            cbMiktarCesit.TabIndex = 2;
            // 
            // cbYemek
            // 
            cbYemek.FormattingEnabled = true;
            cbYemek.Location = new Point(236, 109);
            cbYemek.Name = "cbYemek";
            cbYemek.Size = new Size(197, 23);
            cbYemek.TabIndex = 2;
            // 
            // btnAra
            // 
            btnAra.BackgroundImage = (Image)resources.GetObject("btnAra.BackgroundImage");
            btnAra.BackgroundImageLayout = ImageLayout.Stretch;
            btnAra.Location = new Point(410, 55);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(21, 23);
            btnAra.TabIndex = 3;
            btnAra.UseVisualStyleBackColor = true;
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(772, 178);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(102, 119);
            BtnEkle.TabIndex = 4;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvYemek
            // 
            dgvYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemek.Location = new Point(24, 187);
            dgvYemek.Name = "dgvYemek";
            dgvYemek.Size = new Size(705, 110);
            dgvYemek.TabIndex = 5;
            // 
            // Kahvaltı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(886, 309);
            Controls.Add(dgvYemek);
            Controls.Add(BtnEkle);
            Controls.Add(btnAra);
            Controls.Add(cbYemek);
            Controls.Add(cbMiktarCesit);
            Controls.Add(txtMikar);
            Controls.Add(txtAra);
            Name = "Kahvaltı";
            Text = "Kahvaltı";
            ((System.ComponentModel.ISupportInitialize)dgvYemek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtAra;
        private TextBox txtMikar;
        private ComboBox cbMiktarCesit;
        private ComboBox cbYemek;
        private Button btnAra;
        private Button BtnEkle;
        private DataGridView dgvYemek;
    }
}