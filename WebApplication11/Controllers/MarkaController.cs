using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models.tümsiniflarim;

namespace WebApplication11.Controllers
{
    [Authorize]
    public class MarkaController : Controller
    {
        Context c = new Context();
        // GET: Kategori
        public ActionResult Index()
        {
            var kategori = c.Markas.ToList();
            return View(kategori);
        }
        [HttpGet]
        public ActionResult MarkaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MarkaEkle(Marka k)
        {
            if (!ModelState.IsValid)
            {
                return View("MarkaEkle");
            }
            c.Markas.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MarkaSil(int id)
        {
            var kategori = c.Markas.Find(id);
            c.Markas.Remove(kategori);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MarkaGetir(int id)
        {
            var secilen = c.Markas.Find(id);
            return View("MarkaGetir", secilen);
        }

        public ActionResult MarkaGuncelle(Marka k)
        {
            var ktg = c.Markas.Find(k.ID);
            ktg.Ad = k.Ad;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}