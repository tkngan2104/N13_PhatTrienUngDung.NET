using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;

namespace BUS
{
    public class BUS_Phong
    {
        //Khai báo biến tĩnh.
        private static BUS_Phong instance;
        private DAL_Phong dal_p = new DAL_Phong();

        public static BUS_Phong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_Phong();
                }
                return instance;
            }
        }

        /// <summary>
        /// Đổ dữ liệu loại phòng.
        /// </summary>
        /// <param name="cbo"></param>
        public void DSPhongCombobox(ComboBox cbo)
        {
            cbo.DataSource = DAL_Phong.Instance.DSPhongCombobox(cbo);
            cbo.DisplayMember = "tenLP";
            cbo.ValueMember = "tenLP";
        }

        /// <summary>
        /// Đổ dữ liệu loại giường.
        /// </summary>
        /// <param name="cbo"></param>
        public void DSGiuongCombobox(ComboBox cbo)
        {
            cbo.DataSource = DAL_Phong.Instance.DSGiuongCombobox(cbo);
            cbo.DisplayMember = "tenLG";
            cbo.ValueMember = "tenLG";
        }

        /// <summary>
        /// Đổ dữ liệu trạng thái.
        /// </summary>
        /// <param name="cbo"></param>
        public void DSTrangThaiCombobox(ComboBox cbo)
        {
            cbo.DataSource = DAL_Phong.Instance.DSTrangThaiCombobox(cbo);
            cbo.DisplayMember = "trangThai";
            cbo.ValueMember = "trangThai";
        }

        /// <summary>
        /// Mã phòng tự động.
        /// </summary>
        /// <param name="loaiPhong"></param>
        /// <returns></returns>
        public string TaoMaTuDong(string loaiPhong)
        {
            return dal_p.TaoMaTuDong(loaiPhong);
        }

        /// <summary>
        /// Lấy danh sách phòng.
        /// </summary>
        /// <returns></returns>
        public string LayMaPhong()
        {
            return dal_p.LayMaPhong();
        }

        /// <summary>
        /// Danh sách phòng.
        /// </summary>
        /// <param name="dgvDSP"></param>
        public void DSPhong(DataGridView dgvDSP, string tenLP, string tenLG)
        {
            // Gán DataSource cho DataGridView
            dgvDSP.DataSource = dal_p.DSPhong(tenLP, tenLG);
        }

        /// <summary>
        /// Thêm phòng.
        /// </summary>
        /// <param name="etP"></param>
        public void ThemPhong(ET_Phong etP)
        {
            if (dal_p.ThemPhong(etP) == true)
            {
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa phòng.
        /// </summary>
        /// <param name="dgvDSP"></param>
        public void XoaPhong(DataGridView dgvDSP)
        {
            if (dal_p.XoaPhong(dgvDSP.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đang được đối chiếu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa phòng.
        /// </summary>
        /// <param name="etP"></param>
        public void SuaPhong(ET_Phong etP)
        {
            dal_p.SuaPhong(etP);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
