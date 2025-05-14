using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class DAL_LoaiMonAn
    {
        QLResortDataContext db = new QLResortDataContext();

        //Lấy danh sách loại món ăn
        public IQueryable layDSLMA()
        {
            return db.LoaiMonAns.OrderByDescending(k => k.maLMA);
        }

        //thêm loại món ăn vào danh sách
        public bool themLoaiMonAn(ET_LoaiMonAn et)
        {
            try
            {
                LoaiMonAn lma = new LoaiMonAn
                {
                    maLMA = et.MaLMA,
                    tenLMA = et.TenLMA
                };
                db.LoaiMonAns.InsertOnSubmit(lma);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Tạo mã tự động tăng
        /// </summary>
        /// <returns></returns>
        public string TaoMaLMA()
        {
            var last = db.LoaiMonAns
                         .OrderByDescending(x => x.maLMA)
                         .Select(x => x.maLMA)
                         .FirstOrDefault();

            if (string.IsNullOrEmpty(last))
                return "LMA01";

            // Giả sử mã là dạng LMA01, LMA02,...
            int so = int.Parse(last.Substring(3)) + 1;
            return "LMA" + so.ToString("D2"); // giữ 2 chữ số
        }

        //xoá loại món ăn ra khỏi danh sách
        public bool xoaLoaiMonAn(string maLMA)
        {
            try
            {
                var item = db.LoaiMonAns.FirstOrDefault(x => x.maLMA == maLMA);
                if (item != null)
                {
                    db.LoaiMonAns.DeleteOnSubmit(item);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

        //sửa loại món ăn
        public bool SuaLoaiMonAn(ET_LoaiMonAn lma)
        {
            try
            {
                var item = db.LoaiMonAns.FirstOrDefault(x => x.maLMA == lma.MaLMA);
                if (item != null)
                {
                    item.tenLMA = lma.TenLMA;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
    }
}
