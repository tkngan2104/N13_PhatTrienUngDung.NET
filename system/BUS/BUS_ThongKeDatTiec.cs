using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThongKeDatTiec
    {
        //Khai báo biến tĩnh.
        private static BUS_ThongKeDatTiec instance;
        private DAL_ThongKeDatTiec dal_dt = new DAL_ThongKeDatTiec();

        public static BUS_ThongKeDatTiec Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ThongKeDatTiec();
                }
                return instance;
            }
        }

        public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoNgay(DateTime tuNgay)
        {
            return dal_dt.ThongKeDatTiecTheoNgay(tuNgay);
        }
    }
}
