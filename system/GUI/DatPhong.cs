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
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class DatPhong: Form
    {
        private List<ET_ChiTietDatPhong> danhSachPhongTam = new List<ET_ChiTietDatPhong>();
        private BindingSource bindingSourcePhong = new BindingSource();
        private readonly BUS_DatPhong dp = new BUS_DatPhong();
        private readonly BUS_LoaiHinhLuuTru lhlt = new BUS_LoaiHinhLuuTru();
        private readonly BUS_ChiTietDatPhong ctdp = new BUS_ChiTietDatPhong();
        private readonly BUS_KhachHang kh = new BUS_KhachHang();

        public DatPhong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btn thoát.
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

        private void btnSDDV_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Đi tới màn hình sử dụng dịch vụ ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new SuDungDichVu());
            }
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            dp.DSDatPhong(dgvDSDatPhong);
            txtMaNS.Text = "NV025";
            txtDatPhong.Text = dp.TaoMaTuDong();
            txtMaCTDP.Text = ctdp.TaoMaTuDong();
            lhlt.DSLoaiHinhLuuTruCombobox(cboLoaiHinh);
            ctdp.HienThiPhongTrong(cboMaPhong, cboLoaiHinh.SelectedValue.ToString());

            dtpNgayDatPhong.MinDate = DateTime.Today;
            DateTime maxDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(4).AddDays(-1);
            dtpNgayDatPhong.MaxDate = maxDate;

            dtpNgayTraPhong.MinDate = DateTime.Today;
            dtpNgayTraPhong.MaxDate = DateTime.Today.AddMonths(4);

            AutoCompleteStringCollection cccdSuggestions = new AutoCompleteStringCollection();
            List<string> dsCCCD = kh.LayTatCaCCCD();
            cccdSuggestions.AddRange(dsCCCD.ToArray());

            txtCCCD.AutoCompleteCustomSource = cccdSuggestions;
            txtCCCD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCCCD.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //khúc này là đặt phòng.

            bindingSourcePhong.DataSource = danhSachPhongTam;
            dgvDSPhong.DataSource = bindingSourcePhong;
            dgvDSPhong.AutoGenerateColumns = true;

            ctdp.CapNhatTrangThaiPhongTheoNgay();
        }

        /// <summary>
        /// Bắt lỗi căn cước công dân.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ET_KhachHang kh2 = kh.LayKhachHangTheoCCCD(txtCCCD.Text.Trim());
                if (kh2 != null)
                {
                    txtMaKH.Text = kh2.MaKH;
                    txtTenKH.Text = kh2.TenKH;
                    txtSDTKH.Text = kh2.SoDT;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với CCCD này.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Bắt lỗi ngày trả phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpNgayTraPhong_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan chenhLech = dtpNgayTraPhong.Value - dtpNgayDatPhong.Value;

            if (dtpNgayTraPhong.Value < dtpNgayDatPhong.Value)
            {
                MessageBox.Show("Ngày trả phòng không được nhỏ hơn ngày đặt phòng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayTraPhong.Value = dtpNgayDatPhong.Value;
            }
            else if (chenhLech.TotalDays > 7)
            {
                MessageBox.Show("Không được đặt phòng quá 7 ngày!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayTraPhong.Value = dtpNgayDatPhong.Value.AddDays(7);
            }
        }

        private void cboLoaiHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiHinh.SelectedItem == null)
                return;

            ctdp.HienThiPhongTrong(cboMaPhong, cboLoaiHinh.SelectedValue.ToString());
        }

        /// <summary>
        /// Đặt phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận đặt phòng?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string maDP = txtDatPhong.Text;
                    string maKH = txtMaKH.Text;
                    string maLH = cboMaPhong.SelectedValue.ToString();
                    string maNS = txtMaNS.Text;
                    DateTime ngayTP = dtpNgayTraPhong.Value;

                    // Lưu thông tin đặt phòng chung trước
                    ET_DatPhong datPhong = new ET_DatPhong(maNS,maDP, maKH, ngayTP);
                    dp.ThemDatPhong(datPhong);

                    // Sau đó thêm từng chi tiết phòng
                    foreach (var phong in danhSachPhongTam)
                    {
                        ctdp.ThemCTDP(phong);
                    }

                    MessageBox.Show("Đặt phòng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    danhSachPhongTam.Clear();
                    bindingSourcePhong.ResetBindings(false);
                    dp.DSDatPhong(dgvDSDatPhong);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đặt phòng: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool KtraBoTrong()
        {
            if (txtCCCD.Text.Length == 0)
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
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm phòng vào danh sách ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong())
                {
                    string maDP = txtDatPhong.Text;
                    string maCTDP = ctdp.TaoMaTam(danhSachPhongTam);  // Tạo mã mới và lưu vào maCTDP

                    // Hiển thị mã vừa tạo lên textbox
                    txtMaCTDP.Text = maCTDP;

                    string maPhong = cboMaPhong.SelectedValue.ToString();
                    DateTime ngayTP = dtpNgayTraPhong.Value;

                    var phongTonTai = danhSachPhongTam.FirstOrDefault(p => p.MaLH == maPhong);

                    if (phongTonTai == null)
                    {
                        var phongMoi = new ET_ChiTietDatPhong
                        {
                            MaDP = maDP,
                            MaCTDP = maCTDP,
                            MaLH = maPhong,
                            NgayTraPhong = ngayTP
                        };

                        danhSachPhongTam.Add(phongMoi);

                        ctdp.CapNhatTrangThaiPhong(maPhong, "Đã đặt");

                        bindingSourcePhong.ResetBindings(false);
                        
                    }
                    else
                    {
                        MessageBox.Show("Phòng này đã được thêm rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
        }

        private void dgvDSDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSDatPhong_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvDSDatPhong.CurrentRow;
            try
            {
                string maNS = row.Cells[0].Value.ToString();
                string maKH = row.Cells[2].Value.ToString();
                string madp = dgvDSDatPhong.CurrentRow.Cells[1].Value.ToString();
                BUS_ChiTietDatPhong.Instance.DSChiTietDatPhongTheoMa(dgvDSPhong, madp);
                string ngayDP = row.Cells[3].Value?.ToString();
                txtMaNS.Text = maNS;
                txtDatPhong.Text = madp;

                // Gán ngày đặt phòng nếu có
                if (DateTime.TryParse(ngayDP, out DateTime dtDP))
                    dtpNgayDatPhong.Value = dtDP;

                var kh = BUS_KhachHang.Instance.LayKHTheoMa(maKH);
                if (kh != null)
                {
                    txtMaKH.Text = kh.MaKH;
                    txtTenKH.Text = kh.TenKH;
                    txtCCCD.Text = kh.Cccd;
                    txtSDTKH.Text = kh.SoDT;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận xóa phòng khỏi danh sách?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                string maCTDP = txtMaCTDP.Text;  // Lấy mã chi tiết đặt phòng từ textbox

                var phongCanXoa = danhSachPhongTam.FirstOrDefault(p => p.MaCTDP == maCTDP);
                if (phongCanXoa != null)
                {
                    danhSachPhongTam.Remove(phongCanXoa);  // Xóa phòng khỏi danh sách

                    // Cập nhật trạng thái phòng về trạng thái ban đầu (Chưa đặt)
                    BUS_ChiTietDatPhong.Instance.CapNhatTrangThaiPhong(phongCanXoa.MaLH, "Chưa đặt");

                    bindingSourcePhong.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận sửa lại phòng?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong())
                {
                    string maCTDP = txtMaCTDP.Text;
                    string maPhong = cboMaPhong.SelectedValue?.ToString();
                    DateTime ngayTP = dtpNgayTraPhong.Value;

                    var phongCanSua = danhSachPhongTam.FirstOrDefault(p => p.MaCTDP == maCTDP);
                    if (phongCanSua != null)
                    {
                        // Cập nhật lại thông tin
                        BUS_ChiTietDatPhong.Instance.CapNhatTrangThaiPhong(phongCanSua.MaLH, "Chưa đặt"); // trả lại phòng cũ

                        phongCanSua.MaLH = maPhong;
                        phongCanSua.NgayTraPhong = ngayTP;

                        BUS_ChiTietDatPhong.Instance.CapNhatTrangThaiPhong(maPhong, "Đã đặt");

                        bindingSourcePhong.ResetBindings(false);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn phòng cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
