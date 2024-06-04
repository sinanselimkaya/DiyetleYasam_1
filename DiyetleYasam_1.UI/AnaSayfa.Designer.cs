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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            dateTimePicker1 = new DateTimePicker();
            btnKahvaltı = new Button();
            btnOgle = new Button();
            btnAksam = new Button();
            btnApartif = new Button();
            DgvKahvaltı = new DataGridView();
            DGVOgle = new DataGridView();
            DGVAksam = new DataGridView();
            DGVApartif = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvKahvaltı).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVOgle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVAksam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVApartif).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption;
            dateTimePicker1.Location = new Point(2, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnKahvaltı
            // 
            btnKahvaltı.BackColor = SystemColors.ControlLightLight;
            btnKahvaltı.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnKahvaltı.Location = new Point(287, 101);
            btnKahvaltı.Name = "btnKahvaltı";
            btnKahvaltı.Size = new Size(213, 34);
            btnKahvaltı.TabIndex = 1;
            btnKahvaltı.Text = "Kahvaltı";
            btnKahvaltı.UseVisualStyleBackColor = false;
            // 
            // btnOgle
            // 
            btnOgle.BackColor = SystemColors.ControlLightLight;
            btnOgle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnOgle.Location = new Point(287, 143);
            btnOgle.Name = "btnOgle";
            btnOgle.Size = new Size(213, 31);
            btnOgle.TabIndex = 1;
            btnOgle.Text = "Öğlen Yemeği";
            btnOgle.UseVisualStyleBackColor = false;
            // 
            // btnAksam
            // 
            btnAksam.BackColor = SystemColors.ControlLightLight;
            btnAksam.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnAksam.Location = new Point(287, 182);
            btnAksam.Name = "btnAksam";
            btnAksam.Size = new Size(213, 33);
            btnAksam.TabIndex = 1;
            btnAksam.Text = "Aksam Yemeği";
            btnAksam.UseVisualStyleBackColor = false;
            // 
            // btnApartif
            // 
            btnApartif.BackColor = SystemColors.ControlLightLight;
            btnApartif.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnApartif.Location = new Point(287, 221);
            btnApartif.Name = "btnApartif";
            btnApartif.Size = new Size(213, 30);
            btnApartif.TabIndex = 1;
            btnApartif.Text = "Aparatifler";
            btnApartif.UseVisualStyleBackColor = false;
            // 
            // DgvKahvaltı
            // 
            DgvKahvaltı.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvKahvaltı.Location = new Point(12, 12);
            DgvKahvaltı.Name = "DgvKahvaltı";
            DgvKahvaltı.Size = new Size(115, 69);
            DgvKahvaltı.TabIndex = 2;
            // 
            // DGVOgle
            // 
            DGVOgle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVOgle.Location = new Point(133, 12);
            DGVOgle.Name = "DGVOgle";
            DGVOgle.Size = new Size(115, 69);
            DGVOgle.TabIndex = 2;
            // 
            // DGVAksam
            // 
            DGVAksam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAksam.Location = new Point(254, 12);
            DGVAksam.Name = "DGVAksam";
            DGVAksam.Size = new Size(115, 69);
            DGVAksam.TabIndex = 2;
            // 
            // DGVApartif
            // 
            DGVApartif.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVApartif.Location = new Point(375, 12);
            DGVApartif.Name = "DGVApartif";
            DGVApartif.Size = new Size(115, 69);
            DGVApartif.TabIndex = 2;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 253);
            Controls.Add(DGVApartif);
            Controls.Add(DGVAksam);
            Controls.Add(DGVOgle);
            Controls.Add(DgvKahvaltı);
            Controls.Add(btnApartif);
            Controls.Add(btnAksam);
            Controls.Add(btnOgle);
            Controls.Add(btnKahvaltı);
            Controls.Add(dateTimePicker1);
            Name = "AnaSayfa";
            Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)DgvKahvaltı).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVOgle).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVAksam).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVApartif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnKahvaltı;
        private Button btnOgle;
        private Button btnAksam;
        private Button btnApartif;
        private DataGridView DgvKahvaltı;
        private DataGridView DGVOgle;
        private DataGridView DGVAksam;
        private DataGridView DGVApartif;
    }
}