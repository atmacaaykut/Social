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
    public class ImageEntityTypeConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable($"{SocialOfficeConsts.DbTablePrefix}{nameof(Image)}", SocialOfficeConsts.DbSchema);
            builder.ConfigureByConvention();

            builder.HasOne(entity => entity.Post)
                .WithMany(parent => parent.Images)
                .HasForeignKey(entity => entity.PostId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
