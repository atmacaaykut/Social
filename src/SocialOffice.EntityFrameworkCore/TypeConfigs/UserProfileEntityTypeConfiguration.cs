using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialOffice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SocialOffice.TypeConfigs
{
    public class UserProfileEntityTypeConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.ToTable($"{SocialOfficeConsts.DbTablePrefix}{nameof(UserProfile)}", SocialOfficeConsts.DbSchema);
            builder.ConfigureByConvention();

            builder.HasOne(entity => entity.IdentityUser)
                .WithMany(parent => parent.UserProfiles)
                .HasForeignKey(entity => entity.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
