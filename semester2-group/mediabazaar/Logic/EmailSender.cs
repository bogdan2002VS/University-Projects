using FluentEmail.Core;
using FluentEmail.Smtp;
using Logic.CustomEventArgs;
using Logic.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EmailSender
    {
        public static async Task SendEmailPassword(string receiver, string emailMessage)
        {
            string message = "Welcome to mediabaazar, with this link you will be able to set your password.\n" + emailMessage;

            var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                Port = 587,
                Credentials = new NetworkCredential("mediabazaarhr@gmail.com", "uyspfcjlzoxohgzr"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,


            });

            Email.DefaultSender = sender;

            var email = await Email
                .From("mediabazaarhr@gmail.com")
                .To(receiver)
                .Subject("Password Change")
                .Body(emailMessage)
                .SendAsync();
        }

        public void OnEmployeeAdded(object sender, EmployeeArgs employeeArgs)
        {
            string link = "https://localhost:7284/changepassword?Id=" + employeeArgs.Employee.Id;

            SendEmailPassword(employeeArgs.Employee.Email, link);
        }
    }
}
