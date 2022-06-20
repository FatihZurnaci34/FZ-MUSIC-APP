using FZMusicEntites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FZMusicMVC.Controllers
{
    public class PlayListController : Controller
    {
        FZMusicContext db = new FZMusicContext();

        
        // GET: PlayList
        public ActionResult Index()
        {

            string a = @Session["Id"].ToString();
            int id = Convert.ToInt32(a);

            var play = db.Playlist.AsNoTracking().Where(x => x.User_id == id);


            return View(play.ToList());
        }

        //[HttpGet]
        //public ActionResult Ekle(int id)

        //{

        //    List<SelectListItem> muzikler = db.Music.AsNoTracking()
        //                                        .Select(s => new SelectListItem
        //                                        {
        //                                            Value = s.Id.ToString(),
        //                                            Text = s.Name
        //                                        }).ToList();
        //    ViewBag.Muzikler = muzikler;
        //    return View();
        //}

        //[HttpPost]

        //public ActionResult Ekle(PlayListMusic pPlaylist)
        //{
        //    string a = @Session["Id"].ToString();
        //    int id = Convert.ToInt32(a);
        //    Playlist playlists = new Playlist();


        //    playlists.Name = pPlaylist.Playlist.Name;
        //    playlists.User_id= id;

        //    db.Playlist.Add(playlists);
        //    db.SaveChanges();
        //    PlayListMusic playlistortak = new PlayListMusic();
        //    //playlists.Id = pPlaylist.PlaylistId;
        //    int mucisId = db.Music.Find(pPlaylist.MusicId);
        //    playlistortak.MusicId = 7; 
        //    playlistortak.PlaylistId = playlists.Id;

        //    db.playListMusic.Add(playlistortak);
        //    db.SaveChanges();

        //    return RedirectToAction("Index");
        //}


        public ActionResult Ekle(Playlist p)
        {

            PlaylistAndPlayListMusic papl = new PlaylistAndPlayListMusic();
            papl.Musics = db.Music.ToList();

            int pa = Convert.ToInt32(Session["PlaylistId"]);

            papl.PlayListMusics = db.playListMusic.Where(x => x.PlaylistId == pa).ToList();

            
            ViewBag.Name = Session["PlaylistName"];
            ViewBag.Id = Session["PlaylistId"];
            return View(papl);

        }

        public ActionResult MusicEkle(int id)
        {
            Music music = db.Music.Find(id);
            PlayListMusic playListMusic = new PlayListMusic();
            int playlistId = Convert.ToInt32(Session["PlaylistId"]);
            Playlist playlist = db.Playlist.Find(playlistId);

            playListMusic.MusicId = music.Id;
            playListMusic.PlaylistId = playlist.Id;

            db.playListMusic.Add(playListMusic);
            db.SaveChanges();

            return RedirectToAction("Ekle");


        }

        public ActionResult PlaylistEkle()
        {
            string a = @Session["Id"].ToString();
            int userId = Convert.ToInt32(a);
            Playlist playlists = new Playlist();
            playlists.Name = "Çalma Listem";
            playlists.User_id = userId;
            db.Playlist.Add(playlists);
            db.SaveChanges();
            Session["PlaylistId"] = playlists.Id;
            Session["PlaylistName"] = playlists.Name;


            return RedirectToAction("Ekle");

        }

        public ActionResult delete(int id)
        {
            PlayListMusic playList = db.playListMusic.Find(id);
            db.playListMusic.Remove(playList);
            db.SaveChanges();

            return RedirectToAction("Ekle");

        }
        
        public ActionResult deletePlaylist(int id)
        {
            Playlist playList = db.Playlist.Find(id);
            db.Playlist.Remove(playList);
            db.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult PlayListListele(string pid)
        {
            PlaylistAndPlayListMusic deneme = new PlaylistAndPlayListMusic();
            deneme.Musics = db.Music.ToList();
            int playid = Convert.ToInt32(pid);
            string a = @Session["Id"].ToString();
            int id = Convert.ToInt32(a);
            deneme.PlayListMusics = db.playListMusic.Where(x => x.PlaylistId == playid).ToList();

            return View(deneme);
        }


    }
}