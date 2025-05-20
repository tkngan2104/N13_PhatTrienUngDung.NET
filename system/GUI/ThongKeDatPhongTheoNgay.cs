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
    public partial class ThongKeDatPhongTheoNgay : Form
    {
        public ThongKeDatPhongTheoNgay()
        {
            InitializeComponent();
        }

        private void ThongKeDatPhongTheoNgay_Load(object sender, EventArgs e)
        {
            var dsDPTN = BUS_ThongKeDatPhong.Instance.ThongKeDatPhongTheoNgay(Data);
            try
            {
                // Clear previous data sources
                rpt_ThongKeDatPhongTheoNgay.LocalReport.DataSources.Clear();

                // Setup new data sources
                ReportDataSource rds1 = new ReportDataSource("DataSetThongTinTheoNgay", dsDPTN);

                ReportParameter[] reportParameters = new ReportParameter[1];
                string userName = CurrentUser.UserName;
                reportParameters[0] = new ReportParameter("TenNhanSu", userName);
                rpt_ThongKeDatPhongTheoNgay.LocalReport.SetParameters(reportParameters);
                rpt_ThongKeDatPhongTheoNgay.LocalReport.DataSources.Add(rds1);

                // Refresh and show the report
                rpt_ThongKeDatPhongTheoNgay.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load report: " + ex.Message + Data);
            }
            this.rpt_ThongKeDatPhongTheoNgay.RefreshReport();
        }

        public DateTime Data { get; set; }
        public ThongKeDatPhongTheoNgay(DateTime data)
        {
            InitializeComponent();
            Data = data;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
        }
    }
}
