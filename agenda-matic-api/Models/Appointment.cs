using System;

namespace AgendaMatic.api.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int? UserId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
