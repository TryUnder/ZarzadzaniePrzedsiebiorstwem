using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner {
    public class Subtask {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public virtual Planner Planner { get; set; }

        [ForeignKey("ParentTaskId")] // jawnie określam FK pomimo fluent api
        public int PlannerId { get; set; }
    }
}
