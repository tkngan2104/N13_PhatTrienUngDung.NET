using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_LoaiHinhLuuTru
    {
        //Khai báo biến tĩnh
        private static DAL_LoaiHinhLuuTru instance;


        public static DAL_LoaiHinhLuuTru Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_LoaiHinhLuuTru();
                }
                return instance;
            }
        }

        private QLResortDataContext db = new QLResortDataContext(Connection_DAL.ConnectionString);

        /// <summary>
        /// Đổ dữ liệu loại hình lưu trú.
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public IQueryable DSLoaiHinhLuuTruCombobox(ComboBox cbo)
        {
            IQueryable dl = from p in db.LoaiHinhLuuTrus
                            group p by p.loaiHinh into grouped
                            select new { loaiHinh = grouped.Key };
            return dl;
        }

        /// <summary>
        /// Đổ dữ liệu trạng thái.
        /// </summary>
        /// <param name="cbo"></param>
        /// <returns></returns>
        public IQueryable DSTrangThaiCombobox(ComboBox cbo)
        {
            IQueryable dl = from p in db.LoaiHinhLuuTrus
                            group p by p.trangThai into grouped
                            select new { trangThai = grouped.Key };

            return dl;
        }

        /// <summary>
        /// Mã loại hình tự động.
        /// </summary>
        /// <param name="loaiPhong"></param>
        /// <returns></returns>
        public string TaoMaTuDong(string loaiHinh)
        {
            string phong = loaiHinh.Trim().ToLower() == "Phòng vip" ? "VIP" : "THG";
            //string giuong = loaiGiuong.Trim().ToLower().Contains("đôi") ? "DOI" : "DON";

            int countMaM = db.LoaiHinhLuuTrus.Count(p => p.maLH.StartsWith(phong)) + 1;

            string newMa;
            do
            {
                if (countMaM < 10)
                {
                    newMa = $"{phong}000{countMaM}";
                }
                else if (countMaM < 100)
                {
                    newMa = $"{phong}00{countMaM}";
                }
                else if (countMaM < 1000)
                {
                    newMa = $"{phong}0{countMaM}";
                }
                else
                {
                    newMa = $"{phong}{countMaM}";
                }

                countMaM++;

            } while (db.LoaiHinhLuuTrus.Any(p => p.maLH == newMa));

            return newMa;
        }

        /// <summary>
        /// Lấy danh sách loại hình lưu trú.
        /// </summary>
        /// <returns></returns>
        public string LayMaLoaiHinh()
        {
            return db.LoaiHinhLuuTrus.FirstOrDefault()?.maLH;
        }

        /// <summary>
        /// Danh sách loại hình lưu trú.
        /// </summary>
        /// <returns></returns>
        public IQueryable DSLoaiHinh(string lh)
        {
            var phong = from p in db.LoaiHinhLuuTrus
                        where p.loaiHinh.Trim() == lh.Trim()
                        orderby p.maLH descending
                        select p;
            return phong;
        }

        /// <summary>
        /// Thêm loại hình lưu trú.
        /// </summary>
        /// <param name="etLH"></param>
        /// <returns></returns>
        public bool ThemLoaiHinh(ET_LoaiHinhLuuTru etLH)
        {
            if (db.LoaiHinhLuuTrus.Any(p => p.maLH == etLH.MaLH))
            {
                return false;
            }
            else
            {
                try
                {
                    LoaiHinhLuuTru p = new LoaiHinhLuuTru
                    {
                        maLH = etLH.MaLH,
                        tenLH = etLH.TenLH,
                        loaiHinh = etLH.LoaiHinh,
                        slNguoi = etLH.SlNguoi,
                        giaTien = etLH.GiaTien,
                        trangThai = etLH.TrangThai,
                        ghiChu = etLH.GhiChu
                    };
                    db.LoaiHinhLuuTrus.InsertOnSubmit(p);
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }

        /// <summary>
        /// Xóa loại hình lưu trú.
        /// </summary>
        /// <param name="maLH"></param>
        /// <returns></returns>
        public bool XoaLoaiHinh(string maLH)
        {
            try
            {
                var xoa = from p in db.LoaiHinhLuuTrus
                          where p.maLH == maLH
                          select p;

                foreach (var x in xoa)
                {
                    db.LoaiHinhLuuTrus.DeleteOnSubmit(x);
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
        /// Sửa loại hình lưu trú.
        /// </summary>
        /// <param name="etLH"></param>
        public void SuaLoaiHinh(ET_LoaiHinhLuuTru etLH)
        {
            var update = db.LoaiHinhLuuTrus.Single(p => p.maLH == etLH.MaLH);

            update.tenLH = etLH.TenLH;
            update.loaiHinh = etLH.LoaiHinh;
            update.slNguoi = etLH.SlNguoi;
            update.giaTien = etLH.GiaTien;
            update.trangThai = etLH.TrangThai;
            update.ghiChu = etLH.GhiChu;

            db.SubmitChanges();
        }

        /// <summary>
        /// Tìm kiếm loại hình lưu trú.
        /// </summary>
        /// <param name="tenLH"></param>
        /// <returns></returns>
        public List<sp_TimKiemLoaiHinhLuuTruResult> TimKiemLoaiHinhLuuTru(string tenLH)
        {
            var result = db.sp_TimKiemLoaiHinhLuuTru(tenLH).ToList();
            return result;
        }

        /// <summary>
        /// Tìm kiếm loại hình lưu trú theo tên.
        /// </summary>
        /// <param name="tenCanTim"></param>
        /// <returns></returns>
        public List<ET_LoaiHinhLuuTru> TimTheoTen(string tenCanTim)
        {
            var ds = from lh in db.LoaiHinhLuuTrus
                     where lh.tenLH.Contains(tenCanTim)
                     select new ET_LoaiHinhLuuTru(
                         lh.maLH,
                         lh.tenLH,
                         lh.loaiHinh,
                         lh.trangThai,
                         lh.ghiChu,
                         lh.slNguoi,
                         (float)lh.giaTien
                     );
            return ds.ToList();
        }

        /// <summary>
        /// Lấy thông tin loại hình theo loại hình.
        /// </summary>
        /// <param name="loaiHinh"></param>
        /// <returns></returns>
        public List<ET_LoaiHinhLuuTru> LayLoaiHinhTrongTheoLoai(string loaiHinh)
        {
            var ds = from lh in db.LoaiHinhLuuTrus
                     where lh.loaiHinh == loaiHinh && lh.trangThai == "Trống"
                     select new ET_LoaiHinhLuuTru(
                         lh.maLH,
                         lh.tenLH,
                         lh.loaiHinh,
                         lh.trangThai,
                         lh.ghiChu,
                         lh.slNguoi,
                         (float)lh.giaTien
                     );

            return ds.ToList();
        }



    }
}
