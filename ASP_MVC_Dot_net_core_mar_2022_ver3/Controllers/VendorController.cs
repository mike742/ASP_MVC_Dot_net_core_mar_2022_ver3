using ASP_MVC_Dot_net_core_mar_2022_ver3.Data.Interfaces;
using ASP_MVC_Dot_net_core_mar_2022_ver3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Dot_net_core_mar_2022_ver3.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorRepo _repo;

        // private readonly MockVendorRepo _repo = new MockVendorRepo();

        public VendorController(IVendorRepo repo)
        {
            _repo = repo;
        }

        // GET: VendorController
        public ActionResult Index()
        {
            var vendors = _repo.GetAll();
            return View(vendors);
        }

        // GET: VendorController/Details/5
        public ActionResult Details(int id)
        {
            var vendor = _repo.GetById(id);

            if (vendor != null)
            { 
                return View(vendor);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: VendorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VendorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vendor input)
        {
            try
            {
                _repo.Create(input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VendorController/Edit/5
        public ActionResult Edit(int id)
        {
            var vendorInCollection = _repo.GetById(id);

            if (vendorInCollection != null)
            {
                return View(vendorInCollection);
            }

            return RedirectToAction(nameof(Index));
        }

        // POST: VendorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Vendor vendor)
        {
            try
            {
                _repo.Update(id, vendor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VendorController/Delete/5
        public ActionResult Delete(int id)
        {
            var vendor = _repo.GetById(id);

            if (vendor != null)
            {
                return View(vendor);
            }

            return RedirectToAction(nameof(Index));
        }

        // POST: VendorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _repo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
