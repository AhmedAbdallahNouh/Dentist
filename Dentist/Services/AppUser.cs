using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dentist.Services
{
    public class AppUser:IdentityUser
    {    
        [MaxLength(50)]
        public string firstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }


        [MaxLength(100)]
        public string Address { get; set; }



        // Navigation property to represent the user's schedules
        public List<Schedule> Schedules { get; set; }  = new List<Schedule>();
        // Navigation property to represent user roles

        public  ICollection<IdentityUserRole<string>> UserRoles { get; } = new List<IdentityUserRole<string>>();

        // Navigation property to represent user roles doctor and patient
        public List<Appointment> AppointmentsAsDoctor { get; set; } = new List<Appointment>();
        public List<Appointment> AppointmentsAsPatient { get; set; } = new List<Appointment>();


        public override string ToString()
        {
            return this.firstName + this.LastName + this.Address;
        }
    }
}
