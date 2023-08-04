using FinalProject.DataAccess.Concrete.EntityFramework.Config;
using Microsoft.EntityFrameworkCore;
using FinalProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess.Concrete.EntityFramework.Contexts
{
	public class DataContexts : DbContext
	{
		public DataContexts(DbContextOptions<DataContexts> options) : base(options)
		{

		}


		//dbSet
		public DbSet<User> Users { get; set; }
		public DbSet<Flat> Flats { get; set; }
		public DbSet<Dues> Dues { get; set; }
		public DbSet<Invoice> Invoices { get; set; }



		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new FlatConfiguration());
			modelBuilder.ApplyConfiguration(new DuesConfiguration());
			modelBuilder.ApplyConfiguration(new InvoiceConfiguration());

			base.OnModelCreating(modelBuilder);
		}
	}
}
