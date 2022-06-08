
using FZMusicEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FZMusicMVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index2()
        {
            return View();
        }


        public ActionResult Index() {

            return View();        
        }



        [HttpPost]
        public ActionResult Index(User pUser)
        {
            using (FZMusicContext db = new FZMusicContext())
            {
                var user = db.User.FirstOrDefault(x => x.Email == pUser.Email && x.Password == pUser.Password);

                if (user !=null)
                {
                    FormsAuthentication.SetAuthCookie(user.Email, false);
                    Session["Id"] = user.Id;
                    Session["Name"] = user.Name.ToString();
                    

                    return RedirectToAction("Index","AnaSayfa");

                }

                else
                {
                    ViewBag.Message = "E-mail veya şifreniz yanlış";
                    return View();
                }
            }
            


        }
    }
}