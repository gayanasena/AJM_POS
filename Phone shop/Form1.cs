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
    public partial class Form1 : Form
    {
        String currentUserName = "User";
        String currentUserType = "Standerd User";

        public Form1()
        {
            InitializeComponent();
            CustomizeDesing();
            billControl11.BringToFront();
        }
        public Form1(String currUser, String userName)
        {
            InitializeComponent();
            CustomizeDesing();
            billControl11.BringToFront();
            currentUserName = userName;
            currentUserType = currUser;
            lblUserLineTxt.Text = "Current User - " + currentUserName + "(" + currentUserType + ")";
            setPrivileges();
            billControl11.txtBillEmp.Text = currentUserName;
        }

        private void setPrivileges()
        {
            if(currentUserType != "Admin")
            {
                Btndeleteitem.Enabled = false;
                Btnaddemployee.Enabled = false;
                Btnreports.Enabled = false;
                btnSalesTransfer.Enabled = false;
                billControl11.txtBillEmp.Enabled = false;
            }
        }
        public void CustomizeDesing()
        {
            panelstocksubmenu.Visible = false;
            panelemployeesubmenu.Visible = false;
            panelcustomersubmenu.Visible = false;
            panelSalesSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelstocksubmenu.Visible == true)
                panelstocksubmenu.Visible = false;
            if (panelemployeesubmenu.Visible == true)
                panelemployeesubmenu.Visible = false;
            if (panelcustomersubmenu.Visible == true)
                panelcustomersubmenu.Visible = false;
            if (panelSalesSubMenu.Visible == true)
                panelSalesSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void Btnstock_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelstocksubmenu);
        }

        private void Btnadditem_Click(object sender, EventArgs e)
        {
            HideSubMenu();

            addItemControl11.BringToFront();
        }

        private void Btndeleteitem_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            deleteItemControl11.BringToFront();
        }

        private void Btnviewitem_Click(object sender, EventArgs e)
        {
            HideSubMenu();
           viewItemControl11.BringToFront();
        }

        private void Btnaddemployee_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            addEmployeeControl11.BringToFront();
        }

        private void Btnattendance_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            attendanceControl11.BringToFront();
        }

        private void Btnaddcustomer_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            addCustomerControl11.BringToFront();
        }

        private void Btnremovecustomer_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            customerCardControl1.BringToFront();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelemployeesubmenu);

        }

        private void Btncustomer_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelcustomersubmenu);
        }

        private void Btnbill_Click(object sender, EventArgs e)
        {
            billControl11.BringToFront();
        }

        private void Btnreports_Click(object sender, EventArgs e)
        {
            reportsControl11.BringToFront();
        }

        private void Btnbarcodes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSalesSubMenu);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //HomeControl.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the programme?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalesOrdersLog_Click(object sender, EventArgs e)
        {
            //barcodesControl11.BringToFront();
        }

        private void btnSalesOrdersLog_Click_1(object sender, EventArgs e)
        {
            salesControl1.BringToFront();
        }

        private void btnSalesTransfer_Click(object sender, EventArgs e)
        {
            transferControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            returnControl11.BringToFront();
        }
    }
}
