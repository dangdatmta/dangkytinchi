using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dangkytinchi2.Controllers
{
    public class CaiDatHeThongController : Controller
    {
        // GET: CaiDatHeThong
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ThiKetThuc()
        {
            return View("ThiKetThuc");
        }
        public ActionResult CanhCao()
        {
            return View("CanhCao");
        }
        public ActionResult HocBong()
        {
            return View("HocBong");
        }
        public ActionResult TotNghiep()
        {
            return View("TotNghiep");
        }
    }
}