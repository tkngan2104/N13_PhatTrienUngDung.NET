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
    public partial class ThongKeDatPhongTheoThang : Form
    {
        public ThongKeDatPhongTheoThang()
        {
            InitializeComponent();
        }
        public DateTime Data { get; set; }

        public ThongKeDatPhongTheoThang(DateTime data)
        {
            InitializeComponent();
            Data = data;

            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
        }
        private void ThongKeDatPhongTheoThang_Load(object sender, EventArgs e)
        {

            var dsDPTT = BUS_ThongKeDatPhong.Instance.ThongKeDatPhongTheoThang(Data.Year, Data.Month);
            try
            {
                // Clear previous data sources
                rpt_ThongKePhongTheoThang.LocalReport.DataSources.Clear();

                // Setup new data sources
                ReportDataSource rds2 = new ReportDataSource("DataSetThongTinPhongTheoThang", dsDPTT);

                ReportParameter[] reportParameters = new ReportParameter[1];
                string userName = CurrentUser.UserName;
                reportParameters[0] = new ReportParameter("TenNhanSu", userName);
                rpt_ThongKePhongTheoThang.LocalReport.SetParameters(reportParameters);
                rpt_ThongKePhongTheoThang.LocalReport.DataSources.Add(rds2);

                // Refresh and show the report
                rpt_ThongKePhongTheoThang.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load report: " + ex.Message);
            }
        }
    }
}
