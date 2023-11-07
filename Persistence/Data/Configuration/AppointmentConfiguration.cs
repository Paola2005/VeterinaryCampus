using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("Appointment");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p => p.Date)
        .HasColumnType("Date");

        builder.Property(p => p.Hour)
        .HasColumnType("Time");

        builder.HasOne(p => p.Users)
            .WithMany(p => p.Appointments)
            .HasForeignKey(p => p.IdUser);


        builder.HasOne(p => p.Pets)
        .WithMany(p => p.Appointments)
        .HasForeignKey(p => p.IdPet);

        builder.HasOne(p => p.Services)
        .WithMany(p => p.Appointments)
        .HasForeignKey(p => p.IdService);
        }
    }
}