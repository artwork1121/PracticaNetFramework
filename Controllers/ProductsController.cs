using NET_Framework.Models;
using NET_Framework.Services;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace NET_Framework.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _service;
        private readonly BrandService _brandService;

        public ProductsController()
        {
            _service = new ProductService();
            _brandService = new BrandService();
        }

        // GET: Products
        public ViewResult Index()
        {
            var model = _service.GetAll();
            return View(model);
        }

        // GET: Products/Details/5
        public ViewResult Details(int id)
        {
            //var result = _service.Get(id);
            var result = _service.GetFull(id);
            return View(result);
        }

        // GET: Products/Create
        public ViewResult Create()
        {
            //ViewBag.bands = new List<Brand>();
            ViewBag.brands = (List<Brand>)_brandService.GetAll();
            return View();
        }

        /*public ActionResult ServiceCenterPost(ServiceCenterPost model)
        {
            foreach (var file in model.FileUpload)
            {
                if (file != null && file.ContentLength > 0)
                {
                    byte[] fileBytes = new byte[file.ContentLength];
                    file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                    string thumbpath = _fileStorageService.GetPath(fileName);
                    _fileStorageService.SaveFile(thumbpath, fileBytes);
                }
            }
        }*/

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product model)
        {
            //var a = Request.InputStream.ReadByte();
            //var b = Request.Params; TEST
            //var c = Request.ContentEncoding; TEST
            HttpPostedFileBase file = Request.Files[0];
            WebImage image = new WebImage(file.InputStream);
            image.Resize(300, 300);
            model.Image = image.GetBytes();

            try
            {

                if (ModelState.IsValid)
                {
                    model.Image = null;
                    _service.Create(model);
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return View();
            }

            return View(model);
        }

        // GET: Products/Edit/5
        public ViewResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ViewResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return View();
            }
        }
    }
}
