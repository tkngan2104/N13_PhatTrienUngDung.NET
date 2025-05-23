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
    public partial class ThongKeSuDungDichVuTheoNam: Form
    {
        public ThongKeSuDungDichVuTheoNam()
        {
            InitializeComponent();
        }

        public DateTime Data { get; set; }

        public ThongKeSuDungDichVuTheoNam(DateTime data)
        {
            InitializeComponent();
            Data = data;

            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongKeSuDungDichVuTheoNam_Load(object sender, EventArgs e)
        {
            var dsDTTN = BUS_ThongKeSuDungDichVu.Instance.ThongKeDichVuTheoNam(Data.Year);
            try
            {
                // Clear previous data sources
                rptThongKeSDDVTheoNam.LocalReport.DataSources.Clear();

                // Setup new data sources
                ReportDataSource rds1 = new ReportDataSource("DataSetThongKeSDDVTheoNam", dsDTTN);

                ReportParameter[] reportParameters = new ReportParameter[1];
                string userName = CurrentUser.UserName;
                reportParameters[0] = new ReportParameter("TenNhanSu", userName);
                rptThongKeSDDVTheoNam.LocalReport.SetParameters(reportParameters);
                rptThongKeSDDVTheoNam.LocalReport.DataSources.Add(rds1);

                // Refresh and show the report
                rptThongKeSDDVTheoNam.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load report: " + ex.Message);
            }
            this.rptThongKeSDDVTheoNam.RefreshReport();
        }
    }
}
