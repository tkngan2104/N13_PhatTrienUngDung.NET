using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_ThanhToanDatTiec
    {
        QLResortDataContext db =new QLResortDataContext();
        public IQueryable<ET_HoaDonDatTiec> TimKiemTheoSDTKhach(string soDienThoai)
        {
            var query = from dt in db.DatTiecs
                        join kh in db.KhachHangs on dt.MaKH equals kh.MaKH
                        join hd in db.HoaDonDatTiecs on dt.maDT equals hd.maDT into hdGroup
                        from hd in hdGroup.DefaultIfEmpty()
                        where kh.SoDT.Trim() == soDienThoai.Trim()
                        select new ET_HoaDonDatTiec(
                            dt.MaNhanSu,
                            hd != null ? hd.maHDDT : null,
                            dt.maDT,
                            hd != null ? hd.trangThai : "Chưa thanh toán",
                            dt.ngayDT,
                            (float)(dt.tongTien)
                        );

            return query;
        }

        public bool thanhToan(ET_HoaDonDatTiec hd)
        {
            try
            {
                var hoaDonCu = db.HoaDonDatTiecs.FirstOrDefault(hdOld => hdOld.maDT == hd.MaDT);

                if (hoaDonCu != null)
                {
                    hoaDonCu.trangThai = "Đã thanh toán";
                    hoaDonCu.ngayLap = hd.NgayLap;
                    hoaDonCu.tongTien = (float)hd.TongTien;
                    hoaDonCu.MaNhanSu = hd.MaNS;
                }
                else
                {
                    // Tạo mã hóa đơn mới nếu chưa có
                    if (string.IsNullOrEmpty(hd.MaHDDT))
                    {
                        hd.MaHDDT = TaoMaHDDT_TuDong();
                    }

                    var hoaDonMoi = new HoaDonDatTiec
                    {
                        maHDDT = hd.MaHDDT,
                        MaNhanSu = hd.MaNS,
                        maDT = hd.MaDT,
                        trangThai = "Đã thanh toán",
                        ngayLap = hd.NgayLap,
                        tongTien = (float)hd.TongTien
                    };

                    db.HoaDonDatTiecs.InsertOnSubmit(hoaDonMoi);
                }

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            // Lấy mã HDDT lớn nhất hiện tại trong database
            var maxMaHDDT = db.HoaDonDatTiecs
                              .OrderByDescending(hd => hd.maHDDT)
                              .Select(hd => hd.maHDDT)
                              .FirstOrDefault();

            if (string.IsNullOrEmpty(maxMaHDDT))
            {
                // Nếu chưa có mã nào thì tạo mã đầu tiên
                return "HDDT00000001";
            }

            // Lấy phần số của mã (bỏ "HDDT")
            string numberPart = maxMaHDDT.Substring(4);

            // Chuyển sang int và cộng 1
            int number = int.Parse(numberPart);
            number += 1;

            // Tạo lại mã mới với định dạng 8 số, ví dụ HDDT00000002
            return "HDDT" + number.ToString("D8");
        }





    }
}
