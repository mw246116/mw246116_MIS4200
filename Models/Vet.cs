using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace mw246116_MIS4200.Models
{
    public class Vet
    {
        public int vetId { get; set; }
        [Display (Name ="Vet's First Name")]
        [Required(ErrorMessage = "Vet's First Name is required")]
        [StringLength(20)]
        public string vetFirstName { get; set; }
        [Display(Name = "Vet's Last Name")]
        [Required(ErrorMessage = "Vet's Last Name is required")]
        [StringLength(20)]
        public string vetLastName { get; set; }
        [Display(Name = "Vet's Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Please enter an email address.")]
        public string vetEmail { get; set; }
        [Display(Name = "Vet's Phone")]
        [DataType(DataType.PhoneNumber)]
       
        public string vetPhone { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}