using ShopFruist.Models.LoaiSanPhamBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopFruist.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View(LoaiSanPhamBus.DanhSach());
        }
    }
}