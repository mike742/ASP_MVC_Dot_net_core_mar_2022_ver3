using ASP_MVC_Dot_net_core_mar_2022_ver3.Data.Interfaces;
using ASP_MVC_Dot_net_core_mar_2022_ver3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Dot_net_core_mar_2022_ver3.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepo _repo;
        private readonly IVendorRepo _vendorRepo;

        public ProductController(IProductRepo repo, IVendorRepo vendorRepo)
        {
            _repo = repo;
            _vendorRepo = vendorRepo;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public List<string> GetProductsByVendorId(int? id)
        {
            var res = _repo.GetAll()
                .Where(p => p.V_code == id)
                .Select(p => $"{p.P_Code} \t {p.P_descript} ${p.P_Price}<br>")
                .ToList();

            if (res == null || res.Count() == 0)
            {
                return new List<string> { "No product found" };
            }

            return res;
        }
        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.Vendors = new SelectList(_vendorRepo.GetAll(), "V_code", "V_name");
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product input)
        {
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
