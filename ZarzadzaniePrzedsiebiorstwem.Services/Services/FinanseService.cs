﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe;
using ZarzadzaniePrzedsiebiorstwem.Services.Interfaces;

namespace ZarzadzaniePrzedsiebiorstwem.Services.Services {
    public class FinanseService : BaseService, IFinanseService {
        public FinanseService(MyDbContext myDbContext, IUserService userService) : base(myDbContext) { }

        public void AddRachunekZyskowIStratToDb(RachunekZyskowIStrat rachunekZyskowIStrat) {
            using (var transaction = _dbContext.Database.BeginTransaction()) {
                try {
                    _dbContext.RachunekZyskowIStrat.Add(rachunekZyskowIStrat);
                    _dbContext.SaveChanges();

                    transaction.Commit();
                } catch (Exception ex) {
                    transaction.Rollback();
                    throw new Exception("Wystąpił błąd podczas dodawania rachunku zysków i strat do bazy danych", ex);
                }
            }
        }

		public RachunekZyskowIStrat GetRachunekZyskowIStratFromDb(int id) {
            try {
                var rachunekZyskowIStrat = _dbContext.RachunekZyskowIStrat.Where(x => x.Id == id).FirstOrDefault();
                return rachunekZyskowIStrat;
            } catch (Exception ex) {
				throw new Exception("Wystąpił błąd podczas pobierania rachunku zysków i strat z bazy danych", ex);
            }
        }
	}
}
