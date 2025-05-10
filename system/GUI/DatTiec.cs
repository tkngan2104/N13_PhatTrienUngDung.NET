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
    public partial class DatTiec: Form
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
            if (chenhLech.TotalDays > 7)
            {
                MessageBox.Show("Không được đặt tiệc quá 7 ngày !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpNgayKetThuc.Value = dtpNgayBatDau.Value.AddDays(7);
            }
        }

        private void dgvDSDatTiec_Click(object sender, EventArgs e)
        {
            int dong = dgvDSDatTiec.CurrentCell.RowIndex;

            txtDatTiec.Text = dgvDSDatTiec.Rows[dong].Cells[0].Value?.ToString() ?? "";

            txtMaKH.Text = dgvDSDatTiec.Rows[dong].Cells[1].Value?.ToString() ?? "";

            // Nếu bạn không có sẵn CCCD, SDT, MaKH trong lệnh select, thì phải truy vấn lại từ BUS_KhachHang
            txtTenKH.Text = dgvDSDatTiec.Rows[dong].Cells[2].Value?.ToString() ?? "";
            string maKH = txtMaKH.Text;

            var kh = BUS_KhachHang.Instance.LayKHTheoMa(maKH);
            if (kh != null)
            {
                txtCCCD.Text = kh.Cccd;
                txtSDTKH.Text = kh.SoDT;
                txtTenKH.Text = kh.TenKH;
            }

            string maS = dgvDSDatTiec.Rows[dong].Cells[3].Value?.ToString() ?? "";
            cboSanhDT.SelectedValue = maS;

            DateTime ngayDatTiec;
            if (DateTime.TryParse(dgvDSDatTiec.Rows[dong].Cells[4].Value?.ToString(), out ngayDatTiec))
            {
                txtNgayDatTiec.Text = ngayDatTiec.ToString("dd/MM/yyyy");
            }

            DateTime ngayBD;
            if (DateTime.TryParse(dgvDSDatTiec.Rows[dong].Cells[5].Value?.ToString(), out ngayBD))
            {
                dtpNgayBatDau.Value = ngayBD;
            }

            DateTime ngayKT;
            if (DateTime.TryParse(dgvDSDatTiec.Rows[dong].Cells[6].Value?.ToString(), out ngayKT))
            {
                dtpNgayKetThuc.Value = ngayKT;
            }

            txtTongTien.Text = dgvDSDatTiec.Rows[dong].Cells[7].Value?.ToString() ?? "";
            txtDatCoc.Text = dgvDSDatTiec.Rows[dong].Cells[8].Value?.ToString() ?? "";
            txtGhiChu.Text = dgvDSDatTiec.Rows[dong].Cells[9].Value?.ToString() ?? "";
            txtMaNS.Text = dgvDSDatTiec.Rows[dong].Cells[10].Value?.ToString() ?? "";

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
    }
}
