using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe {
    public class Bilans {
        public int BilansId { get; set; }

        public DateTime OkresRozliczeniowy { get; set; }

        public decimal AktywaTrwale { get; set; }

        public decimal WartosciNiematerialneIPrawne { get; set; }
        public decimal RzeczoweAktywaTrwale { get; set; }
        public decimal SrodkiTrwale { get; set; }
        public decimal SrodkiTrwaleWBudowie { get; set; }
        public decimal ZaliczkaNaSrodkiTrwaleWBudowie { get; set; }
        public decimal NaleznosciDlugoterminowe { get; set; }
        public decimal InwestycjeDlugoterminowe { get; set; }
        public decimal RozliczeniaDlugoterminowe { get; set; }

        public decimal AktywaObrotowe { get; set; }

        public decimal Zapasy { get; set; }
        public decimal Materialy { get; set; }
        public decimal PolproduktyIProduktyWToku { get; set; }
        public decimal ProduktyGotowe { get; set; }
        public decimal Towary { get; set; }
        public decimal ZaliczkiNaDostawy { get; set; }
        public decimal NaleznosciKrotkoterminowe { get; set; }
        public decimal NaleznosciZTytuluDostawIUslug { get; set; }
        public decimal NaleznosciZTytuluPodatkow { get; set; }
        public decimal PozostaleNalleznosci { get; set; }
        public decimal NaleznosciDochodzoneNaDrodzeSadowej { get; set; }
        public decimal InwestycjeKrotkoterminowe { get; set; }
        public decimal KrotkoterminoweAktywaFinansowe { get; set; }
        public decimal InneInwestycjeKrotkoterminowe { get; set; }
        public decimal KrotkoterminoweRozliczeniaMiedzyokresowe { get; set; }

        public decimal NalezneWplatyNaKapitalPodstawowy { get; set; }
        public decimal UdzialyWlasne { get; set; }

        public decimal SumaBilansowaAktywow { get; set; } = 0;

        public decimal KapitalFunduszWlasny { get; set; }

        public decimal KapitalFunduzPodstawowy { get; set; }
        public decimal PozostaleKapitaly { get; set; }
        public decimal ZyskStrataZLatUbieglych { get; set; }
        public decimal ZyskStrataNetto { get; set; }
        public decimal OdpisyZZyskuNettoWCiaguRokuObrotowego { get; set; }

        public decimal ZobowiazaniaIRezerwyNaZobowiazania { get; set; }

        public decimal RezerwyNaZobowiazania { get; set; }
        public decimal ZobowiazaniaDlugoterminowe { get; set; }
        public decimal KredytyIPozyczki { get; set; }
        public decimal ZobowiazaniaKrotkoterminowe { get; set; }
        public decimal KredytyIPozyczkiKrotkoterminowe { get; set; }
        public decimal ZobowiazaniaZTytyuluDostawIUslug { get; set; }
        public decimal ZaliczkiOtrzymaneNaDostawy { get; set; }
        public decimal ZobowiazaniaWekslowe { get; set; }
        public decimal ZobowiazaniaZTytyuluPodatkow { get; set; }
        public decimal ZobowiazaniaZTytuluWynagrodzen { get; set; }
        public decimal PozostaleZobowiazania { get; set; }
        public decimal RozliczeniaMiedzyokresowe { get; set; }

        public decimal SumaBilansowaPasywow { get; set; } = 0;

        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
