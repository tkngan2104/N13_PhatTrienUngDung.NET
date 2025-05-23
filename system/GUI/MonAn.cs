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
    public partial class MonAn: Form
    {
        private BUS_MonAn bus = new BUS_MonAn();
       

        public MonAn()
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
        /// Btn loại món ăn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLMA_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new LoaiMonAn());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// load danh sách món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MonAn_Load(object sender, EventArgs e)
        {
            LoadDSMA();
            rdoKhaiVi.Checked = true;
            cboLoaiMA.DataSource = bus.LayDSLoaiMonAn();
            cboLoaiMA.DisplayMember = "tenLMA";
            cboLoaiMA.ValueMember = "maLMA";
            
            txtMaMA.Text = bus.taoMaMA(LayLoaiMonAn());
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// lấy danh sách món ăn
        /// </summary>
        public void LoadDSMA()
        {
            dgvDSMA.DataSource = bus.loadDSMA();
        }
        /// <summary>
        /// Hiển thị thông tin trên textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDSMA_Click(object sender, EventArgs e)
        {
            if (dgvDSMA.Rows.Count > 0 && dgvDSMA.CurrentRow != null &&
               dgvDSMA.CurrentRow.Index < dgvDSMA.Rows.Count)
            {
                int dong = dgvDSMA.CurrentRow.Index;
                txtMaMA.Text = dgvDSMA.Rows[dong].Cells[0].Value.ToString();               
                string maLMA = dgvDSMA.Rows[dong].Cells[1].Value.ToString();
                cboLoaiMA.SelectedValue = maLMA;
                txtTenMA.Text = dgvDSMA.Rows[dong].Cells[2].Value.ToString();
                txtGiaTien.Text = dgvDSMA.Rows[dong].Cells[3].Value.ToString();
                txtMoTa.Text = dgvDSMA.Rows[dong].Cells[4].Value.ToString();
                string loaiMonAn = bus.GetLoaiMonAnFromMaMA(txtMaMA.Text);
                // Gán giá trị cho các radio button
                switch (loaiMonAn.ToLower())
                {
                    case "khai vị":
                        rdoKhaiVi.Checked = true;
                        break;
                    case "món chính":
                        rdoMonChinh.Checked = true;
                        break;
                    case "tráng miệng":
                        rdoTrangMieng.Checked = true;
                        break;
                    case "đồ uống":
                        rdoDoUong.Checked = true;
                        break;
                    default:
                        // Nếu không xác định được loại món ăn, bỏ chọn radio
                        rdoKhaiVi.Checked = false;
                        rdoMonChinh.Checked = false;
                        rdoTrangMieng.Checked = false;
                        rdoDoUong.Checked = false;
                        break;
                }
            }
        }
        /// <summary>
        /// nút thêm món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMA.Text))
            {
                errorProvider1.SetError(txtTenMA, "Tên món ăn không được để trống");
                return;
            }
            else
                errorProvider1.SetError(txtTenMA, "");

            if (cboLoaiMA.SelectedIndex == -1 || cboLoaiMA.SelectedValue == null)
            {
                errorProvider4.SetError(cboLoaiMA, "Loại món ăn không được để trống");
                return;
            }
            else
                errorProvider4.SetError(cboLoaiMA, "");

            if (string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                errorProvider2.SetError(txtGiaTien, "Giá tiền không được để trống");
                return;
            }
            else
                errorProvider2.SetError(txtGiaTien, "");

            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                errorProvider3.SetError(txtMoTa, "Mô tả không được để trống");
                return;
            }
            else
                errorProvider3.SetError(txtMoTa, "");

            if (!float.TryParse(txtGiaTien.Text.Trim(), out float GiaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loaiMonAn = LayLoaiMonAn();
            if (string.IsNullOrEmpty(loaiMonAn))
            {
                MessageBox.Show("Vui lòng chọn loại món ăn bằng radio button!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ET_MonAn et = new ET_MonAn
                {
                    MaMA = bus.taoMaMA(loaiMonAn),
                    MaLMA = cboLoaiMA.SelectedValue.ToString(), // vẫn dùng combobox để lấy nhóm loại món
                    TenMA = txtTenMA.Text.Trim(),
                    GiaTien = GiaTien,
                    MieuTa = txtMoTa.Text.Trim()

                };

                if (bus.themMA(et))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadDSMA();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private string LayLoaiMonAn()
        {
            if (rdoKhaiVi.Checked)
                return "khai vị";
            else if (rdoMonChinh.Checked)
                return "món chính";
            else if (rdoTrangMieng.Checked)
                return "tráng miệng";
            else if (rdoDoUong.Checked)
                return "đồ uống";
            else
                return ""; // Chưa chọn gì
        }
        /// <summary>
        /// làm mới 
        /// </summary>
        private void LamMoi()
        {
            txtMaMA.Clear();
            cboLoaiMA.SelectedIndex = -1;
            txtTenMA.Clear();
            txtGiaTien.Clear();
            txtMoTa.Clear();
            // Đặt lại lựa chọn mặc định cho ComboBox
            if (cboLoaiMA.Items.Count > 0)
            {
                cboLoaiMA.SelectedIndex = 0; // chọn mục đầu tiên
            }
            // Làm mới RadioButton nếu cần
            rdoKhaiVi.Checked = true;
            rdoMonChinh.Checked = false;
            rdoTrangMieng.Checked = false;
            rdoDoUong.Checked = false;

            txtMaMA.Focus();

            string loai = LayLoaiMonAn();
            if (!string.IsNullOrEmpty(loai))
            {
                txtMaMA.Text = bus.taoMaMA(loai);
            }
        }

        private void txtTenMA_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMA.Text))
                errorProvider1.SetError(txtTenMA, "Tên món ăn không được để trống");
            else
                errorProvider1.SetError(txtTenMA, "");
        }

        private void txtGiaTien_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiaTien.Text))
                errorProvider2.SetError(txtGiaTien, "Tên chức vụ không được để trống");
            else
                errorProvider2.SetError(txtGiaTien, "");
        }

        private void txtMoTa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
                errorProvider3.SetError(txtMoTa, "Tên chức vụ không được để trống");
            else
                errorProvider3.SetError(txtMoTa, "");
        }

        private void txtTenMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép xóa (Backspace), phím Space, và chữ cái (a-z, A-Z)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
                MessageBox.Show("Tên chức vụ không được chứa số hoặc ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Giới hạn độ dài tối đa 50 ký tự
            else if (txtTenMA.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Tên chức vụ không được vượt quá 50 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập khoảng trắng, ký tự đặc biệt hay chữ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// nút làm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
        /// <summary>
        /// nút xóa món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                string ma = txtMaMA.Text.Trim();
                if ((bus.xoaMA(ma) == true))
                {
                    MessageBox.Show("Xoa thanh cong");
                    LoadDSMA();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        /// <summary>
        /// nút sửa món ăn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMA.Text))
            {
                errorProvider1.SetError(txtTenMA, "Tên món ăn không được để trống");
                return;
            }
            else
                errorProvider1.SetError(txtTenMA, "");

            if (cboLoaiMA.SelectedIndex == -1 || cboLoaiMA.SelectedValue == null)
            {
                errorProvider4.SetError(cboLoaiMA, "Loại món ăn không được để trống");
                return;
            }
            else
            {
                errorProvider4.SetError(cboLoaiMA, "");
            }
            if (string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                errorProvider2.SetError(txtGiaTien, "Tên giá tiền không được để trống");
                return;
            }
            else
                errorProvider1.SetError(txtGiaTien, "");

            if (string.IsNullOrWhiteSpace(txtTenMA.Text))
            {
                errorProvider3.SetError(txtMoTa, "Mô tả không được để trống");
                return;
            }
            else
                errorProvider1.SetError(txtMoTa, "");
            if (!float.TryParse(txtGiaTien.Text.Trim(), out float GiaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                GiaTien = float.Parse(txtGiaTien.Text.Trim());
                ET_MonAn et = new ET_MonAn
                {
                    MaMA = txtMaMA.Text.Trim(),
                    MaLMA = cboLoaiMA.SelectedValue.ToString(),
                    TenMA = txtTenMA.Text.Trim(),
                    GiaTien = GiaTien,
                    MieuTa = txtMoTa.Text.Trim()
                };
                if (bus.SuaMA(et) == true)
                {
                    MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSMA();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da xay ra loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdoKhaiVi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKhaiVi.Checked)
                txtMaMA.Text = bus.taoMaMA("khai vị");


        }

        private void rdoDoUong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDoUong.Checked)
                txtMaMA.Text = bus.taoMaMA("đồ uống");
        }

        private void rdoMonChinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMonChinh.Checked)
                txtMaMA.Text = bus.taoMaMA("món chính");
        }

        private void rdoTrangMieng_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTrangMieng.Checked)
                txtMaMA.Text = bus.taoMaMA("Tráng miệng");
        }
    }
}
