using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ComBoMonAn
    {
        DAL_ComBoMonAn dal = new DAL_ComBoMonAn();

        public IQueryable LayTatCaCombo()
        {
            return dal.GetAllCombo();
        }
        public bool themCBMA(ET_ComBoMonAn et)
        {
            return dal.ThemCBMA(et);
        }
        public IQueryable LayMonAnTheoCombo(string maCB)
        {
            return dal.LayMonAnTheoCombo(maCB);
        }

        public string TaoMaComboMoi()
        {
            return dal.TaoMaComboTuDong();
        }

        public bool xoaComboMonAn(string ma)
        {
            return dal.xoaComboMonAn(ma);
        }
    }
}
