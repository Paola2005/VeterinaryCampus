using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        {
            builder.ToTable("user");

            builder.Property(p => p.Id).IsRequired();

            builder
                .Property(p => p.Username)
                .HasColumnName("username")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder
                .Property(p => p.Password)
                .HasColumnName("password")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(p => p.Email)
                .HasColumnName("email")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);

            builder.HasOne(j => j.Cities).WithMany(p => p.Users).HasForeignKey(p => p.IdCity);

            /* builder.HasMany(p => p.RefreshTokens).WithOne(p => p.User).HasForeignKey(p => p.UserId); */
        }
    }
}
