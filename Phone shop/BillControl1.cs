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
    public partial class BillControl1 : UserControl
    {
        public BillControl1()
        {
            InitializeComponent();
            setOrderID();
            txtBillID.Text = Convert.ToString(order_id);
            txtBillQty.Text = Convert.ToString(qty);
            btnBillPrint.Enabled = false;
        }

        Connection cs = new Connection();

        // activae firebase session
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "kk64b71AbmSsF9T16Xjakefq4i4sden918m8dO7b",
            BasePath = "https://aj-mobiles-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        string quary;
        int count = 0;
        int qty = 1;
        double Amount = 0;
        string type = "";
        double order_id = 1;
        int item_id = 0;
        public List<int> IDlist = new List<int>();
        public List<int> Qtylist = new List<int>();
        int maxQty = 1;

        private void btnBillBarcSrc_Click(object sender, EventArgs e)
        {
            string quary0 = "select Id from inventory where barcode='" + txtBillBarcode.Text + "';";
            string quary1 = "select model from inventory where barcode='" + txtBillBarcode.Text + "';";

            cs.OpenConnection();
            bool stat = cs.ReadDataLogin(quary1);
            cs.CloseConnection();
            if (stat == true)
            {
                cs.OpenConnection();
                string getVal = cs.ReadValues(quary1, "model");
                txtBillfindItem.Text = getVal;
                cs.CloseConnection();

                cs.OpenConnection();
                string getVal0 = cs.ReadValues(quary0, "id");
                item_id = Convert.ToInt32(getVal0);
                txtBillBarcode.Clear();
                cs.CloseConnection();
            }
            else
            {
                MessageBox.Show("Invalid Barcode", "Error", MessageBoxButtons.OK);
                txtBillBarcode.Clear();
                txtBillBarcode.Focus();
            }
        }

        public void setAutoFillData() // auto suggest data collection set
        {

            try
            {
                cs.OpenConnection();
                quary = "SELECT model FROM Inventory;";
                object textObj1 = cs.MenuDataGet(quary);
                txtBillfindItem.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj1;
                cs.CloseConnection();

                cs.OpenConnection();
                quary = "SELECT contact FROM Customer;";
                object textObj2 = cs.MenuDataGet(quary);
                txtBillCusNo.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj2;
                cs.CloseConnection();

                cs.OpenConnection();
                quary = "SELECT name FROM Employee;";
                object textObj3 = cs.MenuDataGet(quary);
                txtBillEmp.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj3;
                cs.CloseConnection();

                cs.OpenConnection();
                quary = "SELECT IMEI FROM Inventory;";
                object textObj4 = cs.MenuDataGet(quary);
                txtBillFindImei.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj4;
                cs.CloseConnection();

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

        private void setOrderID()
        {
            try
            {
                quary = "select top 1 id from orders order by id desc ";
                cs.OpenConnection();
                string getId = cs.ReadValues(quary, "id");
                if(getId == "")
                {
                    order_id = 1;
                }
                else
                {
                    order_id = double.Parse(getId) + 1;
                }
            }
            catch(Exception e)
            {
                //MessageBox.Show("Please contact your IT Support ! ");
                MessageBox.Show("error"+e);
            }
            finally
            {
                cs.CloseConnection();
            }
        }// set from  previos stopped oder id from db

        private void exportToDB()
        {
            String quaryDB = "";

            Orders odr = new Orders()
            {
                type = "Cash",
                salesman = txtBillEmp.Text,
                date = DateTime.Now.ToString("M/d/yyyy HH:mm"),
                amount = txtBillAmount.Text,
            };

            if (radBillCash.Checked == true)
            {
                quaryDB = "insert into Orders (id,mobile,type,salesman,date,amount) values('"+Convert.ToString(order_id)+"','"+txtBillCusNo.Text+"','Cash','" +txtBillEmp.Text+ "','" + DateTime.Now.ToString("M/d/yyyy HH:mm") + "','" + Convert.ToString(Amount) + "');";
            }
            else if (radBillWholesale.Checked == true)
            {
                quaryDB = "insert into Orders (id,mobile,type,salesman,date,amount) values('" + Convert.ToString(order_id) + "','" + txtBillCusNo.Text + "','Wholesale','" + txtBillEmp.Text + "','" + DateTime.Now.ToString("M/d/yyyy") + "','" + Convert.ToString(Amount) + "');";
            }
            else if (radBillDelivery.Checked == true)
            {
                quaryDB = "insert into Orders (id,mobile,type,salesman,date,amount) values('" + Convert.ToString(order_id) + "','" + txtBillCusNo.Text + "','Delivary','" + txtBillEmp.Text + "','" + DateTime.Now.ToString("M/d/yyyy") + "','" + Convert.ToString(Amount) + "');";
            }
            else
            {
                MessageBox.Show("Bill type not found !", "Error");
            }

            //insert to firebase 
            try
            {
                var setter = client.Set("OrdersList/" + txtBillID.Text, odr);
                //MessageBox.Show("Data inserted Successfully", "Firebase Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Had some error with data insertion to Firebase.. ", "Firebase Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                cs.OpenConnection();
                bool status = cs.ExecuteQuary(quaryDB);
                MessageBox.Show("Order placed successfully !...","Billing",MessageBoxButtons.OK );
                btnBillPay.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error export to db " + ex);
            }
            finally
            {
                cs.CloseConnection();
            }
        }// add data to db (a part off pay fn )

        private void clearSoldItemsDB()
        {
            int countQL = 0;

            foreach(int i in IDlist)
            {
                

                int itemQty = 0;
                string quaryGetQty = "SELECT qty FROM Inventory WHERE id = '"+i+"'";
                string quaryDel = "DELETE FROM Inventory WHERE id = '"+i+"'";
               
                
                // get Item Qty
                try
                {
                    cs.OpenConnection();
                    itemQty =int.Parse(cs.ReadValues(quaryGetQty, "qty"));
                }
                catch(Exception ee)
                {
                    MessageBox.Show(Convert.ToString(ee));
                }
                finally
                {
                    cs.CloseConnection();
                }

                int currQty = itemQty - Qtylist[countQL];

                if (itemQty>1)
                {
                    // execute update item qty quary (decrease)
                    try
                    {
                        cs.OpenConnection();
                        MessageBox.Show(Convert.ToString(itemQty+" "+ Qtylist[countQL]));
                        string quaryDecQty = "UPDATE Inventory SET qty='" + currQty + "' WHERE id = '" + i + "'";
                        bool statusUpdate = cs.ExecuteQuary(quaryDecQty);
                    }
                    catch
                    {
                        MessageBox.Show("Error, Please contact IT Support ");
                    }
                    finally
                    {
                        cs.CloseConnection();
                    }
                }
                else
                {
                    // execute delete quary
                    try
                    {
                        cs.OpenConnection();
                        bool status = cs.ExecuteQuary(quaryDel);
                    }
                    catch
                    {
                        MessageBox.Show("Error, Please contact IT Support ");
                    }
                    finally
                    {
                        cs.CloseConnection();
                    }
                }
                countQL++;
            }
        }

        private void BillControl1_Load(object sender, EventArgs e)
        {
            setAutoFillData();
            //initialize firebase
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Network Error", "Firebase Init", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void cmdSBminQty_Click(object sender, EventArgs e)
        {
            if (qty > 1)
            {
                qty--;
                txtBillQty.Text = Convert.ToString(qty);
            }
        }

        private void cmdSBplQty_Click(object sender, EventArgs e)
        {
            string quaryGetMaxQty = "SELECT qty FROM Inventory WHERE model = '" + txtBillfindItem.Text + "'";

            if (txtBillQty.Text == "1")
            {
                if(txtBillFindImei.Text.Length>0)
                {
                    MessageBox.Show("Maximum quantity have reached!", "Maximum Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // get Item Qty
                    try
                    {
                        cs.OpenConnection();
                        maxQty = int.Parse(cs.ReadValues(quaryGetMaxQty, "qty"));
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(Convert.ToString(ee));
                    }
                    finally
                    {
                        cs.CloseConnection();
                    }

                    if (qty < maxQty)
                    {
                        qty++;
                        txtBillQty.Text = Convert.ToString(qty);
                    }
                    else
                    {
                        MessageBox.Show("Maximum quantity have reached!", "Maximum Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
            else
            {
                if(qty<maxQty)
                {
                    qty++;
                    txtBillQty.Text = Convert.ToString(qty);
                }
                else
                {
                    MessageBox.Show("Maximum quantity have reached!","Maximum Quantity",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            
        }

        private void txtBillfindItem_Click(object sender, EventArgs e)
        {
            setAutoFillData();
        }

        private void txtBillCusNo_Click(object sender, EventArgs e)
        {
            //setAutoFillData();
            //txtBillID.Text = Convert.ToString(order_id);
        }

        private void btnBillNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to create new bill  ?", "Create New Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // set things back to normal

                //variables set
                order_id++;
                Amount = 0;
                qty = 1;

                txtBillPayment.Enabled = true;
                txtBillfindItem.Enabled = true;
                txtBillBarcode.Enabled = true;
                txtBillCusNo.Enabled = true;
                btnBillPay.Enabled = true;
                btnBillPrint.Enabled = false;

                //clear txtboxes( + othrs)
                txtBillEmp.Enabled = true;
                txtBillCusNo.Clear();
                txtBillfindItem.Clear();
                txtBillBarcode.Clear();
                dataGridViewBill.Items.Clear(); //list box clear
                txtBillAmount.Clear();
                txtBillTax.Clear();
                txtBillPayment.Clear();
                txtBillTotAmt.Clear();
                txtBillCusNo.Focus();
                txtBillFindImei.Clear();

                setOrderID();
                txtBillID.Text = Convert.ToString(order_id);
            }
        }

        private void btnBillPay_Click(object sender, EventArgs e)
        {
            //validate payment

            if (txtBillPayment.Text.Length < 0)
            {
                MessageBox.Show("Insuffcent payment to pay the bill", "Payment not enough", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to close & pay the bill now ?", "Pay Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        double payment = Convert.ToDouble(txtBillPayment.Text);
                        double totAmount = Convert.ToDouble(txtBillTotAmt.Text);
                        if (payment < totAmount)
                        {
                            MessageBox.Show("Insuffcent payment to pay the bill", "Payment not enough", MessageBoxButtons.OK);
                        }
                        else
                        {
                            txtBillPayment.Text = Convert.ToString("Balance " + (payment - totAmount));

                            txtBillPayment.Enabled = false;
                            txtBillfindItem.Enabled = false;
                            txtBillBarcode.Enabled = false;
                            txtBillCusNo.Enabled = false;

                            exportToDB();
                            btnBillPrint.Enabled = true;
                            clearSoldItemsDB();
                            IDlist.Clear();
                            Qtylist.Clear();

                        }

                    }
                    catch
                    {
                        MessageBox.Show("Please fill the bill before pay", "Error", MessageBoxButtons.OK);
                    }
                }

            }
        }

        private void btnBillItemAdd_Click(object sender, EventArgs e)
        {
            string itemPrice = "";
            string itemBrand = "";
            string itemIMEI = "";
            count++;

            // First get item Id from db to select absolute item
            if(txtBillfindItem.Text.Length>0 && txtBillFindImei.Text.Length<=0)
            {
                try
                {
                    string subQuary = "select TOP 1 Id from Inventory where model = '" + txtBillfindItem.Text + "';";
                    cs.OpenConnection();
                    string itemID = cs.ReadValues(subQuary, "Id");
                    item_id = Convert.ToInt32(itemID);
                }
                catch
                {
                    MessageBox.Show("Try again !... if error exist contact it support  !", "Oops ..", MessageBoxButtons.OK);
                }
                finally
                {
                    cs.CloseConnection();
                }
            }
            else if(txtBillFindImei.Text.Length > 0 && txtBillfindItem.Text.Length <= 0)
            {
                try
                {
                    string subQuary = "select  Id from Inventory where IMEI = '" + txtBillFindImei.Text + "';";
                    cs.OpenConnection();
                    string itemID = cs.ReadValues(subQuary, "Id");
                    item_id = Convert.ToInt32(itemID);
                }
                catch
                {
                    MessageBox.Show("Try again !... if error exist contact it support  !", "Oops ..", MessageBoxButtons.OK);
                }
                finally
                {
                    cs.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Fill Find Item field or Find IMEI field to add items", "error");
            }
            

            // get item prices from db

            try
            {
                string subQuary = "select price from Inventory where Id = '" +item_id + "';";
                cs.OpenConnection();
                itemPrice = cs.ReadValues(subQuary, "price");
            }
            catch
            {
                MessageBox.Show("Try again !... if error exist contact it support  !", "Oops ..", MessageBoxButtons.OK);
            }
            finally
            {
                cs.CloseConnection();
            }

            // get item model from db

            try
            {
                string subQuary = "select model from Inventory where Id = '" + item_id + "';";
                cs.OpenConnection();
                txtBillfindItem.Text = cs.ReadValues(subQuary, "model");
            }
            catch
            {
                MessageBox.Show("Try again !... if error exist contact it support  !", "Oops ..", MessageBoxButtons.OK);
            }
            finally
            {
                cs.CloseConnection();
            }

            // get item brand from db

            try
            {
                string subQuary = "select brand from Inventory where Id = '" + item_id + "';";
                cs.OpenConnection();
                itemBrand = cs.ReadValues(subQuary, "brand");
            }
            catch
            {
                MessageBox.Show("Try again !... if error exist contact it support  !", "Oops ..", MessageBoxButtons.OK);
            }
            finally
            {
                cs.CloseConnection();
            }

            // get item IMEI from db

            try
            {
                string subQuary = "select IMEI from Inventory where Id = '" + item_id + "';";
                cs.OpenConnection();
                itemIMEI = cs.ReadValues(subQuary, "IMEI");
            }
            catch
            {
                MessageBox.Show("Try again !... if error exist contact it support  !", "Oops ..", MessageBoxButtons.OK);
            }
            finally
            {
                cs.CloseConnection();
            }

            // find total for item
            double total = 0;

            try
            {
                total = Convert.ToDouble(txtBillQty.Text) * Convert.ToDouble(itemPrice);

            }
            catch
            {
                MessageBox.Show("Qty cannot be 0 to add the item", "error");
            }


            // store total(s) form amount calculation 

            Amount = Amount + total;

            // add item data to list view

            var item = new ListViewItem(new[] { Convert.ToString(count), itemBrand, Convert.ToString(txtBillfindItem.Text), Convert.ToString(txtBillQty.Text), itemPrice, Convert.ToString(total) });
            dataGridViewBill.Items.Add(item);

            //store order details in db

            string subQuary1 = "INSERT INTO SalesLog VALUES ('" + Convert.ToString(order_id) + "','" + txtBillfindItem.Text + "','" + txtBillQty.Text + "','" + Convert.ToString(itemPrice) + "','" + itemBrand + "','" + itemIMEI + "');";

            try
            {
                cs.OpenConnection();
                cs.ExecuteQuary(subQuary1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);

            }
            finally
            {
                cs.CloseConnection();
            }
            // create puchased item id(s) array
            IDlist.Add(item_id);

            // create puchased item qty(s) array
            Qtylist.Add(qty);

            // clear and set fields to re use

            txtBillfindItem.Clear();
            txtBillQty.Text = Convert.ToString(1);
            qty = 1;
            txtBillBarcode.Clear();
            txtBillFindImei.Clear();
            txtBillfindItem.Focus();

            // show amounts in txtbox

            txtBillAmount.Text = (Convert.ToString(Amount));

            if (radBillCash.Checked == true)
            {
                // includes 0% service charges + 0 tax ratio
                txtBillTax.Text = Convert.ToString(Amount * (0));
                txtBillTotAmt.Text = Convert.ToString((Amount * (0)) + Amount);
            }
            else if (radBillWholesale.Checked == true)
            {
                // includes 0% service charges + 0 tax ratio
                txtBillTax.Text = Convert.ToString(Amount * (0));
                txtBillTotAmt.Text = Convert.ToString((Amount * (0)) + Amount);
            }
            else
            {
                // includes 0% service charges + 0 tax ratio
                txtBillTax.Text = Convert.ToString(Amount * (0));
                txtBillTotAmt.Text = Convert.ToString((Amount * (0)) + Amount);
            }
        }

        private void btnBillPrint_Click(object sender, EventArgs e)
        {
            FormPrintBill frm = new FormPrintBill(order_id);
            frm.Show();
        }

    }
}
