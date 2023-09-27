using Dentist.DTO;

namespace Dentist.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}