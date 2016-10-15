using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Beaver.Models;

namespace Beaver.Controllers
{
    public class VideosController : Controller
    {
        private ApplicationDbContext _dbContext;

        public VideosController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Videos
        public ActionResult Index()
        {
            var videos = _dbContext.Videos.ToList();

            return View(videos);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Add(Video video)
        {
            _dbContext.Videos.Add(video);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var video = _dbContext.Videos.SingleOrDefault(v => v.Id == id);

            if (video == null)
                return HttpNotFound();

            return View(video);
        }
        [HttpPost]
        public ActionResult Update(Video video)
        {
            var videoInDb = _dbContext.Videos.SingleOrDefault(v => v.Id == video.Id);

            if (videoInDb == null)
                return HttpNotFound();

            videoInDb.Title = video.Title;
            videoInDb.Description = video.Description;
            videoInDb.Genre = video.Genre;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int Id)
        {
            var video = _dbContext.Videos.SingleOrDefault(v => v.Id == Id);

            if (video == null)
                return HttpNotFound();

            return View(video);
        }
        [HttpPost]
        public ActionResult DoDelete(int Id)
        {
            var video = _dbContext.Videos.SingleOrDefault(v => v.Id == Id);
            if (video == null)
                return HttpNotFound();
            _dbContext.Videos.Remove(video);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}