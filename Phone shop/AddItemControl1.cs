using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Phone_shop
{
    public partial class AddItemControl1 : UserControl
    {
        public AddItemControl1()
        {
            InitializeComponent();
            setItemID();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "kk64b71AbmSsF9T16Xjakefq4i4sden918m8dO7b",
            BasePath = "https://aj-mobiles-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        Connection cs = new Connection();

        int itemID = 1;

        private void AddItemControl1_Load(object sender, EventArgs e)
        {
            cmbItmCategory.SelectedIndex = 0;
            txtAddItemQty.Text = "1";
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Network Error", "Firebase Init", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

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

        private void BtntAddItemAdd_Click(object sender, EventArgs e)
        {
            //create a obj to insert firebase
            inventory inv = new inventory()
            {
                category = cmbItmCategory.Text,
                supplier = txtAddItemSupplier.Text,
                itemCode = txtAddItemCode.Text,
                brand = txtAddItemBrand.Text,
                model = txtAddItemModel.Text,
                barcode = txtAddItemBarcode.Text,
                sellingprice = txtAddItemPrice.Text,
                quantity = txtAddItemQty.Text,
                IMEI = txtAddItemIMEI.Text,
                capacity = cmbAddItemCapacity.Text,
                color = txtAddItemColor.Text,
                
            };

           
                //get type data
                string category = cmbItmCategory.Text;

                //get system date time
                DateTime now = DateTime.Now;

                string quary = "INSERT INTO Inventory(id,category,supplier,itemCode,brand,model,barcode,price,qty,addDate,IMEI,capacity,color,station)Values('"+Convert.ToString(itemID)+"','" + category + "','" + txtAddItemSupplier.Text + "','" + txtAddItemCode.Text + "','" + txtAddItemBrand.Text + "','" + txtAddItemModel.Text + "','" + txtAddItemBarcode.Text + "','" + txtAddItemPrice.Text + "','" + txtAddItemQty.Text + "','" + now + "','" + txtAddItemIMEI.Text + "','" + cmbAddItemCapacity.SelectedItem + "','" + txtAddItemColor.Text + "','Shop(OnSale)');";

                // validation

                if (txtAddItemBrand.Text.Length == 0 | txtAddItemModel.Text.Length == 0 | cmbItmCategory.Text == null | txtAddItemCode.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all the fealds !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                if (MessageBox.Show("Add this item ?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //insert to firebase 
                    try
                    {
                        var setter = client.Set("InventoryList/" + txtAddItemCode.Text, inv);
                        MessageBox.Show("Data inserted Successfully","Firebase Insertion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Had some error with data insertion to Firebase.. ", "Firebase Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
                        txtAddItemSupplier.Clear();
                        txtAddItemCode.Clear();
                        txtAddItemBarcode.Clear();
                        txtAddItemBrand.Clear();
                        txtAddItemModel.Clear();
                        txtAddItemBrand.Clear();
                        txtAddItemPrice.Clear();
                        txtAddItemQty.Clear();
                        txtAddItemIMEI.Clear();
                        txtAddItemColor.Clear();
                        cmbAddItemCapacity.Text = "";
                        cmbItmCategory.Text = "Select a value";
                        itemID++;
                        MessageBox.Show("Item added successfully ....", "Add item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            
        }

    }
}
