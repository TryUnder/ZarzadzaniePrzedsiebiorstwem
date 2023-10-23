using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe {
	public class Konto {
		public int KontoId { get; set; }

		public string NumerKonta { get; set; }
		public string NazwaKonta { get; set; }
		public decimal KwotaDebet { get; set; }
		public decimal KwotaKredyt { get; set; }

		public virtual Bilans Bilans { get; set; }
		public int BilansId { get; set; }
	}
}
