using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    public class HistoryController : Controller
    {
        // GET: History
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Historys.ToList();
            return View(degerler);
        }
    }
}