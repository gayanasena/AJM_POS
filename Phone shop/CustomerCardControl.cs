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
    public partial class CustomerCardControl : UserControl
    {
        public CustomerCardControl()
        {
            InitializeComponent();
        }

        Connection cs = new Connection();

        int cus_Id = 0;

        public void setAutoFillData()
        {
            string quary = "SELECT name FROM Customer;";

            try
            {
                cs.OpenConnection();
                object textObj = cs.MenuDataGet(quary);

                txtCusCardSrc.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj;
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

        private void btnCusCardSrc_MouseHover(object sender, EventArgs e)
        {
            if (txtCusCardSrc.Text.Length <= 0)
            {
                btnCusCardSrc.Text = "View All";
            }
            else
            {
                btnCusCardSrc.Text = "Search";
            }
        }

        private void btnCusCardSrc_Click(object sender, EventArgs e)
        {
            if (txtCusCardSrc.Text.Length <= 0)
            {
                string quary = "SELECT * FROM Customer";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewCusCard.DataSource = obj;
                    dataGridViewCusCard.Columns[0].HeaderCell.Value = "Customer ID";
                    dataGridViewCusCard.Columns[1].HeaderCell.Value = "Type";
                    dataGridViewCusCard.Columns[2].HeaderCell.Value = "Name";
                    dataGridViewCusCard.Columns[3].HeaderCell.Value = "Mobile No";
                    dataGridViewCusCard.Columns[4].HeaderCell.Value = "Address Line 1";
                    dataGridViewCusCard.Columns[5].HeaderCell.Value = "Address Line 2";
                    dataGridViewCusCard.Columns[6].HeaderCell.Value = "City";
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
                string quary = "SELECT * FROM Customer WHERE name='" + txtCusCardSrc.Text + "';";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewCusCard.DataSource = obj;
                    dataGridViewCusCard.Columns[0].HeaderCell.Value = "Customer ID";
                    dataGridViewCusCard.Columns[1].HeaderCell.Value = "Type";
                    dataGridViewCusCard.Columns[2].HeaderCell.Value = "Name";
                    dataGridViewCusCard.Columns[3].HeaderCell.Value = "Mobile No";
                    dataGridViewCusCard.Columns[4].HeaderCell.Value = "Address Line 1";
                    dataGridViewCusCard.Columns[5].HeaderCell.Value = "Address Line 2";
                    dataGridViewCusCard.Columns[6].HeaderCell.Value = "City";
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

        private void CustomerCardControl_Load(object sender, EventArgs e)
        {
            setAutoFillData();
        }

        private void dataGridViewCusCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String getId = dataGridViewCusCard.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblCusCardID.Text = getId;
            cus_Id = Convert.ToInt32(getId);

            String catchStr1 = "";

            // get name field
            try
            {
                cs.OpenConnection();
                catchStr1 = cs.ReadValues("SELECT name FROM Customer WHERE Id = '" + getId + "' ;", "name");
                lblCusCardName.Text = catchStr1;
            }
            catch
            {
                MessageBox.Show("Please contact your IT Support ! (error - DatItmTy) ");
            }
            finally
            {
                cs.CloseConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CustomerTableAdapter.Fill(this.DataSetForCusCard.Customer,cus_Id);
            this.reportViewer1.RefreshReport();
        }
    }
}
