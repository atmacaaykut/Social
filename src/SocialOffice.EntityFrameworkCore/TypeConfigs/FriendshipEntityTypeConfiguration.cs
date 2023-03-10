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
    public class FriendshipEntityTypeConfiguration : IEntityTypeConfiguration<Friendship>
    {
        public void Configure(EntityTypeBuilder<Friendship> builder)
        {
            builder.ToTable($"{SocialOfficeConsts.DbTablePrefix}{nameof(Friendship)}", SocialOfficeConsts.DbSchema);
            builder.ConfigureByConvention();

            builder.HasOne(entity => entity.RequestorIdentityUser)
                .WithMany(parent => parent.FriendshipSenders)
                .HasForeignKey(entity => entity.RequestorId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(entity => entity.ReceiverIdentityUser)
                .WithMany(parent => parent.FriendshipReceivers)
                .HasForeignKey(entity => entity.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
