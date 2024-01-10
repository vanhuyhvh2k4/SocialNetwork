using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialNetwork.Domain.Aggregates.UserProfileAggregate;

namespace SocialNetwork.Infrashstructure.Configurations
{
	internal class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
	{
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.OwnsOne(up => up.BasicInfo);
        }
    }
}

