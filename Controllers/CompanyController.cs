using Dominio.Models.dto;
using NET_Framework.Models;
using NET_Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NET_Framework.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyService _service;

        public CompanyController()
        {
            _service = new CompanyService();
        }

        // GET: Company
        public ActionResult Index()
        {
            CompanyDto model = _service.Get();
            if(model == null)
            {
                return RedirectToAction("Create");
            }

            return View(model);
        }

        // GET: Company/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost]
        public ActionResult Create(CompanyDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
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

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_service.Get());
        }

        // POST: Company/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CompanyDto model)
        {
            try
            {
                _service.Update(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Company/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
