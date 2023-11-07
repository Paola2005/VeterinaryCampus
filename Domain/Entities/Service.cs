using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Service : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<City> Cities { get; set; }
            public ICollection<Appointment> Appointments { get; set; }
    }
}
