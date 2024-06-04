using DiyetleYasam_1.Bussines.Abstract;
using DiyetleYasam_1.DAL.Concrete.EnitityFramewok;
using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.Bussines.Concrete
{
    public class MealTimeManager : IMealTimeService
    {
        EfMealTimeDal EfMealTimeDal=new EfMealTimeDal();
           
        public void Add(MealTime mealTime)
        {
         EfMealTimeDal.Add(mealTime);
        }

        public void Delete(MealTime mealTime)
        {
            EfMealTimeDal.Delete(mealTime);
        }

        public List<MealTime> GetAll()
        {
            return EfMealTimeDal.GetAll(); 
        }

        public MealTime GetById(int id)
        {
            return EfMealTimeDal.GetById(id);
        }

        public void Update(MealTime mealTime)
        {
             EfMealTimeDal.Update(mealTime);
        }
    }
}
