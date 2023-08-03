using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    public class AdminProfileController : Controller
    {
        // GET: AdminProfile
        Context c=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var mail = (string)Session["Email"];
            var degerler = c.Users.FirstOrDefault(x => x.Email == mail);
            ViewBag.m = mail;
            return View(degerler);
        }
    }
}