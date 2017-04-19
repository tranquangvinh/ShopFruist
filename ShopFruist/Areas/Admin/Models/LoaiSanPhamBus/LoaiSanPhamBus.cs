using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopFruistConnection;
namespace ShopFruist.Areas.Admin.Models.LoaiSanPhamBus
{
    public class LoaiSanPhamBus
    {
        public static IEnumerable<LOAISANPHAM> DanhSach()
        {
            var db = new ShopFruistConnectionDB();
            return db.Query<LOAISANPHAM>("select * from loaisanpham");
        }

        public static void insert(LOAISANPHAM lsp)
        {
            lsp.Insert();
        }

        public static LOAISANPHAM GetProductType(int id) {
            var db = new ShopFruistConnectionDB();
            return db.SingleOrDefault<LOAISANPHAM>("select * from loaisanpham where MaLoaiSanPham=@0", id);
        }

        public static void UpdateProductType(LOAISANPHAM lsp)
        {
            using (var db = new ShopFruistConnectionDB())
            {
                db.Update<LOAISANPHAM>("SET TenLoaiSanPham=@0 WHERE MaLoaiSanPham=@1", lsp.TenLoaiSanPham, lsp.MaLoaiSanPham);
            }
        }
    }
}