using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChucVu
    {
        QLResortDataContext db = new QLResortDataContext();
        public IQueryable loadDSCV()
        {
            IQueryable chucVu = from cv in db.ChucVus
                                select cv;
            return chucVu;
        }
        public string taoMaTuDong()
        {
            var maCuoi = db.ChucVus
                .OrderByDescending(d => d.MaChucVu)
                .Select(d => d.MaChucVu)
                .FirstOrDefault();

            if (maCuoi == null)
                return "CV001";

            int so = int.Parse(maCuoi.Substring(2)) + 1;
            return "CV" + so.ToString("D3");
        }

        public bool themCV(ET_ChucVu et)
        {
            try
            {
                ChucVu cv = new ChucVu
                {
                    MaChucVu = et.MaChucVu,
                    TenChucVu = et.TenChucVu
                };
                db.ChucVus.InsertOnSubmit(cv);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể thêm chức vụ: " + ex.Message);
            }
            finally
            {
                db.SubmitChanges(); // chỉ gọi nếu không có lỗi
            }
        }
        public bool xoaCV(string ma)
        {
            bool kt = false;
            var xoa = db.ChucVus.Where(d => d.MaChucVu == ma).FirstOrDefault();
            if (xoa == null)
            {
                return kt;

            }
            else
            {
                db.ChucVus.DeleteOnSubmit(xoa);
                db.SubmitChanges();
                return kt =true;
            }
            return kt;       
        }

        public bool suaCV(ET_ChucVu et)
        {
            bool flag = false;
            try
            {
                var sua = db.ChucVus.Single(cv => cv.MaChucVu == et.MaChucVu);
                sua.TenChucVu = et.TenChucVu;
                db.SubmitChanges();
                flag = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Khong sua duoc: " + ex.Message);
            }
            return flag;
        }
    }
}
