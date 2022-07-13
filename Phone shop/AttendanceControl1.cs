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
    public partial class AttendanceControl1 : UserControl
    {
        public AttendanceControl1()
        {
            InitializeComponent();
        }

        //create connection class object
        Connection cs = new Connection();

        // activae firebase session
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "kk64b71AbmSsF9T16Xjakefq4i4sden918m8dO7b",
            BasePath = "https://aj-mobiles-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        private void btnEmpAtteSrc_Click(object sender, EventArgs e)
        {
            if (txtEmpSrc.Text.Length <= 0)
            {
                string quary = "SELECT * FROM Employee";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewEmpView.DataSource = obj;
                    dataGridViewEmpView.Columns[0].HeaderCell.Value = "Employee ID";
                    dataGridViewEmpView.Columns[1].HeaderCell.Value = "Position";
                    dataGridViewEmpView.Columns[2].HeaderCell.Value = "Name";
                    dataGridViewEmpView.Columns[3].HeaderCell.Value = "Mobile No";
                    dataGridViewEmpView.Columns[4].HeaderCell.Value = "Address Line 1";
                    dataGridViewEmpView.Columns[5].HeaderCell.Value = "Address Line 2";
                    dataGridViewEmpView.Columns[6].HeaderCell.Value = "City";
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
                string quary = "SELECT * FROM Employee WHERE name Like'" + txtEmpSrc.Text + "%';";

                try
                {
                    cs.OpenConnection();
                    object obj = cs.ShowDataInView(quary);
                    dataGridViewEmpView.DataSource = obj;
                    dataGridViewEmpView.Columns[0].HeaderCell.Value = "Employee ID";
                    dataGridViewEmpView.Columns[1].HeaderCell.Value = "Position";
                    dataGridViewEmpView.Columns[2].HeaderCell.Value = "Name";
                    dataGridViewEmpView.Columns[3].HeaderCell.Value = "Mobile No";
                    dataGridViewEmpView.Columns[4].HeaderCell.Value = "Address Line 1";
                    dataGridViewEmpView.Columns[5].HeaderCell.Value = "Address Line 2";
                    dataGridViewEmpView.Columns[6].HeaderCell.Value = "City";
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

        private void btnEmpAtteSrc_MouseHover(object sender, EventArgs e)
        {
            if (txtEmpSrc.Text.Length <= 0)
            {
                btnEmpAtteSrc.Text = "View All";
            }
            else
            {
                btnEmpAtteSrc.Text = "Search";
            }
        }

        private void dataGridViewEmpView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String getId = dataGridViewEmpView.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblEmpID.Text = getId;

            String catchStr1 = "";

            // get name field
            try
            {
                cs.OpenConnection();
                catchStr1 = cs.ReadValues("SELECT name FROM Employee WHERE Id = '" + getId + "' ;", "name");
                lblEmpName.Text = catchStr1;
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

        private void btnEmpAtteStamp_Click(object sender, EventArgs e)
        {
            //get system date time
            DateTime now = DateTime.Now;

            string quary = "INSERT INTO Attendance Values('"+lblEmpID.Text+"','" +lblEmpName.Text+ "','" +now+ "');";

            //create attendance list object 
            Attendance att = new Attendance()
            {
                empID = lblEmpID.Text,
                name = lblEmpName.Text,
                stamp_Date = Convert.ToString(now),

            };

            // validation

            if (lblEmpID.Text.Length<=0 | lblEmpID.Text=="None")
            {
                MessageBox.Show("Please select an employee id !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //insert to firebase 
                try
                {
                    var setter = client.Set("AttendanceList/" + lblEmpID.Text, att);
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
                    lblEmpID.Text = "None";
                    lblEmpName.Text = "No Name";
                    MessageBox.Show("Attendance stamped successfully ....", "Adttendance Stamp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnEmpAtteView_Click(object sender, EventArgs e)
        {
            string quary = "SELECT empID,name,date FROM Attendance WHERE date LIKE '"+dateTimePickerAtteData.Text+"%'";

            try
            {
                cs.OpenConnection();
                object obj = cs.ShowDataInView(quary);
                dataGridViewAtteData.DataSource = obj;
                dataGridViewAtteData.Columns[0].HeaderCell.Value = "Employee ID";
                dataGridViewAtteData.Columns[1].HeaderCell.Value = "Name";
                dataGridViewAtteData.Columns[2].HeaderCell.Value = "Stamped Date/Time";
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

        private void AttendanceControl1_Load(object sender, EventArgs e)
        {
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
    }
}
