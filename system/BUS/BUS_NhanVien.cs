using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_NhanVien
    {
        //Khai báo biến tĩnh.
        private static BUS_NhanVien instance;
        private DAL_NhanVien dal_nv = new DAL_NhanVien();

        public static BUS_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_NhanVien();
                }
                return instance;
            }
        }

        public void DSChucVuCombobox(ComboBox cbo)
        {
            cbo.DataSource = DAL_NhanVien.Instance.DSChucVuCombobox(cbo);
            cbo.DisplayMember = "maCV";
            cbo.DisplayMember = "maCV";
        }

        /// <summary>
        /// Mã nhân viên tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            return dal_nv.TaoMaTuDong();
        }

        /// <summary>
        /// Danh sách nhân viên.
        /// </summary>
        /// <param name="dgvDSNV"></param>
        public void DSNhanVien(DataGridView dgvDSNV)
        {
            // Gán DataSource cho DataGridView
            dgvDSNV.DataSource = dal_nv.DSNhanVien();
        }
    }
}
