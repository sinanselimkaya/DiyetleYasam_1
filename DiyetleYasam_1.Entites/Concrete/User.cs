using DiyetleYasam_1.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.Entites.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Photo{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<DietPlanFood> DietPlanFood { get; set; }
    }
}
