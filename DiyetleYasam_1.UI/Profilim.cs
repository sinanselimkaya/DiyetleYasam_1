using DiyetleYasam_1.DAL.Concrete.EnitityFramewok;
using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace DiyetleYasam_1.UI
{
    public partial class Profilim : Form
    {
        private readonly User _user;
        private User user;

        public Profilim(DiyetDbContext context, User user)
        {
            InitializeComponent();
            
            this._user = user;


             txtEMali.Text=user.Email;
             txtAd.Text=user.Name;
             txtSoyad.Text=user.Name;
             txtCinsiyet.Text=user.Gender;
             txtYas.Text=Convert.ToString(user.Age);
             txtKilo.Text=Convert.ToString(user.Weight);
             


        }

        public Profilim(User user)
        {
            this.user = user;
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


        private void btnGuncele_Click(object sender, EventArgs e)
        {
            string email = txtEMali.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string cinsiyet = txtCinsiyet.Text;
            int yas = Convert.ToInt32(txtYas.Text);
            decimal kilo = Convert.ToDecimal(txtKilo.Text);
            string sifre = sha256_hash(txtSifre.Text);
            string SifreTekrar = sha256_hash(txtSifreTekrar.Text);

            
        }
    }
}
