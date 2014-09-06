using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using SendGrid;

namespace HouseOfBurt.Services
{
    public class EmailService
    {
        private Web transportWeb;

        public EmailService()
        {
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
            transportWeb = new Web(credentials);
        }

        public void SendSelfEmail(string subject, string message)
        {
            var myMessage = new SendGridMessage();
            myMessage.From = new MailAddress("houseofburt@houseofburt.com");
            myMessage.Subject = "Link Submission";
            myMessage.Text = "Hello World plain text!";
            myMessage.AddTo("HouseOfBurtSoftware@Yahoo.com");

            transportWeb.Deliver(myMessage);
        }
    }
}