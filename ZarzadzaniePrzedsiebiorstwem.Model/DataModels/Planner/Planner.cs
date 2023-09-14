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
        public string TaskName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }

        public string TaskList { get; set; } = "Upcoming";
        public virtual ICollection<Tag>? Tags { get; set; }
        public virtual ICollection<Subtask>? Subtask { get; set; }

        public virtual User User { get; set; }

        [ForeignKey("UserId")] // jawnie określam FK pomimo fluent api
        public int UserId { get; set; }
    }
}
