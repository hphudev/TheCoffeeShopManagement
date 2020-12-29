namespace CoffeeShopManagement.Report
{
    partial class PrintPreview
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportDataset = new CoffeeShopManagement.ReportDataset.ReportDataset();
            this.reportDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableQuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableQuanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableCTHDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableQuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableQuanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCTHDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QUAN";
            reportDataSource1.Value = this.dataTableQuanBindingSource;
            reportDataSource2.Name = "HOADON";
            reportDataSource2.Value = this.dataTableHoaDonBindingSource;
            reportDataSource3.Name = "CTHD";
            reportDataSource3.Value = this.dataTableCTHDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CoffeeShopManagement.Report.ReportPhieuThanhToan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(826, 658);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportDataset
            // 
            this.reportDataset.DataSetName = "ReportDataset";
            this.reportDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportDatasetBindingSource
            // 
            this.reportDatasetBindingSource.DataSource = this.reportDataset;
            this.reportDatasetBindingSource.Position = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTableCTHD";
            this.dataTable1BindingSource.DataSource = this.reportDatasetBindingSource;
            // 
            // dataTableCTHDBindingSource
            // 
            this.dataTableCTHDBindingSource.DataMember = "DataTableCTHD";
            this.dataTableCTHDBindingSource.DataSource = this.reportDatasetBindingSource;
            // 
            // dataTableQuanBindingSource
            // 
            this.dataTableQuanBindingSource.DataMember = "DataTableQuan";
            this.dataTableQuanBindingSource.DataSource = this.reportDatasetBindingSource;
            // 
            // dataTableQuanBindingSource1
            // 
            this.dataTableQuanBindingSource1.DataMember = "DataTableQuan";
            this.dataTableQuanBindingSource1.DataSource = this.reportDatasetBindingSource;
            // 
            // dataTableHoaDonBindingSource
            // 
            this.dataTableHoaDonBindingSource.DataMember = "DataTableHoaDon";
            this.dataTableHoaDonBindingSource.DataSource = this.reportDatasetBindingSource;
            // 
            // dataTableCTHDBindingSource1
            // 
            this.dataTableCTHDBindingSource1.DataMember = "DataTableCTHD";
            this.dataTableCTHDBindingSource1.DataSource = this.reportDatasetBindingSource;
            // 
            // PrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 658);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintPreview";
            this.Text = "PrintPreview";
            this.Load += new System.EventHandler(this.PrintPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableQuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableQuanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCTHDBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportDataset.ReportDataset reportDataset;
        private System.Windows.Forms.BindingSource reportDatasetBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTableQuanBindingSource;
        private System.Windows.Forms.BindingSource dataTableHoaDonBindingSource;
        private System.Windows.Forms.BindingSource dataTableCTHDBindingSource;
        private System.Windows.Forms.BindingSource dataTableQuanBindingSource1;
        private System.Windows.Forms.BindingSource dataTableCTHDBindingSource1;
    }
}