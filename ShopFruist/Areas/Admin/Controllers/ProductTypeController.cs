using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopFruist.Areas.Admin.Controllers
{
    public class ProductTypeController : Controller
    {
        // GET: Admin/ProductType
        public ActionResult Index()
        {
            var ds = Models.LoaiSanPhamBus.LoaiSanPhamBus.DanhSach();
            return View(ds);
        }

        // GET: Admin/ProductType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProductType/Create
        [HttpPost]
        public ActionResult Create(ShopFruistConnection.LOAISANPHAM lsp)
        {
            Models.LoaiSanPhamBus.LoaiSanPhamBus.insert(lsp);
            return RedirectToAction("Create");
        }

        // GET: Admin/ProductType/Edit/5

        public ActionResult Edit(int id)
        {
            var lsp = Models.LoaiSanPhamBus.LoaiSanPhamBus.GetProductType(id);
            return View(lsp);
        }

        // POST: Admin/ProductType/Edit/5
        [HttpPost]
        public ActionResult Edit(ShopFruistConnection.LOAISANPHAM lsp)
        {
            Models.LoaiSanPhamBus.LoaiSanPhamBus.UpdateProductType(lsp);
            return RedirectToAction("Index");
        }

        // GET: Admin/ProductType/Delete/5
        public ActionResult Delete(int id)
        {
            Models.LoaiSanPhamBus.LoaiSanPhamBus.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
