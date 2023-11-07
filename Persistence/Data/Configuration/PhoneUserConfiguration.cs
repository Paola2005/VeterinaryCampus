using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PhoneUserConfiguration : IEntityTypeConfiguration<PhoneUser>
    {
        public void Configure(EntityTypeBuilder<PhoneUser> builder)
        {
            builder.ToTable("PhoneUser");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Number)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Users)
            .WithMany(p => p.PhonesUsers)
            .HasForeignKey(p => p.IdUser);
        }
    }
}
