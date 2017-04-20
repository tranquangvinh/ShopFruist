using ShopFruist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopFruist.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var SanPhamBanChay = SanPhamBus.List(6, "ASC");
            ViewBag.SanPhamMoiVe = SanPhamBus.List(12, "DESC");
            return View(SanPhamBanChay);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}