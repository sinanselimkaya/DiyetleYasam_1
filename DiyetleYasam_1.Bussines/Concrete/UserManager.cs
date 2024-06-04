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
    internal class UserManager : IUserService
    {
        EfUserDal _userDal =new EfUserDal();

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
           return _userDal.GetAll();
        }

        public User GetById(int id)
        {
          return  _userDal.GetById(id);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
