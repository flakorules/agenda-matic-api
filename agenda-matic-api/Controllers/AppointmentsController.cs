namespace AgendaMatic.api.Controllers
{
    using AgendaMatic.api.Models;
    using AgendaMatic.api.Request;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly AgendaMaticContext _context;

        public AppointmentsController(AgendaMaticContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public IActionResult GetByUserId(int userId)
        {
            var appointments = _context.Appointments.Where(appointment => appointment.UserId == userId).ToList();

            var appointmentsByDate = appointments
                .GroupBy(a => a.AppointmentDate.Date)
                .Select(appointment => new
                {
                    Date = appointment.Key,
                    appointments = appointments.Where(appointmentByDate => appointmentByDate.AppointmentDate.Date == appointment.Key)
                });

            return Ok(appointmentsByDate);
        }

        [HttpGet("available")]
        public IActionResult GetAvailable()
        {
            var appointments = _context.Appointments.Where(appointment => appointment.UserId == null).ToList();

            var appointmentsByDate = appointments
                .GroupBy(a => a.AppointmentDate.Date)
                .Select(appointment => new
                {
                    Date = appointment.Key,
                    appointments = appointments.FindAll(appointmentByDate => appointmentByDate.AppointmentDate.Date == appointment.Key)
                });

            return Ok(appointmentsByDate);
        }

        [HttpPatch("book/{appointmentId}")]
        public IActionResult BookAppointment(int appointmentId, BookAppointmentRequest request)
        {
            var appointment = _context.Appointments.FirstOrDefault(appointment => appointment.AppointmentId == appointmentId);

            if (appointment.UserId != null)
            {
                return BadRequest(new { message = "This appointment is already booked" });
            }
            appointment.UserId = request.UserId;
            _context.SaveChanges();
            return Ok(new { message = "Appointment booked succesfully" });
        }

        [HttpPatch("cancel/{appointmentId}")]
        public IActionResult CancelAppointment(int appointmentId)
        {
            var appointment = _context.Appointments.FirstOrDefault(appointment => appointment.AppointmentId == appointmentId);

            if (appointment == null)
            {
                return BadRequest(new { message = "This appointment does not exist in Data Base" });
            }

            appointment.UserId = null;
            _context.SaveChanges();
            return Ok(new { message = "Appointment cancelled succesfully" });
        }
    }
}
