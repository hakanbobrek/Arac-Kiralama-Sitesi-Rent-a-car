using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models.tümsiniflarim;
namespace WebApplication11.Controllers
{
    public class AnasayfaController : Controller
    {
        Context c = new Context();
        // GET: Anasayfa
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Opel()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 15).ToList();
           
            return View(markalar);
        }
        public ActionResult Araclar()
        {
            var kategori = c.Markas.ToList();
            return View(kategori);
        }
        public ActionResult Renault()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 12).ToList();

            return View(markalar);
        }
        public ActionResult Citroen()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 9).ToList();

            return View(markalar);
        }
        public ActionResult Toyota()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 14).ToList();

            return View(markalar);
        }
        public ActionResult Aston()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 5).ToList();

            return View(markalar);
        }
        public ActionResult Fiat()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 10).ToList();

            return View(markalar);
        }
        public ActionResult Wolsvagen()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 13).ToList();

            return View(markalar);
        }
        public ActionResult Peugeot()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 16).ToList();

            return View(markalar);
        }
        public ActionResult MercedesBenz()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 17).ToList();

            return View(markalar);
        }
        public ActionResult Audi()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 6).ToList();

            return View(markalar);
        }
        public ActionResult BMW()
        {
            var markalar = c.Uruns.Where(x => x.MarkaID == 4).ToList();

            return View(markalar);
        }
    }
}