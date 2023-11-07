using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
        public string LastName { get; set; }

        public int IdCity { get; set; }
        public City Cities { get; set; }

        public UserAddress UsersAddresses { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<PhoneUser> PhonesUsers { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
