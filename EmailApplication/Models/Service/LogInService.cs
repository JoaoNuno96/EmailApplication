using EmailApplication.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace EmailApplication.Models.Service
{
    public static class LogInService
    {
        public static bool TryToLogin(User userAuth)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
                smtp.Credentials = new NetworkCredential(userAuth.Email, userAuth.Password);

                //Send an email message to Alert you logged in to our app
                MailMessage message = new MailMessage(userAuth.Email, userAuth.Email);
                message.Subject = "Alert you enter EmailApplication with your email!";
                message.Body = "This is only to alert you enter our application with your email";
                smtp.EnableSsl = true;

                smtp.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
