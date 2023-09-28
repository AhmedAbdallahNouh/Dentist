namespace Dentist.Services
{
    public class Schedule
    {
        public int Id { get; set; }
        public string? DayOfWeek { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        //Foreign Key
        public string DocotrId { get; set; }
        // Navigation property to represent the user
        public AppUser Doctor { get; set; } = new AppUser();
    }
}
