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
			builder.Property(x => x.BlokNo).IsRequired(true);
			builder.Property(x => x.FlatNumber).IsRequired(true);
			builder.Property(x => x.FloorNumber).IsRequired(true);

			builder.HasIndex(x => x.UserId);

		}
	}
}
