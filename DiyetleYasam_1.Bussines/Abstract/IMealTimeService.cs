using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.Bussines.Abstract
{
    public interface IMealTimeService
    {
        List<MealTime> GetAll();
        MealTime GetById(int id);
        void Add(MealTime mealTime);
        void Update(MealTime mealTime);
        void Delete(MealTime mealTime
    }
}
