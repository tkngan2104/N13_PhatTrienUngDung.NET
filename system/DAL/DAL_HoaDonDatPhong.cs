using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_HoaDonDatPhong
    {
        private static DAL_HoaDonDatPhong instance;

        public static DAL_HoaDonDatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_HoaDonDatPhong();
                }
                return instance;
            }
        }

        QLResortDataContext db = new QLResortDataContext();

        /// <summary>
        /// Mã sử dụng dịch vụ tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            int countMa = db.HoaDonDatPhongs.Count() + 1;

            //Tạo mã mới.
            string newMa;
            do
            {
                if (countMa < 10)
                {
                    newMa = $"HDDP00{countMa}";
                }
                else
                {
                    newMa = $"HDDP0{countMa}";
                }
                countMa++;
            } while (db.HoaDonDatPhongs.Any(dp => dp.maHDDP == newMa));
            return newMa;
        }

        public IQueryable DSHDDP(string sddv)
        {
            IQueryable a = from dv in db.SuDungDichVus
                           join ctdp in db.ChiTietDatPhongs
                           on dv.maCTDP equals ctdp.maCTDP
                           join dvv in db.DichVus
                           on dv.maDV equals dvv.maDV
                           join dp in db.HoaDonDatPhongs
                           on dv.maSDDV equals dp.maSDDV
                           where dv.maCTDP == sddv

                           select new { dp.maHDDP, dvv.tenDV, dv.maCTDP, dv.soLuong, dv.tongTien };
            return a;
        }

        
        public float LayGiaPhongTheoMaCTDP(string maCTDP)
        {
            using (QLResortDataContext db = new QLResortDataContext())
            {
                var hoaDon = db.HoaDonDatPhongs.FirstOrDefault(h => h.maCTDP == maCTDP);
                if (hoaDon != null)
                {
                    return (float)hoaDon.tongTien;
                }
                return 0;
            }
        }

        public string LayMaNhanSuTheoCTDP(string maCTDP)
        {
            var hoaDon = db.HoaDonDatPhongs.FirstOrDefault(h => h.maCTDP == maCTDP);
            return hoaDon?.MaNhanSu;
        }


    }
}
