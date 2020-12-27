namespace CoffeeShopManagement
{
    partial class FormReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableQuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataset = new CoffeeShopManagement.ReportDataset.ReportDataset();
            this.dataTableHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableQuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCTHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableQuanBindingSource
            // 
            this.dataTableQuanBindingSource.DataMember = "DataTableQuan";
            this.dataTableQuanBindingSource.DataSource = this.reportDataset;
            // 
            // reportDataset
            // 
            this.reportDataset.DataSetName = "ReportDataset";
            this.reportDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableHoaDonBindingSource
            // 
            this.dataTableHoaDonBindingSource.DataMember = "DataTableHoaDon";
            this.dataTableHoaDonBindingSource.DataSource = this.reportDataset;
            // 
            // dataTableCTHDBindingSource
            // 
            this.dataTableCTHDBindingSource.DataMember = "DataTableCTHD";
            this.dataTableCTHDBindingSource.DataSource = this.reportDataset;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "QUAN";
            reportDataSource4.Value = this.dataTableQuanBindingSource;
            reportDataSource5.Name = "HOADON";
            reportDataSource5.Value = this.dataTableHoaDonBindingSource;
            reportDataSource6.Name = "CTHD";
            reportDataSource6.Value = this.dataTableCTHDBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CoffeeShopManagement.Report.ReportPhieuThanhToan.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(925, 913);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Load += new System.EventHandler(this.ReportViewer_Load);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 913);
            this.Controls.Add(this.reportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReport_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableQuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCTHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource dataTableCTHDBindingSource;
        private ReportDataset.ReportDataset reportDataset;
        private System.Windows.Forms.BindingSource dataTableHoaDonBindingSource;
        private System.Windows.Forms.BindingSource dataTableQuanBindingSource;
    }
}