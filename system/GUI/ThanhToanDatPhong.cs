using BUS;
using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThanhToanDatPhong: Form
    {
        BUS_HoaDonDatPhong bus = new BUS_HoaDonDatPhong();
        QLResortDataContext db = new QLResortDataContext();
        public ThanhToanDatPhong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Btn thanh toán.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int dong = dgvKetQuaTimKiem.CurrentCell.RowIndex;

            string trangThai = dgvKetQuaTimKiem.Rows[dong].Cells["trangThai"].Value?.ToString();

            if (trangThai != null && trangThai.Trim() == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn này đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try 
            {
                float tongTienDichVu = 0;
                foreach (DataGridViewRow row in dgvDSDichVu.Rows)
                {
                    if (row.Cells["tongTien"].Value != null)
                    {
                        tongTienDichVu += float.Parse(row.Cells["tongTien"].Value.ToString());
                    }
                }
                float tienPhong = bus.LayGiaPhong(txtChiTietDP.Text);
                float tongTien = tienPhong + tongTienDichVu;
                txtThanhTien.Text = tongTien.ToString();
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý thanh toán: " + ex.Message);
            }
            
        }

        /// <summary>
        /// Btn thoát.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn đang thoát màn hình ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sdt = txtTimKH.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var danhSach = bus.timSDT(sdt).ToList();

                if (danhSach.Any())
                {
                    dgvKetQuaTimKiem.DataSource = danhSach;
                    //FormatKetQuaTimKiem();  // 👉 Gọi hàm định dạng cột
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hoá đơn cho số điện thoại này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new InHoaDonDatPhong());
        }

        private void dgvKetQuaTimKiem_Click(object sender, EventArgs e)
        {
            int dong = dgvKetQuaTimKiem.CurrentCell.RowIndex;
            txtChiTietDP.Text = dgvKetQuaTimKiem.Rows[dong].Cells[2].Value?.ToString() ?? "";

            try
            {
                string maCTDP = dgvKetQuaTimKiem.Rows[dong].Cells[2].Value?.ToString() ?? "";
                dgvDSDichVu.DataSource = bus.LayDSDichVuTheoMaCTDP(maCTDP);
                txtThanhTien.Text = dgvKetQuaTimKiem.Rows[dong].Cells[6].Value?.ToString() ?? "";
                string maNS = bus.LayMaNhanSuTheoCTDP(maCTDP);
                txtMaNS.Text = maNS ?? "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách dịch vụ: " + ex.Message);
            }
        }

        private void ThanhToanDatPhong_Load(object sender, EventArgs e)
        {
            txtHDDP.Text = bus.TaoMaTuDong();
            if(dgvKetQuaTimKiem.CurrentRow != null && !dgvKetQuaTimKiem.Rows[dgvKetQuaTimKiem.CurrentRow.Index].IsNewRow)
            {
                int dong = dgvKetQuaTimKiem.CurrentCell.RowIndex;
                string maCTDP = dgvKetQuaTimKiem.Rows[dong].Cells[2].Value?.ToString() ?? "";
                dgvDSDichVu.DataSource = bus.LayDSDichVuTheoMaCTDP(maCTDP);
            }
        }

        public bool KTraMa(string maP)
        {
            if (maP.Equals(dgvDSDichVu.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }
        private void dgvDSDichVu_Click(object sender, EventArgs e)
        {
            int dong = dgvDSDichVu.CurrentCell.RowIndex;
            txtHDDP.Text = dgvDSDichVu.Rows[dong].Cells[0].Value?.ToString() ?? "";
           
            txtChiTietDP.Text = dgvDSDichVu.Rows[dong].Cells[2].Value?.ToString() ?? "";
           
            txtThanhTien.Text = dgvDSDichVu.Rows[dong].Cells[4].Value?.ToString() ?? "";            
        }

        private void dgvKetQuaTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
