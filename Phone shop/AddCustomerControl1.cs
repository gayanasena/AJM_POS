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
    public partial class AddCustomerControl1 : UserControl
    {
        public AddCustomerControl1()
        {
            InitializeComponent();
            cmbCusType.SelectedIndex = 0;
            setCusID();
        }

        // activae firebase session
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "kk64b71AbmSsF9T16Xjakefq4i4sden918m8dO7b",
            BasePath = "https://aj-mobiles-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        Connection cs = new Connection();
        int cusID = 1;

        private void setCusID()
        {
            try
            {
                String getIdQuary = "select top 1 id from Customer order by id desc ";
                cs.OpenConnection();
                string getId = cs.ReadValues(getIdQuary, "id");
                if (getId == "")
                {
                    cusID = 1;
                }
                else
                {
                    cusID = int.Parse(getId) + 1;
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
        }// set from  previos stopped cus id from db

        public void setAutoFillData()
        {
            string quary = "SELECT name FROM Customer;";

            try
            {
                cs.OpenConnection();
                object textObj = cs.MenuDataGet(quary);

                txtCusSrc.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj;
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
        private void AddCustomerControl1_Load(object sender, EventArgs e)
        {
            setAutoFillData();

            //initialize firebase
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Network Error","Firebase Init",MessageBoxButtons.OK,MessageBoxIcon.Warning); ;
            }
        }

        private void btnCusSrc_MouseHover(object sender, EventArgs e)
        {
            if (txtCusSrc.Text.Length <= 0)
            {
                btnCusSrc.Text = "View All";
            }
            else
            {
                btnCusSrc.Text = "Search";
            }
        }

        private void btnCusSrc_Click(object sender, EventArgs e)
        {
            if (txtCusSrc.Text.Length <= 0)
            {
                string quary = "SELECT * FROM Customer";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewCus.DataSource = obj;
                    dataGridViewCus.Columns[0].HeaderCell.Value = "Customer ID";
                    dataGridViewCus.Columns[1].HeaderCell.Value = "Type";
                    dataGridViewCus.Columns[2].HeaderCell.Value = "Name";
                    dataGridViewCus.Columns[3].HeaderCell.Value = "Mobile No";
                    dataGridViewCus.Columns[4].HeaderCell.Value = "Address Line 1";
                    dataGridViewCus.Columns[5].HeaderCell.Value = "Address Line 2";
                    dataGridViewCus.Columns[6].HeaderCell.Value = "City";
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
                string quary = "SELECT * FROM Customer WHERE name='" + txtCusSrc.Text + "';";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewCus.DataSource = obj;
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

        private void btnCusAdd_Click(object sender, EventArgs e)
        {
            string quary = "INSERT INTO Customer VALUES('"+Convert.ToString(cusID)+"','" + cmbCusType.SelectedItem + "','" + txtCusName.Text + "','" + txtCusContact.Text + "','" + txtCusAddL1.Text + "','" + txtCusAddL2.Text + "','" + txtCusCity.Text + "');";

            Customer cus = new Customer()
            {
                type = cmbCusType.Text,
                name = txtCusName.Text,
                contact = txtCusContact.Text,
                address_line_1 = txtCusAddL1.Text,
                address_line_2 = txtCusAddL2.Text,
                city = txtCusCity.Text,
            };


            if (txtCusName.Text.Length == 0 | txtCusContact.Text.Length == 0 | txtCusAddL1.Text == null | txtCusCity.Text.Length == 0)
            {
                MessageBox.Show("Please fill all the fealds !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to add this customer ?", "Add Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //insert to firebase 
                    try
                    {
                        var setter = client.Set("CustomerList/" + txtCusName.Text, cus);
                        MessageBox.Show("Data inserted Successfully", "Firebase Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Had some error with data insertion to Firebase.. ", "Firebase Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //insert to db
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
                        txtCusName.Clear();
                        txtCusContact.Clear();
                        txtCusAddL1.Clear();
                        txtCusAddL2.Clear();
                        txtCusCity.Clear();
                        cmbCusType.SelectedIndex = 0;
                        cusID++;
                        MessageBox.Show("Customer added successfully ....", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
    }
}
