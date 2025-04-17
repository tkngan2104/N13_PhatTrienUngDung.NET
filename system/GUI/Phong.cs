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
            BUS_Phong.Instance.DSPhongCombobox(cboLoaiPhong);
            BUS_Phong.Instance.DSGiuongCombobox(cboLoaiGiuong);
            BUS_Phong.Instance.DSTrangThaiCombobox(cboTrangThai);
            string loaiPhong = Convert.ToString(cboLoaiPhong.SelectedValue);
            string loaiGiuong = Convert.ToString(cboLoaiGiuong.SelectedValue);
            BUS_Phong.Instance.DSPhong(dgvDSPhong, loaiPhong, loaiGiuong);
            txtMaPhong.Text = BUS_Phong.Instance.TaoMaTuDong(loaiPhong);
        }

        private void dgvDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSPhong_Click(object sender, EventArgs e)
        {
            int dong = dgvDSPhong.CurrentCell.RowIndex;
            txtMaPhong.Text = dgvDSPhong.Rows[dong].Cells[0].Value?.ToString() ?? "";
            cboLoaiPhong.Text = dgvDSPhong.Rows[dong].Cells[1].Value?.ToString() ?? "";
            cboLoaiGiuong.Text = dgvDSPhong.Rows[dong].Cells[2].Value?.ToString() ?? "";

            //cboLoaiPhong.SelectedIndexChanged -= cboLoaiPhong_SelectedIndexChanged;
            //cboLoaiGiuong.SelectedIndexChanged -= cboLoaiGiuong_SelectedIndexChanged;

            txtGiaPhong.Text = dgvDSPhong.Rows[dong].Cells[3].Value?.ToString() ?? "";
            cboTrangThai.Text = dgvDSPhong.Rows[dong].Cells[4].Value?.ToString() ?? "";
            btnSua.Enabled = true;
            cboLoaiPhong.Enabled = false;
        }
        private void LoadDSPhongTheoLuaChon()
        {
            string loaiPhong = cboLoaiPhong.Text.Trim();
            string loaiGiuong = cboLoaiGiuong.Text.Trim();

            //txtMaPhong.Text = BUS_Phong.Instance.TaoMaTuDong(loaiPhong);
            BUS_Phong.Instance.DSPhong(dgvDSPhong, loaiPhong, loaiGiuong);
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSPhongTheoLuaChon();
            string loaiPhong = cboLoaiPhong.Text.Trim();
            txtMaPhong.Text = BUS_Phong.Instance.TaoMaTuDong(loaiPhong);
        }

        private void cboLoaiGiuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSPhongTheoLuaChon();
        }

        public bool KTraMa(string maP)
        {
            if (maP.Equals(dgvDSPhong.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtGiaPhong.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Thêm phòng.
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
                    string loaiPhong = Convert.ToString(cboLoaiPhong.SelectedValue);
                    string loaiGiuong = Convert.ToString(cboLoaiGiuong.SelectedValue);
                    BUS_Phong.Instance.ThemPhong(new ET_Phong(txtMaPhong.Text, cboLoaiPhong.SelectedValue.ToString(), cboLoaiGiuong.SelectedValue.ToString(), cboTrangThai.SelectedValue.ToString(), float.Parse(txtGiaPhong.Text)));
                    BUS_Phong.Instance.DSPhong(dgvDSPhong, loaiPhong, loaiGiuong);
                }
                else
                {
                    MessageBox.Show("Không được để trống bất kỳ trường dữ liệu nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Xóa phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSPhong.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa chọn !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    string loaiPhong = Convert.ToString(cboLoaiPhong.SelectedValue);
                    string loaiGiuong = Convert.ToString(cboLoaiGiuong.SelectedValue);
                    BUS_Phong.Instance.XoaPhong(dgvDSPhong);
                    BUS_Phong.Instance.DSPhong(dgvDSPhong, loaiPhong, loaiGiuong);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Sửa phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (dgvDSPhong.SelectedRows.Count > 0)
            //{
            DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    //if (KTraMa(txtMaPhong.Text) == true)
                    //{
                    string loaiPhong = Convert.ToString(cboLoaiPhong.SelectedValue);
                    string loaiGiuong = Convert.ToString(cboLoaiGiuong.SelectedValue);
                    BUS_Phong.Instance.SuaPhong(new ET_Phong(txtMaPhong.Text, cboLoaiPhong.SelectedValue.ToString(), cboLoaiGiuong.SelectedValue.ToString(), cboTrangThai.SelectedValue.ToString(), float.Parse(txtGiaPhong.Text)));
                    BUS_Phong.Instance.DSPhong(dgvDSPhong, loaiPhong, loaiGiuong);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Vui lòng không sửa mã " + dgvDSPhong.CurrentRow.Cells[0].Value.ToString(), "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtMaPhong.Text = dgvDSPhong.CurrentRow.Cells[0].Value.ToString();
                    //}
                    //cboLoaiPhong.SelectedIndexChanged += cboLoaiPhong_SelectedIndexChanged;
                    //cboLoaiGiuong.SelectedIndexChanged += cboLoaiGiuong_SelectedIndexChanged;
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng chọn dòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
        /// <summary>
        /// Làm mới màn hình.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            string loaiPhong = Convert.ToString(cboLoaiPhong.SelectedValue);
            string loaiGiuong = Convert.ToString(cboLoaiGiuong.SelectedValue);
            txtMaPhong.Text = BUS_Phong.Instance.TaoMaTuDong(loaiPhong);
            BUS_Phong.Instance.DSPhongCombobox(cboLoaiPhong);
            BUS_Phong.Instance.DSGiuongCombobox(cboLoaiGiuong);
            BUS_Phong.Instance.DSTrangThaiCombobox(cboTrangThai);
            txtGiaPhong.Clear();
            btnSua.Enabled = false;
            cboLoaiPhong.Enabled = true;
        }
        /// <summary>
        /// Bắt lỗi giá phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            //string maPhong = BUS_Phong.Instance.LayMaPhong();

            //if (string.IsNullOrEmpty(maPhong))
            //{
            //    MessageBox.Show("Không tìm thấy mã phòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtTimKiem.Clear();
            //}
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //string keyword = txtTimKiem.Text.Trim().ToLower();

            //if (string.IsNullOrEmpty(keyword))
            //{
            //    lstSuggest.Visible = false; // Nếu không có từ khóa, ẩn gợi ý
            //    return;
            //}

            //// Lọc danh sách mã phòng theo ký tự người dùng đã nhập
            //var dsPhong = BUS_Phong.Instance.LayDSPhong()
            //                .Where(p => p.ToLower().Contains(keyword)) // Tìm phòng có tên chứa keyword
            //                .ToList();

            //if (dsPhong.Any())
            //{
            //    lstSuggest.DataSource = dsPhong;
            //    lstSuggest.Visible = true; // Hiện listBox gợi ý nếu có phòng khớp
            //}
            //else
            //{
            //    lstSuggest.Visible = false; // Ẩn listBox nếu không tìm thấy kết quả
            //}
        }
        ///// <summary>
        ///// Btn loại phòng.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnLoaiPhong_Click(object sender, EventArgs e)
        //{
        //    Menu formMenu = (Menu)this.ParentForm;
        //    formMenu.openChildForm(new LoaiPhong());
        //}

        ///// <summary>
        ///// Btn loại giường.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>

        //private void btnLoaiGiuong_Click(object sender, EventArgs e)
        //{
        //    Menu formMenu = (Menu)this.ParentForm;
        //    formMenu.openChildForm(new LoaiGiuong());
        //}
    }
}
