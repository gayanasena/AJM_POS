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
    public partial class ViewItemControl1 : UserControl
    {
        public ViewItemControl1()
        {
            InitializeComponent();
        }

        Connection cs = new Connection();

        private void BtnInvViewSrc_MouseHover(object sender, EventArgs e)
        {
            if (txtInvViewSrc.Text.Length <= 0)
            {
                BtnInvViewSrc.Text = "View All";
            }
            else
            {
                BtnInvViewSrc.Text = "Search";
            }
        }

        private void BtnInvViewSrc_Click(object sender, EventArgs e)
        {
            if (txtInvViewSrc.Text.Length <= 0)
            {
                string quary = "SELECT * FROM inventory";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewInvView.DataSource = obj;
                    dataGridViewInvView.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewInvView.Columns[1].HeaderCell.Value = "Category";
                    dataGridViewInvView.Columns[2].HeaderCell.Value = "Supplier";
                    dataGridViewInvView.Columns[3].HeaderCell.Value = "Custom Code";
                    dataGridViewInvView.Columns[4].HeaderCell.Value = "Brand";
                    dataGridViewInvView.Columns[5].HeaderCell.Value = "Model";
                    dataGridViewInvView.Columns[6].HeaderCell.Value = "Barcode";
                    dataGridViewInvView.Columns[7].HeaderCell.Value = "Selling Price";
                    dataGridViewInvView.Columns[8].HeaderCell.Value = "Available Qty";
                    dataGridViewInvView.Columns[9].HeaderCell.Value = "Added Date";
                    dataGridViewInvView.Columns[10].HeaderCell.Value = "IMEI*";
                    dataGridViewInvView.Columns[11].HeaderCell.Value = "Capacity*";
                    dataGridViewInvView.Columns[12].HeaderCell.Value = "Colour*";
                    dataGridViewInvView.Columns[13].HeaderCell.Value = "Current Station";
                }
                catch
                {
                    MessageBox.Show("Error , Please contact your IT support !");
                }
                finally
                {
                    cs.CloseConnection();
                }
            }
            else if (cmbFind.SelectedItem == "IMEI")
            {
                string quary = "SELECT * FROM inventory WHERE IMEI = '" + txtInvViewSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewInvView.DataSource = obj;
                    dataGridViewInvView.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewInvView.Columns[1].HeaderCell.Value = "Category";
                    dataGridViewInvView.Columns[2].HeaderCell.Value = "Supplier";
                    dataGridViewInvView.Columns[3].HeaderCell.Value = "Custom Code";
                    dataGridViewInvView.Columns[4].HeaderCell.Value = "Brand";
                    dataGridViewInvView.Columns[5].HeaderCell.Value = "Model";
                    dataGridViewInvView.Columns[6].HeaderCell.Value = "Barcode";
                    dataGridViewInvView.Columns[7].HeaderCell.Value = "Selling Price";
                    dataGridViewInvView.Columns[8].HeaderCell.Value = "Available Qty";
                    dataGridViewInvView.Columns[9].HeaderCell.Value = "Added Date";
                    dataGridViewInvView.Columns[10].HeaderCell.Value = "IMEI*";
                    dataGridViewInvView.Columns[11].HeaderCell.Value = "Capacity*";
                    dataGridViewInvView.Columns[12].HeaderCell.Value = "Colour*";
                    dataGridViewInvView.Columns[13].HeaderCell.Value = "Current Station";
                }
                catch
                {
                    MessageBox.Show("Error , Please contact your IT support !");
                }
                finally
                {
                    cs.CloseConnection();
                }
            }
            else if (cmbFind.SelectedItem == "Model")
            {
                string quary = "SELECT * FROM inventory WHERE Model = '" + txtInvViewSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewInvView.DataSource = obj;
                    dataGridViewInvView.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewInvView.Columns[1].HeaderCell.Value = "Category";
                    dataGridViewInvView.Columns[2].HeaderCell.Value = "Supplier";
                    dataGridViewInvView.Columns[3].HeaderCell.Value = "Custom Code";
                    dataGridViewInvView.Columns[4].HeaderCell.Value = "Brand";
                    dataGridViewInvView.Columns[5].HeaderCell.Value = "Model";
                    dataGridViewInvView.Columns[6].HeaderCell.Value = "Barcode";
                    dataGridViewInvView.Columns[7].HeaderCell.Value = "Selling Price";
                    dataGridViewInvView.Columns[8].HeaderCell.Value = "Available Qty";
                    dataGridViewInvView.Columns[9].HeaderCell.Value = "Added Date";
                    dataGridViewInvView.Columns[10].HeaderCell.Value = "IMEI*";
                    dataGridViewInvView.Columns[11].HeaderCell.Value = "Capacity*";
                    dataGridViewInvView.Columns[12].HeaderCell.Value = "Colour*";
                    dataGridViewInvView.Columns[13].HeaderCell.Value = "Current Station";
                }
                catch
                {
                    MessageBox.Show("Error , Please contact your IT support !");
                }
                finally
                {
                    cs.CloseConnection();
                }
            }
            else if (cmbFind.SelectedItem == "Item Code")
            {
                string quary = "SELECT * FROM inventory WHERE itemCode = '" + txtInvViewSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewInvView.DataSource = obj;
                    dataGridViewInvView.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewInvView.Columns[1].HeaderCell.Value = "Category";
                    dataGridViewInvView.Columns[2].HeaderCell.Value = "Supplier";
                    dataGridViewInvView.Columns[3].HeaderCell.Value = "Custom Code";
                    dataGridViewInvView.Columns[4].HeaderCell.Value = "Brand";
                    dataGridViewInvView.Columns[5].HeaderCell.Value = "Model";
                    dataGridViewInvView.Columns[6].HeaderCell.Value = "Barcode";
                    dataGridViewInvView.Columns[7].HeaderCell.Value = "Selling Price";
                    dataGridViewInvView.Columns[8].HeaderCell.Value = "Available Qty";
                    dataGridViewInvView.Columns[9].HeaderCell.Value = "Added Date";
                    dataGridViewInvView.Columns[10].HeaderCell.Value = "IMEI*";
                    dataGridViewInvView.Columns[11].HeaderCell.Value = "Capacity*";
                    dataGridViewInvView.Columns[12].HeaderCell.Value = "Colour*";
                    dataGridViewInvView.Columns[13].HeaderCell.Value = "Current Station";
                }
                catch
                {
                    MessageBox.Show("Error , Please contact your IT support !");
                }
                finally
                {
                    cs.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Please select a searching field !");
            }
        }
        public void setAutoFillData()
        {
            string quary = "SELECT model FROM inventory;";

            try
            {
                cs.OpenConnection();
                object textObj = cs.MenuDataGet(quary);

                txtInvViewSrc.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj;
            }
            catch
            {
                MessageBox.Show("Please contact your IT Support ! ");
            }
            finally
            {
                cs.CloseConnection();
            }
        }
        private void ViewItemControl1_Load(object sender, EventArgs e)
        {
            setAutoFillData();
        }
    }
}
