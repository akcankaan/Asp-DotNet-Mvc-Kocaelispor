using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    [Authorize]
    public class AdminMainImageController : Controller
    {
        // GET: AdminMainImage
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.MainImages.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult ImageAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ImageAdd(MainImage i)
        {
            c.MainImages.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MainImageUpdate(int id)
        {
            var image = c.MainImages.Find(id);
            return View("MainImageUpdate", image);
        }
        public ActionResult ImageUpdate(MainImage i) 
        {
            var mimage = c.MainImages.Find(i.MainImageID);
            mimage.MainImageUrl = i.MainImageUrl;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MainImageDelete(int id)
        {
            var img = c.MainImages.Find(id);
            c.MainImages.Remove(img);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}