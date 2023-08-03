using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        Context c = new Context();
        public ActionResult Index()
        {
            var mainDegerler = c.Mains.ToList();
            var mainImageDegerler=c.MainImages.ToList();
            var degerler = new Tuple<List<Main>, List<MainImage>>(mainDegerler, mainImageDegerler);
            return View(degerler);
        }
    }
}