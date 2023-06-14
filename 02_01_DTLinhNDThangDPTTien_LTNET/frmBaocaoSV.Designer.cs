namespace _02_01_DTLinhNDThangDPTTien_LTNET
{
    partial class frmBaocaoSV
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
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsv_02_DTLinhNDThangDPTTienDataSet = new _02_01_DTLinhNDThangDPTTien_LTNET.qlsv_02_DTLinhNDThangDPTTienDataSet();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sinhvienTableAdapter = new _02_01_DTLinhNDThangDPTTien_LTNET.qlsv_02_DTLinhNDThangDPTTienDataSetTableAdapters.sinhvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv_02_DTLinhNDThangDPTTienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.qlsv_02_DTLinhNDThangDPTTienDataSet;
            // 
            // qlsv_02_DTLinhNDThangDPTTienDataSet
            // 
            this.qlsv_02_DTLinhNDThangDPTTienDataSet.DataSetName = "qlsv_02_DTLinhNDThangDPTTienDataSet";
            this.qlsv_02_DTLinhNDThangDPTTienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sinhvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_02_01_DTLinhNDThangDPTTien_LTNET.ReportSV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaocaoSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaocaoSV";
            this.Text = "Báo cáo sinh viên QLSV_02_DTLinh_NDThang_DPTTien";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv_02_DTLinhNDThangDPTTienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private qlsv_02_DTLinhNDThangDPTTienDataSet qlsv_02_DTLinhNDThangDPTTienDataSet;
        private qlsv_02_DTLinhNDThangDPTTienDataSetTableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
    }
}