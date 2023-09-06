using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;
using ZarzadzaniePrzedsiebiorstwem.ViewModels.ViewModels;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public class PrzedsiebiorstwoService : BaseService, IPrzedsiebiorstwoService {

        public PrzedsiebiorstwoService(MyDbContext dbContext) : base(dbContext) { }

        public Przedsiebiorstwo GetPrzedsiebiorstwoFromUserId(int userId) {
            return _dbContext.Przedsiebiorstwo.Where(p => p.UserId == userId).FirstOrDefault();
        }

        public void EditOrUpdateCompanyUser(AddCompanyViewModel editOrUpdateCompanyUser) {
            if (editOrUpdateCompanyUser.User != null) {
                var user = _dbContext.User.FirstOrDefault(u => u.Id == editOrUpdateCompanyUser.User.Id);

                if (user != null) {
                    if (editOrUpdateCompanyUser.User.Login != null) {
                        if (user.Login != editOrUpdateCompanyUser.User.Login) {
                            user.Login = editOrUpdateCompanyUser.User.Login;
                        }
                    }
                    if (editOrUpdateCompanyUser.User.Haslo != null) {
                        if (user.Haslo != editOrUpdateCompanyUser.User.Haslo) {
                            user.Haslo = editOrUpdateCompanyUser.User.Haslo;
                        }
                    }
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
