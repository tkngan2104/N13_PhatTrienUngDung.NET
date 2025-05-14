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
    public partial class ThongKeSuDungDichVuTheoThang: Form
    {
        public ThongKeSuDungDichVuTheoThang()
        {
            InitializeComponent();
        }

        public DateTime Data { get; set; }

        public ThongKeSuDungDichVuTheoThang(DateTime data)
        {
            InitializeComponent();
            Data = data;

            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongKeSuDungDichVuTheoThang_Load(object sender, EventArgs e)
        {
            var dsSDDVTT = BUS_ThongKeSuDungDichVu.Instance.ThongKeDichVuTheoThang(Data.Month, Data.Year);
            try
            {
                // Clear previous data sources
                rptThongKeSDDVTheoThang.LocalReport.DataSources.Clear();

                // Setup new data sources
                ReportDataSource rds2 = new ReportDataSource("DataSetThongKeSDDVTheoThang", dsSDDVTT);

                ReportParameter[] reportParameters = new ReportParameter[1];
                string userName = CurrentUser.UserName;
                reportParameters[0] = new ReportParameter("TenNhanSu", userName);
                rptThongKeSDDVTheoThang.LocalReport.SetParameters(reportParameters);
                rptThongKeSDDVTheoThang.LocalReport.DataSources.Add(rds2);

                // Refresh and show the report
                rptThongKeSDDVTheoThang.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load report: " + ex.Message);
            }
        }
    }
}
