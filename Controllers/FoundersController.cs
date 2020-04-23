using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tg_crud_solution.Models.DataBase;
using tg_crud_solution.Services.FounderService;
using tg_crud_solution.ViewModels;

namespace tg_crud_solution.Controllers
{
    public class FoundersController : Controller
    {

        public IFounderService Service;
        
        public FoundersController(IFounderService service)
        {
            this.Service = service;
        }

        // GET: Founder
        public ActionResult Index()
        {
            List<Founder> _founders = Service.GetFounders();
            FounderViewModel fvm = new FounderViewModel() { Title = "Учредители", Founders = _founders };
            return View(fvm);
        }

        // GET: Founder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Founder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Founder/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Founder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Founder/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Founder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Founder/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}