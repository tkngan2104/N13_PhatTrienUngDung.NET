using ET;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
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
            var xoa = db.MonAns.Where(d => d.maMA == ma).FirstOrDefault();
            if (xoa == null)
            {
                return false;  // Không tìm thấy món ăn để xóa, trả về false
            }
            else
            {
                db.MonAns.DeleteOnSubmit(xoa);  // Xóa món ăn
                db.SubmitChanges();  // Áp dụng thay đổi vào cơ sở dữ liệu
                return true;  // Trả về true sau khi xóa thành công
            }
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

        public string TaoMaTuDong(string maMA)
        {
            string loaiLower = maMA.Trim().ToLower();
            string maMonAn;
            switch (loaiLower)
            {
                case "khai vị":
                    maMonAn = "MAK";
                    break;
                case "món chính":
                    maMonAn = "MAC";
                    break;
                case "tráng miệng":
                    maMonAn = "MAT";
                    break;
                case "đồ uống":
                    maMonAn = "MAD";
                    break;
                default:
                    maMonAn = "MA";
                    break;
            }

            int countMaM = db.MonAns.Count(m => m.maMA.StartsWith(maMonAn)) + 1; ;

            string newMa;
            do
            {
                if (countMaM < 10)
                {
                    newMa = $"{maMonAn}0{countMaM}";
                }               
                else
                {
                    newMa = $"{maMonAn}{countMaM}";
                }

                countMaM++;

            } while (db.MonAns.Any(p => p.maMA == newMa));

            return newMa;
        }

        public string GetLoaiMonAnFromMaMA(string maMA)
        {
            string loaiMonAn = "";

            // Lấy loại món ăn từ cơ sở dữ liệu (ví dụ: từ db.MonAns)
            var monAn = db.MonAns.FirstOrDefault(m => m.maMA == maMA);

            if (monAn != null)
            {
                // Dựa vào thông tin từ database, xác định loại món ăn
                if (monAn.maMA.StartsWith("MAK"))
                    loaiMonAn = "khai vị";
                else if (monAn.maMA.StartsWith("MAC"))
                    loaiMonAn = "món chính";
                else if (monAn.maMA.StartsWith("MAT"))
                    loaiMonAn = "tráng miệng";
                else if (monAn.maMA.StartsWith("MAD"))
                    loaiMonAn = "đồ uống";
            }

            return loaiMonAn;
        }

        public List<string> LayMonAnTheoTen()
        {
            
            return db.MonAns.Select(m => m.tenMA).ToList();

        }

        public List<ET_MonAn> LayTatCaMonAn()
        {
            return db.MonAns.Select(ma => new ET_MonAn
            {
                MaMA = ma.maMA,
                MaLMA = ma.maLMA,
                TenMA = ma.tenMA,
                GiaTien = (float)ma.giaTien,
                MieuTa = ma.mieuTa
            }).ToList();
        }
    }
}
