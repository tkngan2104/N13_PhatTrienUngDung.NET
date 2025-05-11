using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        //kết nối dữ liệu db
        QLResortDataContext db = new QLResortDataContext();

        //Lấy danh sách khách hàng
        public IQueryable layDSKH()
        {
            IQueryable kh = from el in db.KhachHangs
                            select el;
            return kh;
        }

        //Xoá khách hàng
        public bool xoaKhachHang(ET_KhachHang et)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(et.MaKH))
            {
                throw new Exception("Vui lòng chọn mã khách hàng để xóa!");
            }

            if (et.MaKH == null)
            {
                throw new Exception("Không tìm thấy khách hàng với mã: "+ et.MaKH);
            }
            var xoa = db.KhachHangs.SingleOrDefault(kh => kh.MaKH == et.MaKH);
            
                db.KhachHangs.DeleteOnSubmit(xoa);
                db.SubmitChanges();
                flag = true;
           
            return flag;
            
        }
        public bool xoaKhachHang(string maKH)
        {
            try
            {
                var kh = db.KhachHangs.SingleOrDefault(k => k.MaKH == maKH);
                if (kh != null)
                {
                    db.KhachHangs.DeleteOnSubmit(kh);
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

        //Thêm khách hàng
        public bool themKhachHang(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                KhachHang kh = new KhachHang
                {
                    MaKH = et.MaKH,
                    TenKH = et.TenKH,
                    SoDT = et.SoDT,
                    NgaySinh = et.NgaySinh,
                    GioiTinh = et.GioiTinh,
                    Diachi = et.DiaChi,
                    Email = et.Email,
                    CCCD = et.Cccd,
                    QuocTich = et.QuocTich
                };
                db.KhachHangs.InsertOnSubmit(kh);

            }
            finally
            {
                db.SubmitChanges();
                flag = true;
            };
            return flag;
        }
       

        //Mã khách hàng tăng tự động
        public string TaoMaKH()
        {
            var khCuoi = db.KhachHangs
                           .OrderByDescending(k => k.MaKH)
                           .Select(k => k.MaKH)
                           .FirstOrDefault();

            if (khCuoi == null) return "KH0001";

            // Bỏ phần "KH" để lấy số
            string soKhCuoiStr = khCuoi.Substring(2);

            // Chuyển sang số, tăng 1
            int so = int.Parse(soKhCuoiStr) + 1;

            // Ghép lại mã mới với 4 chữ số
            return "KH" + so.ToString("D4"); // D4: luôn có 4 chữ số, thêm số 0 phía trước nếu cần
        }

        //sửa khách hàng
        public bool suaKhachHang(ET_KhachHang et)
        {
            if (string.IsNullOrEmpty(et.MaKH))
                throw new Exception("Mã khách hàng không được để trống!");

            var kh = db.KhachHangs.SingleOrDefault(x => x.MaKH == et.MaKH);

            if (kh == null)
                throw new Exception("Không tìm thấy khách hàng để cập nhật!");

            // Cập nhật các thuộc tính
            kh.TenKH = et.TenKH;
            kh.SoDT = et.SoDT;
            kh.NgaySinh = et.NgaySinh;
            kh.GioiTinh = et.GioiTinh;
            kh.Diachi = et.DiaChi;
            kh.Email = et.Email;
            kh.CCCD = et.Cccd;
            kh.QuocTich = et.QuocTich;

            db.SubmitChanges();
            return true;
        }
    }
}
