
namespace Phone_shop
{
    partial class BillControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillControl1));
            this.btnBillNew = new System.Windows.Forms.Button();
            this.txtBillPayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBillTotAmt = new System.Windows.Forms.TextBox();
            this.txtBillTax = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewBill = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBillEmp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBillFindImei = new System.Windows.Forms.TextBox();
            this.btnBillBarcSrc = new System.Windows.Forms.Button();
            this.btnSBsrcBc = new System.Windows.Forms.Button();
            this.cmdSBminQty = new System.Windows.Forms.Button();
            this.btnBillItemAdd = new System.Windows.Forms.Button();
            this.cmdSBplQty = new System.Windows.Forms.Button();
            this.txtBillBarcode = new System.Windows.Forms.TextBox();
            this.txtBillfindItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radBillCash = new System.Windows.Forms.RadioButton();
            this.radBillWholesale = new System.Windows.Forms.RadioButton();
            this.radBillDelivery = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBillCusNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBillPrint = new System.Windows.Forms.Button();
            this.btnBillPay = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dTPBillDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBillNew
            // 
            this.btnBillNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBillNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillNew.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillNew.ForeColor = System.Drawing.Color.White;
            this.btnBillNew.Location = new System.Drawing.Point(18, 505);
            this.btnBillNew.Name = "btnBillNew";
            this.btnBillNew.Size = new System.Drawing.Size(107, 48);
            this.btnBillNew.TabIndex = 199;
            this.btnBillNew.Text = "New Bill";
            this.btnBillNew.UseVisualStyleBackColor = false;
            this.btnBillNew.Click += new System.EventHandler(this.btnBillNew_Click);
            // 
            // txtBillPayment
            // 
            this.txtBillPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillPayment.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillPayment.Location = new System.Drawing.Point(544, 559);
            this.txtBillPayment.Multiline = true;
            this.txtBillPayment.Name = "txtBillPayment";
            this.txtBillPayment.Size = new System.Drawing.Size(162, 21);
            this.txtBillPayment.TabIndex = 198;
            this.txtBillPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(451, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 197;
            this.label10.Text = "Payment(Rs)";
            // 
            // txtBillTotAmt
            // 
            this.txtBillTotAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillTotAmt.Enabled = false;
            this.txtBillTotAmt.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillTotAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillTotAmt.Location = new System.Drawing.Point(544, 532);
            this.txtBillTotAmt.Multiline = true;
            this.txtBillTotAmt.Name = "txtBillTotAmt";
            this.txtBillTotAmt.Size = new System.Drawing.Size(162, 21);
            this.txtBillTotAmt.TabIndex = 196;
            this.txtBillTotAmt.Text = "0";
            this.txtBillTotAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBillTax
            // 
            this.txtBillTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillTax.Enabled = false;
            this.txtBillTax.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillTax.Location = new System.Drawing.Point(544, 505);
            this.txtBillTax.Multiline = true;
            this.txtBillTax.Name = "txtBillTax";
            this.txtBillTax.Size = new System.Drawing.Size(162, 21);
            this.txtBillTax.TabIndex = 195;
            this.txtBillTax.Text = "0";
            this.txtBillTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillAmount.Enabled = false;
            this.txtBillAmount.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillAmount.Location = new System.Drawing.Point(544, 478);
            this.txtBillAmount.Multiline = true;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(162, 21);
            this.txtBillAmount.TabIndex = 186;
            this.txtBillAmount.Text = "0";
            this.txtBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(423, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 194;
            this.label9.Text = "Total Amount(Rs)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(423, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 193;
            this.label8.Text = "Charges/Tax*(Rs)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(460, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 187;
            this.label7.Text = "Amount(Rs)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 185;
            this.label2.Text = "Current Bill";
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Brand,
            this.Item_Name,
            this.Qty,
            this.unit_price,
            this.total});
            this.dataGridViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBill.HideSelection = false;
            this.dataGridViewBill.Location = new System.Drawing.Point(14, 234);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(692, 228);
            this.dataGridViewBill.TabIndex = 192;
            this.dataGridViewBill.UseCompatibleStateImageBehavior = false;
            this.dataGridViewBill.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 40;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Brand.Width = 95;
            // 
            // Item_Name
            // 
            this.Item_Name.Text = "Item Name";
            this.Item_Name.Width = 239;
            // 
            // Qty
            // 
            this.Qty.Text = "Quantitty";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Qty.Width = 88;
            // 
            // unit_price
            // 
            this.unit_price.Text = "Unit Price";
            this.unit_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unit_price.Width = 115;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total.Width = 110;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtBillID);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(267, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(124, 55);
            this.groupBox5.TabIndex = 188;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 19);
            this.label6.TabIndex = 172;
            this.label6.Text = "ID";
            // 
            // txtBillID
            // 
            this.txtBillID.AutoCompleteCustomSource.AddRange(new string[] {
            "Espresso",
            "Dinner",
            "Lunch"});
            this.txtBillID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBillID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBillID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillID.Enabled = false;
            this.txtBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillID.Location = new System.Drawing.Point(28, 22);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(90, 17);
            this.txtBillID.TabIndex = 173;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBillEmp);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(267, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 55);
            this.groupBox4.TabIndex = 190;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salesman";
            // 
            // txtBillEmp
            // 
            this.txtBillEmp.AutoCompleteCustomSource.AddRange(new string[] {
            "Espresso",
            "Dinner",
            "Lunch"});
            this.txtBillEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBillEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBillEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillEmp.Location = new System.Drawing.Point(6, 24);
            this.txtBillEmp.Name = "txtBillEmp";
            this.txtBillEmp.Size = new System.Drawing.Size(112, 17);
            this.txtBillEmp.TabIndex = 174;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtBillFindImei);
            this.groupBox3.Controls.Add(this.btnBillBarcSrc);
            this.groupBox3.Controls.Add(this.btnSBsrcBc);
            this.groupBox3.Controls.Add(this.cmdSBminQty);
            this.groupBox3.Controls.Add(this.btnBillItemAdd);
            this.groupBox3.Controls.Add(this.cmdSBplQty);
            this.groupBox3.Controls.Add(this.txtBillBarcode);
            this.groupBox3.Controls.Add(this.txtBillfindItem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBillQty);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(398, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 183);
            this.groupBox3.TabIndex = 191;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Items";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 175;
            this.label11.Text = "Find IMEI";
            // 
            // txtBillFindImei
            // 
            this.txtBillFindImei.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBillFindImei.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBillFindImei.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillFindImei.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillFindImei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillFindImei.Location = new System.Drawing.Point(101, 55);
            this.txtBillFindImei.Name = "txtBillFindImei";
            this.txtBillFindImei.Size = new System.Drawing.Size(201, 18);
            this.txtBillFindImei.TabIndex = 174;
            // 
            // btnBillBarcSrc
            // 
            this.btnBillBarcSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillBarcSrc.Image = ((System.Drawing.Image)(resources.GetObject("btnBillBarcSrc.Image")));
            this.btnBillBarcSrc.Location = new System.Drawing.Point(265, 91);
            this.btnBillBarcSrc.Name = "btnBillBarcSrc";
            this.btnBillBarcSrc.Size = new System.Drawing.Size(37, 38);
            this.btnBillBarcSrc.TabIndex = 173;
            this.btnBillBarcSrc.UseVisualStyleBackColor = true;
            this.btnBillBarcSrc.Click += new System.EventHandler(this.btnBillBarcSrc_Click);
            // 
            // btnSBsrcBc
            // 
            this.btnSBsrcBc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSBsrcBc.Image = ((System.Drawing.Image)(resources.GetObject("btnSBsrcBc.Image")));
            this.btnSBsrcBc.Location = new System.Drawing.Point(340, 76);
            this.btnSBsrcBc.Name = "btnSBsrcBc";
            this.btnSBsrcBc.Size = new System.Drawing.Size(37, 38);
            this.btnSBsrcBc.TabIndex = 172;
            this.btnSBsrcBc.UseVisualStyleBackColor = true;
            // 
            // cmdSBminQty
            // 
            this.cmdSBminQty.BackColor = System.Drawing.Color.White;
            this.cmdSBminQty.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdSBminQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSBminQty.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSBminQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSBminQty.Image = ((System.Drawing.Image)(resources.GetObject("cmdSBminQty.Image")));
            this.cmdSBminQty.Location = new System.Drawing.Point(19, 148);
            this.cmdSBminQty.Name = "cmdSBminQty";
            this.cmdSBminQty.Size = new System.Drawing.Size(37, 27);
            this.cmdSBminQty.TabIndex = 171;
            this.cmdSBminQty.UseVisualStyleBackColor = false;
            this.cmdSBminQty.Click += new System.EventHandler(this.cmdSBminQty_Click);
            // 
            // btnBillItemAdd
            // 
            this.btnBillItemAdd.BackColor = System.Drawing.Color.White;
            this.btnBillItemAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBillItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillItemAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillItemAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnBillItemAdd.Image")));
            this.btnBillItemAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillItemAdd.Location = new System.Drawing.Point(186, 145);
            this.btnBillItemAdd.Name = "btnBillItemAdd";
            this.btnBillItemAdd.Size = new System.Drawing.Size(98, 30);
            this.btnBillItemAdd.TabIndex = 170;
            this.btnBillItemAdd.Text = "      ADD";
            this.btnBillItemAdd.UseVisualStyleBackColor = false;
            this.btnBillItemAdd.Click += new System.EventHandler(this.btnBillItemAdd_Click);
            // 
            // cmdSBplQty
            // 
            this.cmdSBplQty.BackColor = System.Drawing.Color.White;
            this.cmdSBplQty.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdSBplQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSBplQty.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSBplQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSBplQty.Image = ((System.Drawing.Image)(resources.GetObject("cmdSBplQty.Image")));
            this.cmdSBplQty.Location = new System.Drawing.Point(125, 148);
            this.cmdSBplQty.Name = "cmdSBplQty";
            this.cmdSBplQty.Size = new System.Drawing.Size(37, 27);
            this.cmdSBplQty.TabIndex = 169;
            this.cmdSBplQty.UseVisualStyleBackColor = false;
            this.cmdSBplQty.Click += new System.EventHandler(this.cmdSBplQty_Click);
            // 
            // txtBillBarcode
            // 
            this.txtBillBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillBarcode.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillBarcode.Location = new System.Drawing.Point(20, 102);
            this.txtBillBarcode.Name = "txtBillBarcode";
            this.txtBillBarcode.Size = new System.Drawing.Size(231, 18);
            this.txtBillBarcode.TabIndex = 145;
            // 
            // txtBillfindItem
            // 
            this.txtBillfindItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBillfindItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBillfindItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillfindItem.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillfindItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillfindItem.Location = new System.Drawing.Point(101, 23);
            this.txtBillfindItem.Name = "txtBillfindItem";
            this.txtBillfindItem.Size = new System.Drawing.Size(201, 18);
            this.txtBillfindItem.TabIndex = 161;
            this.txtBillfindItem.Click += new System.EventHandler(this.txtBillfindItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 19);
            this.label1.TabIndex = 144;
            this.label1.Text = "Barcode (*Scan with reader)";
            // 
            // txtBillQty
            // 
            this.txtBillQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillQty.Enabled = false;
            this.txtBillQty.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillQty.Location = new System.Drawing.Point(62, 148);
            this.txtBillQty.Multiline = true;
            this.txtBillQty.Name = "txtBillQty";
            this.txtBillQty.Size = new System.Drawing.Size(57, 27);
            this.txtBillQty.TabIndex = 168;
            this.txtBillQty.Text = "0";
            this.txtBillQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 167;
            this.label4.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 165;
            this.label3.Text = "Find Model";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBillCash);
            this.groupBox2.Controls.Add(this.radBillWholesale);
            this.groupBox2.Controls.Add(this.radBillDelivery);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 55);
            this.groupBox2.TabIndex = 189;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Type";
            // 
            // radBillCash
            // 
            this.radBillCash.AutoSize = true;
            this.radBillCash.Checked = true;
            this.radBillCash.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBillCash.ForeColor = System.Drawing.Color.White;
            this.radBillCash.Location = new System.Drawing.Point(6, 22);
            this.radBillCash.Name = "radBillCash";
            this.radBillCash.Size = new System.Drawing.Size(59, 21);
            this.radBillCash.TabIndex = 162;
            this.radBillCash.TabStop = true;
            this.radBillCash.Text = "Cash";
            this.radBillCash.UseVisualStyleBackColor = true;
            // 
            // radBillWholesale
            // 
            this.radBillWholesale.AutoSize = true;
            this.radBillWholesale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBillWholesale.ForeColor = System.Drawing.Color.White;
            this.radBillWholesale.Location = new System.Drawing.Point(71, 22);
            this.radBillWholesale.Name = "radBillWholesale";
            this.radBillWholesale.Size = new System.Drawing.Size(92, 21);
            this.radBillWholesale.TabIndex = 163;
            this.radBillWholesale.Text = "Wholesale";
            this.radBillWholesale.UseVisualStyleBackColor = true;
            // 
            // radBillDelivery
            // 
            this.radBillDelivery.AutoSize = true;
            this.radBillDelivery.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBillDelivery.ForeColor = System.Drawing.Color.White;
            this.radBillDelivery.Location = new System.Drawing.Point(169, 22);
            this.radBillDelivery.Name = "radBillDelivery";
            this.radBillDelivery.Size = new System.Drawing.Size(76, 21);
            this.radBillDelivery.TabIndex = 164;
            this.radBillDelivery.Text = "Delivery";
            this.radBillDelivery.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBillCusNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 55);
            this.groupBox1.TabIndex = 184;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // txtBillCusNo
            // 
            this.txtBillCusNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBillCusNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBillCusNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillCusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCusNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBillCusNo.Location = new System.Drawing.Point(66, 20);
            this.txtBillCusNo.Name = "txtBillCusNo";
            this.txtBillCusNo.Size = new System.Drawing.Size(169, 17);
            this.txtBillCusNo.TabIndex = 172;
            this.txtBillCusNo.Click += new System.EventHandler(this.txtBillCusNo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 171;
            this.label5.Text = "Mobile";
            // 
            // btnBillPrint
            // 
            this.btnBillPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBillPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillPrint.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillPrint.ForeColor = System.Drawing.Color.White;
            this.btnBillPrint.Location = new System.Drawing.Point(156, 505);
            this.btnBillPrint.Name = "btnBillPrint";
            this.btnBillPrint.Size = new System.Drawing.Size(107, 48);
            this.btnBillPrint.TabIndex = 183;
            this.btnBillPrint.Text = "Print Bill";
            this.btnBillPrint.UseVisualStyleBackColor = false;
            this.btnBillPrint.Click += new System.EventHandler(this.btnBillPrint_Click);
            // 
            // btnBillPay
            // 
            this.btnBillPay.BackColor = System.Drawing.Color.Red;
            this.btnBillPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillPay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillPay.ForeColor = System.Drawing.Color.White;
            this.btnBillPay.Location = new System.Drawing.Point(294, 505);
            this.btnBillPay.Name = "btnBillPay";
            this.btnBillPay.Size = new System.Drawing.Size(107, 48);
            this.btnBillPay.TabIndex = 200;
            this.btnBillPay.Text = "Pay Now";
            this.btnBillPay.UseVisualStyleBackColor = false;
            this.btnBillPay.Click += new System.EventHandler(this.btnBillPay_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dTPBillDate);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(8, 145);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(383, 55);
            this.groupBox6.TabIndex = 185;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sales Date";
            // 
            // dTPBillDate
            // 
            this.dTPBillDate.Enabled = false;
            this.dTPBillDate.Location = new System.Drawing.Point(10, 23);
            this.dTPBillDate.Name = "dTPBillDate";
            this.dTPBillDate.Size = new System.Drawing.Size(367, 23);
            this.dTPBillDate.TabIndex = 2;
            // 
            // BillControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnBillPay);
            this.Controls.Add(this.btnBillNew);
            this.Controls.Add(this.txtBillPayment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBillTotAmt);
            this.Controls.Add(this.txtBillTax);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBillPrint);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillControl1";
            this.Size = new System.Drawing.Size(720, 594);
            this.Load += new System.EventHandler(this.BillControl1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBillNew;
        private System.Windows.Forms.TextBox txtBillPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBillTotAmt;
        private System.Windows.Forms.TextBox txtBillTax;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView dataGridViewBill;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Item_Name;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader unit_price;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSBsrcBc;
        private System.Windows.Forms.Button cmdSBminQty;
        private System.Windows.Forms.Button btnBillItemAdd;
        private System.Windows.Forms.Button cmdSBplQty;
        private System.Windows.Forms.TextBox txtBillBarcode;
        private System.Windows.Forms.TextBox txtBillfindItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBillCash;
        private System.Windows.Forms.RadioButton radBillWholesale;
        private System.Windows.Forms.RadioButton radBillDelivery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBillCusNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBillPrint;
        private System.Windows.Forms.Button btnBillPay;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dTPBillDate;
        private System.Windows.Forms.Button btnBillBarcSrc;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBillFindImei;
        public System.Windows.Forms.TextBox txtBillEmp;
    }
}
