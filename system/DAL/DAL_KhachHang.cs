﻿using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_KhachHang();
                }
                return instance;
            }
        }

        //kết nối dữ liệu db
        QLResortDataContext db = new QLResortDataContext();

        //Lấy danh sách khách hàng
        public IQueryable layDSKH()
        {
            return db.KhachHangs.OrderByDescending(k => k.MaKH);
        }


        //Xoá khách hàng
        public bool xoaKhachHang(ET_KhachHang et)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(et.MaKH))
            {
                throw new Exception("Vui lòng chọn mã khách hàng để xóa!");
            }

            if (et.MaKH == null)
            {
                throw new Exception("Không tìm thấy khách hàng với mã: "+ et.MaKH);
            }
            var xoa = db.KhachHangs.SingleOrDefault(kh => kh.MaKH == et.MaKH);
            
                db.KhachHangs.DeleteOnSubmit(xoa);
                db.SubmitChanges();
                flag = true;
           
            return flag;
            
        }
        public bool xoaKhachHang(string maKH)
        {
            try
            {
                var kh = db.KhachHangs.SingleOrDefault(k => k.MaKH == maKH);
                if (kh != null)
                {
                    db.KhachHangs.DeleteOnSubmit(kh);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Thêm khách hàng
        public bool themKhachHang(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                KhachHang kh = new KhachHang
                {
                    MaKH = et.MaKH,
                    TenKH = et.TenKH,
                    SoDT = et.SoDT,
                    NgaySinh = et.NgaySinh,
                    GioiTinh = et.GioiTinh,
                    Diachi = et.DiaChi,
                    Email = et.Email,
                    CCCD = et.Cccd,
                    QuocTich = et.QuocTich
                };
                db.KhachHangs.InsertOnSubmit(kh);

            }
            finally
            {
                db.SubmitChanges();
                flag = true;
            };
            return flag;
        }
       

        //Mã khách hàng tăng tự động
        public string TaoMaKH()
        {
            var khCuoi = db.KhachHangs
                           .OrderByDescending(k => k.MaKH)
                           .Select(k => k.MaKH)
                           .FirstOrDefault();

            if (khCuoi == null) return "KH0001";

            // Bỏ phần "KH" để lấy số
            string soKhCuoiStr = khCuoi.Substring(2);

            // Chuyển sang số, tăng 1
            int so = int.Parse(soKhCuoiStr) + 1;

            // Ghép lại mã mới với 4 chữ số
            return "KH" + so.ToString("D4"); // D4: luôn có 4 chữ số, thêm số 0 phía trước nếu cần
        }

        //sửa khách hàng
        public bool suaKhachHang(ET_KhachHang et)
        {
            if (string.IsNullOrEmpty(et.MaKH))
                throw new Exception("Mã khách hàng không được để trống!");

            var kh = db.KhachHangs.SingleOrDefault(x => x.MaKH == et.MaKH);

            if (kh == null)
                throw new Exception("Không tìm thấy khách hàng để cập nhật!");

            // Cập nhật các thuộc tính
            kh.TenKH = et.TenKH;
            kh.SoDT = et.SoDT;
            kh.NgaySinh = et.NgaySinh;
            kh.GioiTinh = et.GioiTinh;
            kh.Diachi = et.DiaChi;
            kh.Email = et.Email;
            kh.CCCD = et.Cccd;
            kh.QuocTich = et.QuocTich;

            db.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Lấy danh sách CCCD.
        /// </summary>
        /// <returns></returns>
        public List<string> LayTatCaCCCD()
        {
            return db.KhachHangs.Select(kh => kh.CCCD).ToList();
        }

        /// <summary>
        /// Lấy thông tin khách hàng qua cccd.
        /// </summary>
        /// <returns></returns>
        public ET_KhachHang LayKhachHangTheoCCCD(string cccd)
        {
            var kh = db.KhachHangs.FirstOrDefault(k => k.CCCD == cccd);
            if (kh != null)
            {
                return new ET_KhachHang(
                    kh.MaKH,
                    kh.TenKH,
                    kh.SoDT,
                    kh.GioiTinh,
                    kh.Diachi,
                    kh.Email,
                    kh.CCCD,
                    kh.QuocTich,
                    (DateTime)kh.NgaySinh
                );
            }
            return null;
        }

        /// <summary>
        /// Lấy khách hàng qua mã khách hàng.
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public ET_KhachHang LayKHTheoMa(string maKH)
        {
            if (string.IsNullOrWhiteSpace(maKH))
                return null;

            var kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == maKH);
            if (kh == null)
                return null;

            return new ET_KhachHang
            {
                MaKH = kh.MaKH,
                TenKH = kh.TenKH,
                Cccd = kh.CCCD,
                SoDT = kh.SoDT
            };
        }

    }
}
