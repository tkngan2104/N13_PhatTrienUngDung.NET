using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_NhanVien
    {
        //Khai báo biến tĩnh
        private static DAL_NhanVien instance;

        public static DAL_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_NhanVien();
                }
                return instance;
            }
        }

        private QLResortDataContext db = new QLResortDataContext(Connection_DAL.ConnectionString);

        /// <summary>
        /// Mã nhân viên tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            int countMaNS = db.NhanSus
                      .Where(nv => nv.MaNhanSu.StartsWith("NV"))
                      .Count() + 1;

            string newMaKH;
            do
            {
                newMaKH = $"NV{countMaNS}";
                countMaNS++;
            } while (db.NhanSus.Any(kh => kh.MaNhanSu == newMaKH));
            return newMaKH;
        }

        /// <summary>
        /// Danh sách nhân viên.
        /// </summary>
        /// <returns></returns>
        public IQueryable DSNhanVien()
        {
            var nhanvien = from nv in db.NhanSus
                           join cv in db.ChucVus on nv.MaChucVu equals cv.MaChucVu
                           orderby nv.MaNhanSu descending
                           select new
                           {
                               nv.MaNhanSu,
                               nv.HoTen,
                               ChucVu = cv.TenChucVu,
                               nv.GioiTinh,
                               nv.NgaySinh,
                               nv.SDT,
                               nv.CCCD,
                               nv.Email,
                               nv.DiaChi,
                               nv.NgayVaoLam
                           };

            return nhanvien;
        }

        /// <summary>
        /// Thêm nhân viên.
        /// </summary>
        /// <param name="etS"></param>
        /// <returns></returns>
        public bool ThemNhanVien(ET_NhanVien etnv)
        {
            if (db.NhanSus.Any(s => s.MaNhanSu == etnv.MaNhanSu))
            {
                return false;
            }
            else
            {
                try
                {
                    NhanSu ns = new NhanSu
                    {
                        MaNhanSu = etnv.MaNhanSu,
                        HoTen = etnv.HoTen,
                        MaChucVu = etnv.MaCV,
                        GioiTinh = etnv.GioiTinh,
                        NgaySinh = etnv.NgaySinh,
                        SDT = etnv.SoDT,
                        CCCD = etnv.CccdNS,
                        Email = etnv.EmailNS,
                        DiaChi = etnv.DiaChi,
                        NgayVaoLam = etnv.NgayVaoLam
                    };
                    db.NhanSus.InsertOnSubmit(ns);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public bool XoaNhanVien(string maNV)
        {
            try
            {
                var xoa = from nv in db.NhanSus
                          where nv.MaNhanSu == maNV
                          select nv;

                foreach (var x in xoa)
                {
                    db.NhanSus.DeleteOnSubmit(x);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return false;
                }
                return false;
            }
        }

        /// <summary>
        /// Sửa nhân viên.
        /// </summary>
        /// <param name="etnv"></param>
        public void SuaNhanVien(ET_NhanVien etnv)
        {
            var update = db.NhanSus.Single(nv => nv.MaNhanSu == etnv.MaNhanSu);

            update.HoTen = etnv.HoTen;
            update.GioiTinh = etnv.GioiTinh;
            update.NgaySinh = etnv.NgaySinh;
            update.SDT = etnv.SoDT;
            update.CCCD = etnv.CccdNS;
            update.Email = etnv.EmailNS;
            update.DiaChi = etnv.DiaChi;
            update.MaChucVu = etnv.MaCV;
            update.NgayVaoLam = etnv.NgayVaoLam;

            db.SubmitChanges();
        }

        /// <summary>
        /// Bắt lỗi trùng email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool KiemTraEmailTonTai(string emailMoi, string emailCuu)
        {
            using (var context = new QLResortDataContext())
            {
                if (emailMoi != emailCuu)
                {
                    return context.NhanSus.Any(ns => ns.Email == emailMoi);
                }
                return false;
            }
        }

        /// <summary>
        /// Bắt lỗi trùng cccd.
        /// </summary>
        /// <param name="cccd"></param>
        /// <returns></returns>
        public bool KiemTraCCCDTonTai(string cccd)
        {
            using (var context = new QLResortDataContext())
            {
                return context.NhanSus.Any(ns => ns.CCCD == cccd);
            }
        }

        /// <summary>
        /// Bắt lỗi trùng điện thoại.
        /// </summary>
        /// <param name="sdt"></param>
        /// <returns></returns>
        public bool KiemTraSDTTonTai(string sdt)
        {
            using (var context = new QLResortDataContext())
            {
                return context.NhanSus.Any(ns => ns.SDT == sdt);
            }
        }
    }
}
