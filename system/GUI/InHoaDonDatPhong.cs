﻿using BUS;
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
    public partial class InHoaDonDatPhong : Form
    {
        public InHoaDonDatPhong()
        {
            InitializeComponent();
        }

        private void InHoaDonDatPhong_Load(object sender, EventArgs e)
        {
            List<ET_InHoaDonThanhToanDatPhong> ds = new BUS_InHoaDonThanhToanDP().LayDanhSachHoaDonDP();

            ReportDataSource rds = new ReportDataSource("dsHoaDonDatPhong", ds); // tên Dataset trong RDLC

            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report_HoaDonDatPhong.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }


    }
}
