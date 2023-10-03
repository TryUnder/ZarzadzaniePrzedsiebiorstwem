using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner {
    public class Tag {
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public virtual ICollection<Planner>? Tasks { get; set; } = new List<Planner>();

        public virtual Planner Planner { get; set; }
        public int PlannerId { get; set; }
    }
}
