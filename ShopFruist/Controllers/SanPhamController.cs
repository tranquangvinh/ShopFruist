using ShopFruist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopFruist.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: Product
        public ActionResult Index(int id, int page=1)
        {
            ViewBag.SanPhamBanChay = SanPhamBus.List(6, "ASC");
            var LisrProduct = SanPhamBus.GetProductByProductType(page, 3, id);
            return View(LisrProduct);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.SanPhamBanChay = SanPhamBus.List(6, "ASC");

            var sp = SanPhamBus.Details(id);

            ViewBag.LSP = Models.LoaiSanPhamBus.LoaiSanPhamBus.DanhSach();
             
            ViewBag.SanPhamLienQuan = SanPhamBus.RelatedProductsDetails(id, 6, sp.LoaiSp);
         
            return View(sp);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
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

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
