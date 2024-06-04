﻿using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.DAL.Abstract
{
    public interface IDietPlanFoodDal
    {
        List<DietPlanFood> GetAll();
        DietPlanFood GetById(int id);
        void Add(DietPlanFood dietPlanFood);
        void Update(DietPlanFood dietPlanFood);
        void Delete(DietPlanFood dietPlanFood);
    }
}
