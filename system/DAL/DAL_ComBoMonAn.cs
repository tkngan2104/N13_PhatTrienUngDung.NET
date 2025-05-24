using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DAL_ComBoMonAn
    {
        private QLResortDataContext db = new QLResortDataContext(Connection_DAL.ConnectionString);
        // Load danh sách tất cả combo
        public IQueryable GetAllCombo()
        {
            var comboMonAN = from cb in db.ComboMonAns
                             select cb;
            return comboMonAN;
        }
        // Lấy danh sách món ăn trong một combo
        public IQueryable LayMonAnTheoCombo(string maCB)
        {
            var result = from ct in db.ChiTietCombos
                         where ct.maCB == maCB
                         select ct.MonAn;

            return result;
        }
        public string TaoMaComboTuDong()
        {
            int count = db.ComboMonAns.Count() + 1;
            string newMa;

            do
            {
                if (count < 10)
                    newMa = $"CB0000{count}";
                else if (count < 100)
                    newMa = $"CB000{count}";
                else if (count < 1000)
                    newMa = $"CB00{count}";
                else if (count < 10000)
                    newMa = $"CB0{count}";
                else
                    newMa = $"CB{count}";

                count++;
            }
            while (db.ComboMonAns.Any(cb => cb.maCB == newMa));

            return newMa;
        }

        public bool ThemCBMA(ET_ComBoMonAn et)
        {
            try
            {
                //Tạo một đối tượng mới.
                ComboMonAn cbma = new ComboMonAn
                {
                    maCB = et.MaCB,
                    tenCB = et.TenCB,
                    giaCB = et.GiaCB,
                };
                //Thêm loại hàng vào cơ sở dữ liệu
                db.ComboMonAns.InsertOnSubmit(cbma);
            }
            finally
            {
                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
            }
            // Trả về true để báo hiệu việc thêm mới thành công
            return true;
        }

        public bool xoaComboMonAn(string ma)
        {
            var xoa = db.ComboMonAns.Where(d => d.maCB == ma).FirstOrDefault();
            if (xoa == null)
            {
                return false;  // Không tìm thấy món ăn để xóa, trả về false
            }
            else
            {
                db.ComboMonAns.DeleteOnSubmit(xoa);  // Xóa món ăn
                db.SubmitChanges();  // Áp dụng thay đổi vào cơ sở dữ liệu
                return true;  // Trả về true sau khi xóa thành công
            }
        }
    }
}
