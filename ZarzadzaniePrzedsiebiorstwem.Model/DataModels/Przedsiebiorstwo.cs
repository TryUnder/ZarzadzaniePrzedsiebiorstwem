﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels
{
    public class Przedsiebiorstwo
    {
        public int Id { get; set; }

        public string? NazwaSkrocona { get; set; }
        public string NazwaPelna { get; set; } = null!;
        public string NIP { get; set; } = null!;
        public string REGON { get; set; } = null!;
        public string daneAdresowe { get; set; } = null!;
        public string? PowiatGmina { get; set; }
        public string Wojewodztwo { get; set; } = null!;
        public string RachunekBankowy { get; set; } = null!;
        public FormaPrawna FormaPrawna { get; set; }

        public virtual UrzadSkarbowy UrzadSkarbowy { get; set; } = null!;
        public int UrzadSkarbowyId { get; set; }

        public virtual User User { get; set; } = null!;
        public int UserId { get; set; }
    }
}
