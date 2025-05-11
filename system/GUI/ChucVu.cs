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
using BUS;

namespace GUI
{
    public partial class ChucVu: Form
    {
        private BUS_ChucVu bus = new BUS_ChucVu();
        bool isloading = false;
        public ChucVu()
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
        /// Lấy danh sách chức vụ
        /// </summary>
        public void loadDSCV()
        {
            dgvDSCV.DataSource = bus.loadDSCV();
        }

        private void dgvDSCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Hiển thị thông tin trên textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDSCV_Click(object sender, EventArgs e)
        {
            if (dgvDSCV.Rows.Count > 0 && dgvDSCV.CurrentRow != null &&
               dgvDSCV.CurrentRow.Index < dgvDSCV.Rows.Count)
            {
                int dong = dgvDSCV.CurrentRow.Index;
                    txtMaCV.Text = dgvDSCV.Rows[dong].Cells[0].Value.ToString();
                    txtTenCV.Text = dgvDSCV.Rows[dong].Cells[1].Value.ToString();
            }
        }
        /// <summary>
        /// Thêm chức vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCV.Text))
            {
                errorProvider1.SetError(txtTenCV, "Tên chức vụ không được để trống");
                return;
            }
            else
                errorProvider1.SetError(txtTenCV, "");
            try
            {
                ET_ChucVu et = new ET_ChucVu
                {
                    MaChucVu = bus.taoMaCV(),
                    TenChucVu = txtTenCV.Text,
                };
                if (bus.themCV(et) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    loadDSCV();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
        /// <summary>
        /// Xóa chức vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                string ma = txtMaCV.Text.Trim();
                if ((bus.xoaCV(ma) == true))
                {
                    MessageBox.Show("Xoa thanh cong");
                    loadDSCV();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        /// <summary>
        /// sửa chức vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCV.Text))
            {
                errorProvider1.SetError(txtTenCV, "Tên chức vụ không được để trống");
                return;
            }
            else
                errorProvider1.SetError(txtTenCV, "");

            try
            {
                ET_ChucVu et = new ET_ChucVu
                {
                    MaChucVu = txtMaCV.Text.Trim(),
                    TenChucVu = txtTenCV.Text,
                };
                if (bus.SuaCV(et) == true)
                {
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDSCV();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da xay ra loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// làm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
          
        }
        //lam mới
        private void LamMoi()
        {
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtMaCV.Focus(); // Di chuyển con trỏ về đầu
            txtMaCV.Text = bus.taoMaCV();
        }
        /// <summary>
        /// load dữ liệu chức vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChucVu_Load(object sender, EventArgs e)
        {
            loadDSCV();
            txtMaCV.Text = bus.taoMaCV();
        }

        private void ChucVu_Leave(object sender, EventArgs e)
        {

        }

        private void txtMaCV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCV.Text))
                errorProvider1.SetError(txtMaCV, "Mã chức vụ không được để trống");
            else
                errorProvider1.SetError(txtMaCV, "");
        }

        private void txtTenCV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCV.Text))
                errorProvider1.SetError(txtTenCV, "Tên chức vụ không được để trống");
            else
                errorProvider1.SetError(txtTenCV, "");
        }

        private void txtTenCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép xóa (Backspace), phím Space, và chữ cái (a-z, A-Z)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
                MessageBox.Show("Tên chức vụ không được chứa số hoặc ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Giới hạn độ dài tối đa 50 ký tự
            else if (txtTenCV.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Tên chức vụ không được vượt quá 50 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
