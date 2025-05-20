namespace GUI
{
    partial class ThongKeDatPhongTheoNam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rpt_ThongKePhongTHeoNam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpt_ThongKePhongTHeoNam
            // 
            this.rpt_ThongKePhongTHeoNam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpt_ThongKePhongTHeoNam.LocalReport.ReportEmbeddedResource = "GUI.rpt_ThongKeDatPhongTheoNam.rdlc";
            this.rpt_ThongKePhongTHeoNam.Location = new System.Drawing.Point(0, 49);
            this.rpt_ThongKePhongTHeoNam.Name = "rpt_ThongKePhongTHeoNam";
            this.rpt_ThongKePhongTHeoNam.ServerReport.BearerToken = null;
            this.rpt_ThongKePhongTHeoNam.Size = new System.Drawing.Size(800, 401);
            this.rpt_ThongKePhongTHeoNam.TabIndex = 0;
            // 
            // ThongKeDatPhongTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpt_ThongKePhongTHeoNam);
            this.Name = "ThongKeDatPhongTheoNam";
            this.Text = "ThongKeDatPhongTheoNam";
            this.Load += new System.EventHandler(this.ThongKeDatPhongTheoNam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_ThongKePhongTHeoNam;
    }
}