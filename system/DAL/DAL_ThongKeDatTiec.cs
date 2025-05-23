using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongKeDatTiec
    {
        private static DAL_ThongKeDatTiec instance;

        public static DAL_ThongKeDatTiec Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ThongKeDatTiec();
                }
                return instance;
            }
        }

        private QLResortDataContext db = new QLResortDataContext(Connection_DAL.ConnectionString);

        /// <summary>
        /// Thống kê đặt tiệc theo ngày.
        /// </summary>
        /// <param name="ngayDT"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoNgay(DateTime ngayDT)
        {
            var results = db.DSDatTiecTheoNgay(ngayDT);  //TÊN STORE NHA
            return results.Select(r => new ET_ThongKeDatTiec(
                r.maDT,
                r.MaKH,
                r.TenKH,
                r.maS,
                (DateTime)r.ngayDT,
                (DateTime)r.ngayBatDau,
                (DateTime)r.ngayKetThuc,
                Convert.ToSingle(r.tongTien),
                Convert.ToSingle(r.giaTriDC),
                r.ghiChu?.ToString() ?? "",
                r.MaNhanSu
            )).ToList();
        }

        /// <summary>
        /// Thống kê đặt tiệc theo tháng.
        /// </summary>
        /// <param name="nam"></param>
        /// <param name="thang"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoThang(int nam, int thang)
        {
            var results = db.DSDatTiecTheoThang(nam, thang); //TÊN STORE NHA
            return results.Select(r => new ET_ThongKeDatTiec(
                r.maDT,
                r.MaKH,
                r.TenKH,
                r.maS,
                (DateTime)r.ngayDT,
                (DateTime)r.ngayBatDau,
                (DateTime)r.ngayKetThuc,
                Convert.ToSingle(r.tongTien),
                Convert.ToSingle(r.giaTriDC),
                r.ghiChu?.ToString() ?? "",
                r.MaNhanSu
            )).ToList();
        }

        /// <summary>
        /// Thống kê đặt tiệc theo năm.
        /// </summary>
        /// <param name="nam"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoNam(int nam)
        {
            var results = db.DSDatTiecTheoNam(nam); //TÊN STORE NHA
            return results.Select(r => new ET_ThongKeDatTiec(
                r.maDT,
                r.MaKH,
                r.TenKH,
                r.maS,
                (DateTime)r.ngayDT,
                (DateTime)r.ngayBatDau,
                (DateTime)r.ngayKetThuc,
                Convert.ToSingle(r.tongTien),
                Convert.ToSingle(r.giaTriDC),
                r.ghiChu?.ToString() ?? "",
                r.MaNhanSu
            )).ToList();
        }
    }
}
