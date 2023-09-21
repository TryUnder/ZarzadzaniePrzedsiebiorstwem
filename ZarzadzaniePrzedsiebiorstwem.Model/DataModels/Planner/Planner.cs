using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner {
    public class Planner {
        public int Id { get; set; }
        public string TaskName { get; set; } = "";
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }

        public string TaskList { get; set; } = "Nadchodzące";
        public virtual ICollection<Tag>? Tags { get; set; } = new List<Tag>();
        public virtual ICollection<Subtask>? Subtask { get; set; } = new List<Subtask>();

        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
