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
    public class DietPlanFoodManager : IDietPlanFoodService
    {
        EfDietPlanFoodDAL efDietPlanFoodDAL { get; set; }
        public void Add(DietPlanFood dietPlanFood)
        {
            efDietPlanFoodDAL.Add(dietPlanFood);
        }

        public void Delete(DietPlanFood dietPlanFood)
        {efDietPlanFoodDAL.Delete(dietPlanFood);
        }

        public List<DietPlanFood> GetAll()
        {return efDietPlanFoodDAL.GetAll();
        }

        public DietPlanFood GetById(int id)
        {
            return efDietPlanFoodDAL.GetById(id);
        }

        public void Update(DietPlanFood dietPlanFood)
        {
            efDietPlanFoodDAL.Update(dietPlanFood);
        }
    }
}
