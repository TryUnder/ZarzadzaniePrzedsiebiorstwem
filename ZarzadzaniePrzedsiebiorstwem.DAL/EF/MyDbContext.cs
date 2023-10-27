using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZarzadzaniePrzedsiebiorstwem.Model.Authentication;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner;
using ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe;

namespace ZarzadzaniePrzedsiebiorstwem.DAL.EF {

	public class MyDbContext : DbContext {

		public virtual DbSet<Przedsiebiorstwo> Przedsiebiorstwo { get; set; }
		public virtual DbSet<Pracownik> Pracownik { get; set; }
		public virtual DbSet<User> User { get; set; }
		public virtual DbSet<Planner> Planner { get; set; }
		public virtual DbSet<Subtask> SubTask { get; set; }
		public virtual DbSet<Tag> Tag { get; set; }
		public virtual DbSet<RachunekZyskowIStrat> RachunekZyskowIStrat { get; set; }
		public virtual DbSet<Bilans> Bilans { get; set; }

		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseLazyLoadingProxies();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Planner>()
				.HasOne(p => p.User)
				.WithMany(u => u.Planners)
				.HasForeignKey(p => p.UserId);

			modelBuilder.Entity<Planner>()
				.HasMany(p => p.Subtask)
				.WithOne(s => s.Planner)
				.HasForeignKey(s => s.PlannerId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Planner>()
				.HasMany(p => p.Tags)
				.WithOne(t => t.Planner)
				.HasForeignKey(t => t.PlannerId)
				.OnDelete(DeleteBehavior.Cascade);
		}

	}
}
