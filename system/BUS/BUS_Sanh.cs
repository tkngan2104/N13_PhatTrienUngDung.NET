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
    public class BUS_Sanh
    {
        //Khai báo biến tĩnh.
        private static BUS_Sanh instance;
        private DAL_Sanh dal_s = new DAL_Sanh();

        public static BUS_Sanh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Sanh();
                }
                return instance;
            }
        }

        /// <summary>
        /// Mã sảnh tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            return dal_s.TaoMaTuDong();
        }

        /// <summary>
        /// Danh sách sảnh.
        /// </summary>
        /// <param name="dgvDSP"></param>
        public void DSSanh(DataGridView dgvDSP)
        {
            // Gán DataSource cho DataGridView
            dgvDSP.DataSource = dal_s.DSSanh();
        }

        /// <summary>
        /// Thêm sảnh.
        /// </summary>
        /// <param name="etS"></param>
        public void ThemSanh(ET_Sanh etS)
        {
            if (dal_s.ThemSanh(etS) == true)
            {
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa sảnh.
        /// </summary>
        /// <param name="dgvDSS"></param>
        public void XoaSanh(DataGridView dgvDSS)
        {
            if (dal_s.XoaSanh(dgvDSS.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đang được đối chiếu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa sảnh.
        /// </summary>
        /// <param name="etS"></param>
        public void SuaSanh(ET_Sanh etS)
        {
            dal_s.SuaSanh(etS);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Đổ dữ liệu sảnh.
        /// </summary>
        /// <param name="cbo"></param>
        public void DSSanhCombobox(ComboBox cbo)
        {
            cbo.DataSource = dal_s.DSSanhCombobox(cbo);
            cbo.DisplayMember = "tenS";
            cbo.ValueMember = "maS";
        }

        /// <summary>
        /// Lấy giá sảnh theo mã.
        /// </summary>
        /// <param name="maS"></param>
        /// <returns></returns>
        public float LayGiaSTheoMa(string maS)
        {
            return dal_s.LayGiaSTheoMa(maS);
        }
    }
}