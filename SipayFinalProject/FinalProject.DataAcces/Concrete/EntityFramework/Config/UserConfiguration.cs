using Microsoft.EntityFrameworkCore;
using FinalProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess.Concrete.EntityFramework.Config
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.Property(x => x.Id).IsRequired(true).UseIdentityColumn();
			builder.Property(x => x.Name).IsRequired(true).HasMaxLength(50);
			builder.Property(x => x.Surname).IsRequired(true).HasMaxLength(50);
			builder.Property(x => x.TCNumber).IsRequired(true);
			builder.Property(x => x.PhoneNumber).IsRequired(true);
			builder.Property(x => x.Email).IsRequired(true);
		}
	}
}
