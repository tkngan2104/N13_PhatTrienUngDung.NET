using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_ChiTietDatTiec
    {
        private QLResortDataContext db = new QLResortDataContext(Connection_DAL.ConnectionString);
        public IQueryable layDSCTDT()
        {
            var result = from ct in db.ChiTiecDatTiecs
                         join cb in db.ComboMonAns on ct.maCB equals cb.maCB into comboGroup
                         from cb in comboGroup.DefaultIfEmpty()

                         join ma in db.MonAns on ct.maMA equals ma.maMA into monAnGroup
                         from ma in monAnGroup.DefaultIfEmpty()

                         orderby ct.maCTDT descending
                         select new
                         {
                             ct.maCTDT,
                             ct.maDT,
                             ct.maMA,
                             tenMA = ma != null ? ma.tenMA : "(Không có)",
                             ct.soLuong,
                             ct.maCB,
                             tenCB = cb != null ? cb.tenCB : "(Không có)"
                         };

            return result;
        }
        // Hàm thêm chi tiết đặt tiệc
        // Thêm chi tiết đặt tiệc
        public bool themChiTietDatTiec(ET_ChiTiecDatTiec et)
        {
            bool flag = false;
            try
            {
                ChiTiecDatTiec ctDatTiec = new ChiTiecDatTiec
                {
                    maCTDT = et.MaCTDT,
                    maDT = et.MaDT,
                    maMA = et.MaMA,
                    soLuong = et.SoLuong,
                    maCB = et.MaCB
                };

                db.ChiTiecDatTiecs.InsertOnSubmit(ctDatTiec);
                db.SubmitChanges(); // Lưu vào cơ sở dữ liệu

                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }

        // Xoá chi tiết đặt tiệc theo mã CTDT
        public bool XoaChiTietDatTiec(string maChiTiet)
        {
            try
            {
                var ct = db.ChiTiecDatTiecs.SingleOrDefault(c => c.maCTDT == maChiTiet);
                if (ct != null)
                {
                    db.ChiTiecDatTiecs.DeleteOnSubmit(ct);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // log lỗi nếu cần
            }
            return false;
        }

        // Sửa chi tiết đặt tiệc
        public bool suaChiTietDatTiec(ET_ChiTiecDatTiec et)
        {
            var ctDatTiec = db.ChiTiecDatTiecs.SingleOrDefault(ct => ct.maCTDT == et.MaCTDT);
            if (ctDatTiec != null)
            {
                ctDatTiec.maDT = et.MaDT;
                ctDatTiec.maMA = et.MaMA;
                ctDatTiec.soLuong = et.SoLuong;
                ctDatTiec.maCB = et.MaCB;

                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public string TaoMaCTDT()
        {
            var ctdtCuoi = db.ChiTiecDatTiecs
                             .OrderByDescending(c => c.maCTDT)
                             .Select(c => c.maCTDT)
                             .FirstOrDefault();

            if (ctdtCuoi == null) return "CTDT0001";  // Nếu chưa có mã nào, trả về mã đầu tiên

            // Bỏ phần "CTDT" để lấy số
            string soCtdtCuoiStr = ctdtCuoi.Substring(4);  // Cắt phần "CTDT" chỉ lấy số

            // Chuyển sang số, tăng 1
            int so = int.Parse(soCtdtCuoiStr) + 1;

            // Ghép lại mã mới với 4 chữ số
            return "CTDT" + so.ToString("D4"); // D4: luôn có 4 chữ số, thêm số 0 phía trước nếu cần
        }
    }
}
