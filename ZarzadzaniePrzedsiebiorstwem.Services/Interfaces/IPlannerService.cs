using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Interfaces {
    public interface IPlannerService {
        public void CreatePlanner(int userId);
        public bool GetPlannerBool(int userId);
        public Planner GetPlanner(int userId);
        public void AddPlanner(Planner planner);
        public void DeletePlanner(Planner planner);
        public Planner GerPlannerByPlannerId(int plannerId);
    }
}
