using Dominio.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace NET_Framework.Controllers
{
    public class PhotoController : Controller
    {
        // GET: Photo
        public ActionResult Index()
        {
            return View();
        }

        // POST: Photo
        public ActionResult Create(PhotoDto model)
        {
            model.Photo = Request.Files[Request.Files.Count - 1];
            ViewBag.title = model.Photo.FileName;
            WebImage photo = new WebImage(model.Photo.InputStream).Resize(300, 300);
            var x = WebImage.GetImageFromRequest(Request.Files[Request.Files.Count - 1].FileName);
            //ViewBag.x = x.Write();
            ViewBag.x = photo.Write();
            ViewBag.image = photo;
            return View();
        }
    }
}