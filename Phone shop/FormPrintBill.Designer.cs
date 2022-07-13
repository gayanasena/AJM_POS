namespace Phone_shop
{
    partial class FormPrintBill
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalesLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetForBill = new Phone_shop.DataSetForBill();
            this.SalesLogTableAdapter = new Phone_shop.DataSetForBillTableAdapters.SalesLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForBill)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalesLogBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Phone_shop.ReportBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(824, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalesLogBindingSource
            // 
            this.SalesLogBindingSource.DataMember = "SalesLog";
            this.SalesLogBindingSource.DataSource = this.DataSetForBill;
            // 
            // DataSetForBill
            // 
            this.DataSetForBill.DataSetName = "DataSetForBill";
            this.DataSetForBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesLogTableAdapter
            // 
            this.SalesLogTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPrintBill";
            this.Text = "Print Bill";
            this.Load += new System.EventHandler(this.FormPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesLogBindingSource;
        private DataSetForBill DataSetForBill;
        private DataSetForBillTableAdapters.SalesLogTableAdapter SalesLogTableAdapter;
    }
}