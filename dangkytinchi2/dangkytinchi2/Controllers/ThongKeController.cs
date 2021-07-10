using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dangkytinchi2.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: ThongKe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SinhVien()
        {
            return View("SinhVien");
        }

        public ActionResult GiaoVien()
        {
            return View("GiaoVien");
        }

        public ActionResult LopHocPhan()
        {
            return View("LopHocPhan");
        }

        public ActionResult HocPhan()
        {
            return View("HocPhan");
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