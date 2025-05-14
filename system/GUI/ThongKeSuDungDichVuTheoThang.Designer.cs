namespace GUI
{
    partial class ThongKeSuDungDichVuTheoThang
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
            this.rptThongKeSDDVTheoThang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptThongKeSDDVTheoThang
            // 
            this.rptThongKeSDDVTheoThang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptThongKeSDDVTheoThang.LocalReport.ReportEmbeddedResource = "GUI.rpt_ThongKeSuDungDichVuTheoThang.rdlc";
            this.rptThongKeSDDVTheoThang.Location = new System.Drawing.Point(0, 90);
            this.rptThongKeSDDVTheoThang.Name = "rptThongKeSDDVTheoThang";
            this.rptThongKeSDDVTheoThang.ServerReport.BearerToken = null;
            this.rptThongKeSDDVTheoThang.Size = new System.Drawing.Size(1451, 898);
            this.rptThongKeSDDVTheoThang.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnExit.Location = new System.Drawing.Point(1258, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ThongKeSuDungDichVuTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1451, 988);
            this.Controls.Add(this.rptThongKeSDDVTheoThang);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeSuDungDichVuTheoThang";
            this.Text = "ThongKeSuDungDichVuTheoThang";
            this.Load += new System.EventHandler(this.ThongKeSuDungDichVuTheoThang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptThongKeSDDVTheoThang;
        private System.Windows.Forms.Button btnExit;
    }
}