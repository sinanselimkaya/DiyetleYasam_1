using DiyetleYasam_1.DAL.Abstract;
using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.DAL.Concrete.EnitityFramewok
{
    public class EfFoodDal : IFoodDal
    {
        DiyetDbContext _Context = new DiyetDbContext();
        public void Add(Food food)
        {
            _Context.Foods.Add(food); 
            _Context.SaveChanges();
        }

        public void Delete(Food food)
        {
            _Context.Foods.Remove(food);
            _Context.SaveChanges();

        }

        public List<Food> GetAll()
        {
            return _Context.Foods.Where(a => a.IsDeleted == false).ToList();
        }

        public Food GetById(int id)
        {
            return _Context.Foods.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
        }

        public void Update(Food food)
        {
            var result = _Context.Foods.FirstOrDefault(x => x.Id == food.Id && x.IsDeleted == false);
            if (result != null)
            {
                result.Name = food.Name;
                result.PortionSize=food.PortionSize;
                result.Unit=food.Unit;
                result.Calories=food.Calories;
                result.IsDeleted = food.IsDeleted;
                _Context.SaveChanges();
            }
        }
    }
}
