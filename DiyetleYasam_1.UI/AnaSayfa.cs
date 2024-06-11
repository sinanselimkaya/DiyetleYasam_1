using DiyetleYasam_1.Bussines.Concrete;
using DiyetleYasam_1.DAL.Concrete.EnitityFramewok;
using DiyetleYasam_1.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetleYasam_1.UI
{

    public partial class AnaSayfa : Form
    {

        private readonly User _user;
        FoodManager food = new FoodManager();
        MealTimeManager mealTime = new MealTimeManager();
        DietPlanFoodManager dietPlanFoodManager = new DietPlanFoodManager();
        int id;


        public AnaSayfa(User user)
        {
            InitializeComponent();

            this._user = user;


            dgvGunluk.DataSource = dietPlanFoodManager.QueryAll(x => x.UserId == _user.Id && x.CreatedDate == DateTime.Today);
            dgvGunluk.Columns[0].Visible = false;
            cbOgun.DataSource = mealTime.GetAll();
            cbOgun.DisplayMember = "Name";
            cbOgun.ValueMember = "Id";
            cbYemek.DataSource = food.GetAll();
            cbYemek.DisplayMember = "Name";
            cbYemek.ValueMember = "Id";
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMiktar.Text != " ")
            {
                DietPlanFood plan = new DietPlanFood();
                plan.PortionSize = Convert.ToDouble(txtMiktar.Text);
                plan.CreatedDate = dtpTarih.Value;
                plan.FoodId = Int32.Parse(cbYemek.SelectedValue.ToString());
                plan.MealTimeId = Int32.Parse(cbYemek.SelectedValue.ToString());
                plan.UserId = _user.Id;
                dgvGunluk.DataSource = dietPlanFoodManager.QueryAll(x => x.UserId == _user.Id && x.CreatedDate == DateTime.Today);
                txtMiktar.Text = " ";
            }


        }

        private void btnGüncele_Click(object sender, EventArgs e)
        {
            DietPlanFood dietPlanFood = dietPlanFoodManager.GetById(id);
            dietPlanFood.PortionSize = Convert.ToDouble(txtMiktar.Text);
            dietPlanFood.CreatedDate = dtpTarih.Value;
            dietPlanFood.FoodId = Int32.Parse(cbYemek.SelectedValue.ToString());
            dietPlanFood.MealTimeId = Int32.Parse(cbYemek.SelectedValue.ToString());
            dietPlanFood.UserId = _user.Id;
            dietPlanFoodManager.Update(dietPlanFood);
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
            txtMiktar.Text = " ";
            dgvGunluk.DataSource = dietPlanFoodManager.QueryAll(x => x.UserId == _user.Id && x.CreatedDate == DateTime.Today);
        }

        private void dgvGunluk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGunluk.Rows[e.RowIndex];
                id = Int32.Parse(row.Cells[0].Value.ToString());
                btnEkle.Enabled = true;
                btnSil.Enabled = true;


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DietPlanFood dietPlanFood = dietPlanFoodManager.GetById(id);
            dietPlanFoodManager.Delete(dietPlanFood);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {

            Profilim profilim = new Profilim(_user);
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
