using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels {
    public class Planer {
        public int Id { get; set; }

        public virtual ICollection<String> Zadanie { get; set; }
        public virtual ICollection<String>? Podzadanie { get; set; }
        public virtual ICollection<String>? Tagi { get; set; }
        public DateTime? Termin { get; set; }
    }
}
