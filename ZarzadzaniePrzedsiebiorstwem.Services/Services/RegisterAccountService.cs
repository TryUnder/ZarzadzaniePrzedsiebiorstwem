﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public class RegisterAccountService : BaseService, IRegisterAccount {

        public RegisterAccountService(MyDbContext dbContext) : base(dbContext) { }

        public User RegisterAccount(User user) {
            try {
                if (_dbContext.User!.Any(u => u.Login == user.Login)) {
                    throw new Exception("Użytkownik o podanym loginie już istnieje");
                } else {
                    _dbContext.User!.Add(user);
                    _dbContext.SaveChanges();
                }
                return user;
            } catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
