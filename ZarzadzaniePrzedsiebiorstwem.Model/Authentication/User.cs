using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzaniePrzedsiebiorstwem.Model.Authentication {
    public class User {
        public int Id { get; set; }

        public string Login { get; set; } = null!;
        public string Haslo { get; set; } = null!;
    }
}
