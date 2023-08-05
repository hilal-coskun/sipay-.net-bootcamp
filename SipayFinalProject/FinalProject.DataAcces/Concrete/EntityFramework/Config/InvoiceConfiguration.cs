using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.Entities.Concrete;

namespace FinalProject.DataAccess.Concrete.EntityFramework.Config
{
	public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
	{
		public void Configure(EntityTypeBuilder<Invoice> builder)
		{
			builder.Property(i => i.Amount).HasPrecision(18, 2);
		}
	}
}
