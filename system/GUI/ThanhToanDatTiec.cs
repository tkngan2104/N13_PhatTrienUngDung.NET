using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThanhToanDatTiec: Form
    {
        private readonly BUS_ThanhToanDatTiec bus= new BUS_ThanhToanDatTiec();
        public ThanhToanDatTiec()
        {
            InitializeComponent();
        }

        /// <summary>
        /// lấy danh sách hoá đơn đặt tiệc
        /// </summary>
        //public void layDSHDDT()
        //{
        //    dgvDSDV.DataSource = bus.layDSHDDT();
        //}

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

        /// <summary>
        /// Tìm hoa don dat tiec qua sdt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    FormatKetQuaTimKiem();  // 👉 Gọi hàm định dạng cột
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


        private void dgvKetQuaTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một hàng hợp lệ (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy mã đặt tiệc từ ô trong DGV (giả sử maDT ở cột đầu tiên)
                string maDT = dgvKetQuaTimKiem.Rows[e.RowIndex].Cells["maDT"].Value.ToString();

                // Gọi DAL để lấy thông tin đặt tiệc theo mã đặt tiệc
                var danhSachDatTiec = bus.LayDTTheoMa(maDT);

                // Kiểm tra nếu có thông tin đặt tiệc
                if (danhSachDatTiec.Any())
                {
                    // Hiển thị kết quả vào DGV dịch vụ đã sử dụng (dgvDSDV)
                    dgvDSDV.DataSource = danhSachDatTiec.ToList();
                    FormatDgvDSDV();
                }
                else
                {
                    MessageBox.Show("Không có thông tin đặt tiệc cho mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void FormatDgvDSDV()
        {
            dgvDSDV.Columns["tongTien"].DefaultCellStyle.Format = "#,##0";
        }
        private void FormatKetQuaTimKiem()
        {
            dgvKetQuaTimKiem.Columns["maDT"].HeaderText = "Mã Đặt Tiệc";
            dgvKetQuaTimKiem.Columns["ngayLap"].HeaderText = "Ngày Lập";
            dgvKetQuaTimKiem.Columns["tongTien"].HeaderText = "Tổng Tiền";
            dgvKetQuaTimKiem.Columns["trangThai"].HeaderText = "Trạng Thái";

            dgvKetQuaTimKiem.Columns["tongTien"].DefaultCellStyle.Format = "#,##0 VNĐ"; 
        }

        private void dgvDSDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKetQuaTimKiem.Rows[e.RowIndex];
                int dong;
                txtMaDT.Text = row.Cells["maDT"].Value.ToString();
                txtMaNS.Text = row.Cells["maNS"].Value.ToString();
                txtThanhTien.Text = string.Format("{0:#,##0} VNĐ", row.Cells["tongTien"].Value);
                txtTrangThai.Text = row.Cells["trangThai"].Value.ToString();

                // Tạo mã hoá đơn đặt tiệc tự động (giả sử có logic riêng)
                txtMaHDDT.Text = bus.taoMTD();
            }
        }

        private void ThanhToanDatTiec_Load(object sender, EventArgs e)
        {
            txtMaHDDT.Text = bus.taoMTD();
        }
    }
}
