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
    public partial class ThongKeDatTiecTheoNgay: Form
    {
        public ThongKeDatTiecTheoNgay()
        {
            InitializeComponent();
        }

        public DateTime Data { get; set; }
        public ThongKeDatTiecTheoNgay(DateTime data)
        {
            InitializeComponent();
            Data = data;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
        }

        private void ThongKeDatTiecTheoNgay_Load(object sender, EventArgs e)
        {

            var dsDTTN = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoNgay(Data);
            try
            {
                // Clear previous data sources
                rptThongKeTheoNgay.LocalReport.DataSources.Clear();

                // Setup new data sources
                ReportDataSource rds1 = new ReportDataSource("DataSetThongKeDatTiecTheoNgay", dsDTTN);

                ReportParameter[] reportParameters = new ReportParameter[1];
                string userName = CurrentUser.UserName;
                reportParameters[0] = new ReportParameter("TenNhanSu", userName);
                rptThongKeTheoNgay.LocalReport.SetParameters(reportParameters);
                rptThongKeTheoNgay.LocalReport.DataSources.Add(rds1);

                // Refresh and show the report
                rptThongKeTheoNgay.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load report: " + ex.Message + Data);
            }
            this.rptThongKeTheoNgay.RefreshReport();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
