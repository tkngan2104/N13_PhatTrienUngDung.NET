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
        //Khai báo biến tĩnh.
        private static BUS_KhachHang instance;

        public static BUS_KhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_KhachHang();
                }
                return instance;
            }
        }

        private readonly DAL_KhachHang dal = new DAL_KhachHang();

        QLResortDataContext db = new QLResortDataContext();

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

        /// <summary>
        /// Lấy danh sách CCCD.
        /// </summary>
        /// <returns></returns>
        public List<string> LayTatCaCCCD()
        {
            return DAL_KhachHang.Instance.LayTatCaCCCD();
        }

        /// <summary>
        /// Lấy thông tin khách hàng qua cccd.
        /// </summary>
        /// <param name="cccd"></param>
        /// <returns></returns>
        public ET_KhachHang LayKhachHangTheoCCCD(string cccd)
        {
            return DAL_KhachHang.Instance.LayKhachHangTheoCCCD(cccd);
        }

        /// <summary>
        /// Lấy thông tin khách hàng theo mã.
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public ET_KhachHang LayKHTheoMa(string maKH)
        {
            return DAL_KhachHang.Instance.LayKHTheoMa(maKH);
        }
    }
}
