namespace Dentist.DTO
{
    public class EmailBody
    {
        public static string EmailStringBody(string email, string emailToken)
        {
            return $@"<html>
<head>
</head>
<body style=""margin:0; padding:0; font-family: Arial, Helvetica, sans-serif;"">
 <div style=""height: auto;background: linear-gradient(to top, #c9c9ff 50%, #6e6ef6 90%) no-repeat; width: 400px; padding: 30px"">
    <div>
        <div>
            <h1>Reset Your Password</h1>
            <hr>
            <p>You're reciving this e-mail beacause you requested a password reset for your Ketab account.</p>
            <p>plaese tap the button below to choose a new password.</p>
            
            <a href='http://localhost:5249/login' target='_blank'>Login</a>
            <a href=""http://localhost:5249/resetpassword/{email}/{emailToken}"" target=""_blank"" style=""background:#0d6efd;padding:10px;boeder:none;
            color:ehite;border-radius:4px;display:block;margin:0 auto; width50%;text-align:center;text-decoration:none"">Reset Password</a><br>
            
            <p>Kind Regards, <br><br>
            ketab</p>
        </div>
    </div>
  </div>
 </body>
</html>";

        }
    }
}
