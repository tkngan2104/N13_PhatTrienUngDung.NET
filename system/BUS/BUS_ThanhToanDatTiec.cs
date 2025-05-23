using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThanhToanDatTiec
    {
        private readonly DAL_ThanhToanDatTiec dal = new DAL_ThanhToanDatTiec();
        public IQueryable<ET_HoaDonDatTiec> timSDT(string sdt)
        {
            return dal.TimKiemTheoSDTKhach(sdt);
        }
        public IQueryable<ET_DatTiec> LayDTTheoMa(string maDT)
        {
            return dal.LayDatTiecTheoMaDT(maDT);
        }
        public string taoMTD()
        {
            return dal.TaoMaHDDT_TuDong();
        }

        public bool ThanhToan(ET_HoaDonDatTiec hd)
        {
            return dal.thanhToan(hd);
        }


    }
}
