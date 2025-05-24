using BUS;
using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class ChiTietDatTiec: Form
    {
        private readonly BUS_ChiTietDatTiec bus = new BUS_ChiTietDatTiec();
        private readonly BUS_ComBoMonAn bus_cbma = new BUS_ComBoMonAn();
        private readonly BUS_MonAn bus_ma = new BUS_MonAn();
        private BUS_DatTiec datTiecBUS = new BUS_DatTiec();
        public ChiTietDatTiec()
        {
            InitializeComponent();
        }

        public void layDSCTDT()
        {
            dgvDSThucDon.DataSource = bus.layDSCTDT();
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

        private void ChiTietDatTiec_Load(object sender, EventArgs e)
        {
            cboMA.DataSource = bus_ma.loadDSMA();   
            cboMA.DisplayMember = "tenMA";              
            cboMA.ValueMember = "maMA";                 
            loadComboBoxComboMonAn();
            LoadComboBoxDatTiec();
            layDSCTDT();
            txtMaNS.Text = bus.taoMaCTDT();
        }
        private void dgvDSThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSThucDon.Rows[e.RowIndex];

                txtMaNS.Text = row.Cells["maCTDT"].Value?.ToString();
                cboMaDatTiec.Text = row.Cells["maDT"].Value?.ToString();
                var maCB = row.Cells["maCB"].Value;
                if (maCB != DBNull.Value && maCB != null && !string.IsNullOrWhiteSpace(maCB.ToString()))
                {
                    cboComboMA.SelectedValue = maCB;
                }
                else
                {
                    cboComboMA.SelectedIndex = -1; 
                    cboComboMA.Text = "";
                }
                var maMA = row.Cells["maMA"].Value?.ToString();
                if (!string.IsNullOrEmpty(maMA))
                {
                    cboMA.SelectedValue = maMA;
                }
                else
                {
                    cboMA.SelectedIndex = -1;
                }
                numSoLuong.Text = row.Cells["soLuong"].Value?.ToString();
            }
        }

        private void cboComboMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboComboMA.SelectedItem != null)
            {
                cboComboMA.Text = cboComboMA.SelectedItem.ToString();
            }
            else
            {
                cboComboMA.Text = ""; // hoặc giữ nguyên
            }
        }
        private void loadComboBoxComboMonAn()
        {
            
            IQueryable dt = bus_cbma.LayTatCaCombo();
            cboComboMA.DataSource = dt;
            cboComboMA.DisplayMember = "tenCB"; // Tên hiển thị
            cboComboMA.ValueMember = "maCB";    // Giá trị thực
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an object to hold the data
                ET_ChiTiecDatTiec et = new ET_ChiTiecDatTiec
                {
                    MaCTDT = bus.taoMaCTDT(), // Assuming this function generates a unique ID
                    MaDT = cboMaDatTiec.SelectedValue.ToString(),
                    MaCB = cboComboMA.SelectedValue.ToString(),
                    MaMA = cboMA.SelectedValue?.ToString(),
                    SoLuong = (int)numSoLuong.Value
                };

                // Call the BUS function to add this detail
                bool result = bus.themChiTietDatTiec(et);

                if (result)
                {
                    MessageBox.Show("Thêm chi tiết đặt tiệc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layDSCTDT(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết đặt tiệc thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadComboBoxDatTiec()
        {
            var danhSachMa = datTiecBUS.layDSDT();

            cboMaDatTiec.DataSource = danhSachMa;
            cboMaDatTiec.DisplayMember = "maDT"; // nếu là string thì không cần
            cboMaDatTiec.ValueMember = "maDT";   // nếu là string thì không cần
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //txtMaNS.Clear();
            //cboMaDatTiec.SelectedIndex=-1;
            //cboComboMA.SelectedIndex = -1;
            //cboMA.SelectedIndex = -1;
            numSoLuong.Value = 0;
            txtMaNS.Text = bus.taoMaCTDT();
        }

        private void cboMaDatTiec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaDatTiec.SelectedItem != null)
            {
                cboMaDatTiec.Text = cboMaDatTiec.SelectedItem.ToString();
            }
            else
            {
                cboMaDatTiec.Text = ""; // hoặc giữ nguyên
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maChiTiet = txtMaNS.Text.Trim();

            if (string.IsNullOrEmpty(maChiTiet))
            {
                MessageBox.Show("Vui lòng chọn mã chi tiết cần xoá.");
                return;
            }

            var confirm = MessageBox.Show("Bạn chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool result = bus.xoaChiTietDatTiec(maChiTiet);
                if (result)
                {
                    MessageBox.Show("Xoá thành công!");
                    btnLamMoi.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
            layDSCTDT(); 

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng ET từ form
                ET_ChiTiecDatTiec et = new ET_ChiTiecDatTiec
                {
                    MaCTDT = txtMaNS.Text,
                    MaDT = cboMaDatTiec.SelectedValue?.ToString(),
                    MaMA = cboMA.SelectedValue?.ToString(),
                    SoLuong = int.Parse(numSoLuong.Text),
                    MaCB = cboComboMA.SelectedValue?.ToString()
                };

                if (bus.suaChiTietDatTiec(et))
                {
                    MessageBox.Show("Sửa chi tiết đặt tiệc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layDSCTDT(); // Hàm reload lại DataGridView
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã cần sửa hoặc dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDatTD_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an object to hold the data
                ET_ChiTiecDatTiec et = new ET_ChiTiecDatTiec
                {
                    MaCTDT = bus.taoMaCTDT(), // Assuming this function generates a unique ID
                    MaDT = cboMaDatTiec.SelectedValue.ToString(),
                    MaCB = cboComboMA.SelectedValue.ToString(),
                    MaMA = cboMA.SelectedValue?.ToString(),
                    SoLuong = (int)numSoLuong.Value
                };

                // Call the BUS function to add this detail
                bool result = bus.themChiTietDatTiec(et);

                if (result)
                {
                    MessageBox.Show("Thêm chi tiết đặt tiệc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layDSCTDT(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết đặt tiệc thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
