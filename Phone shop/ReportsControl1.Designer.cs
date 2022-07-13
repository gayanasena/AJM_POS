
namespace Phone_shop
{
    partial class ReportsControl1
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

        #region Component Designer generated code

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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetForReports = new Phone_shop.DataSetForReports();
            this.SalesLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblHeadingTxt = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomerTableAdapter = new Phone_shop.DataSetForReportsTableAdapters.CustomerTableAdapter();
            this.SalesLogTableAdapter = new Phone_shop.DataSetForReportsTableAdapters.SalesLogTableAdapter();
            this.InventoryTableAdapter = new Phone_shop.DataSetForReportsTableAdapters.InventoryTableAdapter();
            this.OrdersTableAdapter = new Phone_shop.DataSetForReportsTableAdapters.OrdersTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataMember = "Customer";
            this.CustomerBindingSource.DataSource = this.DataSetForReports;
            // 
            // DataSetForReports
            // 
            this.DataSetForReports.DataSetName = "DataSetForReports";
            this.DataSetForReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesLogBindingSource
            // 
            this.SalesLogBindingSource.DataMember = "SalesLog";
            this.SalesLogBindingSource.DataSource = this.DataSetForReports;
            // 
            // InventoryBindingSource
            // 
            this.InventoryBindingSource.DataMember = "Inventory";
            this.InventoryBindingSource.DataSource = this.DataSetForReports;
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Orders";
            this.OrdersBindingSource.DataSource = this.DataSetForReports;
            // 
            // cmbTable
            // 
            this.cmbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTable.Font = new System.Drawing.Font("Century Gothic", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "Customers Details Report",
            "Sold Item Log Report (Sales)",
            "Inventory Report (Stock)",
            "Monthly Sales Report"});
            this.cmbTable.Location = new System.Drawing.Point(133, 58);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(394, 25);
            this.cmbTable.TabIndex = 147;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 146;
            this.label7.Text = "Select a report";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(548, 48);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(158, 40);
            this.btnPreview.TabIndex = 145;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(10, 16);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(86, 24);
            this.lblHeadingTxt.TabIndex = 148;
            this.lblHeadingTxt.Text = "Reports";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Phone_shop.ReportCusDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(692, 472);
            this.reportViewer1.TabIndex = 150;
            // 
            // CustomerTableAdapter
            // 
            this.CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // SalesLogTableAdapter
            // 
            this.SalesLogTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryTableAdapter
            // 
            this.InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SalesLogBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Phone_shop.ReportOrdersLog.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(14, 107);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(692, 472);
            this.reportViewer2.TabIndex = 151;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet4";
            reportDataSource3.Value = this.InventoryBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Phone_shop.ReportInventory.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(14, 107);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(692, 472);
            this.reportViewer3.TabIndex = 152;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DataSet5";
            reportDataSource4.Value = this.OrdersBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Phone_shop.ReportMonthlySales.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(14, 107);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(692, 472);
            this.reportViewer4.TabIndex = 153;
            // 
            // ReportsControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblHeadingTxt);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPreview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportsControl1";
            this.Size = new System.Drawing.Size(720, 594);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblHeadingTxt;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private DataSetForReports DataSetForReports;
        private DataSetForReportsTableAdapters.CustomerTableAdapter CustomerTableAdapter;
        private System.Windows.Forms.BindingSource SalesLogBindingSource;
        private DataSetForReportsTableAdapters.SalesLogTableAdapter SalesLogTableAdapter;
        private System.Windows.Forms.BindingSource InventoryBindingSource;
        private DataSetForReportsTableAdapters.InventoryTableAdapter InventoryTableAdapter;
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private DataSetForReportsTableAdapters.OrdersTableAdapter OrdersTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
    }
}
