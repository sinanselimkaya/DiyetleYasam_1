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
    public interface IUserDal
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
