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

        public IQueryable<ET_HoaDonDatPhong> TimKiemTheoSDTKhach(string soDienThoai)
        {
            var query = from dp in db.DatPhongs
                        join kh in db.KhachHangs on dp.MaKH equals kh.MaKH
                        join ctdp in db.ChiTietDatPhongs on dp.maDP equals ctdp.maDP
                        join hd in db.HoaDonDatPhongs on ctdp.maCTDP equals hd.maCTDP into hdGroup
                        from hd in hdGroup.DefaultIfEmpty()
                        where kh.SoDT.Trim() == soDienThoai.Trim()
                        select new ET_HoaDonDatPhong
                        {
                            MaNS = dp.MaNhanSu,
                            MaHDDP = hd != null ? hd.maHDDP : null,
                            MaCTDP = ctdp.maCTDP,
                            MaSDDV = hd != null ? hd.maSDDV : null,
                            TrangThai = hd != null ? hd.trangThai : "Chưa thanh toán",
                            NgayLap = hd != null ? (DateTime)hd.ngayLap : dp.ngayDatPhong, // fallback ngày đặt phòng nếu chưa có hóa đơn
                            TongTien = hd != null ? (float)hd.tongTien : 0f
                        };

            return query;
        }
        //public IQueryable DSHDDP(string sddv)
        //{
        //    IQueryable a = from dv in db.SuDungDichVus
        //                   join ctdp in db.ChiTietDatPhongs
        //                   on dv.maCTDP equals ctdp.maCTDP
        //                   join dvv in db.DichVus
        //                   on dv.maDV equals dvv.maDV
        //                   join dp in db.HoaDonDatPhongs
        //                   on dv.maSDDV equals dp.maSDDV
        //                   where dv.maCTDP == sddv

        //                   select new { dp.maHDDP, dvv.tenDV, dv.maCTDP, dv.soLuong, dv.tongTien };
        //    return a;
        //}

        public List<ET_SuDungDichVu> LayDSDichVuTheoMaCTDP(string maCTDP)
        {
            var query = from sddv in db.SuDungDichVus
                        where sddv.maCTDP == maCTDP
                        select new ET_SuDungDichVu(
                            sddv.maSDDV,
                            sddv.maDV,
                            sddv.maCTDP,
                            (int)sddv.soLuong,
                            (float)sddv.tongTien
                        );

            return query.ToList();
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
