using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication11.Models.tümsiniflarim;

namespace WebApplication11.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        // GET: Login
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(Admin p)
        {
            var kullanıcı = c.Admins.FirstOrDefault(x => x.TC == p.TC && x.Sifre == p.Sifre);
            if (kullanıcı != null)
            {
                FormsAuthentication.SetAuthCookie(kullanıcı.Ad, false);
                Session["id"] = kullanıcı.ID;
                Session["ad"] = kullanıcı.Ad;
                Session["soyad"] = kullanıcı.Soyad;
                return RedirectToAction("Index", "Urun");

            }
            else
            {
                ViewBag.mesaj = "Kullanıcı Adı Veya Şifre Hatalı !!";
                return View();
            }

        }
       
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Giris", "Login");
        }
    }
}