using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("State");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p=>p.Countries)
        .WithMany(p=>p.States)
        .HasForeignKey(p=>p.IdCountry);
        }
    }
}

