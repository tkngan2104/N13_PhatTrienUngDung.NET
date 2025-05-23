using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmXuatHoaDon : Form
    {
        private string maHDDT;

        public frmXuatHoaDon()
        {
            InitializeComponent();
            this.maHDDT = null; 
        }

        private void frmXuatHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "rptHoaDonDatTiec.rpt");
                if (!File.Exists(path))
                {
                    MessageBox.Show("Không tìm thấy file rpt: " + path);
                    return;
                }

                ReportDocument rpt = new ReportDocument();
                rpt.Load(path);

                if (!string.IsNullOrEmpty(maHDDT))
                {
                    // Nếu có mã hóa đơn, filter theo mã đó
                    rpt.SetParameterValue("maHDDT", maHDDT);
                }
                else
                {
                    // Không có mã hóa đơn thì không lọc, hiện tất cả
                    // Có thể cần reset filter hoặc bỏ điều kiện ở report
                }

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
