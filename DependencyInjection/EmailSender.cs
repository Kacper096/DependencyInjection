using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace DependencyInjection
{
    class EmailSender : INotification
    {
        public void ActOnNotification(string message)
        {
            string yourEmailAddress = "Your Email";
            string yourEmailPassword = "YourPass";

            //wysyłanie wiadomości do Administratora Sieci
            MailAddress to = new MailAddress(yourEmailAddress);
            MailAddress from = new MailAddress(yourEmailAddress);
            MailMessage mail = new MailMessage(from, to);
            mail.Subject = "Dependency Injection";
            mail.Body = "Cwiczenia z Dependency Injection"; 

            //Połaczenie z danym portem do portalu
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            //Uwierzytelnianie wysyłającego
            smtp.Credentials = new NetworkCredential(yourEmailAddress, yourEmailPassword);
            smtp.EnableSsl = true;
            Console.WriteLine("Wysyłanie wiadomości...");
            smtp.Send(mail);
        }
    }
}
