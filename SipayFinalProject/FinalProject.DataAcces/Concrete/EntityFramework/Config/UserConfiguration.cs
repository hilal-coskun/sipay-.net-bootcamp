using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using FinalProject.Core.Entities.Concrete;

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
