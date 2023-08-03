using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using g212102053_mehmet_kaan_akcan_odev.Models.Siniflar;

namespace g212102053_mehmet_kaan_akcan_odev.Controllers
{
    [Authorize]
    public class AdminPlayersController : Controller
    {
        // GET: AdminPlayer
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Players.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult PlayerAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PlayerAdd(Player p)
        {
            c.Players.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PlayerUpdate(int id)
        {
            var player = c.Players.Find(id);
            return View("PlayerUpdate",player);
        }
        public ActionResult Update(Player p) 
        {
            var plyr = c.Players.Find(p.PlayerID);
            plyr.PlayerImage = p.PlayerImage;
            plyr.PlayerNumber = p.PlayerNumber;
            plyr.PlayerName = p.PlayerName;
            plyr.PlayerSurname = p.PlayerSurname;
            plyr.position_played = p.position_played;
            plyr.Nationality = p.Nationality;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PlayerDelete(int id)
        {
            var plyr = c.Players.Find(id);
            c.Players.Remove(plyr);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}