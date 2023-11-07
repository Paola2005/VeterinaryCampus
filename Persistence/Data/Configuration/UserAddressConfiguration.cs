using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.ToTable("UserAddress"); 
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.TypeOfStreet)
                .HasMaxLength(50); 

            builder.Property(p => p.FirstNumber);

            builder.Property(p => p.Letter)
                .HasMaxLength(2); 

            builder.Property(p => p.Bis)
                .HasMaxLength(10); 

            builder.Property(p => p.SecondLetter)
                .HasMaxLength(2); 

            builder.Property(p => p.Cardinal)
                .HasMaxLength(10); 

            builder.Property(p => p.SecondNumber);

            builder.Property(p => p.ThirdLetter)
                .HasMaxLength(2); 

            builder.Property(p => p.ThirdNumber);

            builder.Property(p => p.SecondCardinal)
                .HasMaxLength(10); 

            builder.Property(p => p.Complement)
                .HasMaxLength(255); 

            builder.Property(p => p.PostalCode)
                .HasMaxLength(10); 

            builder.HasOne(a => a.Users)
            .WithOne(b => b.UsersAddresses)
            .HasForeignKey<UserAddress>(b => b.IdUsers);

            builder.HasOne(p => p.Cities)
            .WithOne(p => p.UsersAddresses)
            .HasForeignKey<UserAddress>(p => p.IdCity);
        }
    }
}

