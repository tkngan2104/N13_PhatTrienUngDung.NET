using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhanSu: Form
    {
        public NhanSu()
        {
            InitializeComponent();
        }

        private BUS_NhanVien nv = new BUS_NhanVien();
        private BUS_Sanh s = new BUS_Sanh();
        private BUS_ChucVu cv = new BUS_ChucVu();

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
        /// Btn chức vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private Menu mainForm;

        public NhanSu(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new ChucVu());
        }

        private void NhanSu_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            nv.DSNhanVien(dgvDSNS);
            txtMaNS.Text = nv.TaoMaTuDong();
            cv.DSChucVuCombobox(cboChucVu);
            dtpNgaySinh.MinDate = new DateTime(1950, 1, 1);
            dtpNgaySinh.MaxDate = DateTime.Today;
            dtpNgaySinh.Value = DateTime.Today;
            dtpNgayVaoLam.MinDate = new DateTime(1960, 1, 1);
            dtpNgayVaoLam.MaxDate = DateTime.Today;
            dtpNgayVaoLam.Value = DateTime.Today;
        }

        private void dgvDSNS_Click(object sender, EventArgs e)
        {
            int dong = dgvDSNS.CurrentCell.RowIndex;
            txtMaNS.Text = dgvDSNS.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenNS.Text = dgvDSNS.Rows[dong].Cells[1].Value?.ToString() ?? "";

            if (DateTime.TryParse(dgvDSNS.Rows[dong].Cells[4].Value?.ToString(), out DateTime birthDate))
            {
                if (birthDate < dtpNgaySinh.MinDate || birthDate > dtpNgaySinh.MaxDate)
                {
                    dtpNgaySinh.Value = DateTime.Today;
                }
                else
                {
                    dtpNgaySinh.Value = birthDate;
                }
            }
            else
            {
                dtpNgaySinh.Value = DateTime.Today;
            }

            if (dgvDSNS.Rows[dong].Cells[3].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtSDT.Text = dgvDSNS.Rows[dong].Cells[5].Value?.ToString() ?? "";
            txtCCCD.Text = dgvDSNS.Rows[dong].Cells[6].Value?.ToString() ?? "";
            txtEmail.Text = dgvDSNS.Rows[dong].Cells[7].Value?.ToString() ?? "";
            txtDiaChi.Text = dgvDSNS.Rows[dong].Cells[8].Value?.ToString() ?? "";
            cboChucVu.Text = dgvDSNS.Rows[dong].Cells[2].Value?.ToString() ?? "";
            if (DateTime.TryParse(dgvDSNS.Rows[dong].Cells[9].Value?.ToString(), out DateTime date))
            {
                if (date < dtpNgaySinh.MinDate || date > dtpNgaySinh.MaxDate)
                {
                    dtpNgayVaoLam.Value = DateTime.Today;
                }
                else
                {
                    dtpNgayVaoLam.Value = date;
                }
            }
            else
            {
                dtpNgayVaoLam.Value = DateTime.Today;
            }
            btnSua.Enabled = true;
            btnThem.Enabled = false;
        }

        public bool KTraMa(string maP)
        {
            if (maP.Equals(dgvDSNS.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtTenNS.Text.Length == 0 || txtCCCD.Text.Length == 0 || txtDiaChi.Text.Length == 0 || txtSDT.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        public string layGioiTinh()
        {
            string gtinh = string.Empty;
            if (radNam.Checked == true)
            {
                gtinh = radNam.Text;
            }
            else
            {
                gtinh = radNu.Text;
            }
            return gtinh;
        }

        /// <summary>
        /// Thêm nhân viên.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    nv.ThemNhanVien(new ET_NhanVien(txtMaNS.Text, txtTenNS.Text, layGioiTinh(), txtSDT.Text, txtCCCD.Text, txtEmail.Text, txtDiaChi.Text, cboChucVu.SelectedValue.ToString(), dtpNgaySinh.Value, dtpNgayVaoLam.Value));
                    nv.DSNhanVien(dgvDSNS);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Xóa nhân viên.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSNS.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa chọn !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    nv.XoaNhanVien(dgvDSNS);
                    nv.DSNhanVien(dgvDSNS);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa nhân viên.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSNS.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaNS.Text) == true)
                        {
                            nv.SuaNhanVien(new ET_NhanVien(txtMaNS.Text, txtTenNS.Text, layGioiTinh(), txtSDT.Text, txtCCCD.Text, txtEmail.Text, txtDiaChi.Text, cboChucVu.SelectedValue.ToString(), dtpNgaySinh.Value, dtpNgayVaoLam.Value));
                            nv.DSNhanVien(dgvDSNS);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không sửa mã " + dgvDSNS.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaNS.Text = dgvDSNS.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMaNS.Text = s.TaoMaTuDong();
            txtTenNS.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            cv.DSChucVuCombobox(cboChucVu);
            dtpNgaySinh.MinDate = new DateTime(1950, 1, 1);
            dtpNgaySinh.MaxDate = DateTime.Today;
            dtpNgaySinh.Value = DateTime.Today;
            dtpNgayVaoLam.MinDate = new DateTime(1960, 1, 1);
            dtpNgayVaoLam.MaxDate = DateTime.Today;
            dtpNgayVaoLam.Value = DateTime.Today;

            dgvDSNS.ClearSelection();

            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }

        /// <summary>
        /// Bắt lỗi tên nhân sự.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTenNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar != '\b' && txtTenNS.Text.Trim().Length == 0 && !char.IsLetter(e.KeyChar))
            {
                // Nếu chưa có ký tự chữ nào
                e.Handled = true;
                MessageBox.Show("Tên nhân sự phải chứa ít nhất một ký tự chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenNS.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên nhân sự quá 50 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Bắt lỗi căn cước công dân.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();

            // Kiểm tra nếu CCCD đã tồn tại trong cơ sở dữ liệu
            if (nv.KiemTraCCCDTonTai(cccd))
            {
                MessageBox.Show("Số CCCD đã tồn tại trong hệ thống. Vui lòng nhập CCCD khác.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Bắt lỗi số điện thoại.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && txtSDT.Text.Length > 14)
            {
                e.Handled = true;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra nếu số điện thoại đã tồn tại trong cơ sở dữ liệu
            if (nv.KiemTraSDTTonTai(sdt))
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống. Vui lòng nhập số điện thoại khác.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        /// <summary>
        /// Bắt lỗi email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string emailMoi = txtEmail.Text.Trim();
            string emailCu = "email_cu_lay_tu_database";

            if (!Regex.IsMatch(emailMoi, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng (ví dụ: ten@email.com)", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nv.KiemTraEmailTonTai(emailMoi, emailCu))
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống. Vui lòng nhập email khác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Bắt lỗi địa chỉ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '/' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt trừ '/' và '-',',' !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar != '\b' && txtDiaChi.Text.Trim().Length == 0 && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Địa chỉ phải chứa ít nhất một ký tự chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaChi.Text.Length > 149 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa chỉ quá 50 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Bắt lỗi ngày sinh.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpNgaySinh_Leave(object sender, EventArgs e)
        {
            DateTime ngaySinh = dtpNgaySinh.Value;
            int tuoi = DateTime.Today.Year - ngaySinh.Year;

            if (ngaySinh > DateTime.Today.AddYears(-tuoi))
                tuoi--;

            if (tuoi < 18)
            {
                MessageBox.Show("Nhân sự phải đủ ít nhất 18 tuổi!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
            }
        }
    }
}
