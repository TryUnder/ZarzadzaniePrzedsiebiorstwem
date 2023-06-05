using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public abstract class BaseService {
        protected readonly MyDbContext _dbContext;

        public BaseService(MyDbContext dbContext) {
            _dbContext = dbContext;
        }
    }
}
