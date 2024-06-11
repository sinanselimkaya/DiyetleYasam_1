using DiyetleYasam_1.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.Bussines.Abstract
{
    internal interface IUserService
    {
        public List<User> QueryAll(Expression<Func<User, bool>> constraint);

        public User QueryAllSingel(Expression<Func<User, bool>> constraint);
        List<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
