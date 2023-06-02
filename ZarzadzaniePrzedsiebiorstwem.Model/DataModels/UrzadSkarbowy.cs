using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels {
	public class UrzadSkarbowy {
		public int Id { get; set; }

		public string Nazwa { get; set; }
		public int KodUs { get; set; }
		public string Adres { get; set; }
		public string RachunekBankowy { get; set; }
	}
}
