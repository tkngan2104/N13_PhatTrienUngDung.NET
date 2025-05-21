using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_InHoaDonThanhToanDatPhong
    {
        private static DAL_InHoaDonThanhToanDatPhong instance;

        public static DAL_InHoaDonThanhToanDatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_InHoaDonThanhToanDatPhong();
                }
                return instance;
            }
        }

        QLResortDataContext db = new QLResortDataContext();

        public List<ET_InHoaDonThanhToanDatPhong> InHoaDonThanhToanDP()
        {
            var results = db.DSHoaDonDatPhong();  //TÊN STORE NHA
            return results.Select(r => new ET_InHoaDonThanhToanDatPhong(
               r.maHDDP,
               r.MaNhanSu,
               r.trangThai,
               r.maCTDP,
               (DateTime)r.ngayLap,
               r.maSDDV,
               r.soLuong,
               Convert.ToSingle(r.tongTien)
        )).ToList();
        }
    }
}
