using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Kind)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.Birthdate)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Breeds)
            .WithMany(p => p.Pets)
            .HasForeignKey(p => p.IdBreed);

            builder.HasOne(p => p.Users)
            .WithMany(p => p.Pets)
            .HasForeignKey(p => p.IdUser);
        }
    }
}
