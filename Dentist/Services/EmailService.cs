using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using Dentist.DTO;
using System.Net.Mail;
using MailKit.Net.Smtp;
using System.Net;

namespace Dentist.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public void SendEmail(EmailDto request)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailHost").Value));
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = request.Subject;
                email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                smtp.Connect(_config.GetSection("EmailHost").Value, 465, SecureSocketOptions.StartTls);
                smtp.Authenticate(_config.GetSection("EmailHost").Value, _config.GetSection("EmailPassword").Value);
                smtp.Send(email);
                smtp.Disconnect(true);

            }
            catch (Exception ex)
            {
                    var a = ex.Message;
            }
            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.mail.ru");
           
        }
    }
}
