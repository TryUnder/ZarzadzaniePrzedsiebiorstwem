using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.ViewModels.ViewModels {
    public class SelectedFilters {
        public List<string> RodzajAnalizy { get; set; } = new List<string>();
        public List<string> OkresRozliczeniowyPoczatek { get; set; } = new List<string>();
        public List<string> OkresRozliczeniowyKoniec { get; set; } = new List<string>();
        public int UserId { get; set; }
    }
}
