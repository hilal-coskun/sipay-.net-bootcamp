using FinalProject.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.Entities.Concrete;

namespace FinalProject.DataAccess.Concrete.EntityFramework.Seed
{
	public class DataSeeder
	{
		public static void SeedData(DataContexts dbContext)
		{
			if (!dbContext.Users.Any())
			{
				dbContext.Users.AddRange(
					new User { Name = "Ürün 1" },
					new User { Name = "Ürün 2" }
				// Diğer başlangıç verileri
				);

				dbContext.SaveChanges();
			}

			if (!dbContext.Flats.Any())
			{
				dbContext.Flats.AddRange(
					new Flat { BlokNo = "Ürün 1" },
					new Flat { BlokNo = "Ürün 2" }
				// Diğer başlangıç verileri
				);

				dbContext.SaveChanges();
			}

			if (!dbContext.Dues.Any())
			{
				dbContext.Dues.AddRange(
					new Dues { FlatId = 6 },
					new Dues { FlatId = 6 }
				// Diğer başlangıç verileri
				);

				dbContext.SaveChanges();
			}
		}
	}
}
