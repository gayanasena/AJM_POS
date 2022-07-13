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
    public partial class FormLoginAJM : Form
    {
        public FormLoginAJM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = false;
            String userType = "";
            Connection cs = new Connection();
            string quary = "select * from login where username = '" + txtUser.Text.Trim() + "' and password ='" + txtPassword.Text.Trim() + "'";
            string quaryGetType = "select * from login where username = '" + txtUser.Text.Trim() + "' and password ='" + txtPassword.Text.Trim() + "'";
            //get user type to pass
            try
            {
                cs.OpenConnection();
                userType = cs.ReadValues(quaryGetType,"type");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex);
            }
            finally
            {
                cs.CloseConnection();
            }

            try
            {
                cs.OpenConnection();
                status = cs.ReadDataLogin(quary);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex);
            }
            finally
            {
                cs.CloseConnection();


                if (status == true)
                {
                    this.Hide();
                    Form1 obj = new Form1(userType, txtUser.Text);

                    try
                    {
                        obj.ShowDialog();
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong .. please restart the application ! ", "Oops ... ", MessageBoxButtons.OK);
                    }
                    finally
                    {
                        this.Close();
                    }
                }


                else
                {
                    MessageBox.Show("Entered username or password wrong ..... !", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            FormCreateAcc fo = new FormCreateAcc();
            this.Hide();
            fo.Show();
        }

        private void btnLogExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure , you want to close the programme?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AJ Mobile™ Managemet System. Software Created By NIBM DSE Students. 2022 All Right Reserved", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
