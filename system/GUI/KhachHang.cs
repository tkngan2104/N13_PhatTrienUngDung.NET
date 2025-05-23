using BUS;
using DAL;
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
            txtMaKH.Text = bus.taoMaKH();

            dtpNgaySinh.MaxDate = DateTime.Today.AddDays(-1);
            dtpNgaySinh.Value = dtpNgaySinh.MaxDate;
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
            string cccd = txtCCCD.Text.Trim();
            if (!string.IsNullOrEmpty(cccd) && (cccd.Length != 12 || !cccd.All(char.IsDigit)))
            {
                errorProvider1.SetError(txtCCCD, "CCCD phải gồm đúng 12 chữ số.");
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
            }
            this.Focus();
        }

        /// <summary>
        /// kiểm tra sdt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            // Lọc ký tự không phải số
            string raw = txtSDT.Text;
            string digitsOnly = new string(raw.Where(char.IsDigit).ToArray());

            // Cắt bớt nếu > 12 chữ số  (C# 7.3: dùng Substring)
            if (digitsOnly.Length > 12)
                digitsOnly = digitsOnly.Substring(0, 12);

            // Cập nhật textbox nếu có thay đổi
            if (digitsOnly != raw)
            {
                int pos = txtSDT.SelectionStart;
                txtSDT.Text = digitsOnly;
                txtSDT.SelectionStart = Math.Min(pos, digitsOnly.Length);
            }

            // Hiển thị lỗi (nếu cần)
            if (string.IsNullOrEmpty(digitsOnly))
                errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại.");
            else if (!_rgSDT.IsMatch(digitsOnly))
                errorProvider1.SetError(txtSDT, "Số điện thoại tối đa 12 chữ số.");
            else
                errorProvider1.SetError(txtSDT, "");
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
            string cccd = txtCCCD.Text.Trim();

            
            // Tên KH
            string ten = txtTenKH.Text.Trim();
            if (string.IsNullOrWhiteSpace(ten))
            {
                errorProvider1.SetError(txtTenKH, "Vui lòng nhập tên khách hàng.");
                isValid = false;
            }
            else if (!_rgTen.IsMatch(ten))
            {
                errorProvider1.SetError(txtTenKH, "Tên không chứa số/ký tự đặc biệt và không có 2 khoảng trắng liền.");
                isValid = false;
            }

            //sdt
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt))
            {
                errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại.");
                isValid = false;
            }
            else if (!_rgSDT.IsMatch(sdt))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại chỉ chứa số và tối đa 12 ký tự.");
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
            string diaChi = txtDiaChi.Text.Trim();
            if (string.IsNullOrWhiteSpace(diaChi))
            {
                errorProvider1.SetError(txtDiaChi, "Vui lòng nhập địa chỉ.");
                isValid = false;
            }
            else if (!_rgDiaChi.IsMatch(diaChi))
            {
                errorProvider1.SetError(txtDiaChi, "Địa chỉ không hợp lệ (chỉ chữ, số, / - , . ; phải có cả chữ lẫn số).");
                isValid = false;
            }


            // Quốc tịch
            string quocTich = txtQuocTich.Text.Trim();

            if (string.IsNullOrWhiteSpace(quocTich))
            {
                errorProvider1.SetError(txtQuocTich, "Vui lòng nhập quốc tịch.");
                isValid = false;
            }
            else if (!_rgQuocTich.IsMatch(quocTich))
            {
                errorProvider1.SetError(txtQuocTich, "Quốc tịch không chứa số/ký tự đặc biệt và không có 2 khoảng trắng liền.");
                isValid = false;
            }


            return isValid;


        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            
            // Ép chỉ còn 1 space liên tiếp
            int pos = txtTenKH.SelectionStart;
            txtTenKH.Text = Regex.Replace(txtTenKH.Text, @"\s{2,}", " ");
            txtTenKH.SelectionStart = pos; // giữ caret

            if (!_rgTen.IsMatch(txtTenKH.Text.Trim()))
                errorProvider1.SetError(txtTenKH, "Tên chỉ gồm ký tự chữ, không số/ký tự đặc biệt.");
            else
                errorProvider1.SetError(txtTenKH, "");
        }
        // Cho phép: chữ cái (có dấu), khoảng trắng đơn lẻ.
        private static readonly Regex _rgTen =
            new Regex(@"^(?!.*\s{2})(?!.*\d)(?!.*[^A-Za-zÀ-ỹà-ỹ\s]).+$", RegexOptions.Compiled);

        // Chữ cái có dấu + space, cấm 2 space liên tiếp, cấm số & ký tự đặc biệt
        private static readonly Regex _rgQuocTich =
            new Regex(@"^(?!.*\s{2})(?!.*\d)(?!.*[^A-Za-zÀ-ỹà-ỹ\s]).+$", RegexOptions.Compiled);

        //sdt
        private static readonly Regex _rgSDT =
            new Regex(@"^\d{1,12}$", RegexOptions.Compiled);

        //địa chỉ
        private static readonly Regex _rgDiaChi =
        new Regex(@"^(?!.*\s{2})[A-Za-zÀ-ỹà-ỹ0-9\s\-\/\.,]+$", RegexOptions.Compiled);

        //Quốc tịch bắt lỗi nhập
        private void txtQuocTich_TextChanged(object sender, EventArgs e)
        {
            // Ép chỉ còn 1 space liên tiếp
            int pos = txtQuocTich.SelectionStart;
            txtQuocTich.Text = Regex.Replace(txtQuocTich.Text, @"\s{2,}", " ");
            txtQuocTich.SelectionStart = pos;

            if (!_rgQuocTich.IsMatch(txtQuocTich.Text.Trim()))
                errorProvider1.SetError(txtQuocTich, "Quốc tịch chỉ gồm chữ, không số/ký tự đặc biệt.");
            else
                errorProvider1.SetError(txtQuocTich, "");
        }

        /// <summary>
        /// Địa chỉ bắt lỗi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            int pos = txtDiaChi.SelectionStart;
            txtDiaChi.Text = Regex.Replace(txtDiaChi.Text, @"\s{2,}", " ");
            txtDiaChi.SelectionStart = pos;

            if (_rgDiaChi.IsMatch(txtDiaChi.Text.Trim()))
                errorProvider1.SetError(txtDiaChi, "");
            else
                errorProvider1.SetError(txtDiaChi, "Địa chỉ chỉ được chứa chữ, số, / - , . và không có 2 khoảng trắng liên tiếp.");
        }
    }
}
