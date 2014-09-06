using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using SendGrid;
using Xunit;
using FluentAssertions;

namespace HouseOfBurt.Tests.Services
{
    public class EmailServiceTest
    {
        public EmailServiceTest()
        { }

        [Fact]
        public void EmailSend_IntegrationTest()
        {
            var msg = new MailMessage
            {
                From = new MailAddress("HouseOfBurtSoftware@HouseOfBurt.com"),
                Subject = "ContextIsNeeded Submission",
                Body = "link: " + "Test Email 1",
                Priority = MailPriority.High
            };
            msg.To.Add("HouseOfBurtSoftware@Yahoo.com");

            var client = new SmtpClient
            {
                Credentials = new NetworkCredential("ChargerIIC@yahoo.com", "DarkBaka1!"),
                Host = "smtp.mail.yahoo.com",
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
                UseDefaultCredentials = true
            };
            client.Send(msg);

        }

        [Fact]
        public void EmailSend_SendGrid()
        {
            // Create the email object first, then add the properties.
            var myMessage = new SendGridMessage();
            myMessage.From = new MailAddress("houseofburt@houseofburt.com");
            myMessage.AddTo("HouseOfBurtSoftware@Yahoo.com");

            myMessage.Subject = "Link Submission";
            myMessage.Text = "Hello World plain text!";

            // Create network credentials to access your SendGrid account
            var username = "azure_1966145e5180c56ff3d3548aaec82fa8@azure.com";
            var pswd = "c1KKiG9QG8yymNU";

            /* Alternatively, you may store these credentials via your Azure portal
               by clicking CONFIGURE and adding the key/value pairs under "app settings".
               Then, you may access them as follows: 
               var username = System.Environment.GetEnvironmentVariable("SENDGRID_USER"); 
               var pswd = System.Environment.GetEnvironmentVariable("SENDGRID_PASS");
               assuming you named your keys SENDGRID_USER and SENDGRID_PASS */

            var credentials = new NetworkCredential(username, pswd);
            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);

            // Send the email.
            // You can also use the **DeliverAsync** method, which returns an awaitable task.
            transportWeb.Deliver(myMessage);
        }
    }
}
