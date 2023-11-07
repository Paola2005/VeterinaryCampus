using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
        
namespace Persistence.Data
{
    public class JwtDbContext : DbContext
    {
        public JwtDbContext(DbContextOptions options)
            : base(options) { }
    
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PhoneUser> PhoneUsers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<UserAddress> UsersAddresss { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
