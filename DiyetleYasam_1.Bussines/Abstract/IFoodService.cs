﻿using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.Bussines.Abstract
{
    public interface IFoodService
    {
        List<Food> GetAll();
        Food GetById(int id);
        void Add(Food food);
        void Update(Food food);
        void Delete(Food food);
    }
}
