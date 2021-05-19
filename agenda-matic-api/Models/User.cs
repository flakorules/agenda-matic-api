using System.Collections.Generic;


namespace AgendaMatic.api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
