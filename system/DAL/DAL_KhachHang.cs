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

        public bool suaKhachHang(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                var sua = db.KhachHangs.SingleOrDefault(k => k.MaKH == et.MaKH);
                if (sua != null)
                {
                    //Cập nhật các trường
                    sua.TenKH = et.TenKH;
                    sua.SoDT = et.SoDT;
                    sua.GioiTinh = et.GioiTinh;
                    sua.Email = et.Email;
                    sua.CCCD = et.Cccd;
                    sua.QuocTich = et.QuocTich;
                    db.SubmitChanges();
                    flag |= true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: "+ex);
            }

            return flag;
        }
    }
}
