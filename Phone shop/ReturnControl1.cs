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
    public partial class ReturnControl1 : UserControl
    {
        public ReturnControl1()
        {
            InitializeComponent();
            cmbRetFind.SelectedIndex = 0;
            cmbRetStation.SelectedIndex = 0;
            setItemID();
        }

        Connection cs = new Connection();

        String getId = "";
        String getBrand = "";
        String getModel = "";
        String getImei = "";
        String getPrice = "";
        String getCapacity = "";
        String getColor = "";
        String getCode = "";
        int itemID = 1;
        private void setItemID()
        {
            try
            {
                String getIdQuary = "select top 1 id from inventory order by id desc ";
                cs.OpenConnection();
                string getId = cs.ReadValues(getIdQuary, "id");
                if (getId == "")
                {
                    itemID = 1;
                }
                else
                {
                    itemID = int.Parse(getId) + 1;
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show("Please contact your IT Support ! ");
                MessageBox.Show("error" + e);
            }
            finally
            {
                cs.CloseConnection();
            }
        }// set from  previos stopped item id from db

        private void BtnRtnSrc_Click(object sender, EventArgs e)
        {
            if (txtRetSrc.Text.Length <= 0)
            {
                string quary = "SELECT id,brand,model,IMEI,price,capacity,color,sold_date,itemCode FROM inventory_sold";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewRtn.DataSource = obj;
                    dataGridViewRtn.Columns[0].HeaderCell.Value = "ID";
                    dataGridViewRtn.Columns[1].HeaderCell.Value = "Brand";
                    dataGridViewRtn.Columns[2].HeaderCell.Value = "Model";
                    dataGridViewRtn.Columns[3].HeaderCell.Value = "IMEI";
                    dataGridViewRtn.Columns[4].HeaderCell.Value = "Price";
                    dataGridViewRtn.Columns[5].HeaderCell.Value = "Capacity";
                    dataGridViewRtn.Columns[6].HeaderCell.Value = "Color";
                    dataGridViewRtn.Columns[7].HeaderCell.Value = "Sold Date/Time";
                    dataGridViewRtn.Columns[8].HeaderCell.Value = "Item Code";

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
            else if (cmbRetFind.SelectedItem == "IMEI")
            {
                string quary = "SELECT id,brand,model,IMEI,price,cpacity,color,sold_date,itemCode FROM inventory_sold WHERE IMEI = '" + txtRetSrc.Text + "'";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewRtn.DataSource = obj;
                    dataGridViewRtn.Columns[0].HeaderCell.Value = "ID";
                    dataGridViewRtn.Columns[1].HeaderCell.Value = "Brand";
                    dataGridViewRtn.Columns[2].HeaderCell.Value = "Model";
                    dataGridViewRtn.Columns[3].HeaderCell.Value = "IMEI";
                    dataGridViewRtn.Columns[4].HeaderCell.Value = "Price";
                    dataGridViewRtn.Columns[5].HeaderCell.Value = "Capacity";
                    dataGridViewRtn.Columns[6].HeaderCell.Value = "Color";
                    dataGridViewRtn.Columns[7].HeaderCell.Value = "Sold Date/Time";
                    dataGridViewRtn.Columns[8].HeaderCell.Value = "Item Code";
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

        private void BtnRetUpdate_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            string quary = "INSERT INTO Inventory(id,category,supplier,itemCode,brand,model,barcode,price,qty,addDate,IMEI,capacity,color,station)Values('"+Convert.ToString(itemID)+"','Mobile','AJMobile','" + getCode + "','" + getBrand + "','" + getModel + "','" + txtRetBarcode.Text + "','" + getPrice + "','1','" + now + "','" + getImei + "','" + getCapacity + "','" + getColor + "','" + cmbRetStation.SelectedItem + " " + txtRetReason.Text + "');";

            // validation
            if(getImei.Length>0 |getModel.Length>0)
            {
                if (txtRetBarcode.Text.Length == 0 | cmbRetStation.Text == null | lblInvModID.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all the fealds !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Add this return item back?", "Return Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                            txtRetSrc.Clear();
                            txtRetBarcode.Clear();
                            txtRetReason.Clear();
                            txtRetImei.Text = "";
                            cmbRetStation.SelectedIndex = 0;
                            MessageBox.Show("Item re-added successfully ....", "Return item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        string delQuary = "Delete from inventory_sold where id='"+lblInvModID.Text+"' ";

                        // delete from inventory_sold
                        try
                        {
                            cs.OpenConnection();
                            cs.ExecuteQuary(delQuary);
                            lblInvModID.Text = "";
                        }
                        catch
                        {
                            MessageBox.Show("Please contact your IT Support ! ");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Select a record and fill the fields first", "Return item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dataGridViewRtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getId = dataGridViewRtn.Rows[e.RowIndex].Cells[0].Value.ToString();
            getBrand = dataGridViewRtn.Rows[e.RowIndex].Cells[1].Value.ToString();
            getModel = dataGridViewRtn.Rows[e.RowIndex].Cells[2].Value.ToString();
            getImei= dataGridViewRtn.Rows[e.RowIndex].Cells[3].Value.ToString();
            getPrice= dataGridViewRtn.Rows[e.RowIndex].Cells[4].Value.ToString();
            getCapacity = dataGridViewRtn.Rows[e.RowIndex].Cells[5].Value.ToString();
            getColor = dataGridViewRtn.Rows[e.RowIndex].Cells[6].Value.ToString();
            getCode = dataGridViewRtn.Rows[e.RowIndex].Cells[8].Value.ToString();
            lblInvModID.Text = getId;
            txtRetImei.Text = getImei;

        }

    }
}
