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
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
            toogglePnlDVR();
            toogglePnlTTDV();
            toogglePnlBCTK();
            toogglePnlDLRS();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {

            try
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlManHinh.Controls.Add(childForm);
                pnlManHinh.Tag = childForm;
                // Code để thêm và hiển thị form con
                this.pnlManHinh.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                // Ghi lại hoặc hiển thị lỗi
                Console.WriteLine("Lỗi khi mở màn hình này !");
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private Boolean showPnl = false;
        public Panel PanelMain
        {
            get { return pnlManHinh; }
            set { pnlManHinh = value; }
        }

        /// <summary>
        /// Mở pnlDichVu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toogglePnlDVR()
        {
            if (showPnl)
            {
                pnlDVResort.Height = 0;
            }
            else
            {
                pnlDVResort.Height = 115;
            }
        }

        private void btnDichVuResort_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlDVR();
        }

        /// <summary>
        /// Mở pnlThanhToanDichVu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toogglePnlTTDV()
        {
            if (showPnl)
            {
                pnlThanhToanDichVu.Height = 0;
            }
            else
            {
                pnlThanhToanDichVu.Height = 77;
            }
        }

        private void btnThanhToanDichVu_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlTTDV();
        }

        /// <summary>
        /// Mở pnlBaoCaoThongKe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toogglePnlBCTK()
        {
            if (showPnl)
            {
                pnlBaoCaoThongKe.Height = 0;
            }
            else
            {
                //pnlBaoCaoThongKe.Height = 77;
                pnlBaoCaoThongKe.Height = 10;
            }
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlBCTK();
        }

        /// <summary>
        /// Mở pnlDuLieuResort.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toogglePnlDLRS()
        {
            if (showPnl)
            {
                pnlDuLieuResort.Height = 275;
            }
            else
            {
                pnlDuLieuResort.Height = 0;
            }
        }

        private void btnDuLieuResort_Click(object sender, EventArgs e)
        {
            showPnl = !showPnl;
            toogglePnlDLRS();
        }

        /// <summary>
        /// Btn thoát chương trình.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát ứng dụng !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Btn đăng xuất.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void picLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            MessageBox.Show("Đăng xuất thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Btn mở thông tin liên hệ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void picSetting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        /// <summary>
        /// Btn khách hàng.
        /// </summary>

        private KhachHang kh;
        private void btnThongTinKhachHang_Click(object sender, EventArgs e)
        {
            if (kh == null || kh.IsDisposed)
            {
                openChildForm(new KhachHang());
            }
            else
            {
                kh.BringToFront();
            }
        }

        /// <summary>
        /// Btn nhân sự.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private NhanSu ns;
        private void btnThongTinNhanSu_Click(object sender, EventArgs e)
        {
            if (ns == null || ns.IsDisposed)
            {
                openChildForm(new NhanSu());
            }
            else
            {
                ns.BringToFront();
            }
        }

        /// <summary>
        /// Btn phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private Phong p;
        private void btnPhong_Click(object sender, EventArgs e)
        {
            if (p == null || p.IsDisposed)
            {
                openChildForm(new Phong());
            }
            else
            {
                p.BringToFront();
            }
        }

        /// <summary>
        /// Btn loại phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private LoaiPhong lp;
        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            if (lp == null || lp.IsDisposed)
            {
                openChildForm(new LoaiPhong());
            }
            else
            {
                lp.BringToFront();
            }
        }

        /// <summary>
        /// Btn loại giường.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private LoaiGiuong lg;
        private void btnLoaiGiuong_Click(object sender, EventArgs e)
        {
            if (lg == null || lg.IsDisposed)
            {
                openChildForm(new LoaiGiuong());
            }
            else
            {
                lg.BringToFront();
            }
        }

        /// <summary>
        /// Btn sử dụng dịch vụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private SuDungDichVu sddv;
        private void btnSDDichVu_Click(object sender, EventArgs e)
        {
            if (sddv == null || sddv.IsDisposed)
            {
                openChildForm(new SuDungDichVu());
            }
            else
            {
                sddv.BringToFront();
            }
        }

        /// <summary>
        /// Btn món ăn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private MonAn ma;
        private void btnMonAn_Click(object sender, EventArgs e)
        {
            if (ma == null || ma.IsDisposed)
            {
                openChildForm(new MonAn());
            }
            else
            {
                ma.BringToFront();
            }
        }

        /// <summary>
        /// Btn thực đơn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private ComboMonAn cboMA;
        private void btnThucDon_Click(object sender, EventArgs e)
        {
            if (cboMA == null || cboMA.IsDisposed)
            {
                openChildForm(new ComboMonAn());
            }
            else
            {
                cboMA.BringToFront();
            }
        }

        /// <summary>
        /// Btn đặt tiệc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private DatTiec dt;
        private void btnDatTiec_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.IsDisposed)
            {
                openChildForm(new DatTiec());
            }
            else
            {
                dt.BringToFront();
            }
        }

        /// <summary>
        /// Btn thanh toán đặt phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private ThanhToanDatPhong ttdp;
        private void btnTTDatPhong_Click(object sender, EventArgs e)
        {
            if (ttdp == null || ttdp.IsDisposed)
            {
                openChildForm(new ThanhToanDatPhong());
            }
            else
            {
                ttdp.BringToFront();
            }
        }

        /// <summary>
        /// Btn đặt phòng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private DatPhong dp;
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (dp == null || dp.IsDisposed)
            {
                openChildForm(new DatPhong());
            }
            else
            {
                dp.BringToFront();
            }
        }

        /// <summary>
        /// Thanh toán đặt tiệc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private ThanhToanDatTiec ttdt;
        private void btnTTDatTiec_Click(object sender, EventArgs e)
        {
            if (ttdt == null || ttdt.IsDisposed)
            {
                openChildForm(new ThanhToanDatTiec());
            }
            else
            {
                ttdt.BringToFront();
            }
        }
    }
}
