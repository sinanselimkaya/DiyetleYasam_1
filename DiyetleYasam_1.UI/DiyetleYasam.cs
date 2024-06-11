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

namespace DiyetleYasam_1.UI
{
    public partial class DiyetleYasam : Form
    {
        User User=new User();
        UserManager userManager = new UserManager();



        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        public DiyetleYasam(User _user)
        {
            InitializeComponent();
            _user=User;
        }

       

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string email=txtEMail.Text;
            string sifre= sha256_hash(txtSifre.Text);
            if(string.IsNullOrEmpty(email) ||string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kulanıcı adı ve şifreyi giriniz");
                return;

            }
            var user = userManager.QueryAllSingel(x => x.Email == email && x.Password == sifre);
            if (txtEMail.Text=="ADMİN" && txtSifre.Text=="1234")
            {
                Admin admin = new Admin(User);
                admin.Show();
                this.Hide();
                return;
            }
            if(user!= null) 
            {
               AnaSayfa anaSayfa=new AnaSayfa(user);
                anaSayfa.Show();
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Kulanıcı adı ve şifre hatalı");
            }

        }

        private void DiyetleYasam_Load(object sender, EventArgs e)
        {

        }

        private void linklblKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayitOl = new KayitOl(User);
            kayitOl.Show();
            this.Hide();

                
        }
    }
}
