using DiyetleYasam_1.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.DAL.Abstract
{
    public interface IDietPlanFoodDal
    {
        List<DietPlanFood> QueryAll(Expression<Func<DietPlanFood, bool>> constraint);
       
        List<DietPlanFood> GetAll();
        DietPlanFood GetById(int id);
        void Add(DietPlanFood dietPlanFood);
        void Update(DietPlanFood dietPlanFood);
        void Delete(DietPlanFood dietPlanFood);
    }
}
