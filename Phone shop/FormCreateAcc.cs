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
    public partial class FormCreateAcc : Form
    {
        public FormCreateAcc()
        {
            InitializeComponent();
            cmbPosition.SelectedIndex = 0;
        }

        private void btnLogExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to close the programme?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Connection cs = new Connection();

            if(txtUsername.Text.Length >= 8)
            {
                string quary1 = "select username from Login where username='" + txtUsername.Text + "';";

                try
                {
                    cs.OpenConnection();
                    string column = "username";
                    String extUsername = cs.ReadValues(quary1, column);
                    if(extUsername != txtUsername.Text) // check if username already exist
                    {
                        if(txtPassword.Text.Length>=8)
                        {
                            if(txtPassword.Text == txtRePwd.Text)
                            {
                                Connection cs2 = new Connection();
                                string quary2 = "insert into login values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbPosition.SelectedItem + "');";

                                try
                                {
                                    cs2.OpenConnection();
                                    cs2.ExecuteQuary(quary2);
                                    if (MessageBox.Show("User account created successfully ... Login please..", "User Accounts", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                    {
                                        FormLoginAJM frmObj = new FormLoginAJM();
                                        this.Hide();
                                        frmObj.Show();
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Error in database connection.. Please contact your IT support !");
                                }
                                finally
                                {
                                    cs2.CloseConnection();
                                    MessageBox.Show("User account created successfully ... Login please..", "User Accounts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password not matching with 'Re-Password' !", "Error", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must have at least 8 characters !", "Warning", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username already have!, Type an another username","Warning",MessageBoxButtons.OK);
                    }

                }
                catch
                {
                    MessageBox.Show("Error in connection with database .. Please contact your IT support !");
                }
                finally
                {
                    cs.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Username should have minimum 8 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
