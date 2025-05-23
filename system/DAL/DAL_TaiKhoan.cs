using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;
        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_TaiKhoan();
                }
                return instance;
            }
        }
        private QLResortDataContext db = new QLResortDataContext(Connection_DAL.ConnectionString);
        //Check thông tin đăng nhập
        public bool KiemTraNhanVienCoThongTinKhong(string tenTK)
        {
            var taiKhoan = from tk in db.TaiKhoans
                           join nv in db.NhanSus on tk.MaNhanSu equals nv.MaNhanSu
                           where tk.MaNhanSu == tenTK
                           select tk;

            // Kiểm tra xem có tài khoản nào không
            return taiKhoan.Any(); // Trả về true nếu có tài khoản, false nếu không
        }
        //Kiểm tra phân quyền
        public bool KiemTraPhanQuyen(string tenTK)
        {
            var taiKhoan = (from tk in db.TaiKhoans
                            join nv in db.NhanSus on tk.MaNhanSu equals nv.MaNhanSu
                            join cv in db.ChucVus on nv.MaChucVu equals cv.MaChucVu
                            where tk.taikhoan1 == tenTK
                            select cv.MaChucVu).FirstOrDefault();
            return taiKhoan == "CV006"; //phân quyền admin.
        }

        public bool KiemTraNhapMKDungSai(string tenTK, string matKhau)
        {
            var matKhauDaLuu = (from ds in db.TaiKhoans
                                where ds.taikhoan1 == tenTK
                                select ds.matkhau).FirstOrDefault();
            return matKhauDaLuu == matKhau;
        }
        public string LayTenNVNhoTenTK(string tenTK)
        {
            string tenNV = (from dl in db.NhanSus
                            where dl.MaNhanSu == tenTK
                            select dl.HoTen).FirstOrDefault();
            return tenNV;
        }
    }
}
