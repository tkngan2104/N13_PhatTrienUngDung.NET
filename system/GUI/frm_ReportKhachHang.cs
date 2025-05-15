using System;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace GUI
{
    public partial class frm_ReportKhachHang : Form
    {
        public frm_ReportKhachHang()
        {
            InitializeComponent();
        }

        private void frm_ReportKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "rtpKhachHang.rpt");
                if (!File.Exists(path))
                {
                    MessageBox.Show("Không tìm thấy file rpt: " + path);
                    return;
                }

                ReportDocument rpt = new ReportDocument();
                rpt.Load(path);

               
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load báo cáo: " + ex.Message);
            }

            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }
    }
}
