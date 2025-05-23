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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class InHoaDonDatPhong : Form
    {
        public InHoaDonDatPhong()
        {
            InitializeComponent();
        }

        private void InHoaDonDatPhong_Load(object sender, EventArgs e)
        {
            List<ET_InHoaDonThanhToanDatPhong> ds = new BUS_InHoaDonThanhToanDP().LayDanhSachHoaDonDP();

            ReportDataSource rds = new ReportDataSource("DataSetInHoaDonThanhToanDP", ds); // tên Dataset trong RDLC
            ReportParameter[] reportParameters = new ReportParameter[1];
            string userName = CurrentUser.UserName;
            reportParameters[0] = new ReportParameter("TenNhanSu", userName);
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.InHoaDonThanhToanDP.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
