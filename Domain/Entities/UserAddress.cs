using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserAddress : BaseEntity
    {
        public string TypeOfStreet { get; set; }

        public int FirstNumber { get; set; }

        public string Letter { get; set; }
        public string Bis { get; set; }
        public string SecondLetter { get; set; }
        public string Cardinal { get; set; }
        public int SecondNumber { get; set; }
        public string ThirdLetter { get; set; }
        public int ThirdNumber { get; set; }
        public string SecondCardinal { get; set; }
        public string Complement { get; set; }
        public string PostalCode { get; set; }

        public int IdCity { get; set; }
        public City Cities { get; set; }

        public int IdUsers { get; set; }
        public User Users { get; set; }
    }
}
