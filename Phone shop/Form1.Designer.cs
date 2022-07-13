
namespace Phone_shop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSalesSubMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalesTransfer = new System.Windows.Forms.Button();
            this.btnSalesOrdersLog = new System.Windows.Forms.Button();
            this.Btnbarcodes = new System.Windows.Forms.Button();
            this.Btnreports = new System.Windows.Forms.Button();
            this.Btnbill = new System.Windows.Forms.Button();
            this.panelcustomersubmenu = new System.Windows.Forms.Panel();
            this.Btnremovecustomer = new System.Windows.Forms.Button();
            this.Btnaddcustomer = new System.Windows.Forms.Button();
            this.Btncustomer = new System.Windows.Forms.Button();
            this.panelemployeesubmenu = new System.Windows.Forms.Panel();
            this.Btnattendance = new System.Windows.Forms.Button();
            this.Btnaddemployee = new System.Windows.Forms.Button();
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.panelstocksubmenu = new System.Windows.Forms.Panel();
            this.Btnviewitem = new System.Windows.Forms.Button();
            this.Btndeleteitem = new System.Windows.Forms.Button();
            this.Btnadditem = new System.Windows.Forms.Button();
            this.Btnstock = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.returnControl11 = new Phone_shop.ReturnControl1();
            this.transferControl1 = new Phone_shop.TransferControl();
            this.salesControl1 = new Phone_shop.SalesControl();
            this.attendanceControl11 = new Phone_shop.AttendanceControl1();
            this.reportsControl11 = new Phone_shop.ReportsControl1();
            this.billControl11 = new Phone_shop.BillControl1();
            this.customerCardControl1 = new Phone_shop.CustomerCardControl();
            this.addCustomerControl11 = new Phone_shop.AddCustomerControl1();
            this.addEmployeeControl11 = new Phone_shop.AddEmployeeControl1();
            this.viewItemControl11 = new Phone_shop.ViewItemControl1();
            this.deleteItemControl11 = new Phone_shop.DeleteItemControl1();
            this.addItemControl11 = new Phone_shop.AddItemControl1();
            this.lblUserLineTxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSalesSubMenu.SuspendLayout();
            this.panelcustomersubmenu.SuspendLayout();
            this.panelemployeesubmenu.SuspendLayout();
            this.panelstocksubmenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.panelSalesSubMenu);
            this.panel1.Controls.Add(this.Btnbarcodes);
            this.panel1.Controls.Add(this.Btnreports);
            this.panel1.Controls.Add(this.Btnbill);
            this.panel1.Controls.Add(this.panelcustomersubmenu);
            this.panel1.Controls.Add(this.Btncustomer);
            this.panel1.Controls.Add(this.panelemployeesubmenu);
            this.panel1.Controls.Add(this.BtnEmployee);
            this.panel1.Controls.Add(this.panelstocksubmenu);
            this.panel1.Controls.Add(this.Btnstock);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 661);
            this.panel1.TabIndex = 0;
            // 
            // panelSalesSubMenu
            // 
            this.panelSalesSubMenu.Controls.Add(this.button1);
            this.panelSalesSubMenu.Controls.Add(this.btnSalesTransfer);
            this.panelSalesSubMenu.Controls.Add(this.btnSalesOrdersLog);
            this.panelSalesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalesSubMenu.Location = new System.Drawing.Point(0, 825);
            this.panelSalesSubMenu.Name = "panelSalesSubMenu";
            this.panelSalesSubMenu.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.panelSalesSubMenu.Size = new System.Drawing.Size(228, 155);
            this.panelSalesSubMenu.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(49, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Return Items";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalesTransfer
            // 
            this.btnSalesTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesTransfer.FlatAppearance.BorderSize = 0;
            this.btnSalesTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesTransfer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesTransfer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalesTransfer.Location = new System.Drawing.Point(49, 45);
            this.btnSalesTransfer.Name = "btnSalesTransfer";
            this.btnSalesTransfer.Size = new System.Drawing.Size(179, 45);
            this.btnSalesTransfer.TabIndex = 4;
            this.btnSalesTransfer.Text = "Items Transfer";
            this.btnSalesTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesTransfer.UseVisualStyleBackColor = true;
            this.btnSalesTransfer.Click += new System.EventHandler(this.btnSalesTransfer_Click);
            // 
            // btnSalesOrdersLog
            // 
            this.btnSalesOrdersLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesOrdersLog.FlatAppearance.BorderSize = 0;
            this.btnSalesOrdersLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesOrdersLog.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesOrdersLog.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalesOrdersLog.Location = new System.Drawing.Point(49, 0);
            this.btnSalesOrdersLog.Name = "btnSalesOrdersLog";
            this.btnSalesOrdersLog.Size = new System.Drawing.Size(179, 45);
            this.btnSalesOrdersLog.TabIndex = 3;
            this.btnSalesOrdersLog.Text = "Sales Log";
            this.btnSalesOrdersLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesOrdersLog.UseVisualStyleBackColor = true;
            this.btnSalesOrdersLog.Click += new System.EventHandler(this.btnSalesOrdersLog_Click_1);
            // 
            // Btnbarcodes
            // 
            this.Btnbarcodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnbarcodes.FlatAppearance.BorderSize = 0;
            this.Btnbarcodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbarcodes.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnbarcodes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnbarcodes.Location = new System.Drawing.Point(0, 770);
            this.Btnbarcodes.Name = "Btnbarcodes";
            this.Btnbarcodes.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btnbarcodes.Size = new System.Drawing.Size(228, 55);
            this.Btnbarcodes.TabIndex = 9;
            this.Btnbarcodes.Text = "Sales && Transfer";
            this.Btnbarcodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnbarcodes.UseVisualStyleBackColor = true;
            this.Btnbarcodes.Click += new System.EventHandler(this.Btnbarcodes_Click);
            // 
            // Btnreports
            // 
            this.Btnreports.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnreports.FlatAppearance.BorderSize = 0;
            this.Btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnreports.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnreports.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnreports.Location = new System.Drawing.Point(0, 715);
            this.Btnreports.Name = "Btnreports";
            this.Btnreports.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btnreports.Size = new System.Drawing.Size(228, 55);
            this.Btnreports.TabIndex = 8;
            this.Btnreports.Text = "Reports";
            this.Btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnreports.UseVisualStyleBackColor = true;
            this.Btnreports.Click += new System.EventHandler(this.Btnreports_Click);
            // 
            // Btnbill
            // 
            this.Btnbill.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnbill.FlatAppearance.BorderSize = 0;
            this.Btnbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnbill.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnbill.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnbill.Location = new System.Drawing.Point(0, 660);
            this.Btnbill.Name = "Btnbill";
            this.Btnbill.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btnbill.Size = new System.Drawing.Size(228, 55);
            this.Btnbill.TabIndex = 7;
            this.Btnbill.Text = "Billing";
            this.Btnbill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnbill.UseVisualStyleBackColor = true;
            this.Btnbill.Click += new System.EventHandler(this.Btnbill_Click);
            // 
            // panelcustomersubmenu
            // 
            this.panelcustomersubmenu.Controls.Add(this.Btnremovecustomer);
            this.panelcustomersubmenu.Controls.Add(this.Btnaddcustomer);
            this.panelcustomersubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcustomersubmenu.Location = new System.Drawing.Point(0, 566);
            this.panelcustomersubmenu.Name = "panelcustomersubmenu";
            this.panelcustomersubmenu.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.panelcustomersubmenu.Size = new System.Drawing.Size(228, 94);
            this.panelcustomersubmenu.TabIndex = 6;
            // 
            // Btnremovecustomer
            // 
            this.Btnremovecustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnremovecustomer.FlatAppearance.BorderSize = 0;
            this.Btnremovecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnremovecustomer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnremovecustomer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnremovecustomer.Location = new System.Drawing.Point(49, 45);
            this.Btnremovecustomer.Name = "Btnremovecustomer";
            this.Btnremovecustomer.Size = new System.Drawing.Size(179, 45);
            this.Btnremovecustomer.TabIndex = 4;
            this.Btnremovecustomer.Text = "Customer Card";
            this.Btnremovecustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnremovecustomer.UseVisualStyleBackColor = true;
            this.Btnremovecustomer.Click += new System.EventHandler(this.Btnremovecustomer_Click);
            // 
            // Btnaddcustomer
            // 
            this.Btnaddcustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnaddcustomer.FlatAppearance.BorderSize = 0;
            this.Btnaddcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnaddcustomer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaddcustomer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnaddcustomer.Location = new System.Drawing.Point(49, 0);
            this.Btnaddcustomer.Name = "Btnaddcustomer";
            this.Btnaddcustomer.Size = new System.Drawing.Size(179, 45);
            this.Btnaddcustomer.TabIndex = 3;
            this.Btnaddcustomer.Text = "Customer Management";
            this.Btnaddcustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnaddcustomer.UseVisualStyleBackColor = true;
            this.Btnaddcustomer.Click += new System.EventHandler(this.Btnaddcustomer_Click);
            // 
            // Btncustomer
            // 
            this.Btncustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btncustomer.FlatAppearance.BorderSize = 0;
            this.Btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncustomer.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncustomer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btncustomer.Location = new System.Drawing.Point(0, 511);
            this.Btncustomer.Name = "Btncustomer";
            this.Btncustomer.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btncustomer.Size = new System.Drawing.Size(228, 55);
            this.Btncustomer.TabIndex = 5;
            this.Btncustomer.Text = "Customer";
            this.Btncustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncustomer.UseVisualStyleBackColor = true;
            this.Btncustomer.Click += new System.EventHandler(this.Btncustomer_Click);
            // 
            // panelemployeesubmenu
            // 
            this.panelemployeesubmenu.Controls.Add(this.Btnattendance);
            this.panelemployeesubmenu.Controls.Add(this.Btnaddemployee);
            this.panelemployeesubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelemployeesubmenu.Location = new System.Drawing.Point(0, 421);
            this.panelemployeesubmenu.Name = "panelemployeesubmenu";
            this.panelemployeesubmenu.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.panelemployeesubmenu.Size = new System.Drawing.Size(228, 90);
            this.panelemployeesubmenu.TabIndex = 4;
            // 
            // Btnattendance
            // 
            this.Btnattendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnattendance.FlatAppearance.BorderSize = 0;
            this.Btnattendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnattendance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnattendance.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnattendance.Location = new System.Drawing.Point(49, 45);
            this.Btnattendance.Name = "Btnattendance";
            this.Btnattendance.Size = new System.Drawing.Size(179, 45);
            this.Btnattendance.TabIndex = 7;
            this.Btnattendance.Text = "Attendance";
            this.Btnattendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnattendance.UseVisualStyleBackColor = true;
            this.Btnattendance.Click += new System.EventHandler(this.Btnattendance_Click);
            // 
            // Btnaddemployee
            // 
            this.Btnaddemployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnaddemployee.FlatAppearance.BorderSize = 0;
            this.Btnaddemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnaddemployee.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnaddemployee.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnaddemployee.Location = new System.Drawing.Point(49, 0);
            this.Btnaddemployee.Name = "Btnaddemployee";
            this.Btnaddemployee.Size = new System.Drawing.Size(179, 45);
            this.Btnaddemployee.TabIndex = 3;
            this.Btnaddemployee.Text = "Employee Management";
            this.Btnaddemployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnaddemployee.UseVisualStyleBackColor = true;
            this.Btnaddemployee.Click += new System.EventHandler(this.Btnaddemployee_Click);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmployee.FlatAppearance.BorderSize = 0;
            this.BtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployee.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployee.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEmployee.Location = new System.Drawing.Point(0, 366);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.BtnEmployee.Size = new System.Drawing.Size(228, 55);
            this.BtnEmployee.TabIndex = 3;
            this.BtnEmployee.Text = "Employee";
            this.BtnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployee.UseVisualStyleBackColor = true;
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // panelstocksubmenu
            // 
            this.panelstocksubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelstocksubmenu.Controls.Add(this.Btnviewitem);
            this.panelstocksubmenu.Controls.Add(this.Btndeleteitem);
            this.panelstocksubmenu.Controls.Add(this.Btnadditem);
            this.panelstocksubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstocksubmenu.Location = new System.Drawing.Point(0, 231);
            this.panelstocksubmenu.Name = "panelstocksubmenu";
            this.panelstocksubmenu.Padding = new System.Windows.Forms.Padding(49, 0, 0, 0);
            this.panelstocksubmenu.Size = new System.Drawing.Size(228, 135);
            this.panelstocksubmenu.TabIndex = 2;
            // 
            // Btnviewitem
            // 
            this.Btnviewitem.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnviewitem.FlatAppearance.BorderSize = 0;
            this.Btnviewitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnviewitem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnviewitem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnviewitem.Location = new System.Drawing.Point(49, 90);
            this.Btnviewitem.Name = "Btnviewitem";
            this.Btnviewitem.Size = new System.Drawing.Size(179, 45);
            this.Btnviewitem.TabIndex = 6;
            this.Btnviewitem.Text = "View Items";
            this.Btnviewitem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnviewitem.UseVisualStyleBackColor = true;
            this.Btnviewitem.Click += new System.EventHandler(this.Btnviewitem_Click);
            // 
            // Btndeleteitem
            // 
            this.Btndeleteitem.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btndeleteitem.FlatAppearance.BorderSize = 0;
            this.Btndeleteitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndeleteitem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndeleteitem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btndeleteitem.Location = new System.Drawing.Point(49, 45);
            this.Btndeleteitem.Name = "Btndeleteitem";
            this.Btndeleteitem.Size = new System.Drawing.Size(179, 45);
            this.Btndeleteitem.TabIndex = 4;
            this.Btndeleteitem.Text = "Edit / Delete Item";
            this.Btndeleteitem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btndeleteitem.UseVisualStyleBackColor = true;
            this.Btndeleteitem.Click += new System.EventHandler(this.Btndeleteitem_Click);
            // 
            // Btnadditem
            // 
            this.Btnadditem.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnadditem.FlatAppearance.BorderSize = 0;
            this.Btnadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnadditem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnadditem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnadditem.Location = new System.Drawing.Point(49, 0);
            this.Btnadditem.Name = "Btnadditem";
            this.Btnadditem.Size = new System.Drawing.Size(179, 45);
            this.Btnadditem.TabIndex = 3;
            this.Btnadditem.Text = "Add Item";
            this.Btnadditem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnadditem.UseVisualStyleBackColor = true;
            this.Btnadditem.Click += new System.EventHandler(this.Btnadditem_Click);
            // 
            // Btnstock
            // 
            this.Btnstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnstock.FlatAppearance.BorderSize = 0;
            this.Btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnstock.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnstock.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Btnstock.Location = new System.Drawing.Point(0, 176);
            this.Btnstock.Name = "Btnstock";
            this.Btnstock.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.Btnstock.Size = new System.Drawing.Size(228, 55);
            this.Btnstock.TabIndex = 2;
            this.Btnstock.Text = "Inventory";
            this.Btnstock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnstock.UseVisualStyleBackColor = true;
            this.Btnstock.Click += new System.EventHandler(this.Btnstock_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 176);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(132, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Management ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 22);
            this.panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(927, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(251, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 45);
            this.panel4.TabIndex = 23;
            // 
            // returnControl11
            // 
            this.returnControl11.BackColor = System.Drawing.Color.DimGray;
            this.returnControl11.Location = new System.Drawing.Point(244, 68);
            this.returnControl11.Name = "returnControl11";
            this.returnControl11.Size = new System.Drawing.Size(720, 594);
            this.returnControl11.TabIndex = 22;
            // 
            // transferControl1
            // 
            this.transferControl1.BackColor = System.Drawing.Color.DimGray;
            this.transferControl1.Location = new System.Drawing.Point(244, 67);
            this.transferControl1.Name = "transferControl1";
            this.transferControl1.Size = new System.Drawing.Size(720, 594);
            this.transferControl1.TabIndex = 21;
            // 
            // salesControl1
            // 
            this.salesControl1.BackColor = System.Drawing.Color.DimGray;
            this.salesControl1.Location = new System.Drawing.Point(245, 68);
            this.salesControl1.Name = "salesControl1";
            this.salesControl1.Size = new System.Drawing.Size(720, 594);
            this.salesControl1.TabIndex = 20;
            // 
            // attendanceControl11
            // 
            this.attendanceControl11.BackColor = System.Drawing.Color.DimGray;
            this.attendanceControl11.ForeColor = System.Drawing.Color.LightGray;
            this.attendanceControl11.Location = new System.Drawing.Point(245, 67);
            this.attendanceControl11.Margin = new System.Windows.Forms.Padding(2);
            this.attendanceControl11.Name = "attendanceControl11";
            this.attendanceControl11.Size = new System.Drawing.Size(720, 594);
            this.attendanceControl11.TabIndex = 19;
            // 
            // reportsControl11
            // 
            this.reportsControl11.BackColor = System.Drawing.Color.DimGray;
            this.reportsControl11.Location = new System.Drawing.Point(245, 67);
            this.reportsControl11.Margin = new System.Windows.Forms.Padding(2);
            this.reportsControl11.Name = "reportsControl11";
            this.reportsControl11.Size = new System.Drawing.Size(720, 594);
            this.reportsControl11.TabIndex = 18;
            // 
            // billControl11
            // 
            this.billControl11.BackColor = System.Drawing.Color.DimGray;
            this.billControl11.Location = new System.Drawing.Point(245, 67);
            this.billControl11.Margin = new System.Windows.Forms.Padding(2);
            this.billControl11.Name = "billControl11";
            this.billControl11.Size = new System.Drawing.Size(720, 594);
            this.billControl11.TabIndex = 17;
            // 
            // customerCardControl1
            // 
            this.customerCardControl1.BackColor = System.Drawing.Color.DimGray;
            this.customerCardControl1.Location = new System.Drawing.Point(245, 67);
            this.customerCardControl1.Name = "customerCardControl1";
            this.customerCardControl1.Size = new System.Drawing.Size(720, 594);
            this.customerCardControl1.TabIndex = 16;
            // 
            // addCustomerControl11
            // 
            this.addCustomerControl11.BackColor = System.Drawing.Color.DimGray;
            this.addCustomerControl11.Location = new System.Drawing.Point(245, 67);
            this.addCustomerControl11.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomerControl11.Name = "addCustomerControl11";
            this.addCustomerControl11.Size = new System.Drawing.Size(720, 594);
            this.addCustomerControl11.TabIndex = 15;
            // 
            // addEmployeeControl11
            // 
            this.addEmployeeControl11.BackColor = System.Drawing.Color.DimGray;
            this.addEmployeeControl11.Location = new System.Drawing.Point(245, 67);
            this.addEmployeeControl11.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployeeControl11.Name = "addEmployeeControl11";
            this.addEmployeeControl11.Size = new System.Drawing.Size(720, 594);
            this.addEmployeeControl11.TabIndex = 14;
            // 
            // viewItemControl11
            // 
            this.viewItemControl11.BackColor = System.Drawing.Color.DimGray;
            this.viewItemControl11.Location = new System.Drawing.Point(245, 67);
            this.viewItemControl11.Margin = new System.Windows.Forms.Padding(2);
            this.viewItemControl11.Name = "viewItemControl11";
            this.viewItemControl11.Size = new System.Drawing.Size(720, 594);
            this.viewItemControl11.TabIndex = 13;
            // 
            // deleteItemControl11
            // 
            this.deleteItemControl11.BackColor = System.Drawing.Color.DimGray;
            this.deleteItemControl11.Location = new System.Drawing.Point(245, 67);
            this.deleteItemControl11.Margin = new System.Windows.Forms.Padding(2);
            this.deleteItemControl11.Name = "deleteItemControl11";
            this.deleteItemControl11.Size = new System.Drawing.Size(720, 594);
            this.deleteItemControl11.TabIndex = 12;
            // 
            // addItemControl11
            // 
            this.addItemControl11.BackColor = System.Drawing.Color.DimGray;
            this.addItemControl11.Location = new System.Drawing.Point(245, 67);
            this.addItemControl11.Margin = new System.Windows.Forms.Padding(2);
            this.addItemControl11.Name = "addItemControl11";
            this.addItemControl11.Size = new System.Drawing.Size(720, 594);
            this.addItemControl11.TabIndex = 11;
            // 
            // lblUserLineTxt
            // 
            this.lblUserLineTxt.AutoSize = true;
            this.lblUserLineTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUserLineTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserLineTxt.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLineTxt.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserLineTxt.Location = new System.Drawing.Point(302, 37);
            this.lblUserLineTxt.Name = "lblUserLineTxt";
            this.lblUserLineTxt.Size = new System.Drawing.Size(111, 18);
            this.lblUserLineTxt.TabIndex = 24;
            this.lblUserLineTxt.Text = "Current User - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 661);
            this.Controls.Add(this.lblUserLineTxt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.returnControl11);
            this.Controls.Add(this.transferControl1);
            this.Controls.Add(this.salesControl1);
            this.Controls.Add(this.attendanceControl11);
            this.Controls.Add(this.reportsControl11);
            this.Controls.Add(this.billControl11);
            this.Controls.Add(this.customerCardControl1);
            this.Controls.Add(this.addCustomerControl11);
            this.Controls.Add(this.addEmployeeControl11);
            this.Controls.Add(this.viewItemControl11);
            this.Controls.Add(this.deleteItemControl11);
            this.Controls.Add(this.addItemControl11);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelSalesSubMenu.ResumeLayout(false);
            this.panelcustomersubmenu.ResumeLayout(false);
            this.panelemployeesubmenu.ResumeLayout(false);
            this.panelstocksubmenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btnstock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelstocksubmenu;
        private System.Windows.Forms.Button Btnviewitem;
        private System.Windows.Forms.Button Btndeleteitem;
        private System.Windows.Forms.Button Btnadditem;
        private System.Windows.Forms.Panel panelcustomersubmenu;
        private System.Windows.Forms.Button Btnremovecustomer;
        private System.Windows.Forms.Button Btnaddcustomer;
        private System.Windows.Forms.Button Btncustomer;
        private System.Windows.Forms.Panel panelemployeesubmenu;
        private System.Windows.Forms.Button Btnattendance;
        private System.Windows.Forms.Button Btnaddemployee;
        private System.Windows.Forms.Button BtnEmployee;
        private System.Windows.Forms.Button Btnbarcodes;
        private System.Windows.Forms.Button Btnreports;
        private System.Windows.Forms.Button Btnbill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private AddItemControl1 addItemControl11;
        private DeleteItemControl1 deleteItemControl11;
        private ViewItemControl1 viewItemControl11;
        private AddEmployeeControl1 addEmployeeControl11;
        private AddCustomerControl1 addCustomerControl11;
        private CustomerCardControl customerCardControl1;
        private BillControl1 billControl11;
        private ReportsControl1 reportsControl11;
        private System.Windows.Forms.Panel panelSalesSubMenu;
        private System.Windows.Forms.Button btnSalesTransfer;
        private System.Windows.Forms.Button btnSalesOrdersLog;
        private AttendanceControl1 attendanceControl11;
        private SalesControl salesControl1;
        private TransferControl transferControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private ReturnControl1 returnControl11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUserLineTxt;
    }
}

