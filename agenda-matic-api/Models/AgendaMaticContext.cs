using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace AgendaMatic.api.Models
{
    public class AgendaMaticContext:DbContext
    {
        public AgendaMaticContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "flakorules@gmail.com", Password = "123456" },
                new User { Id = 2, Email = "gbustamante@chilesystems.com", Password = "123456" }
            );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { AppointmentId = 1, UserId = 1, AppointmentDate = new DateTime(2021, 05, 24, 9, 0, 0) },
                new Appointment { AppointmentId = 2, UserId = null, AppointmentDate = new DateTime(2021, 05, 24, 10, 0, 0) },
                new Appointment { AppointmentId = 3, UserId = 2, AppointmentDate = new DateTime(2021, 05, 24, 11, 0, 0) },
                new Appointment { AppointmentId = 4, UserId = null, AppointmentDate = new DateTime(2021, 05, 24, 12, 0, 0) },

                new Appointment { AppointmentId = 5, UserId = 2, AppointmentDate = new DateTime(2021, 05, 25, 9, 0, 0) },
                new Appointment { AppointmentId = 6, UserId = null, AppointmentDate = new DateTime(2021, 05, 25, 10, 0, 0) },
                new Appointment { AppointmentId = 7, UserId = 1, AppointmentDate = new DateTime(2021, 05, 25, 11, 0, 0) },
                new Appointment { AppointmentId = 8, UserId = null, AppointmentDate = new DateTime(2021, 05, 25, 12, 0, 0) },

                new Appointment { AppointmentId = 9, UserId = null, AppointmentDate = new DateTime(2021, 05, 26, 9, 0, 0) },
                new Appointment { AppointmentId = 10, UserId = null, AppointmentDate = new DateTime(2021, 05, 26, 10, 0, 0) },
                new Appointment { AppointmentId = 11, UserId = 1, AppointmentDate = new DateTime(2021, 05, 26, 11, 0, 0) },
                new Appointment { AppointmentId = 12, UserId = null, AppointmentDate = new DateTime(2021, 05, 26, 12, 0, 0) },

                new Appointment { AppointmentId = 13, UserId = null, AppointmentDate = new DateTime(2021, 05, 27, 9, 0, 0) },
                new Appointment { AppointmentId = 14, UserId = null, AppointmentDate = new DateTime(2021, 05, 27, 10, 0, 0) },
                new Appointment { AppointmentId = 15, UserId = 2, AppointmentDate = new DateTime(2021, 05, 27, 11, 0, 0) },
                new Appointment { AppointmentId = 16, UserId = null, AppointmentDate = new DateTime(2021, 05, 27, 12, 0, 0) },

                new Appointment { AppointmentId = 17, UserId = null, AppointmentDate = new DateTime(2021, 05, 28, 9, 0, 0) },
                new Appointment { AppointmentId = 18, UserId = null, AppointmentDate = new DateTime(2021, 05, 28, 10, 0, 0) },
                new Appointment { AppointmentId = 19, UserId = null, AppointmentDate = new DateTime(2021, 05, 28, 11, 0, 0) },
                new Appointment { AppointmentId = 20, UserId = null, AppointmentDate = new DateTime(2021, 05, 28, 12, 0, 0) }
            );
        }
    }
}
