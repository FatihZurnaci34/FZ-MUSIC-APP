using FZMusicEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FZMusicMVC.Controllers
{
    public class LikeMusicController : Controller
    {

        FZMusicContext db = new FZMusicContext();
        // GET: LikeMusic
        public ActionResult Index()
        {
            int user_id = Convert.ToInt32(Session["Id"]);
            var musics = db.LikeMusics.Where(x => x.User_id == user_id).ToList();
            return View(musics);
        }

        public ActionResult Like(int id)
        {
            int user_id = Convert.ToInt32(Session["Id"]);
            var likesmusics = db.LikeMusics.Where(x => x.User_id == user_id).ToList();
            for (int i = 0; i < likesmusics.Count; i++) 
            {
                if (likesmusics[i].Music_id==id)
                {
                    int Cd = likesmusics[i].Id;
                    var Music = db.LikeMusics.Find(Cd);
                    db.LikeMusics.Remove(Music);
                    db.SaveChanges();
                    return RedirectToAction("Index", "LikeMusic");
                }
            }
            var like = db.Music.Find(id);
            LikeMusic likes = new LikeMusic();
            likes.Music_id = like.Id;
            likes.User_id = user_id;

            db.LikeMusics.Add(likes);
            db.SaveChanges();
            return RedirectToAction("Index", "Search");

        }
    }
}