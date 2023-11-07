using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhoneUser : BaseEntity
    {
        
    public int IdUser { get; set; }
    public User Users{get; set;}

    
    public string Number { get; set; }
    }
}
