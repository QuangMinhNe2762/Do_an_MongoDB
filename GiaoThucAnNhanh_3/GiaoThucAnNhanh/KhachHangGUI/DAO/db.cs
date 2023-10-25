using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhachHangGUI.DTO;
namespace KhachHangGUI.DAO
{
    internal class db
    {
        protected String ConnectionString = "mongodb://localhost:27017";
        protected String Database = "giao_thuc_an_nhanh";

        public static ThucAn ThucAn = new ThucAn();
        public static KhachHang KhachHang = new KhachHang();
        public static HoaDon HoaDon = new HoaDon();
        public static HoaDon_ThucAn HoaDon_ThucAn = new HoaDon_ThucAn();
    }
}
