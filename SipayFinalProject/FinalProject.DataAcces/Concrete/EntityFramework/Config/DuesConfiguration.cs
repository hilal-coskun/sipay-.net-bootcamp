using FinalProject.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess.Concrete.EntityFramework.Config
{
	public class DuesConfiguration : IEntityTypeConfiguration<Dues>
	{
		public void Configure(EntityTypeBuilder<Dues> builder)
		{
			builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn();
			builder.Property(i => i.Amount).HasPrecision(18, 2);


			builder.HasIndex(x => x.FlatId);
		}
	}
}
