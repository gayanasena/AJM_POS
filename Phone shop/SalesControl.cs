using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_shop
{
    public partial class SalesControl : UserControl
    {
        public SalesControl()
        {
            InitializeComponent();
            cmbFind.SelectedIndex = 0;
        }

        Connection cs = new Connection();
        private void BtnLogSrc_Click(object sender, EventArgs e)
        {

            if (txtLogSrc.Text.Length <= 0)
            {
                string quary = "SELECT SalesLog.odrId, SalesLog.brand,SalesLog.model, SalesLog.imei, SalesLog.qty,  Orders.amount, Orders.mobile, Orders.type, Orders.salesman, Orders.date FROM Orders INNER JOIN SalesLog ON Orders.Id = SalesLog.odrId ";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewLog.DataSource = obj;
                    dataGridViewLog.Columns[0].HeaderCell.Value = "Order ID";
                    dataGridViewLog.Columns[1].HeaderCell.Value = "Brand";
                    dataGridViewLog.Columns[2].HeaderCell.Value = "Model";
                    dataGridViewLog.Columns[3].HeaderCell.Value = "IMEI";
                    dataGridViewLog.Columns[4].HeaderCell.Value = "Quantity";
                    dataGridViewLog.Columns[5].HeaderCell.Value = "Amount(Rs)";
                    dataGridViewLog.Columns[6].HeaderCell.Value = "Customer Mobile";
                    dataGridViewLog.Columns[7].HeaderCell.Value = "Sales Type";
                    dataGridViewLog.Columns[8].HeaderCell.Value = "Salesman";
                    dataGridViewLog.Columns[9].HeaderCell.Value = "Sales Date/Time";
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
                string quary = "SELECT SalesLog.odrId ,SalesLog.brand,  SalesLog.model , SalesLog.imei, SalesLog.qty,  Orders.amount, Orders.mobile, Orders.type, Orders.salesman, Orders.date FROM Orders INNER JOIN SalesLog ON Orders.Id = SalesLog.odrId WHERE SalesLog.imei = '" + txtLogSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewLog.DataSource = obj;
                    dataGridViewLog.Columns[0].HeaderCell.Value = "Order ID";
                    dataGridViewLog.Columns[1].HeaderCell.Value = "Brand";
                    dataGridViewLog.Columns[2].HeaderCell.Value = "Model";
                    dataGridViewLog.Columns[3].HeaderCell.Value = "IMEI";
                    dataGridViewLog.Columns[4].HeaderCell.Value = "Quantity";
                    dataGridViewLog.Columns[5].HeaderCell.Value = "Amount(Rs)";
                    dataGridViewLog.Columns[6].HeaderCell.Value = "Customer Mobile";
                    dataGridViewLog.Columns[7].HeaderCell.Value = "Sales Type";
                    dataGridViewLog.Columns[8].HeaderCell.Value = "Salesman";
                    dataGridViewLog.Columns[9].HeaderCell.Value = "Sales Date/Time";
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
            else if (cmbFind.SelectedItem == "Date")
            {
                string quary = "SELECT SalesLog.odrId,SalesLog.brand, SalesLog.model, SalesLog.imei, SalesLog.qty,  Orders.amount, Orders.mobile, Orders.type, Orders.salesman, Orders.date FROM Orders INNER JOIN SalesLog ON Orders.Id = SalesLog.odrId WHERE Orders.date LIKE '" + txtLogSrc.Text + "%'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewLog.DataSource = obj;
                    dataGridViewLog.Columns[0].HeaderCell.Value = "Order ID";
                    dataGridViewLog.Columns[1].HeaderCell.Value = "Brand";
                    dataGridViewLog.Columns[2].HeaderCell.Value = "Model";
                    dataGridViewLog.Columns[3].HeaderCell.Value = "IMEI";
                    dataGridViewLog.Columns[4].HeaderCell.Value = "Quantity";
                    dataGridViewLog.Columns[5].HeaderCell.Value = "Amount(Rs)";
                    dataGridViewLog.Columns[6].HeaderCell.Value = "Customer Mobile";
                    dataGridViewLog.Columns[7].HeaderCell.Value = "Sales Type";
                    dataGridViewLog.Columns[8].HeaderCell.Value = "Salesman";
                    dataGridViewLog.Columns[9].HeaderCell.Value = "Sales Date/Time";
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

        private void BtnLogSrc_MouseHover(object sender, EventArgs e)
        {
            if (txtLogSrc.Text.Length <= 0)
            {
                BtnLogSrc.Text = "View All";
            }
            else
            {
                BtnLogSrc.Text = "Search";
            }
        }
    }
}
