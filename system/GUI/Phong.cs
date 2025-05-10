using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Phong: Form
    {
        public Phong()
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

        private Menu mainForm;

        public Phong(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        bool isLoading = false;

        private void Phong_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            BUS_LoaiHinhLuuTru.Instance.DSLoaiHinhLuuTruCombobox(cboLoaiHinh);
            BUS_LoaiHinhLuuTru.Instance.DSTrangThaiCombobox(cboTrangThai);
            string loaiHinh = Convert.ToString(cboLoaiHinh.SelectedValue);
            BUS_LoaiHinhLuuTru.Instance.DSLoaiHinh(dgvDSLHLT, loaiHinh);
            txtMaLH.Text = BUS_LoaiHinhLuuTru.Instance.TaoMaTuDong(loaiHinh);
        }

        private void dgvDSLHLT_Click(object sender, EventArgs e)
        {
            int dong = dgvDSLHLT.CurrentCell.RowIndex;
            txtMaLH.Text = dgvDSLHLT.Rows[dong].Cells[0].Value?.ToString() ?? "";
            txtTenLH.Text = dgvDSLHLT.Rows[dong].Cells[1].Value?.ToString() ?? "";
            cboLoaiHinh.Text = dgvDSLHLT.Rows[dong].Cells[2].Value?.ToString() ?? "";
            txtSLNguoi.Text = dgvDSLHLT.Rows[dong].Cells[3].Value?.ToString() ?? "";
            txtGiaTien.Text = dgvDSLHLT.Rows[dong].Cells[4].Value?.ToString() ?? "";
            cboTrangThai.Text = dgvDSLHLT.Rows[dong].Cells[5].Value?.ToString() ?? "";
            txtGhiChu.Text = dgvDSLHLT.Rows[dong].Cells[6].Value?.ToString() ?? "";

            btnSua.Enabled = true;
            btnThem.Enabled = false;
        }

        private void LoadDSPhongTheoLuaChon()
        {
            string loaiHinh = cboLoaiHinh.Text.Trim();

            BUS_LoaiHinhLuuTru.Instance.DSLoaiHinh(dgvDSLHLT, loaiHinh);
        }

        private void cboLoaiHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSPhongTheoLuaChon();
            string loaiHinh = cboLoaiHinh.Text.Trim();
            txtMaLH.Text = BUS_LoaiHinhLuuTru.Instance.TaoMaTuDong(loaiHinh);
        }

        public bool KTraMa(string maP)
        {
            if (maP.Equals(dgvDSLHLT.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtTenLH.Text.Length == 0 || txtSLNguoi.Text.Length == 0 || txtGiaTien.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Thêm loại hình lưu trú.
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
                    string loaiHinh = Convert.ToString(cboLoaiHinh.SelectedValue);
                    BUS_LoaiHinhLuuTru.Instance.ThemLoaiHinh(new ET_LoaiHinhLuuTru(txtMaLH.Text, txtTenLH.Text, cboLoaiHinh.SelectedValue.ToString(), cboTrangThai.SelectedValue.ToString(), txtGhiChu.Text, int.Parse(txtSLNguoi.Text), float.Parse(txtGiaTien.Text)));
                    BUS_LoaiHinhLuuTru.Instance.DSLoaiHinh(dgvDSLHLT, loaiHinh);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Xóa loại hình lưu trú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSLHLT.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa chọn !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    string loaiHinh = Convert.ToString(cboLoaiHinh.SelectedValue);
                    BUS_LoaiHinhLuuTru.Instance.XoaLoaiHinh(dgvDSLHLT);
                    BUS_LoaiHinhLuuTru.Instance.DSLoaiHinh(dgvDSLHLT, loaiHinh);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa loại hình lưu trú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSLHLT.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaLH.Text) == true)
                        {
                            string loaiHinh = Convert.ToString(cboLoaiHinh.SelectedValue);
                            BUS_LoaiHinhLuuTru.Instance.SuaLoaiHinh(new ET_LoaiHinhLuuTru(txtMaLH.Text, txtTenLH.Text, cboLoaiHinh.SelectedValue.ToString(), cboTrangThai.SelectedValue.ToString(), txtGhiChu.Text, int.Parse(txtSLNguoi.Text), float.Parse(txtGiaTien.Text)));
                            BUS_LoaiHinhLuuTru.Instance.DSLoaiHinh(dgvDSLHLT, loaiHinh);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng không sửa mã " + dgvDSLHLT.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaLH.Text = dgvDSLHLT.CurrentRow.Cells[0].Value.ToString();
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
            string loaiHinh = Convert.ToString(cboLoaiHinh.SelectedValue);
            txtMaLH.Text = BUS_LoaiHinhLuuTru.Instance.TaoMaTuDong(loaiHinh);
            BUS_LoaiHinhLuuTru.Instance.DSLoaiHinh(dgvDSLHLT, loaiHinh);
            BUS_LoaiHinhLuuTru.Instance.DSLoaiHinhLuuTruCombobox(cboLoaiHinh);
            BUS_LoaiHinhLuuTru.Instance.DSTrangThaiCombobox(cboTrangThai);
            txtTenLH.Clear();
            txtSLNguoi.Clear();
            txtGhiChu.Clear();
            txtGiaTien.Clear();

            dgvDSLHLT.ClearSelection();

            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }

        /// <summary>
        /// Bắt lỗi tên loại hình.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTenLH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGhiChu.Text.Length > 149 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa chỉ quá 150 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Bắt lỗi số lượng người.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSLNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSLNguoi_Validated(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSLNguoi.Text, out decimal soLuong))
            {
                if (soLuong < 1 || soLuong > 4)
                {
                    MessageBox.Show("Số lượng người chỉ có thể từ 1 đến 4.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSLNguoi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một giá trị hợp lệ.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSLNguoi.Focus();
            }
        }

        /// <summary>
        /// Bắt lỗi giá tiền.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Bắt lỗi ghi chú.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt trừ khoảng trắng, '-' và ',' !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGhiChu.Text.Length > 149 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa chỉ quá 150 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
