using FZMusicEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FZMusicMVC.Controllers
{
    public class AccountController : Controller
    {
        FZMusicContext db = new FZMusicContext();
        // GET: Account
        public ActionResult Index()
        {
            int user_id = Convert.ToInt32(Session["Id"]);
            var user = db.User.Where(x => x.Id == user_id).ToList();

            return View(user);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult PasswordChange()
        {
            int user_id = Convert.ToInt32(Session["Id"]);
            //var user = db.User.Where(x => x.Id == user_id).ToList();
            User usr = db.User.Find(user_id);
            return View(usr);
        }

        [HttpPost]
        public ActionResult PasswordChange(User pUser)
        {
            int user_id = Convert.ToInt32(Session["Id"]);
            User usr = db.User.Find(user_id);
            usr.Password = pUser.Password;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}