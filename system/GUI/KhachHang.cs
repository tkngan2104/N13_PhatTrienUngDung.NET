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
    public partial class KhachHang: Form
    {
        BUS_KhachHang bus = new BUS_KhachHang();
        QLResortDataContext db = new QLResortDataContext();
        ET_KhachHang et = new ET_KhachHang();
        public KhachHang()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load danh sách khách hàng lên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KhachHang_Load(object sender, EventArgs e)
        {
            layDSKH();
            btnLamMoi_Click(sender, e);
            dtpNgaySinh.MaxDate = DateTime.Today;
        }
        //Lấy danh sách khách hàng
        public void layDSKH()
        {
            dgvDSKH.DataSource = bus.layDSKH();
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
        /// Thêm khách hàng vào danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemTraThongTinKhachHang(true))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm khách hàng mới?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            // Tạo đối tượng KhachHang (ET)
            ET_KhachHang kh = new ET_KhachHang
            {
                MaKH = bus.taoMaKH(),
                TenKH = txtTenKH.Text.Trim(),
                SoDT = txtSDT.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radNam.Checked ? "Nam" : "Nữ",
                DiaChi = txtDiaChi.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Cccd = txtCCCD.Text.Trim(),
                QuocTich = txtQuocTich.Text.Trim()
            };

            // Gọi BUS để thêm
            if (bus.themKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                layDSKH();
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Kiểm tra lại thông tin!");
            }
        }
        

        /// <summary>
        /// Click hiển thị 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDSKH_Click(object sender, EventArgs e)
        {
            if (dgvDSKH.Rows.Count > 0 && dgvDSKH.CurrentRow != null && dgvDSKH.CurrentRow.Index < dgvDSKH.Rows.Count)
            {
                int dong = dgvDSKH.CurrentRow.Index;

                txtMaKH.Text = dgvDSKH.Rows[dong].Cells[0].Value?.ToString();
                txtTenKH.Text = dgvDSKH.Rows[dong].Cells[1].Value?.ToString();
                txtSDT.Text = dgvDSKH.Rows[dong].Cells[2].Value?.ToString();

                if (DateTime.TryParse(dgvDSKH.Rows[dong].Cells[3].Value?.ToString(), out DateTime ngaySinh))
                    dtpNgaySinh.Value = ngaySinh;

                string gioiTinh = dgvDSKH.Rows[dong].Cells[4].Value?.ToString();
                if (gioiTinh == "Nam")
                    radNam.Checked = true;
                else if (gioiTinh == "Nữ")
                    radNu.Checked = true;

                txtDiaChi.Text = dgvDSKH.Rows[dong].Cells[5].Value?.ToString();
                txtEmail.Text = dgvDSKH.Rows[dong].Cells[6].Value?.ToString();
                txtCCCD.Text = dgvDSKH.Rows[dong].Cells[7].Value?.ToString();
                txtQuocTich.Text = dgvDSKH.Rows[dong].Cells[8].Value?.ToString();
            }

        }

        /// <summary>
        /// Xóa khách hàng được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng mã: {maKH} không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bus.xoaKhachHang(maKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layDSKH(); // Load lại danh sách
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// sửa thông tin khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tên KH
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
        string.IsNullOrWhiteSpace(txtSDT.Text) ||
        string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtCCCD.Text) ||
        string.IsNullOrWhiteSpace(txtQuocTich.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa thông tin khách hàng?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            // Tạo đối tượng KhachHang (ET)
            ET_KhachHang kh = new ET_KhachHang
            {
                MaKH = txtMaKH.Text.Trim(),
                TenKH = txtTenKH.Text.Trim(),
                SoDT = txtSDT.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radNam.Checked ? "Nam" : "Nữ",
                DiaChi = txtDiaChi.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Cccd = txtCCCD.Text.Trim(),
                QuocTich = txtQuocTich.Text.Trim()
            };

            try
            {
                if (bus.suaKhachHang(kh))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    layDSKH(); // Load lại danh sách
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        
        /// <summary>
        /// Kiểm tra cccd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// kiểm tra sdt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            if (!string.IsNullOrEmpty(sdt) && (sdt.Length > 15 || !sdt.All(char.IsDigit)))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không hợp lệ. Tối đa 15 chữ số.");
                
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }
            this.Focus();
        }

        /// <summary>
        /// kiểm tra email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            try
            {
                if (!string.IsNullOrEmpty(email))
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    if (addr.Address != email)
                    {
                        errorProvider1.SetError(txtEmail, "Email không hợp lệ.");
                    }
                    else
                    {
                        errorProvider1.SetError(txtEmail, "");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtEmail, "");
                }
            }
            catch
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ.");
            }
            this.Focus();
        }

        /// <summary>
        /// làm mới các textnbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa tất cả TextBox
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtCCCD.Clear();
            txtQuocTich.Clear();

            // Reset ngày sinh về hôm nay (hoặc giá trị mặc định)
            dtpNgaySinh.Value = DateTime.Today;

            // Reset giới tính
            radNam.Checked = true;
            radNu.Checked = false;

            // Xóa các lỗi cảnh báo
            errorProvider1.Clear();

            // Đưa focus về ô đầu tiên nếu muốn
            txtTenKH.Focus();

            //gán mã tự động
            txtMaKH.Text = bus.taoMaKH();
        }

        /// <summary>
        /// Kiểm tra các textbox
        /// </summary>
        /// <returns></returns>
        private bool kiemTraThongTinKhachHang(bool isThem)
        {
            bool isValid = true;
            errorProvider1.Clear();
            QLResortDataContext db = new QLResortDataContext();

            string maKH = txtMaKH.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cccd = txtCCCD.Text.Trim();

            // Tên KH
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                errorProvider1.SetError(txtTenKH, "Vui lòng nhập tên khách hàng.");
                isValid = false;
            }

            // Số điện thoại
            if (string.IsNullOrWhiteSpace(sdt))
            {
                errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại.");
                isValid = false;
            }
            else if (sdt.Length > 15 || !sdt.All(char.IsDigit))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không hợp lệ.");
                isValid = false;
            }
            else if (isThem ? db.KhachHangs.Any(kh => kh.SoDT == sdt)
                            : db.KhachHangs.Any(kh => kh.SoDT == sdt && kh.MaKH != maKH))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại đã tồn tại.");
                isValid = false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập email.");
                isValid = false;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ.");
                isValid = false;
            }
            else if (isThem ? db.KhachHangs.Any(kh => kh.Email == email)
                            : db.KhachHangs.Any(kh => kh.Email == email && kh.MaKH != maKH))
            {
                errorProvider1.SetError(txtEmail, "Email đã tồn tại.");
                isValid = false;
            }

            // CCCD
            if (string.IsNullOrWhiteSpace(cccd))
            {
                errorProvider1.SetError(txtCCCD, "Vui lòng nhập CCCD.");
                isValid = false;
            }
            else if (cccd.Length != 12 || !cccd.All(char.IsDigit))
            {
                errorProvider1.SetError(txtCCCD, "CCCD phải đúng 12 chữ số.");
                isValid = false;
            }
            else if (isThem ? db.KhachHangs.Any(kh => kh.CCCD == cccd)
                            : db.KhachHangs.Any(kh => kh.CCCD == cccd && kh.MaKH != maKH))
            {
                errorProvider1.SetError(txtCCCD, "CCCD đã tồn tại.");
                isValid = false;
            }

            // Địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errorProvider1.SetError(txtDiaChi, "Vui lòng nhập địa chỉ.");
                isValid = false;
            }

            // Quốc tịch
            if (string.IsNullOrWhiteSpace(txtQuocTich.Text))
            {
                errorProvider1.SetError(txtQuocTich, "Vui lòng nhập quốc tịch.");
                isValid = false;
            }

            return isValid;
        }


        /// <summary>
        /// CCCD chỉ chứa số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu không phải số và không phải phím điều khiển (Backspace, Delete...) thì chặn
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtCCCD, "CCCD chỉ được nhập số.");
                return;
            }

            // Nếu đã đủ 15 ký tự và không đang ghi đè (tức là không bôi đen) thì chặn
            if (char.IsDigit(e.KeyChar) && txtCCCD.Text.Length >= 12 && txtCCCD.SelectionLength == 0)
            {
                e.Handled = true;
                errorProvider1.SetError(txtCCCD, "CCCD tối đa 12 chữ số.");
                return;
            }

            // Nếu hợp lệ thì xoá lỗi
            errorProvider1.SetError(txtCCCD, "");
        }


        /// <summary>
        /// Quốc tịch không được viết số và ký tự đặc biệt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQuocTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép ký tự chữ cái, phím backspace và khoảng trắng
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // chặn ký tự không hợp lệ
                errorProvider1.SetError(txtQuocTich, "Quốc tịch chỉ được chứa chữ cái");
            }
            else
            {
                errorProvider1.SetError(txtQuocTich, "");
            }
        }


        /// <summary>
        /// Bắt lỗi số điện thoại chỉ có số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự không phải là số và không phải là phím điều khiển (Backspace...), thì chặn
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự không hợp lệ
                errorProvider1.SetError(txtSDT, "Số điện thoại chỉ được chứa số!");
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }
        }


        /// <summary>
        /// Bắt lỗi tên và họ không được viết số và ký tự đặc biệt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép ký tự chữ cái, phím backspace và khoảng trắng
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // chặn ký tự không hợp lệ
                errorProvider1.SetError(txtTenKH, "Họ và tên chỉ được chứa chữ cái");
            }
            else
            {
                errorProvider1.SetError(txtTenKH, "");
            }
        }
    }
}
