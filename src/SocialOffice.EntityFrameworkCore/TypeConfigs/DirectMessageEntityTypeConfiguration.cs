﻿using Microsoft.EntityFrameworkCore;
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
    public class DirectMessageEntityTypeConfiguration : IEntityTypeConfiguration<DirectMessage>
    {
        public void Configure(EntityTypeBuilder<DirectMessage> builder)
        {
            builder.ToTable($"{SocialOfficeConsts.DbTablePrefix}{nameof(DirectMessage)}", SocialOfficeConsts.DbSchema);            
            builder.ConfigureByConvention();

            builder.HasOne(entity => entity.FromIdentityUser)
                 .WithMany(parent => parent.DirectMessagesSender)
                 .HasForeignKey(entity => entity.FromUserId)
                 .IsRequired(false)
                 .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(entity => entity.ToIdentityUser)
                 .WithMany(parent => parent.DirectMessagesSender)
                 .HasForeignKey(entity => entity.ToUserId)
                 .IsRequired(false)
                 .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}