using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dangkytinchi2.Controllers
{
    public class LopChuyenNganhController : Controller
    {
        // GET: LopChuyenNganh
        public ActionResult Index()
        {
            return View();
        }

        // GET: LopChuyenNganh/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LopChuyenNganh/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopChuyenNganh/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LopChuyenNganh/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LopChuyenNganh/Edit/5
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

        // GET: LopChuyenNganh/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LopChuyenNganh/Delete/5
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