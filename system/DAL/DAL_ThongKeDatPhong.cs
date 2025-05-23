using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongKeDatPhong
    {
        private static DAL_ThongKeDatPhong instance;

        public static DAL_ThongKeDatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ThongKeDatPhong();
                }
                return instance;
            }
        }
        QLResortDataContext db = new QLResortDataContext();
        /// <summary>
        /// Thống kê đặt phòng theo ngày.
        /// </summary>
        /// <param name="ngayDP"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatPhong> ThongKeDatPhongTheoNgay(DateTime ngayDP)
        {
            var results = db.DSDatPhongTheoNgay(ngayDP);  //TÊN STORE NHA
            return results.Select(r => new ET_ThongKeDatPhong(
                r.maDP,
                r.MaKH,
                r.TenKH,
                r.maCTDP,
                (DateTime)r.ngayDatPhong,
                (DateTime)r.ngayTraPhong,
                r.maLH,
                r.MaNhanSu
            )).ToList();
        }
        /// <summary>
        /// Thống kê đặt phòng theo tháng
        /// </summary>
        /// <param name="ngayDP"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatPhong> ThongKeDatPhongTheoThang(int nam, int thang)
        {
            var results = db.DSDatPhongTheoThang(nam, thang);  //TÊN STORE NHA
            return results.Select(r => new ET_ThongKeDatPhong(
                r.maDP,
                r.MaKH,
                r.TenKH,
                r.maCTDP,
                (DateTime)r.ngayDatPhong,
                (DateTime)r.ngayTraPhong,
                r.maLH,
                r.MaNhanSu
            )).ToList();
        }
        /// <summary>
        /// Danh sách thống kê đặt phòng theo năm
        /// </summary>
        /// <param name="nam"></param>
        /// <param name="thang"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatPhong> ThongKeDatPhongTheoNam(int nam)
        {
            var results = db.DSDatPhongTheoNam(nam);  //TÊN STORE NHA
            return results.Select(r => new ET_ThongKeDatPhong(
                r.maDP,
                r.MaKH,
                r.TenKH,
                r.maCTDP,
                (DateTime)r.ngayDatPhong,
                (DateTime)r.ngayTraPhong,
                r.maLH,
                r.MaNhanSu
            )).ToList();
        }
    }
}
