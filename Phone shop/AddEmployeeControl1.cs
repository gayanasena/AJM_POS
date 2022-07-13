using System;
using System.Windows.Forms;

namespace Phone_shop
{
    public partial class AddEmployeeControl1 : UserControl
    {
        public AddEmployeeControl1()
        {
            InitializeComponent();
            cmbEmpPosition.SelectedIndex = 1;
            setEmpID();
        }

        Connection cs = new Connection();
        int empID = 1;

        private void setEmpID()
        {
            try
            {
                String getIdQuary = "select top 1 id from Employee order by id desc ";
                cs.OpenConnection();
                string getId = cs.ReadValues(getIdQuary, "id");
                if (getId == "")
                {
                    empID = 1;
                }
                else
                {
                    empID = int.Parse(getId) + 1;
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
        }// set from  previos stopped emp id from db

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string quary = "INSERT INTO Employee VALUES('"+Convert.ToString(empID)+"','"+cmbEmpPosition.SelectedItem+"','"+txtEmpName.Text+"','"+txtEmpMob.Text+"','"+txtEmpAddL1.Text+"','"+txtEmpAddL2.Text+"','"+txtEmpCity.Text+"');";

            if (txtEmpName.Text.Length == 0 | txtEmpMob.Text.Length == 0 | txtEmpAddL1.Text == null | txtEmpCity.Text.Length == 0)
            {
                MessageBox.Show("Please fill all the fealds !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to add this employee ?", "Add Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        txtEmpName.Clear();
                        txtEmpMob.Clear();
                        txtEmpAddL1.Clear();
                        txtEmpAddL2.Clear();
                        txtEmpCity.Clear();
                        cmbEmpPosition.SelectedIndex = 1;
                        empID++;
                        MessageBox.Show("Employee added successfully ....", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void btnEmpSrc_Click(object sender, EventArgs e)
        {
            if (txtEmpSrc.Text.Length <= 0)
            {
                string quary = "SELECT * FROM Employee";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewEmp.DataSource = obj;
                    dataGridViewEmp.Columns[0].HeaderCell.Value = "Employee ID";
                    dataGridViewEmp.Columns[1].HeaderCell.Value = "Position";
                    dataGridViewEmp.Columns[2].HeaderCell.Value = "Name";
                    dataGridViewEmp.Columns[3].HeaderCell.Value = "Mobile No";
                    dataGridViewEmp.Columns[4].HeaderCell.Value = "Address Line 1";
                    dataGridViewEmp.Columns[5].HeaderCell.Value = "Address Line 2";
                    dataGridViewEmp.Columns[6].HeaderCell.Value = "City";
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
                string quary = "SELECT * FROM Employee WHERE name='" + txtEmpSrc.Text + "';";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewEmp.DataSource = obj;
                    dataGridViewEmp.Columns[0].HeaderCell.Value = "Employee ID";
                    dataGridViewEmp.Columns[1].HeaderCell.Value = "Position";
                    dataGridViewEmp.Columns[2].HeaderCell.Value = "Name";
                    dataGridViewEmp.Columns[3].HeaderCell.Value = "Mobile No";
                    dataGridViewEmp.Columns[4].HeaderCell.Value = "Address Line 1";
                    dataGridViewEmp.Columns[5].HeaderCell.Value = "Address Line 2";
                    dataGridViewEmp.Columns[6].HeaderCell.Value = "City";
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

        private void btnEmpSrc_MouseHover(object sender, EventArgs e)
        {
            if (txtEmpSrc.Text.Length <= 0)
            {
                btnEmpSrc.Text = "View All";
            }
            else
            {
                btnEmpSrc.Text = "Search";
            }
        }
        public void setAutoFillData()
        {
            string quary = "SELECT name FROM Employee;";

            try
            {
                cs.OpenConnection();
                object textObj = cs.MenuDataGet(quary);

                txtEmpSrc.AutoCompleteCustomSource = (AutoCompleteStringCollection)textObj;
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

        private void AddEmployeeControl1_Load(object sender, EventArgs e)
        {
            setAutoFillData();
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            string quary = "DELETE FROM Employee WHERE Id = '" + lblEmpID.Text + "';";
            if (lblEmpID.Text.Length > 0 | lblEmpID.Text != "None")
            {
                if (MessageBox.Show("Are you sure you want to delete this employee ?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        txtEmpName.Clear();
                        txtEmpMob.Clear();
                        txtEmpAddL1.Clear();
                        txtEmpAddL2.Clear();
                        txtEmpCity.Clear();
                        cmbEmpPosition.SelectedIndex = 1;
                        MessageBox.Show("Employee removed successfully ....", "Remove Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setAutoFillData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an Employee ID for delete !", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewEmp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String getId = dataGridViewEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblEmpID.Text = getId;
        }
    }
}
