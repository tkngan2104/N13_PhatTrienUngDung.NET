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
            if (string.IsNullOrWhiteSpace(txtTenLMA.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại món ăn"); 
                return;
            }

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
    }
}
