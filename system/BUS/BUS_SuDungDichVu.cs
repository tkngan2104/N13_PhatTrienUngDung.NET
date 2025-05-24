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
    public class BUS_SuDungDichVu
    {
        //Khai báo biến tĩnh.
        private static BUS_SuDungDichVu instance;
        private DAL_SuDungDichVu dal_sddv = new DAL_SuDungDichVu();

        public static BUS_SuDungDichVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_SuDungDichVu();
                }
                return instance;
            }
        }

        /// <summary>
        /// Mã sử dụng dịch vụ tự động.
        /// </summary>
        /// <returns></returns>
        public string TaoMaTuDong()
        {
            return dal_sddv.TaoMaTuDong();
        }

        /// <summary>
        /// Danh sách sử dụng dịch vụ.
        /// </summary>
        /// <param name="dgvDSSDDV"></param>
        public void DSSDDV(DataGridView dgvDSSDDV, string sddv)
        {
            dgvDSSDDV.DataSource = dal_sddv.DSSDDV(sddv);
        }

        /// <summary>
        /// Thêm sử dụng dịch vụ.
        /// </summary>
        /// <param name="etSDDV"></param>
        public void ThemSDDV(ET_SuDungDichVu etSDDV)
        {
            if (dal_sddv.ThemSDDV(etSDDV))
            {
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa sử dụng dịch vụ.
        /// </summary>
        /// <param name="dgvSDDV"></param>
        public void XoaSDDV(DataGridView dgvSDDV)
        {
            if (dal_sddv.XoaSDDV(dgvSDDV.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dữ liệu đang được đối chiếu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa sử dụng dịch vụ.
        /// </summary>
        /// <param name="etSDDV"></param>
        public void SuaSDDV(ET_SuDungDichVu etSDDV)
        {
            if (dal_sddv.SuaSDDV(etSDDV))  // Kiểm tra kết quả từ DAL
            {
                MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không sửa được dữ liệu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
