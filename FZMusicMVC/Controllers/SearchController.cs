using FZMusicEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FZMusicMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        FZMusicContext db = new FZMusicContext();
        public ActionResult Index(string p)
        {
            var searchmusic = from m in db.Music select m;

            if (!String.IsNullOrEmpty(p))
            {
                searchmusic = searchmusic.Where(s => s.Name.Contains(p));
            }
            return View(searchmusic.ToList());

        }
    }
}