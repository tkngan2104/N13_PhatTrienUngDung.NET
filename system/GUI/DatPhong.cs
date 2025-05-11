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
            BUS_DatPhong.Instance.DSDatPhong(dgvDSDatPhong);
            txtMaNS.Text = "NV025";
            txtDatPhong.Text = BUS_DatPhong.Instance.TaoMaTuDong();
            txtMaCTDP.Text = BUS_ChiTietDatPhong.Instance.TaoMaTuDong();
            BUS_LoaiHinhLuuTru.Instance.DSLoaiHinhLuuTruCombobox(cboLoaiHinh);
            BUS_ChiTietDatPhong.Instance.HienThiPhongTrong(cboMaPhong, cboLoaiHinh.SelectedValue.ToString());

            dtpNgayDatPhong.MinDate = DateTime.Today;
            DateTime maxDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(4).AddDays(-1);
            dtpNgayDatPhong.MaxDate = maxDate;

            dtpNgayTraPhong.MinDate = DateTime.Today;
            dtpNgayTraPhong.MaxDate = DateTime.Today.AddMonths(4);

            AutoCompleteStringCollection cccdSuggestions = new AutoCompleteStringCollection();
            List<string> dsCCCD = BUS_KhachHang.Instance.LayTatCaCCCD();
            cccdSuggestions.AddRange(dsCCCD.ToArray());

            txtCCCD.AutoCompleteCustomSource = cccdSuggestions;
            txtCCCD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCCCD.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //khúc này là đặt phòng.

            bindingSourcePhong.DataSource = danhSachPhongTam;
            dgvDSPhong.DataSource = bindingSourcePhong;
            dgvDSPhong.AutoGenerateColumns = true;

            BUS_ChiTietDatPhong.Instance.CapNhatTrangThaiPhongTheoNgay();
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
                ET_KhachHang kh = BUS_KhachHang.Instance.LayKhachHangTheoCCCD(txtCCCD.Text.Trim());
                if (kh != null)
                {
                    txtMaKH.Text = kh.MaKH;
                    txtTenKH.Text = kh.TenKH;
                    txtSDTKH.Text = kh.SoDT;
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

            BUS_ChiTietDatPhong.Instance.HienThiPhongTrong(cboMaPhong, cboLoaiHinh.SelectedValue.ToString());
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
                    BUS_DatPhong.Instance.ThemDatPhong(datPhong);

                    // Sau đó thêm từng chi tiết phòng
                    foreach (var phong in danhSachPhongTam)
                    {
                        BUS_ChiTietDatPhong.Instance.ThemCTDP(phong);
                    }

                    MessageBox.Show("Đặt phòng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    danhSachPhongTam.Clear();
                    bindingSourcePhong.ResetBindings(false);
                    BUS_DatPhong.Instance.DSDatPhong(dgvDSDatPhong);

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
                    string maCTDP = BUS_ChiTietDatPhong.Instance.TaoMaTam(danhSachPhongTam);  // Tạo mã mới và lưu vào maCTDP

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

                        BUS_ChiTietDatPhong.Instance.CapNhatTrangThaiPhong(maPhong, "Đã đặt");

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
    }
}
