using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;


namespace ShopFruist.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            var ds = Models.SanPhamBus.SanPhamBus.List();

            var LoaiSanPham = Models.LoaiSanPhamBus.LoaiSanPhamBus.DanhSach();
            ViewBag.lsp = LoaiSanPham;
            return View(ds);
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
            string pathValue = Server.MapPath("~/");

            var hpt = HttpContext.Request.Files[0];
            if (HttpContext.Request.Files.Count > 0)
            {
                if (hpt.ContentLength > 0)
                {
                    string temp = hpt.FileName;
                    string RDString = Guid.NewGuid().ToString();
                    string fullNameImage =  "upload/img/" + RDString + temp;
                    hpt.SaveAs(pathValue + fullNameImage);
                    sp.HinhAnh = fullNameImage;
                }
            }

            Models.SanPhamBus.SanPhamBus.insert(sp);

            return RedirectToAction("Create");
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {

            var LoaiSanPham = Models.LoaiSanPhamBus.LoaiSanPhamBus.DanhSach();
            ViewBag.LoaiSanPham = LoaiSanPham;

            var dsSanPham = Models.SanPhamBus.SanPhamBus.GetProduct(id);
            return View(dsSanPham);
        }

        // POST: Admin/Product/Edit/5
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(ShopFruistConnection.SANPHAM sp)
        {
            string pathValue = Server.MapPath("~/");

            var hpt = HttpContext.Request.Files[0];
            if(hpt.FileName == "")
            {
                Models.SanPhamBus.SanPhamBus.UpdateProduct(sp, 0);
            }
            else
            {
                if (HttpContext.Request.Files.Count > 0)
                {
                    if (hpt.ContentLength > 0)
                    {
                        string temp = hpt.FileName;
                        string RDString = Guid.NewGuid().ToString();
                        string fullNameImage = "upload/img/" + RDString + temp;
                        hpt.SaveAs(pathValue + fullNameImage);
                        sp.HinhAnh = fullNameImage;


                    }
                }
                Models.SanPhamBus.SanPhamBus.UpdateProduct(sp, 1);
            }
          
            return RedirectToAction("Index");
        }

       
        public ActionResult Delete(int id)
        {
            Models.SanPhamBus.SanPhamBus.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
