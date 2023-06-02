using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels {
	public class Pracownik {
		public int Id { get; set; }

		public string ImieNazwisko { get; set; }
		public string Pesel { get; set; }
		public string MiejsceUrodzenia { get; set; }
		public DateTime DataUrodzenia { get; set; }

		public virtual UrzadSkarbowy UrzadSkarbowy { get; set; }
		public int UrzadSkarbowyId { get; set; }
	}
}
