using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        private readonly DAL_KhachHang dal = new DAL_KhachHang();

        //Lấy danh sách khách hàng
        public IQueryable layDSKH()
        {
            return dal.layDSKH();
        }

        //Thêm khách hàng vào danh sách
        public bool themKhachHang(ET_KhachHang et)
        {
            return dal.themKhachHang(et);
        }

        //xoá khách hàng khỏi danh sách
        //public bool xoaKhachHang(ET_KhachHang et)

        //Mã khách hàng tự động tăng
        public string taoMaKH()
        {
            return dal.TaoMaKH();
        }

        //xoá khách hàng khỏi danh sách
        public bool xoaKhachHang(string et)
        {
            return dal.xoaKhachHang(et);
        }

        //Sửa khách hàng trong danh sách
        public bool suaKhachHang(ET_KhachHang et)
        {
            return dal.suaKhachHang(et);
        }
    }
}
