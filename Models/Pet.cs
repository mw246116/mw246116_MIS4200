using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mw246116_MIS4200.Models
{
    public class Pet
    {
        public int petId { get; set; }
        public string petName { get; set; }
        public string petType { get; set; }
        public ICollection<Appointment> Appointment { get; set; }


    }
}