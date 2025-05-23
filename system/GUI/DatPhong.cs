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
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
            BUS_DatPhong.Instance.DSDatPhong(dgvDSDichVu);
            txtMaNS.Text = "NV025";
            txtDatPhong.Text = BUS_DatPhong.Instance.TaoMaTuDong();
            txtMaCTDP.Text = BUS_ChiTietDatPhong.Instance.TaoMaTuDong();
            BUS_LoaiHinhLuuTru.Instance.DSLoaiHinhLuuTruCombobox(cboLoaiHinh);
            BUS_ChiTietDatPhong.Instance.HienThiPhongTrong(cboTenLH, cboLoaiHinh.SelectedValue.ToString());

            dtpNgayDatPhong.MinDate = DateTime.MinValue;
            DateTime maxDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(4).AddDays(-1);
            dtpNgayDatPhong.MaxDate = maxDate;

            dtpNgayTraPhong.MinDate = DateTime.MinValue;
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
            //else if (chenhLech.TotalDays > 7)
            //{
            //    MessageBox.Show("Không được đặt phòng quá 7 ngày!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dtpNgayTraPhong.Value = dtpNgayDatPhong.Value.AddDays(7);
            //}
        }

        private void cboLoaiHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiHinh.SelectedItem == null)
            {
                return;
            }

            BUS_ChiTietDatPhong.Instance.HienThiPhongTrong(cboTenLH, cboLoaiHinh.SelectedValue.ToString());
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
                    string maLH = cboTenLH.SelectedValue.ToString();
                    string maNS = txtMaNS.Text;
                    DateTime ngayTP = dtpNgayTraPhong.Value;

                    // Lưu thông tin đặt phòng chung trước
                    ET_DatPhong datPhong = new ET_DatPhong(maNS, maDP, maKH, ngayTP);
                    BUS_DatPhong.Instance.ThemDatPhong(datPhong);

                    // Sau đó thêm từng chi tiết phòng
                    foreach (var phong in danhSachPhongTam)
                    {
                        BUS_ChiTietDatPhong.Instance.ThemCTDP(phong);
                    }

                    MessageBox.Show("Đặt phòng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    danhSachPhongTam.Clear();
                    bindingSourcePhong.ResetBindings(false);
                    BUS_DatPhong.Instance.DSDatPhong(dgvDSDichVu);

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

                    string maPhong = cboTenLH.SelectedValue.ToString();
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



        private void dgvDSDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dgvDSPhong_Click(object sender, EventArgs e)
        {
           int dong  = dgvDSPhong.CurrentCell.RowIndex;
            try
            {
                string maCTDP = dgvDSPhong.Rows[dong].Cells[1].Value.ToString();
                //string maLH = dgvDSPhong.Rows[dong].Cells[2].Value.ToString();
                //cboLoaiHinh.SelectedValue = maLH;
                //cboTenLH.SelectedValue = maLH;
                string ngayTP = dgvDSPhong.Rows[dong].Cells[3].Value?.ToString();
                txtMaCTDP.Text = maCTDP;
               
                ////cboMaPhong
                //MessageBox.Show(dgvDSPhong.Rows[dong].Cells[2].Value.ToString());
                // Gán ngày đặt phòng nếu có
                if (DateTime.TryParse(ngayTP, out DateTime dtTP))
                    dtpNgayTraPhong.Value = dtTP;

               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void lamMoi()
        {
            

        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtCCCD.Clear();
            txtTenKH.Clear();
            txtSDTKH.Clear();
            cboTenLH.SelectedIndex = -1;
            dtpNgayTraPhong.Value = DateTime.Now;
            if (cboTenLH.Items.Count > 0)
            {
                cboTenLH.SelectedIndex = 0; // chọn mục đầu tiên
            }
            // Làm mới danh sách phòng (nếu cần thiết)
            danhSachPhongTam.Clear();
            dgvDSPhong.DataSource = null;
            bindingSourcePhong.ResetBindings(false);
        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      
        private void dgvDSDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvDSDichVu.CurrentRow;
            try
            {
                string maNS = row.Cells[0].Value.ToString();
                string maKH = row.Cells[2].Value.ToString();
                string madp = dgvDSDichVu.CurrentRow.Cells[1].Value.ToString();
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
                        string maPhong = cboTenLH.SelectedValue?.ToString();
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

        private void dgvDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                dgvDSDichVu.DataSource = BUS_ThongKeDatPhong.Instance.ThongKeDatPhongTheoNgay(dtpThoiGian.Value);
            }
            else if (radThang.Checked == true)
            {
                dgvDSDichVu.DataSource = BUS_ThongKeDatPhong.Instance.ThongKeDatPhongTheoThang(dtpThoiGian.Value.Year, dtpThoiGian.Value.Month);
            }
            else if (radNam.Checked == true)
            {
                dgvDSDichVu.DataSource = BUS_ThongKeDatPhong.Instance.ThongKeDatPhongTheoNam(dtpThoiGian.Value.Year);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeDatPhongTheoNgay(dtpThoiGian.Value));
            }
            else if (radThang.Checked == true)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeDatPhongTheoThang(dtpThoiGian.Value));
            }
            else if (radNam.Checked == true)
            {
                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeDatPhongTheoNam(dtpThoiGian.Value));
            }
        }
    }
}
