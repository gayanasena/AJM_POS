using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_shop
{
    public partial class ReportsControl1 : UserControl
    {
        public ReportsControl1()
        {
            InitializeComponent();
            cmbTable.SelectedIndex = 0;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(cmbTable.SelectedItem == "Customers Details Report")
            {
                reportViewer1.Visible = true;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                reportViewer1.Clear();
                this.CustomerTableAdapter.Fill(this.DataSetForReports.Customer);
                this.reportViewer1.RefreshReport();
            }
            else if(cmbTable.SelectedItem == "Sold Item Log Report (Sales)")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = true;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                reportViewer2.Clear();
                this.SalesLogTableAdapter.Fill(this.DataSetForReports.SalesLog);
                this.reportViewer2.RefreshReport();
            }
            else if (cmbTable.SelectedItem == "Inventory Report (Stock)")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = true;
                reportViewer4.Visible = false;
                reportViewer3.Clear();
                this.InventoryTableAdapter.Fill(this.DataSetForReports.Inventory);
                this.reportViewer3.RefreshReport();
            }
            else if(cmbTable.SelectedItem == "Monthly Sales Report")
            {
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = true;
                reportViewer4.Clear();
                string month = DateTime.Now.ToString("MM");
                int mon = int.Parse(month);
                this.OrdersTableAdapter.Fill(this.DataSetForReports.Orders, mon + "%");
                this.reportViewer4.RefreshReport();
            }
        }
    }
}
