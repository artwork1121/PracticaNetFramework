using AccDatos;
using NET_Framework.Models;
using NET_Framework.Services;
using System;
using System.Web.Mvc;

namespace NET_Framework.Controllers
{
    public class BrandsController : Controller
    {
        private readonly MyContext _context;

        public BrandsController()
        {
            _context = new MyContext();
        }

        // GET: Brands
        public ActionResult Index()
        {
            var model = new Repository<Brand>(_context);
            return View(model.GetAll());
        }

        // GET: Brands/Details/5
        public ActionResult Details(long id)
        {
            var model = new Repository<Brand>(_context);
            return View(model.Get(id));
        }

        // GET: Brands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Brands/Create
        [HttpPost]
        public ActionResult Create(Brand model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = new Repository<Brand>(_context);
                    entity.Create(model);
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

        // GET: Brands/Edit/5
        public ActionResult Edit(long id)
        {
            var model = new Repository<Brand>(_context);
            var entity = model.Get(id);
            return View(entity);
        }

        // POST: Brands/Edit/5
        [HttpPost]
        public ActionResult Edit(long id, Brand model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = new Repository<Brand>(_context);
                    entity.Update(model);
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

        // GET: Brands/Delete/5
        public ActionResult Delete(long id)
        {
            var model = new Repository<Brand>(_context);
            return View(model.Get(id));
        }

        // POST: Brands/Delete/5
        [HttpPost]
        public ActionResult Delete(long id, Brand model)
        {
            try
            {
                var entity = new Repository<Brand>(_context);
                entity.Delete(id);
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
