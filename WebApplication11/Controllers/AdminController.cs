using WebApplication11.Models.tümsiniflarim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stok_Takip_Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Personeller
        public ActionResult Index()
        {
            var pers = c.Admins.ToList();
            return View(pers);
        }
        [HttpGet]
        public ActionResult AdminEkle()
        {
            if (!ModelState.IsValid)
            {
                return View("AdminEkle");
            }
            
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(Admin p)
        {
            c.Admins.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AdminSil(int id)
        {
            var per = c.Admins.Find(id);
            c.Admins.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AdminCagir(int id)
        {
           
            var per = c.Admins.Find(id);
            return View("AdminCagir", per);
        }

        public ActionResult AdminGuncelle(Admin p)
        {
            var per = c.Admins.Find(p.ID);
            per.Ad = p.Ad;
            per.Soyad = p.Soyad;
            per.TC = p.TC;
           
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        

    }
}