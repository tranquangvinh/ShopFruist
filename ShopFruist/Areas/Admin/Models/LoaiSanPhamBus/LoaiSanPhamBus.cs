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
    }
}