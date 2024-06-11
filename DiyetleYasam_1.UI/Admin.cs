using DiyetleYasam_1.Bussines.Concrete;
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

namespace DiyetleYasam_1.UI
{
    public partial class Admin : Form
    {
        private readonly User _user;

        FoodManager foodManager = new FoodManager();
        public Admin(User user)
        {
            InitializeComponent();
            this._user=user;
            dgvYemek.DataSource = foodManager.GetAll();
            dgvYemek.Columns[0].Visible = false;
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
        }
        int id;


        private void dgvYemek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvYemek.Rows[e.RowIndex];
                id = Int32.Parse(row.Cells[0].Value.ToString());
                btnEkle.Enabled = true;
                btnSil.Enabled = true;
                btnEkle.Enabled = true;
                btnSil.Enabled = true;

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtYemek.Text != " " && txtTur.Text != " " && txtCalori.Text != " ")
            {
                Food food = new Food();
                food.Unit = txtTur.Text;
                food.Name = txtYemek.Text;
                food.Calories = Convert.ToDouble(txtCalori.Text);
                foodManager.Add(food);
                dgvYemek.DataSource = foodManager.GetAll();

            }
        }

        private void btnGuncele_Click(object sender, EventArgs e)
        {
            Food food = foodManager.GetById(id);
            food.Unit = txtTur.Text;
            food.Name = txtYemek.Text;
            food.Calories = Convert.ToDouble(txtCalori.Text);
            foodManager.Update(food);
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
            txtCalori.Text = " ";
            txtTur.Text = " ";
            txtYemek.Text = " ";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Food food = foodManager.GetById(id);
            foodManager.Delete(food);
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
          
        }
    }
}
