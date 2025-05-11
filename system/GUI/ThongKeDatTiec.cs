using BUS;
using ET;
using Microsoft.Reporting.WinForms;
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
    public partial class ThongKeDatTiec: Form
    {
        public ThongKeDatTiec()
        {
            InitializeComponent();
        }

        private void ThongKeDatTiec_Load(object sender, EventArgs e)
        {

            this.rptThongKeTheoNgay.RefreshReport();
            this.rptThongKeTheoThang.RefreshReport();
            this.rptThongKeTheoNam.RefreshReport();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (radNgay.Checked == true)
            {
                dgvTim.DataSource = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNgay(dtpNgay.Value);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                var dsDTTN = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNgay(dtpNgay.Value);
                var dsDTTT = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNgay(dtpNgay.Value);
                var dsDTTNam = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNgay(dtpNgay.Value);
                try
                {
                    // Clear previous data sources
                    rptThongKeTheoNgay.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds1 = new ReportDataSource("DataSetThongKeDatTiecTheoNgay", dsDTTN);
                    ReportDataSource rds2 = new ReportDataSource("DataSetThongKeDatTiecTheoThang", dsDTTN);
                    ReportDataSource rds3 = new ReportDataSource("DataSetThongKeDatTiecTheoNam", dsDTTN);

                    ReportParameter[] reportParameters = new ReportParameter[1];
                    string userName = CurrentUser.UserName;
                    reportParameters[0] = new ReportParameter("TenNhanVien", userName);
                    rptThongKeTheoNgay.LocalReport.SetParameters(reportParameters);
                    rptThongKeTheoNgay.LocalReport.DataSources.Add(rds1);
                    rptThongKeTheoNgay.LocalReport.SetParameters(reportParameters);
                    rptThongKeTheoThang.LocalReport.DataSources.Add(rds2);
                    rptThongKeTheoNgay.LocalReport.SetParameters(reportParameters);
                    rptThongKeTheoNam.LocalReport.DataSources.Add(rds3);

                    // Refresh and show the report
                    rptThongKeTheoNgay.RefreshReport();
                    rptThongKeTheoThang.RefreshReport();
                    rptThongKeTheoNam.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
        }
    }
}
