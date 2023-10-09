using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe {
    public class RachunekZyskowIStrat {
        public int Id { get; set; }
        public DateTime OkresRozliczeniowy { get; set; }

        public decimal PrzychodyNettoZeSprzedazy { get; set; }

        public decimal? PrzychodyNettoZeSprzedazyProduktow { get; set; }
        public decimal? ZmianaStanuProduktow { get; set; }
        public decimal? KosztWytworzeniaProduktowNaWlasnePotrzebyJednostki { get; set; }
        public decimal? PrzychodyNettoZeSprzedazyTowarowIMaterialow { get; set; }

        public decimal KosztyDzialalnosciOperacyjnej { get; set; }

        public decimal? Amortyzacja { get; set; }
        public decimal? ZuzycieMaterialowIProduktow { get; set; }
        public decimal? UslugiObce { get; set; }
        public decimal? PodatkiIOplaty { get; set; }
        public decimal? Wynagrodzenia { get; set; }
        public decimal? SkladkiNaZus { get; set; }
        public decimal? PozostaleKosztyRodzajowe { get; set; }
        public decimal? WartoscSprzedanychTowarowIMaterialow { get; set; }

        public decimal ZyskStrataZeSprzedazy { get; set; }


        public decimal PozostalePrzychodyOperacyjne { get; set; }

        public decimal? ZyskZTytuluRozchoduNiefinansowychAktywowTrwalych { get; set; }
        public decimal? Inwestycje { get; set; }
        public decimal? ZwiekszenieWartosciAktywowNiefinansowych { get; set; }
        public decimal? InnePrzychodyOperacyjne { get; set; }

        public decimal PozostaleKosztyOperacyjne { get; set; }

        public decimal? StrataZTytuluRozchoduNiefinansowychAktywow { get; set; }
        public decimal? ZmniejszenieWartosciAktywowNiefinansowych { get; set; }
        public decimal? InneKosztyOperacyjne { get; set; }

        public decimal ZyskStrataZDzialalnosciOperacyjnej { get; set; }


        public decimal PrzychodyFinansowe { get; set; }

        public decimal? Dywidendy { get; set; }
        public decimal? OdsetkiDlaFirmy { get; set; }
        public decimal? ZyskZTytuluRozchoduAktywowFinansowych { get; set; }
        public decimal? AktualizacjaWartosciAktywowFinansowych { get; set; }
        public decimal? Inne { get; set; }


        public decimal KosztyFinansowe { get; set; }

        public decimal? OdsetkiNaRzeczInnych { get; set; }
        public decimal? StrataZTytuluRozchoduAktywowFinansowych { get; set; }
        public decimal? AktualizacjaWartosciAktywowFinansowychStrata { get; set; }
        public decimal? InneKosztyFinansowe { get; set; }


        public decimal ZyskStrataBrutto { get; set; }
        public decimal PodatekDochodowy { get; set; }
        public decimal PozostaleObowiazkoweZmniejszeniaZysku { get; set; }
        public decimal ZyskStrataNetto { get; set; }

    }
}
