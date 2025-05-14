using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;


namespace BUS
{
    public class BUS_ChiTietComBo
    {
        DAL_ChiTietComBo dal = new DAL_ChiTietComBo();

        public string TaoMaChiTietComboTuDong()
        {
            return dal.TaoMaChiTietComboTuDong();
        }

        public bool themCTCB(ET_ChiTietComBo et)
        {
            return dal.ThemCTCB(et);
        }
        public string TaoMaTam(List<ET_ChiTietComBo> danhSachTam)
        {
            string maCuoiDB = dal.TaoMaChiTietComboTuDong(); // Lấy mã mới từ DB như cũ
            string prefix = maCuoiDB.Substring(0, 10);
            int soDB = int.Parse(maCuoiDB.Substring(10));

            int soMax = soDB;

            // Kiểm tra mã trong danh sách tạm
            foreach (var item in danhSachTam)
            {
                if (item.MaCTCB.StartsWith(prefix))
                {
                    string soStr = item.MaCTCB.Substring(10);
                    if (int.TryParse(soStr, out int soTam))
                    {
                        if (soTam >= soMax)
                        {
                            soMax = soTam + 1;
                        }
                    }
                }
            }
            string newMa = $"{prefix}{soMax:D3}";

            return newMa;
        }

        public bool XoaChiTietTheoMaCB(string maCB)
        {
            return dal.XoaChiTietTheoMaCB(maCB);
        }
    }
}
