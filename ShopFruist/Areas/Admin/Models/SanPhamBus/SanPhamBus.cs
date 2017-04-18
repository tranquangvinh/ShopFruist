using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopFruistConnection;

namespace ShopFruist.Areas.Admin.Models.SanPhamBus
{
    public class SanPhamBus
    {
        public static IEnumerable<SANPHAM> DanhSach()
        {
            var db = new ShopFruistConnectionDB();
            return db.Query<SANPHAM>("select * from sanpham");
        }

        public static void insert(SANPHAM sp)
        {
             sp.Insert();
        }
    }
}