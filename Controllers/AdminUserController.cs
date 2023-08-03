using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    public class AdminUserController : Controller
    {
        // GET: AdminUser
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Users.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult UserAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserAdd(User u)
        {
            c.Users.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UserUpdate(int id)
        {
            var user = c.Users.Find(id);
            return View("UserUpdate", user);
        }
        public ActionResult Update(User u)
        {
            var usr = c.Users.Find(u.UserID);
            usr.UserName = u.UserName;
            usr.FullName = u.FullName;
            usr.Email = u.Email;
            usr.Authorization = u.Authorization;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UserDelete(int id)
        {
            var usr = c.Users.Find(id);
            c.Users.Remove(usr);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}