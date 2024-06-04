﻿using DiyetleYasam_1.DAL.Abstract;
using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.DAL.Concrete.EnitityFramewok
{
    public class EfUserDal : IUserDal
    {
        DiyetDbContext _Context =new DiyetDbContext();
        public void Add(User user)
        {
            _Context.Users.Add(user);
            _Context.SaveChanges();
        }

        public void Delete(User user)
        {
            _Context.Users.Remove(user);
            _Context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _Context.Users.Where(a=>a.IsDeleted==false). ToList();
        }

        public User GetById(int id)
        {
            return 
                _Context.Users.FirstOrDefault(x => x.Id == id&&x.IsDeleted==false);
        }

        public void Update(User user)
        {
           var result= _Context.Users.FirstOrDefault(x => x.Id == user.Id && x.IsDeleted == false);
            if (result!=null) 
            { 
                result.Age=user.Age;
                result.Name=user.Name;
                result.Email=user.Email;
                result.Weight=user.Weight;
                result.Gender=user.Gender;
                _Context.SaveChanges();
            }

        }
    }
}
