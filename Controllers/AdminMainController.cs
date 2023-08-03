using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    [Authorize]
    public class AdminMainController : Controller
    {
        // GET: Main
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Mains.ToList();
            return View(degerler);
        }
        [Authorize(Roles = "A")]
        public ActionResult MainUpdate(int id)
        {
            var main = c.Mains.Find(id);
            return View("MainUpdate", main);
        }
        public ActionResult Update(Main m) 
        {
            var main = c.Mains.Find(m.MainID);
            main.Promotion = m.Promotion;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult LogOut() 
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}