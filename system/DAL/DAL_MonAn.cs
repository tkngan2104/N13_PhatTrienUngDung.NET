using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MonAn
    {
        QLResortDataContext db = new QLResortDataContext();
        public IQueryable loadDSMA()
        {
            IQueryable monAn = from ma in db.MonAns
                               select ma;
            return monAn;
        }



        public bool themMA(ET_MonAn et)
        {
            try
            {
                MonAn ma = new MonAn
                {
                    maMA = et.MaMA,
                    maLMA = et.MaLMA,
                    tenMA = et.TenMA,
                    giaTien = et.GiaTien,
                    mieuTa = et.MieuTa
                };
                db.MonAns.InsertOnSubmit(ma);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm món ăn: " + ex.Message);
                return false;
            }

        }

        public bool xoaMA(ET_MonAn et)
        {
            bool flag = false;
            if (et.MaMA == "")
            {
                throw new Exception("Vui lòng chọn mã chức vụ để xóa!");
            }
            var xoa = from ma in db.MonAns
                      where ma.maMA == et.MaMA
                      select ma;
            foreach (var x in xoa)
            {
                db.MonAns.DeleteOnSubmit(x);
                db.SubmitChanges();
                flag = true;
            }
            return flag;
        }

        public bool suaMA(ET_MonAn et)
        {
            bool flag = false;
            try
            {
                var sua = db.MonAns.Single(ma => ma.maMA == et.MaMA);
                sua.maLMA = et.MaLMA;
                sua.tenMA = et.TenMA;
                sua.giaTien = et.GiaTien;
                sua.mieuTa = et.MieuTa;
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
