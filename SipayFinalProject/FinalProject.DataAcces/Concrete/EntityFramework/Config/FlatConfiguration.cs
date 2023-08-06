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
	public class FlatConfiguration : IEntityTypeConfiguration<Flat>
	{
		public void Configure(EntityTypeBuilder<Flat> builder)
		{
			builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn();
			builder.Property(x => x.IsFull).IsRequired(true);
			builder.Property(x => x.Block).IsRequired(true);
			builder.Property(x => x.FlatNo).IsRequired(true);
			builder.Property(x => x.FloorNo).IsRequired(true);

			builder.HasIndex(x => x.OwnerId);

		}
	}
}
