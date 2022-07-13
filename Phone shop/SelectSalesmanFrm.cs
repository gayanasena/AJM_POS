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
    public partial class SelectSalesmanFrm : Form
    {
        public SelectSalesmanFrm()
        {
            InitializeComponent();
        }

        Connection cs = new Connection();

        private void btnSSMSrc_Click(object sender, EventArgs e)
        {
            if (txtSSmSrc.Text.Length <= 0)
            {
                string quary = "SELECT id,position,name,mobile FROM Employee";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridSelectSale.DataSource = obj;
                    dataGridSelectSale.Columns[0].HeaderCell.Value = "Employee ID";
                    dataGridSelectSale.Columns[1].HeaderCell.Value = "Position";
                    dataGridSelectSale.Columns[2].HeaderCell.Value = "Name";
                    dataGridSelectSale.Columns[3].HeaderCell.Value = "Mobile No";
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
                string quary = "SELECT id,position,name,mobile FROM Employee WHERE name Like '" + txtSSmSrc.Text + "%';";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridSelectSale.DataSource = obj;
                    dataGridSelectSale.Columns[0].HeaderCell.Value = "Employee ID";
                    dataGridSelectSale.Columns[1].HeaderCell.Value = "Position";
                    dataGridSelectSale.Columns[2].HeaderCell.Value = "Name";
                    dataGridSelectSale.Columns[3].HeaderCell.Value = "Mobile No";
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
        
    }

        private void dataGridSelectSale_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String getId = dataGridSelectSale.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblEmpID.Text = getId;
        }

    }
}
