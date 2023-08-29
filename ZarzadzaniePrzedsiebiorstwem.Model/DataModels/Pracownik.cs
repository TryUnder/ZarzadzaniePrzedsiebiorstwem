using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels {
	public class Pracownik {
		public int Id { get; set; }

		public string ImieNazwisko { get; set; } = null!;
		public string Pesel { get; set; } = null!;
		public string MiejsceUrodzenia { get; set; } = null!;
		public DateTime DataUrodzenia { get; set; }

		public int UrzadSkarbowyId { get; set; }
	}
}
