using System.ComponentModel.DataAnnotations;

namespace Dentist.DTO
{
    public class RegistrationDTO : BaseAccount
    {
      
        public string? Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20)]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "The Phone Number Must Be 11 Digits And Start With 010 or 011 or 012 or 015 ")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
    }
}