using System;
using System.Collections.Generic;
using System.Linq;
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

            }
            catch(Exception)
            {
                ViewBag.Error = "There are some problems in sending email";
            }

            return View();
        }
    }
}