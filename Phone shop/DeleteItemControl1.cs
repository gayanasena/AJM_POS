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
    public partial class DeleteItemControl1 : UserControl
    {
        //Global variable for connection class
        Connection cs = new Connection();

        public DeleteItemControl1()
        {
            InitializeComponent();
            cmbFind.SelectedIndex = 0;
        }

        public void setAutoFillData()
        {
            string quary = "SELECT model FROM inventory;";

            try
            {
                cs.OpenConnection();
                object textObj = cs.MenuDataGet(quary);

                txtInvModSrc.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj;
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

        private void BtnInvModSrc_Click(object sender, EventArgs e)
        {

            if (txtInvModSrc.Text.Length <= 0)
            {
                string quary = "SELECT * FROM inventory";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewInvMod.DataSource = obj;
                    dataGridViewInvMod.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewInvMod.Columns[1].HeaderCell.Value = "Category";
                    dataGridViewInvMod.Columns[2].HeaderCell.Value = "Supplier";
                    dataGridViewInvMod.Columns[3].HeaderCell.Value = "Custom Code";
                    dataGridViewInvMod.Columns[4].HeaderCell.Value = "Brand";
                    dataGridViewInvMod.Columns[5].HeaderCell.Value = "Model";
                    dataGridViewInvMod.Columns[6].HeaderCell.Value = "Barcode";
                    dataGridViewInvMod.Columns[7].HeaderCell.Value = "Selling Price";
                    dataGridViewInvMod.Columns[8].HeaderCell.Value = "Available Qty";
                    dataGridViewInvMod.Columns[9].HeaderCell.Value = "Added Date";
                    dataGridViewInvMod.Columns[10].HeaderCell.Value = "IMEI*";
                    dataGridViewInvMod.Columns[11].HeaderCell.Value = "Capacity*";
                    dataGridViewInvMod.Columns[12].HeaderCell.Value = "Colour*";
                    dataGridViewInvMod.Columns[13].HeaderCell.Value = "Current Station";
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
                string quary = "SELECT * FROM inventory WHERE IMEI = '" + txtInvModSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewInvMod.DataSource = obj;
                    dataGridViewInvMod.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewInvMod.Columns[1].HeaderCell.Value = "Category";
                    dataGridViewInvMod.Columns[2].HeaderCell.Value = "Supplier";
                    dataGridViewInvMod.Columns[3].HeaderCell.Value = "Custom Code";
                    dataGridViewInvMod.Columns[4].HeaderCell.Value = "Brand";
                    dataGridViewInvMod.Columns[5].HeaderCell.Value = "Model";
                    dataGridViewInvMod.Columns[6].HeaderCell.Value = "Barcode";
                    dataGridViewInvMod.Columns[7].HeaderCell.Value = "Selling Price";
                    dataGridViewInvMod.Columns[8].HeaderCell.Value = "Available Qty";
                    dataGridViewInvMod.Columns[9].HeaderCell.Value = "Added Date";
                    dataGridViewInvMod.Columns[10].HeaderCell.Value = "IMEI*";
                    dataGridViewInvMod.Columns[11].HeaderCell.Value = "Capacity*";
                    dataGridViewInvMod.Columns[12].HeaderCell.Value = "Colour*";
                    dataGridViewInvMod.Columns[13].HeaderCell.Value = "Current Station";
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
                string quary = "SELECT * FROM inventory WHERE Model = '" + txtInvModSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewInvMod.DataSource = obj;
                    dataGridViewInvMod.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewInvMod.Columns[1].HeaderCell.Value = "Category";
                    dataGridViewInvMod.Columns[2].HeaderCell.Value = "Supplier";
                    dataGridViewInvMod.Columns[3].HeaderCell.Value = "Custom Code";
                    dataGridViewInvMod.Columns[4].HeaderCell.Value = "Brand";
                    dataGridViewInvMod.Columns[5].HeaderCell.Value = "Model";
                    dataGridViewInvMod.Columns[6].HeaderCell.Value = "Barcode";
                    dataGridViewInvMod.Columns[7].HeaderCell.Value = "Selling Price";
                    dataGridViewInvMod.Columns[8].HeaderCell.Value = "Available Qty";
                    dataGridViewInvMod.Columns[9].HeaderCell.Value = "Added Date";
                    dataGridViewInvMod.Columns[10].HeaderCell.Value = "IMEI*";
                    dataGridViewInvMod.Columns[11].HeaderCell.Value = "Capacity*";
                    dataGridViewInvMod.Columns[12].HeaderCell.Value = "Colour*";
                    dataGridViewInvMod.Columns[13].HeaderCell.Value = "Current Station";
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
                string quary = "SELECT * FROM inventory WHERE itemCode = '" + txtInvModSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewInvMod.DataSource = obj;
                    dataGridViewInvMod.Columns[0].HeaderCell.Value = "Item ID";
                    dataGridViewInvMod.Columns[1].HeaderCell.Value = "Category";
                    dataGridViewInvMod.Columns[2].HeaderCell.Value = "Supplier";
                    dataGridViewInvMod.Columns[3].HeaderCell.Value = "Custom Code";
                    dataGridViewInvMod.Columns[4].HeaderCell.Value = "Brand";
                    dataGridViewInvMod.Columns[5].HeaderCell.Value = "Model";
                    dataGridViewInvMod.Columns[6].HeaderCell.Value = "Barcode";
                    dataGridViewInvMod.Columns[7].HeaderCell.Value = "Selling Price";
                    dataGridViewInvMod.Columns[8].HeaderCell.Value = "Available Qty";
                    dataGridViewInvMod.Columns[9].HeaderCell.Value = "Added Date";
                    dataGridViewInvMod.Columns[10].HeaderCell.Value = "IMEI*";
                    dataGridViewInvMod.Columns[11].HeaderCell.Value = "Capacity*";
                    dataGridViewInvMod.Columns[12].HeaderCell.Value = "Colour*";
                    dataGridViewInvMod.Columns[13].HeaderCell.Value = "Current Station";
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

        private void DeleteItemControl1_Load(object sender, EventArgs e)
        {
            setAutoFillData();
        }

        private void BtnInvModSrc_MouseHover(object sender, EventArgs e)
        {
            if (txtInvModSrc.Text.Length <= 0)
            {
                BtnInvModSrc.Text = "View All";
            }
            else
            {
                BtnInvModSrc.Text = "Search";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            setAutoFillData();
        }

        private void dataGridViewInvMod_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String getId = dataGridViewInvMod.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblInvModID.Text = getId;
            String catchStr1 = "";
            String catchStr2 = "";
            String catchStr3 = "";
            String catchStr4 = "";
            String catchStr5 = "";
            String catchStr6 = "";

            // get Imei field
            try
            {
                cs.OpenConnection();
                catchStr1 = cs.ReadValues("SELECT IMEI FROM inventory WHERE Id = '" + getId + "' ;", "IMEI");
                txtInvModImei.Text = catchStr1;
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
                txtInvModBarcode.Text = catchStr2;
            }
            catch
            {
                MessageBox.Show("Please contact your IT Support ! (error - DatItmTy) ");
            }
            finally
            {
                cs.CloseConnection();
            }

            //get capacity field
            try
            {
                cs.OpenConnection();
                catchStr3 = cs.ReadValues("SELECT capacity FROM inventory WHERE Id = '" + getId + "' ;", "capacity");
                cmbInvModCapacity.SelectedItem = catchStr3;
            }
            catch
            {
                MessageBox.Show("Please contact your IT Support ! (error - DatItmTy) ");
            }
            finally
            {
                cs.CloseConnection();
            }

            //get price field
            try
            {
                cs.OpenConnection();
                catchStr4 = cs.ReadValues("SELECT price FROM inventory WHERE Id = '" + getId + "' ;", "price");
                txtInvModPrice.Text = catchStr4;
            }
            catch
            {
                MessageBox.Show("Please contact your IT Support ! (error - DatItmTy) ");
            }
            finally
            {
                cs.CloseConnection();
            }

            //get color field
            try
            {
                cs.OpenConnection();
                catchStr5 = cs.ReadValues("SELECT color FROM inventory WHERE Id = '" + getId + "' ;", "color");
                txtInvModColor.Text = catchStr5;
            }
            catch
            {
                MessageBox.Show("Please contact your IT Support ! (error - DatItmTy) ");
            }
            finally
            {
                cs.CloseConnection();
            }

            //get qty field
            try
            {
                cs.OpenConnection();
                catchStr6 = cs.ReadValues("SELECT qty FROM inventory WHERE Id = '" + getId + "' ;", "qty");
                txtInvModQty.Text = catchStr6;
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

        private void BtnInvModDel_Click(object sender, EventArgs e)
        {
            string quary = "DELETE FROM inventory WHERE Id = '" + lblInvModID.Text + "';";
            if (lblInvModID.Text.Length > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete permanently this item ?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        txtInvModImei.Clear();
                        txtInvModBarcode.Clear();
                        txtInvModPrice.Clear();
                        txtInvModColor.Clear();
                        txtInvModQty.Clear();
                        cmbInvModCapacity.SelectedItem = "";
                        MessageBox.Show("Item removed successfully ....", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setAutoFillData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an item for delete !", "Delete item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnInvModUpdate_Click(object sender, EventArgs e)
        {
            string quary = "UPDATE Inventory SET barcode='"+txtInvModBarcode.Text+"', capacity='"+cmbInvModCapacity.SelectedItem+"', price='"+txtInvModPrice.Text+"', color='"+txtInvModColor.Text+"', qty='"+txtInvModQty.Text+"' WHERE Id='"+lblInvModID.Text+"';";

            if (lblInvModID.Text.Length > 0)
            {
                if (MessageBox.Show("Are you sure you want to update  this item ?", "Update Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        txtInvModImei.Clear();
                        txtInvModBarcode.Clear();
                        txtInvModPrice.Clear();
                        txtInvModColor.Clear();
                        txtInvModQty.Clear();
                        cmbInvModCapacity.SelectedItem = "";
                        MessageBox.Show("Item updated successfully ....", "Modify item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setAutoFillData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an item for update !", "Update item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
