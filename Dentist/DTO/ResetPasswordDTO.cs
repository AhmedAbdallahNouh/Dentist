using System.ComponentModel.DataAnnotations;

namespace Dentist.DTO
{
    public class ResetPasswordDTO
    {
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string EmailToken { get; set; }

        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmNewPassword { get; set; }
    }
}
