using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;
using ZarzadzaniePrzedsiebiorstwem.ViewModels.ViewModels;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public class PlannerService : BaseService, IPlannerService {
        
        public PlannerService(MyDbContext dbContext, IUserService userService) : base(dbContext) { }
            
        public bool GetPlannerBool(int userId) {
            var planner = _dbContext.Planner.Where(x => x.UserId == userId).FirstOrDefault();
            
            if (planner == null) {
                return false;
            }

            return true;
        }

        public void CreatePlanner(int userId) {
            var plannerExists = GetPlannerBool(userId);

            if (plannerExists == true) {
                return;
            }

            var planner = new Planner() {
                UserId = userId
            };
            // write a code that will add planner to the user's collection in the database
           
            var user = _dbContext.User.Where(x => x.Id == userId).FirstOrDefault();
            user.Planners.Add(planner);

            _dbContext.SaveChanges();
        }

        public Planner GetPlanner(int userId) {
            var planner = _dbContext.Planner.Where(x => x.UserId == userId).FirstOrDefault();
            return planner;
        }

    }
}
