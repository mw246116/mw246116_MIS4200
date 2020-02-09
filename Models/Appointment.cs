using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mw246116_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentId { get; set; }
        public DateTime appointmentDate { get; set; }
        public string ownerFirstName { get; set; }
        public string ownerLastName { get; set; }
        public int petId { get; set; }
        public virtual Pet Pet { get; set; }
        public int vetId { get; set; }
        public virtual Vet Vet { get; set; }


    }
}