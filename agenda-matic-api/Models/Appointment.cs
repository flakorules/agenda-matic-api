using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaMatic.api.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int? UserId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
