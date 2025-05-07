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
            IQueryable dl = from cv in db.ChucVus
                            select new { cv.MaChucVu, cv.TenChucVu };
            return dl;
        }

        /// <summary>
        /// Mã nhân viên tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            int countMaNV = db.NhanSus.Count() + 1;

            //Tạo mã mới.
            string newMaNV;
            do
            {
                if (countMaNV < 10)
                {
                    newMaNV = $"NV00{countMaNV}";
                }
                if (countMaNV < 100)
                {
                    newMaNV = $"NV0{countMaNV}";
                }
                else
                {
                    newMaNV = $"MV{countMaNV}";
                }
                countMaNV++;
            } while (db.NhanSus.Any(nv => nv.MaNhanSu == newMaNV));
            return newMaNV;
        }

        /// <summary>
        /// Danh sách nhân viên.
        /// </summary>
        /// <returns></returns>
        public IQueryable DSNhanVien()
        {
            IQueryable nhanvien = from nv in db.NhanSus
                                  select nv;
            return nhanvien;
        }
    }
}
