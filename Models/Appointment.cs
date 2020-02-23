using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mw246116_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentId { get; set; }
        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode = true)]
        public DateTime appointmentDate { get; set; }
        [Display (Name ="Owner's First Name")] 
        [Required(ErrorMessage ="Owner's First Name is required")]
        [StringLength(20)]
        public string ownerFirstName { get; set; }
        [Display (Name ="Owner's Last Name")]
        [Required(ErrorMessage = "Owner's Last Name is required")]
        [StringLength(20)]
        public string ownerLastName { get; set; }
        [Display(Name = "Pet's Name")]
        [Required(ErrorMessage = "Pet's Name is required")]
        
        public int petId { get; set; }
        
        public virtual Pet Pet { get; set; }
        [Display(Name = "Vet's Name")]
        [Required(ErrorMessage = "Vet's Name is required")]
        
        public int vetId { get; set; }
        
        public virtual Vet Vet { get; set; }


    }
}