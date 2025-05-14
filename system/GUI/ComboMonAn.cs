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
using DAL;
using ET;

namespace GUI
{
    public partial class ComboMonAn : Form
    {
        BUS_ChiTietComBo busCT = new BUS_ChiTietComBo();
        BUS_MonAn buss = new BUS_MonAn();
        BUS_ComBoMonAn bus = new BUS_ComBoMonAn();
        List<ET_ChiTietComBo> danhSachTam = new List<ET_ChiTietComBo>();
        public ComboMonAn()
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
        /// Btn món ăn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private Menu mainForm;

        public ComboMonAn(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new MonAn());
        }

        private void dgvCB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadComboMonAn()
        {

            dgvCB.DataSource = bus.LayTatCaCombo();
        }
        private void ComboMonAn_Load(object sender, EventArgs e)
        {
            LoadComboMonAn();
            txtMaTD.Text = bus.TaoMaComboMoi();

            // Thiết lập AutoComplete 1 lần duy nhất ở đây
            List<string> dsTenMonAn = buss.LayMonAnTheoTen();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(dsTenMonAn.ToArray());

            txtTenMA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenMA.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenMA.AutoCompleteCustomSource = source;


        }

        private void dgvCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maCB = dgvCB.Rows[e.RowIndex].Cells["maCB"].Value.ToString();
                dgvCTCB.DataSource = bus.LayMonAnTheoCombo(maCB);
            }
        }

        private void dgvCTCB_Click(object sender, EventArgs e)
        {
            if (dgvCTCB.Rows.Count > 0 && dgvCTCB.CurrentRow != null &&
               dgvCTCB.CurrentRow.Index < dgvCTCB.Rows.Count)
            {
                int dong = dgvCTCB.CurrentRow.Index;
                //txtTenMA.Text = dgvCTCB.Rows[dong].Cells[2].Value.ToString();
                txtTenMA.Text = dgvCTCB.Rows[dong].Cells["TenMA"].Value.ToString();

            }
        }

        private void ComboMonAn_Click(object sender, EventArgs e)
        {

        }

        private void dgvCB_Click(object sender, EventArgs e)
        {
            if (dgvCB.Rows.Count > 0 && dgvCB.CurrentRow != null &&
              dgvCB.CurrentRow.Index < dgvCB.Rows.Count)
            {
                int dong = dgvCB.CurrentRow.Index;
                txtMaTD.Text = dgvCB.Rows[dong].Cells[0].Value.ToString();
                txtTenTD.Text = dgvCB.Rows[dong].Cells[1].Value.ToString();
            }
        }

        public bool KtraBoTrong()
        {
            if (txtTenMA.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void btnThemMA_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm món ăn vào danh sách?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong())
                {
                    // Kiểm tra nếu tên món ăn và tên thực đơn không rỗng
                    if (string.IsNullOrEmpty(txtTenMA.Text) || string.IsNullOrEmpty(txtTenTD.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                        return;
                    }

                    var ds = txtTenMA.Text.Trim();
                    var monAn = buss.LayTatCaMonAn(ds);

                    if (monAn != null)
                    {
                        string maCTCB = $"CTCB{(danhSachTam.Count + 1):D3}";

                        // Kiểm tra xem món ăn đã có trong danh sách tạm chưa
                        if (!danhSachTam.Any(x => x.MaMA == monAn.MaMA && x.MaCB == txtMaTD.Text))
                        {
                            // Thêm món ăn vào danh sách tạm
                            danhSachTam.Add(new ET_ChiTietComBo
                            {
                                MaCTCB = maCTCB,
                                MaCB = txtMaTD.Text,
                                MaMA = monAn.MaMA

                            });
                            var danhSachMonAn = buss.LayTatCaMonAn();
                            // Cập nhật DataGridView với danh sách tạm
                            dgvCTCB.DataSource = null;
                            var danhSachHienThi = danhSachTam
                               .Select(ct => new
                               {
                                   ct.MaCTCB,
                                   ct.MaCB,
                                   ct.MaMA,
                                   TenMA = danhSachMonAn.FirstOrDefault(m => m.MaMA == ct.MaMA)?.TenMA ?? ""
                               })
                        .ToList();
                            dgvCTCB.DataSource = danhSachHienThi;
                            dgvCTCB.Columns["TenMA"].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Món ăn đã có trong danh sách!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy món ăn!");
                    }
                }
            }
        }

      

        private void lamMoi()
        {
            txtMaTD.Text = bus.TaoMaComboMoi(); // Gán mã mới vào textbox
            txtTenTD.Clear();
            txtTenMA.Clear();

            danhSachTam.Clear(); // Xóa danh sách tạm
            dgvCTCB.DataSource = null; // Xóa lưới chi tiết
            LoadComboMonAn(); // Cập nhật lại danh sách combo

        }
        private void txtTenMA_KeyDown(object sender, KeyEventArgs e)
        {
            //string searchText = txtTenMA.Text.Trim(); // Lấy chữ cái nhập vào

            //if (!string.IsNullOrEmpty(searchText))
            //{
            //    // Lấy danh sách món ăn có tên bắt đầu với ký tự người dùng nhập
            //    var filteredMonAn = buss.LayMonAnTheoTen()
            //        .Where(ma => ma.StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
            //        .ToList();

            //    AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            //    source.AddRange(filteredMonAn.ToArray());

            //    txtTenMA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    txtTenMA.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    txtTenMA.AutoCompleteCustomSource = source;
            //}
        }

        private void btnSuaMA_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Xác nhận sửa món ăn trong combo?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (dgvCTCB.CurrentRow != null)
                    {
                        string maCTCB = dgvCTCB.CurrentRow.Cells["MaCTCB"].Value.ToString(); // Lấy mã chi tiết combo
                        var suaMA = danhSachTam.FirstOrDefault(ct => ct.MaCTCB == maCTCB); // Tìm món ăn cần sửa

                        if (suaMA != null)
                        {
                            // KHÔNG gán lại txtTenMA.Text ở đây nữa
                            string tenMonAnMoi = txtTenMA.Text.Trim();

                            if (!string.IsNullOrEmpty(tenMonAnMoi))
                            {
                                var monAn = buss.LayTatCaMonAn(tenMonAnMoi); // Lấy món ăn theo tên

                                if (monAn != null)
                                {
                                    suaMA.MaMA = monAn.MaMA;

                                    var danhSachMonAn = buss.LayTatCaMonAn();
                                    var danhSachHienThi = danhSachTam
                                        .Select(ct => new
                                        {
                                            ct.MaCTCB,
                                            ct.MaCB,
                                            ct.MaMA,
                                            TenMA = danhSachMonAn.FirstOrDefault(m => m.MaMA == ct.MaMA)?.TenMA ?? ""
                                        })
                                        .ToList();

                                    dgvCTCB.DataSource = danhSachHienThi;
                                    dgvCTCB.Columns["TenMA"].Visible = false;

                                    MessageBox.Show("Sửa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tên món ăn không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn món ăn cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMA_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận xóa món ăn khỏi chi tiết combo?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (dgvCTCB.CurrentRow != null)
                {
                    string maCTCB = dgvCTCB.CurrentRow.Cells["MaCTCB"].Value.ToString(); // Lấy mã chi tiết combo

                    // Xóa chi tiết combo từ danh sách tạm
                    var xoaMA = danhSachTam.FirstOrDefault(ct => ct.MaCTCB == maCTCB);
                    if (xoaMA != null)
                    {
                        danhSachTam.Remove(xoaMA);

                        // Cập nhật lại dgvCTCB sau khi xóa
                        var danhSachMonAn = buss.LayTatCaMonAn();
                        var danhSachHienThi = danhSachTam
                            .Select(ct => new
                            {
                                ct.MaCTCB,
                                ct.MaCB,
                                ct.MaMA,
                                TenMA = danhSachMonAn.FirstOrDefault(m => m.MaMA == ct.MaMA)?.TenMA ?? ""
                            })
                            .ToList();
                        dgvCTCB.DataSource = danhSachHienThi;
                        dgvCTCB.Columns["TenMA"].Visible = false;

                        MessageBox.Show("Xóa món ăn thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn món ăn cần xóa!");
                }
            }
        }

        private void btnXoaCB_Click_1(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                string ma = txtMaTD.Text.Trim();

                // Xóa chi tiết trước
                busCT.XoaChiTietTheoMaCB(ma);

                // Sau đó mới xóa combo
                if (bus.xoaComboMonAn(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadComboMonAn();
                    lamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTD.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thực đơn và mã thực đơn.");
                return;
            }

            if (danhSachTam.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn trống. Vui lòng thêm món ăn trước.");
                return;
            }
            var danhSachMonAn = buss.LayTatCaMonAn();

            // Tính tổng giá (kiểu float)
            float tongGia = danhSachTam
                .Select(ct => danhSachMonAn.FirstOrDefault(m => m.MaMA == ct.MaMA)?.GiaTien ?? 0f)
                .Sum();
            try
            {
                // Tạo combo món ăn mới
                ET_ComBoMonAn combo = new ET_ComBoMonAn
                {
                    MaCB = txtMaTD.Text,
                    TenCB = txtTenTD.Text,
                    GiaCB = tongGia
                };

                if (bus.themCBMA(combo)) // Thêm vào bảng ComboMonAn
                {
                    foreach (ET_ChiTietComBo ct in danhSachTam)
                    {
                        ct.MaCB = combo.MaCB; // Gán mã combo mới
                        ct.MaCTCB = busCT.TaoMaChiTietComboTuDong(); // Sinh mã mới an toàn
                        busCT.themCTCB(ct);
                    }

                    MessageBox.Show("Lưu combo thành công!");
                    LoadComboMonAn(); // Tải lại dgvCB từ DB
                    danhSachTam.Clear(); // Xóa danh sách tạm
                    dgvCTCB.DataSource = null; // Xóa chi tiết trên lưới
                }
                else
                {
                    MessageBox.Show("Thêm combo thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void txtTenTD_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Cho phép xóa (Backspace), phím Space, và chữ cái (a-z, A-Z)
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
                MessageBox.Show("Tên thực đơn không được chứa ký tự đặc biệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Giới hạn độ dài tối đa 50 ký tự
            else if (!char.IsControl(e.KeyChar) && txtTenTD.Text.Length >= 50)
            {
                e.Handled = true;
                MessageBox.Show("Tên thực đơn không được vượt quá 50 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenTD_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTD.Text))
                errorProvider1.SetError(txtTenTD, "Tên thực đơn không được để trống hoặc ký tự đặc biệt");
            else
                errorProvider1.SetError(txtTenTD, "");
        }
    }
}

