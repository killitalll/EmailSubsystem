using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mailer.NET.Mailer;
using Mailer.NET.Mailer.Transport;

namespace MailerNet.Models
{
    public class Mailer
    {
        static void Main(string[] args)
        {
            Email email = new Email(EmailContentType.Html)
            {
                From = new Contact() { Name = "Alex", Email = "emailsubsystemtest@gmail.com" }
            };
            email.AddTo("alexradevitunes@gmail.com", "Alex");
            email.Subject = "Video is sent";
            email.Template = "template";
            email.AddTemplateVar("person", "teste");
            email.AddTemplateVar("number", "123");
            email.Send();
        }
    }
}