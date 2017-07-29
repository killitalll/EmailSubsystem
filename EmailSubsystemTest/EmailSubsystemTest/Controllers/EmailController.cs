using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace EmailSubsystemTest.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form(string receiverEmail, string subject, string message)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("emailsubsystemtest@gmail.com", "Red Surveillance");
                    var receiveremail = new MailAddress(receiverEmail, "Test receiver");

                    var password = "testtest1234";
                    var sub = subject;
                    var body = message;

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)

                    };

                    using (var mess = new MailMessage(senderEmail, receiveremail)
                    {
                        Subject = subject,
                        Body = body
                    }
                    )
                    {
                        smtp.Send(mess);
                    }



                    return View();
                }



            }
            catch(Exception)
            {
                ViewBag.Error = "There are some problems in sending email";
            }

            return View();
        }
    }
}