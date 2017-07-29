using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MailerNet;
using MailerNet.Models;

namespace MailerNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.Mailer mail = new Models.Mailer();
            mail.sendEmail();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}