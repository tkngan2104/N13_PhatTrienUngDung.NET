using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThongKeSuDungDichVu
    {
        //Khai báo biến tĩnh.
        private static BUS_ThongKeSuDungDichVu instance;
        private DAL_ThongKeSuDungDichVu dal_sddv = new DAL_ThongKeSuDungDichVu();

        public static BUS_ThongKeSuDungDichVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ThongKeSuDungDichVu();
                }
                return instance;
            }
        }

        /// <summary>
        /// Thống kê dịch vụ theo tháng.
        /// </summary>
        /// <param name="thang"></param>
        /// <param name="nam"></param>
        /// <returns></returns>
        public List<ET_ThongKeSuDungDichVu> ThongKeDichVuTheoThang(int thang, int nam)
        {
            return dal_sddv.ThongKeDichVuTheoThang(thang, nam);
        }

        /// <summary>
        /// Thống kê dịch vụ theo năm.
        /// </summary>
        /// <param name="nam"></param>
        /// <returns></returns>
        public List<ET_ThongKeSuDungDichVu> ThongKeDichVuTheoNam(int nam)
        {
            return dal_sddv.ThongKeDichVuTheoNam(nam);
        }
    }
}
