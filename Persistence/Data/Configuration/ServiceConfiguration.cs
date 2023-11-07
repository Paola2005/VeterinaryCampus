using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Price).IsRequired().HasMaxLength(50);
        }
    }
}
