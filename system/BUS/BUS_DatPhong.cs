using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_DatPhong
    {
        //Khai báo biến tĩnh.
        private static BUS_DatPhong instance;
        private DAL_DatPhong dal_dp = new DAL_DatPhong();

        public static BUS_DatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_DatPhong();
                }
                return instance;
            }
        }

        /// <summary>
        /// Mã đặt phòng tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            return dal_dp.TaoMaTuDong();
        }

        /// <summary>
        /// Danh sách đặt phòng.
        /// </summary>
        /// <param name="dgvDSP"></param>
        public void DSDatPhong(DataGridView dgvDSP)
        {
            // Gán DataSource cho DataGridView
            dgvDSP.DataSource = dal_dp.DSDatPhong();
        }

        /// <summary>
        /// Thêm đặt phòng.
        /// </summary>
        /// <param name="etDP"></param>
        /// <returns></returns>
        public bool ThemDatPhong(ET_DatPhong etDP)
        {
            try
            {
                return dal_dp.ThemDatPhong(etDP);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
