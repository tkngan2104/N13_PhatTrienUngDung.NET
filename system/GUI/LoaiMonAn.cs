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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class LoaiMonAn: Form
    {
        BUS_LoaiMonAn bus = new BUS_LoaiMonAn();
        public LoaiMonAn()
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
        /// Lấy danh sách loại món ăn
        /// </summary>
        public void layDSLMA()
        {
            dgvDSLMA.DataSource = bus.layDSLMA();
        }
        /// <summary>
        /// Thêm loại món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm loại món ăn mới?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            ET_LoaiMonAn lma = new ET_LoaiMonAn
            {
                MaLMA = bus.taoMaLMA(),
                TenLMA = txtTenLMA.Text.Trim()
            };

            if (bus.themLMA(lma))
            {
                MessageBox.Show("Thêm thành công!");
                layDSLMA();
                lamMoi();
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        /// <summary>
        /// Xoá loại món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLMA.Text))
            {
                errorProvider1.SetError(txtMaLMA, "Vui lòng chọn loại món ăn để xoá!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá loại món ăn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            if (bus.xoaLMA(txtMaLMA.Text.Trim()))
            {
                MessageBox.Show("Xoá thành công!");
                layDSLMA();
                lamMoi();
            }
            else
                MessageBox.Show("Xoá thất bại!");
        }

        /// <summary>
        /// sửa loại món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLMA.Text) || string.IsNullOrWhiteSpace(txtTenLMA.Text))
            {
                MessageBox.Show("Vui lòng nhập loại món ăn để sửa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật loại món ăn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            ET_LoaiMonAn lma = new ET_LoaiMonAn
            {
                MaLMA = txtMaLMA.Text.Trim(),
                TenLMA = txtTenLMA.Text.Trim()
            };

            if (bus.suaLMA(lma))
            {
                MessageBox.Show("Cập nhật thành công!");
                layDSLMA();
                lamMoi();
            }
            else
                MessageBox.Show("Cập nhật thất bại!");
        }

        /// <summary>
        /// Làm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        //làm mới
        private void lamMoi()
        {
            txtMaLMA.Clear();
            txtTenLMA.Clear();
        }

        /// <summary>
        /// Load danh sách loại món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoaiMonAn_Load(object sender, EventArgs e)
        {
            layDSLMA();
            txtMaLMA.Text = bus.taoMaLMA();
        }

        private void txtMaLMA_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLMA.Text))
                errorProvider1.SetError(txtMaLMA, "Mã loại món ăn không được để trống");
            else
                errorProvider1.SetError(txtMaLMA, "");
        }

        private void txtTenLMA_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLMA.Text))
                errorProvider1.SetError(txtTenLMA, "Tên loại món ăn không được để trống");
            else
                errorProvider1.SetError(txtTenLMA, "");
        }

        /// <summary>
        /// Click hiển thị thông tin lên textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDSLMA_Click(object sender, EventArgs e)
        {
            if (dgvDSLMA.CurrentRow != null)
            {
                int i = dgvDSLMA.CurrentRow.Index;
                txtMaLMA.Text = dgvDSLMA.Rows[i].Cells[0].Value?.ToString();
                txtTenLMA.Text = dgvDSLMA.Rows[i].Cells[1].Value?.ToString();
            }
        }


        //Kiểm tra tên loại món ăn
        private void txtTenLMA_TextChanged(object sender, EventArgs e)
        {
            // 1. Giữ con trỏ hiện tại
            int caret = txtTenLMA.SelectionStart;

            string raw = txtTenLMA.Text;

            // 2. Tự động TRIM bên trái
            string cleaned = raw.TrimStart();

            // 3. Loại ký tự không phải chữ Unicode hay space
            cleaned = Regex.Replace(cleaned, @"[^ \p{L}]", "");

            // 4. Ép mọi chuỗi “2 space liền” thành 1 space
            while (cleaned.Contains("  "))
                cleaned = cleaned.Replace("  ", " ");

            // 5. Nếu chuỗi thay đổi ⇒ gán lại textbox & khôi phục caret
            if (cleaned != raw)
            {
                txtTenLMA.Text = cleaned;
                txtTenLMA.SelectionStart = caret > 0 ? Math.Max(caret - 1, 0) : 0;
            }

            // 6. Cảnh báo khi còn lỗi (ký tự lạ hoặc “  ”)
            bool hasError = Regex.IsMatch(txtTenLMA.Text, @"[^ \p{L}]") || txtTenLMA.Text.Contains("  ");
            errorProvider1.SetError(
                txtTenLMA,
                hasError ? "Tên chỉ chứa chữ, không để 2 khoảng trắng liên tiếp!" : ""
            );
        }
    }
}
