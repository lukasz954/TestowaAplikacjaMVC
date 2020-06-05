using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class EmailSender
    {
        public static void SendEmail(string userName, string emailAddress)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.wp.pl";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            NetworkCredential credentials = new NetworkCredential();
            credentials.UserName = "testowaaplikacjamvc@wp.pl";
            credentials.Password = "TestowaMvc1!";
            smtp.Credentials = credentials;

            MailAddress addressFrom = new MailAddress(credentials.UserName);
            MailAddress addressTo = new MailAddress(emailAddress);
            MailMessage msg = new MailMessage(addressFrom, addressTo);
            msg.Subject = "Zmiana hasła";
            msg.Body = $"Witaj {userName}! {Environment.NewLine} Twój kod aktywacyjny to 1234.";
            smtp.Send(msg);
        }
    }
}
