
using FZMusicEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FZMusicMVC.Controllers
{
    public class HomeController : Controller
    {
        FZMusicContext db = new FZMusicContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User data)
        {
            db.User.Add(data);
            db.SaveChanges();
            return RedirectToAction("Index", "AnaSayfa");
        }
    }
}