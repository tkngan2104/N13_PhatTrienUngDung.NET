using System;
using System.Collections.Generic;
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

        private QLResortDataContext db = new QLResortDataContext();

        /// <summary>
        /// Đổ dữ liệu chức vụ.
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public IQueryable DSChucVuCombobox(ComboBox cbo)
        {
            IQueryable chucvu = from cv in db.ChucVus
                                  orderby cv.MaChucVu descending
                                  select cv.TenChucVu;
            return chucvu;
        }

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
            IQueryable nhanvien = from nv in db.NhanSus
                                  orderby nv.MaNhanSu descending
                                  select nv;
            return nhanvien;
        }
    }
}
