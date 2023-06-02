using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels
{
    public class Przedsiebiorstwo
    {
        public int Id { get; set; }

        public string NazwaSkrocona { get; set; }
        public string NazwaPelna { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public string daneAdresowe { get; set; }
        public string PowiatGmina { get; set; }
        public string Wojewodztwo { get; set; }
        public string RachunekBankowy { get; set; }

    }
}
