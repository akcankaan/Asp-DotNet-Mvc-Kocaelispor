using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    [Authorize]
    public class AdminHistoryController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {

            var degerler = c.Historys.ToList();
            return View(degerler);
        }
        public ActionResult HistoryUpdate(int id)
        {
            var hstr = c.Historys.Find(id);
            return View("HistoryUpdate", hstr);
        }
        public ActionResult Update(History h)
        {
            var hstr = c.Historys.Find(h.HistoryID);
            hstr.HistoryDescription = h.HistoryDescription;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}