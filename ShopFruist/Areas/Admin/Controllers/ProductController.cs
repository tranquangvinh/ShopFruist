using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ShopFruist.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            var ds = Models.SanPhamBus.SanPhamBus.DanhSach();
            return View();
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            var LoaiSanPham = Models.LoaiSanPhamBus.LoaiSanPhamBus.DanhSach();
            ViewBag.LoaiSanPham = LoaiSanPham;

            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(ShopFruistConnection.SANPHAM sp)
        {
            var hpt = HttpContext.Request.Files[0];
            if (HttpContext.Request.Files.Count > 0)
            {
                if (hpt.ContentLength > 0)
                {
                    string temp = hpt.FileName;
                    string RDString = Guid.NewGuid().ToString();
                    string fullNameImage = "~/upload/img/" + RDString + temp;
                    hpt.SaveAs(Server.MapPath(fullNameImage));
                    sp.HinhAnh = fullNameImage;
                }
            }

            Models.SanPhamBus.SanPhamBus.insert(sp);

            return RedirectToAction("Create");
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Product/Edit/5
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

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Product/Delete/5
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
