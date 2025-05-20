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
    public partial class ThongKeDatPhongTheoNam : Form
    {
        public ThongKeDatPhongTheoNam()
        {
            InitializeComponent();
        }
        public DateTime Data { get; set; }
        public ThongKeDatPhongTheoNam(DateTime data)
        {
            InitializeComponent();
            Data = data;
            // Bạn có thể thao tác với dữ liệu ở đây, ví dụ hiển thị lên một control nào đó
        }
        private void ThongKeDatPhongTheoNam_Load(object sender, EventArgs e)
        {

            var dsDPTN = BUS_ThongKeDatPhong.Instance.ThongKeDatPhongTheoNam(Data.Year);
            try
            {
                // Clear previous data sources
                rpt_ThongKePhongTHeoNam.LocalReport.DataSources.Clear();

                // Setup new data sources
                ReportDataSource rds1 = new ReportDataSource("DataSetThongTinPhongTheoNam", dsDPTN);

                ReportParameter[] reportParameters = new ReportParameter[1];
                string userName = CurrentUser.UserName;
                reportParameters[0] = new ReportParameter("TenNhanSu", userName);
                rpt_ThongKePhongTHeoNam.LocalReport.SetParameters(reportParameters);
                rpt_ThongKePhongTHeoNam.LocalReport.DataSources.Add(rds1);

                // Refresh and show the report
                rpt_ThongKePhongTHeoNam.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load report: " + ex.Message);
            }
            this.rpt_ThongKePhongTHeoNam.RefreshReport();
        }
    }
}
