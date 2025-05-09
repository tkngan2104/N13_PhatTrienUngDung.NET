using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietDatPhong
    {
        //Khai báo biến tĩnh
        private static DAL_ChiTietDatPhong instance;


        public static DAL_ChiTietDatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiTietDatPhong();
                }
                return instance;
            }
        }

        private QLResortDataContext db = new QLResortDataContext();

        /// <summary>
        /// Tìm kiếm loại hình trong chi tiết đặt phòng.
        /// </summary>
        /// <param name="tenLH"></param>
        /// <returns></returns>
        public List<ChiTietDatPhong> TimTheoTenLoaiHinh(string tenLH)
        {
            List<ChiTietDatPhong> ds = new List<ChiTietDatPhong>();

            var result = db.sp_TimChiTietDatPhongTheoTenLH(tenLH);

            foreach (var item in result)
            {
                ChiTietDatPhong ctdp = new ChiTietDatPhong();
                ctdp.maCTDP = item.maCTDP;
                ctdp.maDP = item.maDP;
                ctdp.maLH = item.maLH;
                ctdp.ngayTraPhong = item.ngayTraPhong;

                ds.Add(ctdp);
            }

            return ds;
        }
    }
}
