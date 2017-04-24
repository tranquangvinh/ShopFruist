using ShopFruistConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopFruist.Models.DanhSachHinh
{
    public class DanhSachHinh
    {
        public static IEnumerable<LISTIMAGE> danhsach(int id)
        {
            var db = new ShopFruistConnectionDB();
            return db.Query<LISTIMAGE>("select * from listimage where IdSanPham = @0", id);
        }
    }
}