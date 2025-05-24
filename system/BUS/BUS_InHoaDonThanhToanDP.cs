using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_InHoaDonThanhToanDP
    {
        private static BUS_InHoaDonThanhToanDP instance;
        private DAL_InHoaDonThanhToanDatPhong dal_dp = new DAL_InHoaDonThanhToanDatPhong();

        public static BUS_InHoaDonThanhToanDP Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_InHoaDonThanhToanDP();
                }
                return instance;
            }
        }
        public List<ET_InHoaDonThanhToanDatPhong> LayDanhSachHoaDonDP()
        {
            return dal_dp.InHoaDonThanhToanDP();
        }
    }
}
