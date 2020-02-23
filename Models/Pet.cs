using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mw246116_MIS4200.Models
{
    public class Pet
    {
        public int petId { get; set; }
        [Display (Name ="Pet's Name")]
        [Required(ErrorMessage = "Pet's Name is required")]
        [StringLength(20)]
        public string petName { get; set; }
        [Display (Name ="Type of Pet")]
        [Required(ErrorMessage = "Type of Pet is required")]
        [StringLength(20)]
        public string petType { get; set; }
        public ICollection<Appointment> Appointment { get; set; }


    }
}