using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopFruistConnection;
namespace ShopFruist.Areas.Admin.Models.DanhSachHinh
{
    public class DanhSachHinh
    {
        public static void insertImg(String link, int id)
        {
            var a = new LISTIMAGE();
            a.LinkHinh = link;
            a.IdSanPham = id;
            a.Insert();
        }
    }
}