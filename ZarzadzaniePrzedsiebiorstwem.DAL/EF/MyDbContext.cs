using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;

namespace ZarzadzaniePrzedsiebiorstwem.DAL.EF {

	public class MyDbContext : DbContext {

		public virtual DbSet<Przedsiebiorstwo> Przedsiebiorstwo { get; set; }
		public virtual DbSet<Pracownik> Pracownik { get; set; }
		public virtual DbSet<UrzadSkarbowy> UrzadSkarbowy { get; set; }
		public virtual DbSet<User> User { get; set; }

		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseLazyLoadingProxies();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
		}

	}
}
