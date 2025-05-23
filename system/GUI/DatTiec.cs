using BUS;
using ET;
using Microsoft.Reporting.WinForms;
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
    public partial class DatTiec : Form
    {
        public DatTiec()
        {
            InitializeComponent();
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

        /// <summary>
        /// Btn đặt thực đơn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatTD_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xác nhận đặt thực đơn cho buổi tiệc ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ChiTietDatTiec());
            }
        }

        private void btnDatDV_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Xác nhận đặt dịch vụ cho buổi tiệc ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new DatDichVu());
            }
        }

        /// <summary>
        /// BtnSanhDT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSanhDT_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new SanhDatTiec());
        }

        private void DatTiec_Load(object sender, EventArgs e)
        {
            txtDatTiec.Text = BUS_DatTiec.Instance.TaoMaTuDong();
            BUS_Sanh.Instance.DSSanhCombobox(cboSanhDT);

            BUS_DatTiec.Instance.DSDatTiec(dgvDSDatTiec);

            txtMaNS.Text = "NV025";
            txtNgayDatTiec.Text = DateTime.Today.ToString("dd/MM/yyyy");

            dtpNgayBatDau.MinDate = DateTime.Today;
            DateTime maxDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(4).AddDays(-1);
            dtpNgayBatDau.MaxDate = maxDate;

            dtpNgayKetThuc.MinDate = DateTime.Today;
            dtpNgayKetThuc.MaxDate = DateTime.Today.AddMonths(4);

            // TÍNH TIỀN DỰA TRÊN NGÀY BẮT ĐẦU - KẾT THÚC
            if (cboSanhDT.Items.Count > 0)
            {
                string maS = cboSanhDT.SelectedValue.ToString();
                float giaSDT = BUS_Sanh.Instance.LayGiaSTheoMa(maS);

                int soNgay = (dtpNgayKetThuc.Value.Date - dtpNgayBatDau.Value.Date).Days + 1;
                if (soNgay <= 0) soNgay = 1;

                float tongTien = giaSDT * soNgay;
                float datCoc = tongTien * 0.2f;

                txtTongTien.Text = tongTien.ToString("F0");
                txtDatCoc.Text = datCoc.ToString("F0");
            }

            AutoCompleteStringCollection cccdSuggestions = new AutoCompleteStringCollection();
            List<string> dsCCCD = BUS_KhachHang.Instance.LayTatCaCCCD();
            cccdSuggestions.AddRange(dsCCCD.ToArray());

            txtCCCD.AutoCompleteCustomSource = cccdSuggestions;
            txtCCCD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCCCD.AutoCompleteSource = AutoCompleteSource.CustomSource;

            btnSua.Enabled = false;
        }

        private void CapNhatTongTienVaDatCoc()
        {
            string maS = cboSanhDT.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maS)) return;

            float giaSDT = BUS_Sanh.Instance.LayGiaSTheoMa(maS);

            int soNgay = (dtpNgayKetThuc.Value.Date - dtpNgayBatDau.Value.Date).Days + 1;
            if (soNgay <= 0) soNgay = 1;

            float tongTien = giaSDT * soNgay;
            float datCoc = tongTien * 0.2f;

            txtTongTien.Text = tongTien.ToString("F0");
            txtDatCoc.Text = datCoc.ToString("F0");
        }

        /// <summary>
        /// Bắt lỗi CCCD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ET_KhachHang kh = BUS_KhachHang.Instance.LayKhachHangTheoCCCD(txtCCCD.Text.Trim());
                if (kh != null)
                {
                    txtMaKH.Text = kh.MaKH;
                    txtTenKH.Text = kh.TenKH;
                    txtSDTKH.Text = kh.SoDT;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với CCCD này.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && txtCCCD.Text.Length > 11)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Select thông tin của sảnh.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSanhDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanhDT.SelectedValue != null)
            {
                string maS = cboSanhDT.SelectedValue.ToString();

                float giaSDT = BUS_Sanh.Instance.LayGiaSTheoMa(maS);

                float tongTien = giaSDT;
                float datCoc = tongTien * 0.2f;

                txtTongTien.Text = tongTien.ToString("F0");
                txtDatCoc.Text = datCoc.ToString("F0");
            }
        }

        /// <summary>
        /// Bắt lỗi ngày kết thúc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan chenhLech = dtpNgayKetThuc.Value - dtpNgayBatDau.Value;

            if (dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
            {
                MessageBox.Show("Ngày trả phòng không được nhỏ hơn ngày đặt phòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKetThuc.Value = dtpNgayBatDau.Value;
            }
            else if (chenhLech.TotalDays > 7)
            {
                MessageBox.Show("Không được đặt phòng quá 7 ngày!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKetThuc.Value = dtpNgayBatDau.Value.AddDays(7);
            }

            CapNhatTongTienVaDatCoc();
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongTienVaDatCoc();
        }

        private void dgvDSDatTiec_Click(object sender, EventArgs e)
        {
            if (dgvDSDatTiec.CurrentRow == null || dgvDSDatTiec.CurrentRow.IsNewRow)
                return;

            int dong = dgvDSDatTiec.CurrentCell.RowIndex;

            txtDatTiec.Text = dgvDSDatTiec.Rows[dong].Cells["maDT"].Value?.ToString() ?? "";
            txtMaKH.Text = dgvDSDatTiec.Rows[dong].Cells["MaKH"].Value?.ToString() ?? "";

            string maKH = txtMaKH.Text;
            var kh = BUS_KhachHang.Instance.LayKHTheoMa(maKH);
            if (kh != null)
            {
                txtCCCD.Text = kh.Cccd;
                txtSDTKH.Text = kh.SoDT;
                txtTenKH.Text = kh.TenKH;
            }

            string maS = dgvDSDatTiec.Rows[dong].Cells["maS"].Value?.ToString() ?? "";
            cboSanhDT.SelectedValue = maS;

            DateTime ngayDatTiec;
            if (DateTime.TryParse(dgvDSDatTiec.Rows[dong].Cells["ngayDT"].Value?.ToString(), out ngayDatTiec))
            {
                txtNgayDatTiec.Text = ngayDatTiec.ToString("dd/MM/yyyy");
            }

            DateTime ngayBD;
            if (DateTime.TryParse(dgvDSDatTiec.Rows[dong].Cells["ngayBatDau"].Value?.ToString(), out ngayBD))
            {
                dtpNgayBatDau.Value = ngayBD;
            }

            DateTime ngayKT;
            if (DateTime.TryParse(dgvDSDatTiec.Rows[dong].Cells["ngayKetThuc"].Value?.ToString(), out ngayKT))
            {
                dtpNgayKetThuc.Value = ngayKT;
            }

            float tongTien;
            if (float.TryParse(dgvDSDatTiec.Rows[dong].Cells["tongTien"].Value?.ToString(), out tongTien))
            {
                txtTongTien.Text = tongTien.ToString("F0");
            }
            else
            {
                txtTongTien.Text = "0";
            }
            txtDatCoc.Text = dgvDSDatTiec.Rows[dong].Cells["giaTriDC"].Value?.ToString() ?? "";
            txtGhiChu.Text = dgvDSDatTiec.Rows[dong].Cells["ghiChu"].Value?.ToString() ?? "";

            txtMaNS.Text = dgvDSDatTiec.Rows[dong].Cells["MaNhanSu"].Value?.ToString() ?? "";

            btnSua.Enabled = true;
            btnThem.Enabled = false;
        }

        public bool KTraMa(string maP)
        {
            if (maP.Equals(dgvDSDatTiec.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtCCCD.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Thêm đặt tiệc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm đặt tiệc?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong())
                {
                    if (!KTraMa(txtDatTiec.Text)) // Nếu mã chưa tồn tại
                    {
                        ET_DatTiec et = new ET_DatTiec(
                            txtMaNS.Text,
                            txtDatTiec.Text,
                            txtMaKH.Text,
                            cboSanhDT.SelectedValue.ToString(),
                            txtGhiChu.Text,
                            DateTime.Parse(txtNgayDatTiec.Text),
                            dtpNgayBatDau.Value,
                            dtpNgayKetThuc.Value,
                            float.Parse(txtTongTien.Text),
                            float.Parse(txtDatCoc.Text)
                        );

                        BUS_DatTiec.Instance.ThemDatTiec(et);
                        BUS_DatTiec.Instance.DSDatTiec(dgvDSDatTiec);
                    }
                    else
                    {
                        MessageBox.Show("Mã đặt tiệc đã tồn tại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống thông tin khách hàng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Xóa đặt tiệc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSDatTiec.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Xóa đặt tiệc đã chọn?", "THÔNG BÁO", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    BUS_DatTiec.Instance.XoaDatTiec(dgvDSDatTiec);
                    BUS_DatTiec.Instance.DSDatTiec(dgvDSDatTiec);
                }
            }
        }

        /// <summary>
        /// Sửa đặt tiệc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSDatTiec.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Cập nhật dữ liệu này?", "THÔNG BÁO", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    var et = new ET_DatTiec(
                        txtMaNS.Text,
                        txtDatTiec.Text,
                        txtMaKH.Text,
                        cboSanhDT.SelectedValue.ToString(),
                        txtGhiChu.Text,
                        DateTime.Parse(txtNgayDatTiec.Text),
                        dtpNgayBatDau.Value,
                        dtpNgayKetThuc.Value,
                        float.Parse(txtTongTien.Text),
                        float.Parse(txtDatCoc.Text)
                    );
                    BUS_DatTiec.Instance.SuaDatTiec(et);
                    BUS_DatTiec.Instance.DSDatTiec(dgvDSDatTiec);
                }
            }
        }

        /// <summary>
        /// Làm mới dữ liệu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtCCCD.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDTKH.Clear();
            txtGhiChu.Clear();
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;

            txtDatTiec.Text = BUS_DatTiec.Instance.TaoMaTuDong();
            BUS_Sanh.Instance.DSSanhCombobox(cboSanhDT);

            if (cboSanhDT.Items.Count > 0)
            {
                string maS = cboSanhDT.SelectedValue.ToString();
                float giaSDT = BUS_Sanh.Instance.LayGiaSTheoMa(maS);
                float tongTien = giaSDT;
                float datCoc = tongTien * 0.2f;
                txtTongTien.Text = tongTien.ToString("F0");
                txtDatCoc.Text = datCoc.ToString("F0");
            }

            BUS_DatTiec.Instance.DSDatTiec(dgvDSDatTiec);

            txtMaNS.Text = "NV025";
            txtNgayDatTiec.Text = DateTime.Today.ToString("dd/MM/yyyy");

            dtpNgayBatDau.MinDate = DateTime.Today;
            DateTime maxDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(4).AddDays(-1);
            dtpNgayBatDau.MaxDate = maxDate;

            dtpNgayKetThuc.MinDate = DateTime.Today;
            dtpNgayKetThuc.MaxDate = DateTime.Today.AddMonths(4);

            AutoCompleteStringCollection cccdSuggestions = new AutoCompleteStringCollection();
            List<string> dsCCCD = BUS_KhachHang.Instance.LayTatCaCCCD();
            cccdSuggestions.AddRange(dsCCCD.ToArray());

            txtCCCD.AutoCompleteCustomSource = cccdSuggestions;
            txtCCCD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCCCD.AutoCompleteSource = AutoCompleteSource.CustomSource;

            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }

        /// <summary>
        /// Tìm đặt tiệc theo ngày.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                dgvDSDatTiec.DataSource = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNgay(dtpThoiGian.Value);
            }
            else if (radThang.Checked == true)
            {
                dgvDSDatTiec.DataSource = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoThang(dtpThoiGian.Value.Year, dtpThoiGian.Value.Month);
            }
            else if (radNam.Checked == true)
            {
                dgvDSDatTiec.DataSource = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNam(dtpThoiGian.Value.Year);
            }
        }

        /// <summary>
        /// In report tìm kiếm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeDatTiecTheoNgay(dtpThoiGian.Value));
            }
            else if (radThang.Checked == true)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeDatTiecTheoThang(dtpThoiGian.Value));
            }
            else if (radNam.Checked == true)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeDatTiecTheoNam(dtpThoiGian.Value));
            }
        }

        private void dgvDSDatTiec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSDatTiec.Columns.Contains("tongTien") && e.ColumnIndex == dgvDSDatTiec.Columns["tongTien"].Index)
            {
                // Kiểm tra giá trị null hoặc rỗng
                if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    e.Value = "0"; // Gán giá trị mặc định
                    e.FormattingApplied = true;
                    //dgvTongHop.Columns[2].Visible = false;
                }
                else
                {
                    //dgvTongHop.Columns[2].Visible = false;
                    // Thử parse giá trị thành decimal
                    if (decimal.TryParse(e.Value.ToString(), System.Globalization.NumberStyles.Any, null, out decimal tongTien))
                    {
                        e.Value = tongTien.ToString("F0"); // Định dạng không có phần thập phân
                        e.FormattingApplied = true;

                    }
                    else
                    {
                        e.FormattingApplied = false; // Không định dạng được
                    }
                }
            }
            //có thể là này dùng sự kiện cellformatting của dgv
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
