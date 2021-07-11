using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dangkytinchi2.Controllers
{
    public class GiaoVienController : Controller
    {
        // GET: GiaoVien
        public ActionResult Index()
        {
            return View();
        }

        // GET: GiaoVien/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GiaoVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GiaoVien/Create
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

        // GET: GiaoVien/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GiaoVien/Edit/5
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

        // GET: GiaoVien/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GiaoVien/Delete/5
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