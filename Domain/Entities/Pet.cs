using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pet : BaseEntity
    {
       [Required]
    public string Name { get; set; }
    [Required]
    public string Kind { get; set; }
    [Required]
    public DateTime Birthdate { get; set; }


    [Required]
    public int IdBreed { get; set; }
    public Breed Breeds{get; set;}

    [Required]
    public int IdUser { get; set; }
    public User Users{get; set;}


    public ICollection<Appointment> Appointments { get; set; }
    }
}
