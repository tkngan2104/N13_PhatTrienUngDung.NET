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
            this.rptThongKeTheoThang.RefreshReport();
            this.rptThongKeTheoNam.RefreshReport();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (radNgay.Checked == true)
            {
                dgvTim.DataSource = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNgay(dtpNgay1.Value);
            }
            else if (radThang.Checked == true)
            {
                dgvTim.DataSource = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoThang(dtpNgay1.Value.Year, dtpNgay1.Value.Month);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                //var dsDTTN = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNgay(dtpNgay.Value);
                //try
                //{
                //    // Clear previous data sources
                //    rptThongKeTheoNgay.LocalReport.DataSources.Clear();

                //    // Setup new data sources
                //    ReportDataSource rds1 = new ReportDataSource("DataSetThongKeDatTiecTheoNgay", dsDTTN);

                //    ReportParameter[] reportParameters = new ReportParameter[1];
                //    string userName = CurrentUser.UserName;
                //    reportParameters[0] = new ReportParameter("TenNhanVien", userName);
                //    rptThongKeTheoNgay.LocalReport.SetParameters(reportParameters);
                //    rptThongKeTheoNgay.LocalReport.DataSources.Add(rds1);

                //    // Refresh and show the report
                //    rptThongKeTheoNgay.RefreshReport();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Failed to load report: " + ex.Message);
                //}

                Menu formMenu = (Menu)this.ParentForm;
                formMenu.openChildForm(new ThongKeDatTiecTheoNgay(dtpNgay1.Value));

            }
            else if (radThang.Checked == true)
            {
                var dsDTTT = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoThang(dtpNgay.Value.Year, dtpNgay1.Value.Month);
                try
                {
                    // Clear previous data sources
                    rptThongKeTheoThang.LocalReport.DataSources.Clear();

                    // Setup new data sources
                    ReportDataSource rds2 = new ReportDataSource("DataSetThongKeDatTiecTheoThang", dsDTTT);

                    ReportParameter[] reportParameters = new ReportParameter[1];
                    string userName = CurrentUser.UserName;
                    reportParameters[0] = new ReportParameter("TenNhanVien", userName);
                    rptThongKeTheoThang.LocalReport.SetParameters(reportParameters);
                    rptThongKeTheoThang.LocalReport.DataSources.Add(rds2);

                    // Refresh and show the report
                    rptThongKeTheoThang.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load report: " + ex.Message);
                }
            }
            //else if (radNam.Checked == true)
            //{
            //    var dsDTTN = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNam(dtpNgay.Value.Year, dtpNgay.Value.Month);
            //    try
            //    {
            //        // Clear previous data sources
            //        rptThongKeTheoThang.LocalReport.DataSources.Clear();

            //        // Setup new data sources
            //        ReportDataSource rds2 = new ReportDataSource("DataSetThongKeDatTiecTheoThang", dsDTTT);

            //        ReportParameter[] reportParameters = new ReportParameter[1];
            //        string userName = CurrentUser.UserName;
            //        reportParameters[0] = new ReportParameter("TenNhanVien", userName);
            //        rptThongKeTheoThang.LocalReport.SetParameters(reportParameters);
            //        rptThongKeTheoThang.LocalReport.DataSources.Add(rds2);

            //        // Refresh and show the report
            //        rptThongKeTheoThang.RefreshReport();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Failed to load report: " + ex.Message);
            //    }
            //}
        }
    }
}
