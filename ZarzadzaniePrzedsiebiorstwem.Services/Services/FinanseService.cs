using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public class FinanseService : BaseService, IFinanseService {
        public FinanseService(MyDbContext myDbContext, IUserService userService) : base(myDbContext) { }
    }
}
