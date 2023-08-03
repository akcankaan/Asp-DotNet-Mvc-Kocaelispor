using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    [Authorize]
    public class AdminContactController : Controller
    {
        // GET: AdminContact
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Contacts.ToList();
            return View(degerler);
        }
        public ActionResult ContactUpdate(int id)
        {
            var cnt = c.Contacts.Find(id);
            return View("ContactUpdate", cnt);
        }
        public ActionResult Update(Contact h) 
        {
            var cnt = c.Contacts.Find(h.ContactID);
            cnt.Location = h.Location;
            cnt.Email = h.Email;
            cnt.Call = h.Call;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}