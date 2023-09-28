using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Dentist.Services
{
    public class Appointment
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }



        //Foreign Key
        public string DocotrId { get; set; }
        // Navigation property to represent the user
        public AppUser Doctor { get; set; } = new AppUser();

        //Foreign Key
        public string patientId { get; set; }
        // Navigation property to represent the user
        public AppUser Patient { get; set; } = new AppUser();
    }
}
