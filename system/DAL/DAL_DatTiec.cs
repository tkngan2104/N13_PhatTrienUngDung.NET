using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DatTiec
    {
        private static DAL_DatTiec instance;

        public static DAL_DatTiec Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_DatTiec();
                }
                return instance;
            }
        }

        QLResortDataContext db = new QLResortDataContext();


        /// <summary>
        /// Mã đặc tiệc tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            string dinhdangngay = DateTime.Now.ToString("ddMMyy");
            int countMa = db.DatTiecs.Count() + 1;

            //Tạo mã mới.
            string newMa;
            do
            {
                if (countMa < 10)
                {
                    newMa = $"DT{dinhdangngay}000{countMa}";
                }
                else if (countMa < 100)
                {
                    newMa = $"DT{dinhdangngay}00{countMa}";
                }
                else if(countMa < 1000)
                {
                    newMa = $"DT{dinhdangngay}0{countMa}";
                }
                else
                {
                    newMa = $"DT{dinhdangngay}{countMa}";
                }
                countMa++;
            } while (db.DatTiecs.Any(dv => dv.maDT == newMa));
            return newMa;
        }

        /// <summary>
        /// Danh sách đặt tiệc.
        /// </summary>
        /// <returns></returns>
        public IQueryable DSDatTiec()
        {
            var dattiec = from dt in db.DatTiecs
                          join kh in db.KhachHangs on dt.MaKH equals kh.MaKH
                          orderby dt.maDT descending
                          select new
                          { dt.maDT, dt.MaKH, TenKH = kh.TenKH, dt.maS, dt.ngayDT, dt.ngayBatDau, dt.ngayKetThuc, dt.tongTien, dt.giaTriDC, dt.ghiChu, dt.MaNhanSu };

            return dattiec;
        }

        /// <summary>
        /// Thêm đặt tiệc.
        /// </summary>
        /// <param name="et"></param>
        /// <returns></returns>
        public bool ThemDatTiec(ET_DatTiec et)
        {
            if (db.DatTiecs.Any(dt => dt.maDT == et.MaDT))
                return false;

            try
            {
                DatTiec dt = new DatTiec
                {
                    MaNhanSu = et.MaNS,
                    maDT = et.MaDT,
                    MaKH = et.MaKH,
                    maS = et.MaS,
                    ghiChu = et.GhiChu,
                    ngayDT = et.NgayDT,
                    ngayBatDau = et.NgayBatDau,
                    ngayKetThuc = et.NgayKetThuc,
                    tongTien = et.TongTien,
                    giaTriDC = et.GiaTriDC
                };
                db.DatTiecs.InsertOnSubmit(dt);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Xóa đặt tiệc.
        /// </summary>
        /// <param name="maDT"></param>
        /// <returns></returns>
        public bool XoaDatTiec(string maDT)
        {
            try
            {
                var dt = db.DatTiecs.SingleOrDefault(d => d.maDT == maDT);
                if (dt != null)
                {
                    db.DatTiecs.DeleteOnSubmit(dt);
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

        /// <summary>
        /// Sửa đặt tiệc.
        /// </summary>
        /// <param name="et"></param>
        public void SuaDatTiec(ET_DatTiec et)
        {
            var dt = db.DatTiecs.SingleOrDefault(d => d.maDT == et.MaDT);
            if (dt != null)
            {
                dt.MaNhanSu = et.MaNS;
                dt.MaKH = et.MaKH;
                dt.maS = et.MaS;
                dt.ghiChu = et.GhiChu;
                dt.ngayDT = et.NgayDT;
                dt.ngayBatDau = et.NgayBatDau;
                dt.ngayKetThuc = et.NgayKetThuc;
                dt.tongTien = et.TongTien;
                dt.giaTriDC = et.GiaTriDC;
                db.SubmitChanges();
            }
        }
    }
}
