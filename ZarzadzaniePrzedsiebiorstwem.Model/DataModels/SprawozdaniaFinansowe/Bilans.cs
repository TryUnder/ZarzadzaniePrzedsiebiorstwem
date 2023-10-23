using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe {
    public class Bilans {
        public int BilansId { get; set; }

        public decimal KwotaDebet { get; set; }
        public decimal KwotaKredyt { get; set; }

        public virtual ICollection<Konto> Konta { get; set; } = new List<Konto>();

        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
