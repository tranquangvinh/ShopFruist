using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopFruistConnection;

namespace ShopFruist.Models
{
    public class SanPhamBus
    {

        public static IEnumerable<SANPHAM> List(int limit, String sx)
        {
            var db = new ShopFruistConnectionDB();
            String query = "select top " + limit + " * from sanpham order by MaSanPham " + sx;
            return db.Query<SANPHAM>(query);
        }

        public static SANPHAM Details(int id)
        {
            var db = new ShopFruistConnectionDB();
            return db.SingleOrDefault<SANPHAM>("select * from sanpham where MaSanPham = @0", id);
        }

        public static IEnumerable<SANPHAM> RelatedProductsDetails(int idSP, int limit,  int? LSP)
        {
            var db = new ShopFruistConnectionDB();
            String query = "select top " + limit + " * from sanpham where MaSanPham not in ("  + idSP + ") and LoaiSp = " + LSP;
            return db.Query<SANPHAM>(query);
        }
    }
}