using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThongKeDatPhong
    {
        private static BUS_ThongKeDatPhong instance;
        private DAL_ThongKeDatPhong dal_dp = new DAL_ThongKeDatPhong();

        public static BUS_ThongKeDatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ThongKeDatPhong();
                }
                return instance;
            }
        }
        public List<ET_ThongKeDatPhong> ThongKeDatPhongTheoNgay(DateTime tuNgay)
        {
            return dal_dp.ThongKeDatPhongTheoNgay(tuNgay);
        }

        public List<ET_ThongKeDatPhong> ThongKeDatPhongTheoThang(int nam, int thang)
        {
            return dal_dp.ThongKeDatPhongTheoThang(nam, thang);
        }

        public List<ET_ThongKeDatPhong> ThongKeDatPhongTheoNam(int nam)
        {
            return dal_dp.ThongKeDatPhongTheoNam(nam);
        }
    }
}
