using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Interfaces {
    public interface IPrzedsiebiorstwoService {
        public Przedsiebiorstwo GetPrzedsiebiorstwoFromUserId(int userId);
    }
}
