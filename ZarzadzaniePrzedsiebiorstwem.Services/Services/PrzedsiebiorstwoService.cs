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
                var company = _dbContext.Przedsiebiorstwo.FirstOrDefault(c => c.UserId == editOrUpdateCompanyUser.User.Id);

                if (editOrUpdateCompanyUser.User != null) {
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
                }

                if (editOrUpdateCompanyUser.Przedsiebiorstwo != null) {
                    if (editOrUpdateCompanyUser.Przedsiebiorstwo.NazwaPelna != null) {
                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.NazwaPelna != company.NazwaPelna) {
                            company.NazwaPelna = editOrUpdateCompanyUser.Przedsiebiorstwo.NazwaPelna;
                        }
                    }

                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.NazwaSkrocona != null) {
                            if (editOrUpdateCompanyUser.Przedsiebiorstwo.NazwaSkrocona != company.NazwaSkrocona) {
                                company.NazwaSkrocona = editOrUpdateCompanyUser.Przedsiebiorstwo.NazwaSkrocona;
                            }
                        }

                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.NIP != null) {
                            if (editOrUpdateCompanyUser.Przedsiebiorstwo.NIP != company.NIP) {
                                company.NIP = editOrUpdateCompanyUser.Przedsiebiorstwo.NIP;
                            }
                        }

                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.REGON != null) {
                            if (editOrUpdateCompanyUser.Przedsiebiorstwo.REGON != company.REGON) {
                                company.REGON = editOrUpdateCompanyUser.Przedsiebiorstwo.REGON;
                            }
                        }

                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.daneAdresowe != null) {
                            if (editOrUpdateCompanyUser.Przedsiebiorstwo.daneAdresowe != company.daneAdresowe) {
                                company.daneAdresowe = editOrUpdateCompanyUser.Przedsiebiorstwo.daneAdresowe;
                            }
                        }

                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.PowiatGmina != null) {
                            if (editOrUpdateCompanyUser.Przedsiebiorstwo.PowiatGmina != company.PowiatGmina) {
                                company.PowiatGmina = editOrUpdateCompanyUser.Przedsiebiorstwo.PowiatGmina;
                            }
                        }

                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.Wojewodztwo != null) {
                            if (editOrUpdateCompanyUser.Przedsiebiorstwo.Wojewodztwo != company.Wojewodztwo) {
                                company.Wojewodztwo = editOrUpdateCompanyUser.Przedsiebiorstwo.Wojewodztwo;
                            }
                        }

                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.RachunekBankowy != null) {
                            if (editOrUpdateCompanyUser.Przedsiebiorstwo.RachunekBankowy != company.RachunekBankowy) {
                                company.RachunekBankowy = editOrUpdateCompanyUser.Przedsiebiorstwo.RachunekBankowy;
                            }
                        }

                        if (editOrUpdateCompanyUser.Przedsiebiorstwo.FormaPrawna != FormaPrawna.Prosze_Wybrac) {
                            if (editOrUpdateCompanyUser.Przedsiebiorstwo.FormaPrawna != company.FormaPrawna) {
                                company.FormaPrawna = editOrUpdateCompanyUser.Przedsiebiorstwo.FormaPrawna;
                            }
                        }
                    }
                }
                _dbContext.SaveChanges();
        }
    }
}
