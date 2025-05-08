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

        /// <summary>
        /// Thêm nhân viên.
        /// </summary>
        /// <param name="etNV"></param>
        public void ThemNhanVien(ET_NhanVien etNV)
        {
            if (dal_nv.ThemNhanVien(etNV) == true)
            {
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa nhân viên.
        /// </summary>
        /// <param name="dgvDSS"></param>
        public void XoaNhanVien(DataGridView dgvDSS)
        {
            if (dal_nv.XoaNhanVien(dgvDSS.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đang được đối chiếu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa nhân viên.
        /// </summary>
        /// <param name="etNV"></param>
        public void SuaNhanVien(ET_NhanVien etNV)
        {
            dal_nv.SuaNhanVien(etNV);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Bắt lỗi trùng email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool KiemTraEmailTonTai(string emailMoi, string emailCuu)
        {
            return dal_nv.KiemTraEmailTonTai(emailMoi, emailCuu);
        }

        /// <summary>
        /// Bắt lỗi trùng cccd.
        /// </summary>
        /// <param name="cccd"></param>
        /// <returns></returns>
        public bool KiemTraCCCDTonTai(string cccd)
        {
            return dal_nv.KiemTraCCCDTonTai(cccd);
        }

        /// <summary>
        /// Bắt lỗi trùng điện thoại.
        /// </summary>
        /// <param name="sdt"></param>
        /// <returns></returns>
        public bool KiemTraSDTTonTai(string sdt)
        {
            return dal_nv.KiemTraSDTTonTai(sdt);
        }
    }
}
