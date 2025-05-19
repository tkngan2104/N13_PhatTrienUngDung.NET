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
            float tongTienDichVu = 0;
            foreach (DataGridViewRow row in dgvDSDichVu.Rows)
            {
                if (row.Cells["tongTien"].Value != null)
                {
                    tongTienDichVu += float.Parse(row.Cells["tongTien"].Value.ToString());
                }
            }

            float tienPhong = BUS_HoaDonDatPhong.Instance.LayGiaPhong(txtChiTietDP.Text);
            float tongTien = tienPhong + tongTienDichVu;
            txtThanhTien.Text = tongTien.ToString();
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
            string tenLH = txtTimPhong.Text.Trim();
            var ds = BUS_ChiTietDatPhong.Instance.TimTheoTenLoaiHinh(tenLH);
            dgvKetQuaTimKiem.DataSource = ds;
            dgvKetQuaTimKiem.Columns[4].Visible = false;
            dgvKetQuaTimKiem.Columns[5].Visible = false;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
       
        }

        private void dgvKetQuaTimKiem_Click(object sender, EventArgs e)
        {
            int dong = dgvKetQuaTimKiem.CurrentCell.RowIndex;
            txtChiTietDP.Text = dgvKetQuaTimKiem.Rows[dong].Cells[1].Value?.ToString() ?? "";

            try
            {
                string maCTDP = dgvKetQuaTimKiem.Rows[dong].Cells[1].Value?.ToString() ?? "";
                BUS_HoaDonDatPhong.Instance.DSHDDP(dgvDSDichVu,maCTDP);
                string maNS = BUS_HoaDonDatPhong.Instance.LayMaNhanSuTheoCTDP(maCTDP);
                txtMaNS.Text = maNS ?? "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách dịch vụ: " + ex.Message);
            }
        }

        private void ThanhToanDatPhong_Load(object sender, EventArgs e)
        {
            txtHDDP.Text = BUS_HoaDonDatPhong.Instance.TaoMaTuDong();

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
