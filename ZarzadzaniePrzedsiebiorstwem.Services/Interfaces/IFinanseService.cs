using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Interfaces {
    public interface IFinanseService {
        public void AddRachunekZyskowIStratToDb(RachunekZyskowIStrat rachunekZyskowIStrat);
        public RachunekZyskowIStrat GetRachunekZyskowIStratFromDb(int id);
    }
}
