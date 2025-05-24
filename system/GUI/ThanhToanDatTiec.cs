using BUS;
using ET;
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
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvKetQuaTimKiem.Rows[e.RowIndex];

                // Lấy mã đặt tiệc
                string maDT = row.Cells["maDT"].Value.ToString();

                // Hiển thị thông tin lên TextBox
                txtMaDT.Text = maDT;

                if (row.Cells["maNS"].Value != null)
                    txtMaNS.Text = row.Cells["maNS"].Value.ToString();

                if (row.Cells["maHDDT"].Value != null)
                    txtMaHDDT.Text = row.Cells["maHDDT"].Value.ToString();

                if (row.Cells["tongTien"].Value != null)
                {
                    float tongTien;
                    if (float.TryParse(row.Cells["tongTien"].Value.ToString(), out tongTien))
                    {
                        txtThanhTien.Text = string.Format("{0:#,##0} VNĐ", tongTien);
                    }
                    else
                    {
                        txtThanhTien.Text = "0 VNĐ";
                    }
                }


                if (row.Cells["trangThai"].Value != null)
                    txtTrangThai.Text = row.Cells["trangThai"].Value.ToString();

                // Lấy danh sách dịch vụ
                var danhSachDichVu = bus.LayDTTheoMa(maDT);
                dgvDSDV.DataSource = danhSachDichVu.ToList();
                FormatDgvDSDV();

                if (row.Cells["maHDDT"].Value != null)
                {
                    selectedMaHDDT = row.Cells["maHDDT"].Value.ToString();
                    txtMaHDDT.Text = selectedMaHDDT;
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


        private void ThanhToanDatTiec_Load(object sender, EventArgs e)
        {
            txtMaHDDT.Text = bus.taoMTD();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(txtMaDT.Text))
            {
                MessageBox.Show("Vui lòng chọn một đặt tiệc để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTrangThai.Text.ToLower().Contains("đã"))
            {
                MessageBox.Show("Hóa đơn này đã được thanh toán trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Tạo hóa đơn mới
            var hoaDon = new ET_HoaDonDatTiec(
                txtMaNS.Text,
                txtMaHDDT.Text,
                txtMaDT.Text,
                "Đã thanh toán",  // gán trạng thái luôn
                DateTime.Now,
                ChuyenTienVeSo(txtThanhTien.Text)
            );

            // 3. Gọi hàm xử lý trong BUS
            bool result = bus.ThanhToan(hoaDon);

            // 4. Hiển thị kết quả
            if (result)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại danh sách hóa đơn
                string sdt = txtTimKH.Text.Trim();
                dgvKetQuaTimKiem.DataSource = bus.timSDT(sdt).ToList();
                FormatKetQuaTimKiem();

                // Reset trạng thái
                txtTrangThai.Text = "Đã thanh toán";
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm hỗ trợ chuyển "123,000 VNĐ" về 123000 (float)
        private float ChuyenTienVeSo(string chuoiTien)
        {
            try
            {
                return float.Parse(chuoiTien.Replace(" VNĐ", "").Replace(",", "").Trim());
            }
            catch
            {
                return 0;
            }
        }
        private string selectedMaHDDT = "";
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            //frmXuatHoaDon frm = new frmXuatHoaDon(); // Không truyền mã hóa đơn
            //frm.ShowDialog();
        }


    }
}
