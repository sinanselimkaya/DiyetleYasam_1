using DiyetleYasam_1.DAL.Abstract;
using DiyetleYasam_1.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.DAL.Concrete.EnitityFramewok
{
    public class EfDietPlanFoodDAL : IDietPlanFoodDal
    {
        DiyetDbContext _Context = new DiyetDbContext();
        public void Add(DietPlanFood dietPlanFood)
        {
            _Context.DietPlanFoods.Add(dietPlanFood);
            _Context.SaveChanges();
        }

        public void Delete(DietPlanFood dietPlanFood)
        {
            _Context.DietPlanFoods.Remove(dietPlanFood);
            _Context.SaveChanges();
        }

        public List<DietPlanFood> GetAll()
        {
            return _Context.DietPlanFoods.Where(a => a.IsDeleted == false).ToList();
        }

        public DietPlanFood GetById(int id)
        {
            return _Context.DietPlanFoods.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
        }

        public void Update(DietPlanFood dietPlanFood)
        {
            var result = _Context.DietPlanFoods.FirstOrDefault(x => x.Id == dietPlanFood.Id && x.IsDeleted == false);
            if (result != null)
            {
                result.FoodId = dietPlanFood.FoodId;
                result.IsDeleted=dietPlanFood.IsDeleted;
                result.UserId= dietPlanFood.UserId;
                result.MealTimeId= dietPlanFood.MealTimeId;
                _Context.SaveChanges();
            }
        }
    }
}
