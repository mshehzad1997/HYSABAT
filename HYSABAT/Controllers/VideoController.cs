using HYSABAT.Controllers.Data;
using HYSABAT.Models;
using HYSABAT.Models.VideoViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Controllers
{
    public class VideoController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public VideoController(ApplicationDbContext db,IWebHostEnvironment webhost)
        {
            _db = db;
            _webHostEnvironment = webhost;
        }
        public IActionResult Index()
        {
            var allvideos = _db.videos.Select(x => new VideoVM()
            {
                VName = x.VideoName,
                videourl = x.VideoPath,
                
            }).ToList();
            return View(allvideos);
          
        }

        [HttpPost]

        public IActionResult CreateVideo(VideoVM model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
               
                    string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "video");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileVideo.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.FileVideo.CopyTo(stream);
                    }

                model.videourl = uniqueFileName;

                var videoModel = new Video()
                {
                    VideoName = model.VName,
                    
                    VideoPath = uniqueFileName,
                   
                };
                _db.videos.Add(videoModel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        
        public IActionResult DeleteVideo( VideoVM model)
        {
            if (ModelState.IsValid)
            {
                var video = _db.videos.Find(model.Id);


                var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "video",video.VideoPath);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);



                _db.videos.Remove(video);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
       
        public IActionResult UpdateVideo(VideoVM model)
        {
            if (ModelState.IsValid)
            {

                var video = _db.videos.Find(model.Id);

               
               
                if (model.FileVideo != null)
                {
                    if (video.VideoPath != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "video", video.VideoPath);
                        System.IO.File.Delete(filePath);
                    }
                    video.VideoName = model.VName;
                    video.VideoPath = VideoUploadFile(model);
                }

                _db.videos.Update(video);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        private string VideoUploadFile(VideoVM model)
        {
            string uniqueFileName = null;
            string extension = Path.GetExtension(model.FileVideo.FileName);

            string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "video");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileVideo.FileName;
            string filePath = Path.Combine(uploadFolder, uniqueFileName);
            //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                model.FileVideo.CopyTo(stream);
            }

            model.videourl = uniqueFileName;
            return uniqueFileName;
        }
    }
}
