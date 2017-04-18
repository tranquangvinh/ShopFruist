using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopFruistConnection;

namespace ShopFruist.Areas.Admin.Models.SanPhamBus
{
    public class SanPhamBus
    {
        public static IEnumerable<SANPHAM> List()
        {
            var db = new ShopFruistConnectionDB();
            return db.Query<SANPHAM>("select * from sanpham");
        }

        public static void insert(SANPHAM sp)
        {
             sp.Insert();
        }

        public static void Delete(int id)
        {
            try
            {
                using (var db = new ShopFruistConnectionDB())
                {
                    db.Execute("delete from SANPHAM where MaSanPham = @0", id);
                }
            }
            catch
            {
            }
        }

        public static SANPHAM GetProduct(int id)
        {
            using (var db = new ShopFruistConnectionDB())
            {
                return db.SingleOrDefault<ShopFruistConnection.SANPHAM>("select * from SANPHAM where MaSanPham = @0", id);
            }
        }
    }
}