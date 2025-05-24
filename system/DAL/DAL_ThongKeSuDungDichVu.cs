using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongKeSuDungDichVu
    {
        private static DAL_ThongKeSuDungDichVu instance;

        public static DAL_ThongKeSuDungDichVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ThongKeSuDungDichVu();
                }
                return instance;
            }
        }

        private QLResortDataContext db = new QLResortDataContext(Connection_DAL.ConnectionString);

        /// <summary>
        /// Thống kê dịch vụ theo tháng.
        /// </summary>
        /// <param name="thang"></param>
        /// <param name="nam"></param>
        /// <returns></returns>
        public List<ET_ThongKeSuDungDichVu> ThongKeDichVuTheoThang(int thang, int nam)
        {
            var results = db.sp_ThongKeDichVu_TheoThang(thang, nam);
            return results.Select(r => new ET_ThongKeSuDungDichVu(
                r.tenDV,
                (int)r.TongSoLanSuDung,
                Convert.ToSingle(r.TongTien)
            )).ToList();
        }

        /// <summary>
        /// Thống kê dịch vụ theo năm.
        /// </summary>
        /// <param name="nam"></param>
        /// <returns></returns>
        public List<ET_ThongKeSuDungDichVu> ThongKeDichVuTheoNam(int nam)
        {
            var results = db.sp_ThongKeDichVu_TheoNam(nam); // Gọi store
            return results.Select(r => new ET_ThongKeSuDungDichVu(
                r.tenDV,
                (int)r.TongSoLanSuDung,
                Convert.ToSingle(r.TongTien)
            )).ToList();
        }
    }
}
