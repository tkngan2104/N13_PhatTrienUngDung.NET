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
    public partial class ThongKeDatTiecTheoThang: Form
    {
        public ThongKeDatTiecTheoThang()
        {
            InitializeComponent();
        }

        public DateTime Data { get; set; }

        public ThongKeDatTiecTheoThang(DateTime data)
        {
            InitializeComponent();
            Data = data;

            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
        }

        private void ThongKeDatTiecTheoThang_Load(object sender, EventArgs e)
        {
            var dsDTTT = BUS_ThongKeDatTiec.Instance.ThongKeDatTiecTheoThang(Data.Year, Data.Month);
            try
            {
                // Clear previous data sources
                rptThongKeTheoThang.LocalReport.DataSources.Clear();

                // Setup new data sources
                ReportDataSource rds2 = new ReportDataSource("DataSetThongKeDatTiecTheoThang", dsDTTT);

                ReportParameter[] reportParameters = new ReportParameter[1];
                string userName = CurrentUser.UserName;
                reportParameters[0] = new ReportParameter("TenNhanSu", userName);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
