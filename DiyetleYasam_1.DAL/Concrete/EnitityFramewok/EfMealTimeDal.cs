using DiyetleYasam_1.DAL.Abstract;
using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.DAL.Concrete.EnitityFramewok
{
    public class EfMealTimeDal : IMealTimeDal1
    {
        DiyetDbContext _Context = new DiyetDbContext();

        public void Add(MealTime mealTime)
        {
            _Context.MealTimes.Add(mealTime);
            _Context.SaveChanges();
        }

        public void Delete(MealTime mealTime)
        {
            _Context.MealTimes.Remove(mealTime);
            _Context.SaveChanges();
        }

        public List<MealTime> GetAll()
        {
            return _Context.MealTimes.Where(a => a.IsDeleted == false).ToList();
        }

        public MealTime GetById(int id)
        {
            return _Context.MealTimes.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);
        }

        public void Update(MealTime mealTime)
        {
            var result = _Context.MealTimes.FirstOrDefault(x => x.Id == mealTime.Id && x.IsDeleted == false);
            if (result != null)
            {
                result.Name = mealTime.Name;
                _Context.SaveChanges();
            }
        }
    }
}
