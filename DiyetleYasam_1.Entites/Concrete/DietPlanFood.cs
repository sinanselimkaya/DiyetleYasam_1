using DiyetleYasam_1.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetleYasam_1.Entites.Concrete
{
    public class DietPlanFood:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime creatDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int MealTimeId { get; set; }
        public MealTime MealTime { get; set; }
    }
}
