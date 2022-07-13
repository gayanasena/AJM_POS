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
    public partial class FormPrintBill : Form
    {
        double order_Id = 1;

        public FormPrintBill()
        {
            InitializeComponent();
        }
        public FormPrintBill(double orderID)
        {
            InitializeComponent();
            order_Id = orderID;
        }

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetForBill.SalesLog' table. You can move, or remove it, as needed.
            this.SalesLogTableAdapter.Fill(this.DataSetForBill.SalesLog,Convert.ToInt32(order_Id));
            this.reportViewer1.RefreshReport();
        }
    }
}
