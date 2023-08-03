using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Partial1(User u) 
        {
            c.Users.Add(u);
            c.SaveChanges();
            return PartialView();
        }

        [HttpGet]
        public ActionResult UserLogin1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin1(User u)
        {
            var bilgiler = c.Users.FirstOrDefault(x => x.Email == u.Email 
            && x.Password == u.Password);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();
                return RedirectToAction("Index","AdminProfile");
            }
            else { 
                return RedirectToAction("Index","Login");
            }
        }
    }
}