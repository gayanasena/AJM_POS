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
    public partial class TransferControl : UserControl
    {
        public TransferControl()
        {
            InitializeComponent();
            cmbTransFind.SelectedIndex = 0;
            cmbTransStation.SelectedIndex = 0;
        }

        Connection cs = new Connection();
        private void BtnLogSrc_Click(object sender, EventArgs e)
        {
            if (txtTransSrc.Text.Length <= 0)
            {
                string quary = "SELECT Id,model,IMEI,station,addDate FROM inventory";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewTrans.DataSource = obj;
                    dataGridViewTrans.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewTrans.Columns[1].HeaderCell.Value = "Model";
                    dataGridViewTrans.Columns[2].HeaderCell.Value = "IMEI";
                    dataGridViewTrans.Columns[3].HeaderCell.Value = "Current Station";
                    dataGridViewTrans.Columns[4].HeaderCell.Value = "Added Date/Time";
                    
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
            else if (cmbTransFind.SelectedItem == "IMEI")
            {
                string quary = "SELECT Id,model,IMEI,station,addDate FROM inventory WHERE IMEI = '" + txtTransSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewTrans.DataSource = obj;
                    dataGridViewTrans.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewTrans.Columns[1].HeaderCell.Value = "Model";
                    dataGridViewTrans.Columns[2].HeaderCell.Value = "IMEI";
                    dataGridViewTrans.Columns[3].HeaderCell.Value = "Current Station";
                    dataGridViewTrans.Columns[4].HeaderCell.Value = "Added Date/Time";
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

        private void dataGridViewTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String getId = dataGridViewTrans.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblInvModID.Text = getId;
            String catchStr1 = "";
            String catchStr2 = "";
            String catchStr3 = "";

            // get Imei field
            try
            {
                cs.OpenConnection();
                catchStr1 = cs.ReadValues("SELECT IMEI FROM inventory WHERE Id = '" + getId + "' ;", "IMEI");
                txtTransImei.Text = catchStr1;
            }
            catch
            {
                MessageBox.Show("Please contact your IT Support ! (error - DatItmTy) ");
            }
            finally
            {
                cs.CloseConnection();
            }

            //get barcode field
            try
            {
                cs.OpenConnection();
                catchStr2 = cs.ReadValues("SELECT barcode FROM inventory WHERE Id = '" + getId + "' ;", "barcode");
                txtTransBarcode.Text = catchStr2;
            }
            catch
            {
                MessageBox.Show("Please contact your IT Support ! (error - DatItmTy) ");
            }
            finally
            {
                cs.CloseConnection();
            }

            //get Station field
            try
            {
                cs.OpenConnection();
                catchStr2 = cs.ReadValues("SELECT station FROM inventory WHERE Id = '" + getId + "' ;", "station");
                lblTransCurStation.Text = catchStr2;
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

        private void BtnTransUpdate_Click(object sender, EventArgs e)
        {
            string quary = "UPDATE Inventory SET station='"+cmbTransStation.SelectedItem+"(" + txtTransNotes.Text +")"+ "' WHERE Id='" + lblInvModID.Text + "';";

            if (lblInvModID.Text.Length > 0 | lblInvModID.Text != "None")
            {
                try
                {
                    cs.OpenConnection();
                    cs.ExecuteQuary(quary);
                }
                catch
                {
                    MessageBox.Show("Please contact your IT Support ! ");
                }
                finally
                {
                    cs.CloseConnection();
                    lblInvModID.Text = "";
                    txtTransImei.Clear();
                    txtTransBarcode.Clear();
                    txtTransNotes.Clear();
                    lblTransCurStation.Text= "None";
                    cmbTransStation.SelectedItem = 0;
                    MessageBox.Show("Station Data updated successfully ....", "Modify Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select an Item ID for update station !", "Update Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbTransFind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTransSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblHeadingTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
