using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SocialNetwork.Infrashstructure.Configurations
{
	internal class IdentityUserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
	{
		public IdentityUserRoleConfig()
		{
		}

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
			builder.HasKey(iur => iur.RoleId);
        }
    }
}

