using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mw246116_MIS4200.Models
{
    public class Vet
    {
        public int vetId { get; set; }
        public string vetFirstName { get; set; }
        public string vetLastName { get; set; }
        public string vetEmail { get; set; }
        public string vetPhone { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}