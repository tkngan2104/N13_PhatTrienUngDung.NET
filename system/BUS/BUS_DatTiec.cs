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
    public class BUS_DatTiec
    {
        //Khai báo biến tĩnh.
        private static BUS_DatTiec instance;
        private DAL_DatTiec dal_dt = new DAL_DatTiec();

        public static BUS_DatTiec Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_DatTiec();
                }
                return instance;
            }
        }

        /// <summary>
        /// Mã đặc tiệc tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            return dal_dt.TaoMaTuDong();
        }
        /// <summary>
        /// lấy danh sách đặt tiệc
        /// </summary>
        /// <returns></returns>
        public IQueryable layDSDT()
        {
            return dal_dt.DSDatTiec();
        }
        /// <summary>
        /// Danh sách đặt tiệc.
        /// </summary>
        /// <param name="dgvDDT"></param>
        public void DSDatTiec(DataGridView dgvDDT)
        {
            // Gán DataSource cho DataGridView
            dgvDDT.DataSource = dal_dt.DSDatTiec();
        }

        /// <summary>
        /// Thêm đặt tiệc.
        /// </summary>
        /// <param name="et"></param>
        public void ThemDatTiec(ET_DatTiec et)
        {
            if (dal_dt.ThemDatTiec(et))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa đặt tiệc.
        /// </summary>
        /// <param name="dgv"></param>
        public void XoaDatTiec(DataGridView dgv)
        {
            string ma = dgv.CurrentRow.Cells[0].Value.ToString();
            if (dal_dt.XoaDatTiec(ma))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa đặt tiệc.
        /// </summary>
        /// <param name="et"></param>
        public void SuaDatTiec(ET_DatTiec et)
        {
            dal_dt.SuaDatTiec(et);
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
