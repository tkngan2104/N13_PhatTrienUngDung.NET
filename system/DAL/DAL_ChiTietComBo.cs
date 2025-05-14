using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietComBo
    {
        QLResortDataContext db = new QLResortDataContext();

        //public List<ChiTietCombo> TimTheoTenMonAn(string tenMA)
        //{
        //    List<ChiTietCombo> ds = new List<ChiTietCombo>();

        //    var result = db.sp_TimChiTietComboTheoTenMA(tenMA);

        //    foreach (var item in result)
        //    {
        //        ChiTietCombo ctcb = new ChiTietCombo();
        //        ctcb.maCTCB = item.maCTCB;
        //        ctcb.maCB = item.maCB;
        //        ctcb.maMA = item.maMA;
        //        ds.Add(ctcb);
        //    }

        //    return ds;
        //}
        public string TaoMaChiTietComboTuDong()
        {
            int count = db.ChiTietCombos.Count() + 1;
            string newMa;

            do
            {
                if (count < 10)
                    newMa = $"CTCB00{count}";
                else if (count < 100)
                    newMa = $"CTCB0{count}";
                else
                    newMa = $"CTCB{count}";

                count++;
            }
            while (db.ChiTietCombos.Any(ct => ct.maCTCB == newMa));

            return newMa;
        }

        public bool ThemCTCB(ET_ChiTietComBo etCTCB)
        {
            try
            {
                //Tạo một đối tượng mới.
                ChiTietCombo ctcb = new ChiTietCombo
                {
                    maCTCB = etCTCB.MaCTCB,
                    maCB = etCTCB.MaCB,
                    maMA = etCTCB.MaMA,
                };
                //Thêm loại hàng vào cơ sở dữ liệu
                db.ChiTietCombos.InsertOnSubmit(ctcb);
            }
            finally
            {
                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();
            }
            // Trả về true để báo hiệu việc thêm mới thành công
            return true;
        }
        public List<ET_MonAn> TimMonAnTheoTenGanDung(string keyword)
        {
            var result = db.MonAns
                          .Where(ma => ma.tenMA.StartsWith(keyword))
                          .Select(ma => new ET_MonAn(
                              ma.maMA, ma.maLMA, ma.tenMA, (float)ma.giaTien, ma.mieuTa))
                          .ToList();
            return result;
        }

        public bool XoaChiTietTheoMaCB(string maCB)
        {
            try
            {
                var chiTietList = db.ChiTietCombos.Where(ct => ct.maCB == maCB);
                db.ChiTietCombos.DeleteAllOnSubmit(chiTietList);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
