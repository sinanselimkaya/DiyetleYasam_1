using DiyetleYasam_1.Bussines.Concrete;
using DiyetleYasam_1.DAL.Concrete.EnitityFramewok;
using DiyetleYasam_1.Entites.Concrete;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace DiyetleYasam_1.UI
{
    public partial class KayitOl : Form
    {
        private readonly User _user;
        UserManager UserManager = new UserManager();
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        public KayitOl(User user)
        {
            InitializeComponent();
            user = _user;
        }



        private void BosKontrol(object value)
        {
            if (value == null)
            {
                MessageBox.Show("Boş yer bırakılmaz");
                return;
            }

            if (value is string text && string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Boş yer bırakılmaz");
                return;
            }

            if (value is int intValue && intValue == 0)
            {
                MessageBox.Show("Boş yer bırakılmaz veya sıfır değeri kabul edilmez");
                return;
            }

            if (value is double doublelValue && doublelValue == 0)
            {
                MessageBox.Show("Boş yer bırakılmaz veya sıfır değeri kabul edilmez");
                return;
            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            string email = txtEMali.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string cinsiyet = txtCinsiyet.Text;
            int yas = Convert.ToInt32(txtYas.Text);
            double kilo = Convert.ToDouble(txtKilo.Text);
            string sifre = sha256_hash(txtSifre.Text);
            string SifreTekrar = sha256_hash(txtSifreTekrar.Text);

            BosKontrol(email);
            BosKontrol(ad);
            BosKontrol(soyad);
            BosKontrol(cinsiyet);
            BosKontrol(sifre);
            BosKontrol(SifreTekrar);
            BosKontrol(yas);
            BosKontrol(kilo);
            if (sifre != SifreTekrar)
            {
                MessageBox.Show("Şifreler Aynı Değil");
                return;

            }
            var kulanıcıVarmı = UserManager.QueryAllSingel(x => x.Email == email);
            if (kulanıcıVarmı != null)
            {
                MessageBox.Show("Bu maile daha önce kayıt oluşturulmuştur");
                return;
            }

            User user = new User();
            user.Name = ad + " " + soyad;
            user.Email = email;
            user.Age = yas;
            user.Gender = cinsiyet;
            user.Password = sifre;
            user.Weight = kilo;
            UserManager.Add(user);
            MessageBox.Show("Başarı ile kayıt edildi");


        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {


        }

        private void llbGirisyap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DiyetleYasam diyetleYasam = new DiyetleYasam(_user);
            diyetleYasam.Show();
            this.Hide();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }
    }
}
