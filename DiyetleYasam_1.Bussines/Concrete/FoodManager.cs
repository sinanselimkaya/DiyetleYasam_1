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
    public class FoodManager : IFoodService
    {
        EfFoodDal efFoodDal=new EfFoodDal();
        public void Add(Food food)
        {
            efFoodDal.Add(food);
        }

        public void Delete(Food food)
        {
            efFoodDal.Delete(food);
        }

        public List<Food> GetAll()
        {
           return efFoodDal.GetAll();
        }

        public Food GetById(int id)
        {
          return  efFoodDal.GetById(id);
        }

        public void Update(Food food)
        {
            efFoodDal.Update(food);
        }
    }
}
