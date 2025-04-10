using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MonAn
    {
        QLResortDataContext db = new QLResortDataContext();

        public DataTable LayDSLoaiMonAn()
        {
            var query = from l in db.LoaiMonAns
                        select new
                        {
                            maLMA = l.maLMA,
                            tenLMA = l.tenLMA
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("maLMA", typeof(string));
            dt.Columns.Add("tenLMA", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.maLMA, item.tenLMA);
            }

            return dt;
        }




        public DataTable loadDSMA()
        {
            var query = from ma in db.MonAns
                        select new
                        {
                            maMA = ma.maMA,
                            maLMA = ma.maLMA,
                            tenMA = ma.tenMA,
                            giaTien = ma.giaTien,
                            mieuTa = ma.mieuTa
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("maMA", typeof(string));
            dt.Columns.Add("maLMA", typeof(string));
            dt.Columns.Add("tenMA", typeof(string));
            dt.Columns.Add("giaTien", typeof(decimal));
            dt.Columns.Add("mieuTa", typeof(string));

            foreach (var item in query)
            {
                dt.Rows.Add(item.maMA, item.maLMA, item.tenMA, item.giaTien, item.mieuTa);
            }

            return dt;
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
                throw new Exception("Không thể thêm món ăn: " + ex.Message);
            }
            finally
            {
                db.SubmitChanges(); // chỉ gọi nếu không có lỗi
            }

        }

        public bool xoaMA(string ma)
        {
            bool kt = false;
            var xoa = db.MonAns.Where(d => d.maMA == ma).FirstOrDefault();
            if (xoa == null)
            {
                return kt;

            }
            else
            {
                db.MonAns.DeleteOnSubmit(xoa);
                db.SubmitChanges();
                return kt = true;
            }
            return kt;
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

        public string taoMaTuDong()
        {
            var maCuoi = db.MonAns
                .OrderByDescending(d => d.maMA)
                .Select(d => d.maMA)
                .FirstOrDefault();

            if (maCuoi == null)
                return "MA01";

            int so = int.Parse(maCuoi.Substring(2)) + 1;
            return "MA" + so.ToString("D2");
        }
    }
}
