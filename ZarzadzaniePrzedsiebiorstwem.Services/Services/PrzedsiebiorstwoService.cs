using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public class PrzedsiebiorstwoService : BaseService, IPrzedsiebiorstwoService {

        public PrzedsiebiorstwoService(MyDbContext dbContext) : base(dbContext) { }

        public Przedsiebiorstwo GetPrzedsiebiorstwoFromUserId(int userId) {
            return _dbContext.Przedsiebiorstwo.Where(p => p.UserId == userId).FirstOrDefault();
        }
    }
}
