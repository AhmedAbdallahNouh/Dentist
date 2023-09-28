using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

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
        //public List<Schedule> Schedules { get; set; }  = new List<Schedule>();

        public override string ToString()
        {
            return this.firstName + this.LastName + this.Address;
        }
    }
}
