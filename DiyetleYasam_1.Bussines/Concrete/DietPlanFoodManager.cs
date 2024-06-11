using DiyetleYasam_1.Bussines.Abstract;
using DiyetleYasam_1.DAL.Concrete.EnitityFramewok;
using DiyetleYasam_1.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.Bussines.Concrete
{
    public class DietPlanFoodManager : IDietPlanFoodService
    {
        EfDietPlanFoodDAL efDietPlanFoodDAL { get; set; }
        public List<DietPlanFood> QueryAll(Expression<Func<DietPlanFood, bool>> constraint)
        {
            return   efDietPlanFoodDAL.QueryAll(constraint);
        }
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
