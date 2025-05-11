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

        QLResortDataContext db = new QLResortDataContext();

        public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoNgay(DateTime ngayDT)
        {
            var results = db.DSDatTiecTheoNgay(ngayDT);
            return results.Select(r => new ET_ThongKeDatTiec(
             r.MaNhanSu,
             r.maDT,
             r.MaKH,
             r.ngayDT,
             r.maS,
             r.ghiChu,
             (DateTime)r.ngayBatDau,
             (DateTime)r.ngayKetThuc,
             (float)(r.tongTien),
             (float)(r.giaTriDC))).ToList();
        }

        //public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoThang(DateTime ngayDT)
        //{
        //    var results = db.DSDatTiecTheoThang(ngayDT);

        //    var danhSachThongKe = results.Select(r => new ET_ThongKeDatTiec(
        //        r.MaNhanSu,
        //        r.maDT,
        //        r.MaKH,
        //        r.ngayDT ?? DateTime.MinValue,
        //        r.maS,
        //        r.ghiChu,
        //        r.ngayBatDau ?? DateTime.MinValue,
        //        r.ngayKetThuc ?? DateTime.MinValue,
        //        r.tongTien.HasValue ? (float)r.tongTien.Value : 0f,
        //        r.giaTriDC.HasValue ? (float)r.giaTriDC.Value : 0f
        //    )).ToList();

        //    return danhSachThongKe;
        //}
    }
}
