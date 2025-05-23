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

        /// <summary>
        /// Thống kê đặt tiệc theo ngày.
        /// </summary>
        /// <param name="tuNgay"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoNgay(DateTime tuNgay)
        {
            return dal_dt.ThongKeDatTiecTheoNgay(tuNgay);
        }

        /// <summary>
        /// Thống kê đặt tiệc theo tháng.
        /// </summary>
        /// <param name="nam"></param>
        /// <param name="thang"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoThang(int nam, int thang)
        {
            return dal_dt.ThongKeDatTiecTheoThang(nam, thang);
        }

        /// <summary>
        /// Thống kê đặt tiệc theo năm.
        /// </summary>
        /// <param name="nam"></param>
        /// <returns></returns>
        public List<ET_ThongKeDatTiec> ThongKeDatTiecTheoNam(int nam)
        {
            return dal_dt.ThongKeDatTiecTheoNam(nam);
        }
    }
}
