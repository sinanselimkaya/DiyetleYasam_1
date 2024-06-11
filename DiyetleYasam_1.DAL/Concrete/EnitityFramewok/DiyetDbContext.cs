using DiyetleYasam_1.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.DAL.Concrete.EnitityFramewok
{
    public class DiyetDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<MealTime> MealTimes { get; set; }
        public DbSet<DietPlanFood> DietPlanFoods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-178FDDJ;database=Diyetdb;uid=sa;pwd=sa;trustservercertificate=true");
        }
    }
}
