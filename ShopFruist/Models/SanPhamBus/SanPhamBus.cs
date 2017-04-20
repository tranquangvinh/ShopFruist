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
    }
}