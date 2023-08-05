using FinalProject.DataAccess.Concrete.EntityFramework.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.Entities.Concrete;

namespace FinalProject.DataAccess.Concrete.EntityFramework.Contexts
{
	public class DataContexts : DbContext
	{
		/*public DataContexts(DbContextOptions<DataContexts> options) : base(options)
		{

		}*/

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;initial catalog=ProjectFinalDb;Trusted_Connection=True;");
		}


		//dbSet
		public DbSet<User> Users { get; set; }
		public DbSet<Flat> Flats { get; set; }
		public DbSet<Dues> Dues { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
		public DbSet<OperationClaim> OperationClaims { get; set; }



		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new FlatConfiguration());
			modelBuilder.ApplyConfiguration(new DuesConfiguration());
			modelBuilder.ApplyConfiguration(new InvoiceConfiguration());

			modelBuilder.Entity<User>()
		   .HasOne(u => u.Flat)
		   .WithOne(f => f.User)
		   .HasForeignKey<Flat>(f => f.UserId);

			base.OnModelCreating(modelBuilder);
		}
	}
}
