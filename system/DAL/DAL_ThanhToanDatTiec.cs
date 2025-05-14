using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThanhToanDatTiec
    {
        QLResortDataContext db =new QLResortDataContext();
        public IQueryable<ET_HoaDonDatTiec> TimKiemTheoSDTKhach(string soDienThoai)
        {
            var query = from dt in db.DatTiecs
                        join kh in db.KhachHangs on dt.MaKH equals kh.MaKH
                        where kh.SoDT.Trim() == soDienThoai.Trim() 
                        select new ET_HoaDonDatTiec(
                            null, 
                            null, 
                            dt.maDT, 
                            null, 
                            dt.ngayDT, 
                            (float)(dt.tongTien)
                        );

            return query;
        }
        public IQueryable<ET_DatTiec> LayDatTiecTheoMaDT(string maDT)
        {
            var query = from dt in db.DatTiecs
                        join kh in db.KhachHangs on dt.MaKH equals kh.MaKH
                        where dt.maDT == maDT // Lấy đặt tiệc theo mã đặt tiệc
                        select new ET_DatTiec(
                            dt.MaNhanSu,           // Mã nhân sự
                            dt.maDT,               // Mã đặt tiệc
                            dt.MaKH,               // Mã khách hàng
                            dt.maS,                // Mã S (chưa rõ thông tin)
                            dt.ghiChu,             // Ghi chú
                            dt.ngayDT,       // Ngày đặt tiệc (chắc chắn không null)
                            dt.ngayBatDau,   // Ngày bắt đầu (chắc chắn không null)
                            dt.ngayKetThuc.Value,  // Ngày kết thúc (chắc chắn không null)
                            (float)(dt.tongTien), // Tổng tiền, nếu null thì 0.0
                            (float)(dt.giaTriDC)  // Giá trị giảm giá, nếu null thì 0.0
                        );

            return query;
        }

        public string TaoMaHDDT_TuDong()
        {
            return "HDDT" + DateTime.Now.ToString("yyyyMMddHHmmss"); // VD: HDDT20250511153000
        }

    }
}
