
namespace Phone_shop
{
    partial class AddEmployeeControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpAddL2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpAddL1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpMob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEmpPosition = new System.Windows.Forms.ComboBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.lblHeadingTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpSrc = new System.Windows.Forms.TextBox();
            this.btnEmpSrc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAdd.ForeColor = System.Drawing.Color.White;
            this.btnEmpAdd.Location = new System.Drawing.Point(454, 54);
            this.btnEmpAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(144, 40);
            this.btnEmpAdd.TabIndex = 11;
            this.btnEmpAdd.Text = "Add Employee";
            this.btnEmpAdd.UseVisualStyleBackColor = false;
            this.btnEmpAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Address (Line 2)";
            // 
            // txtEmpAddL2
            // 
            this.txtEmpAddL2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpAddL2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpAddL2.Location = new System.Drawing.Point(168, 191);
            this.txtEmpAddL2.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpAddL2.Multiline = true;
            this.txtEmpAddL2.Name = "txtEmpAddL2";
            this.txtEmpAddL2.Size = new System.Drawing.Size(216, 27);
            this.txtEmpAddL2.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 72;
            this.label3.Text = "Address (Line 1)";
            // 
            // txtEmpAddL1
            // 
            this.txtEmpAddL1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpAddL1.AutoCompleteCustomSource.AddRange(new string[] {
            "Apple",
            "Samsung",
            "LG ",
            "Huawei",
            "Sky",
            "Nokia",
            "Alcatel",
            "ZTE",
            "Blackberry",
            "Mi( Xiaomi )",
            "Sony",
            "HTC",
            "Motorolla",
            "Lenovo",
            "Google Pixel",
            "OPPO",
            "Realme",
            "Oneplus",
            "VIVO",
            "ASUS",
            "Microsoft",
            "Energizer",
            "CAT",
            "Sharp",
            "Micromax",
            "Techno",
            "Blue",
            "Redmi",
            "Acer",
            "Panasonic",
            "Other"});
            this.txtEmpAddL1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpAddL1.Location = new System.Drawing.Point(168, 149);
            this.txtEmpAddL1.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpAddL1.Name = "txtEmpAddL1";
            this.txtEmpAddL1.Size = new System.Drawing.Size(216, 26);
            this.txtEmpAddL1.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Mobile No";
            // 
            // txtEmpMob
            // 
            this.txtEmpMob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpMob.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpMob.Location = new System.Drawing.Point(168, 106);
            this.txtEmpMob.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpMob.Multiline = true;
            this.txtEmpMob.Name = "txtEmpMob";
            this.txtEmpMob.Size = new System.Drawing.Size(216, 27);
            this.txtEmpMob.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Position";
            // 
            // cmbEmpPosition
            // 
            this.cmbEmpPosition.DisplayMember = "1";
            this.cmbEmpPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmpPosition.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbEmpPosition.FormattingEnabled = true;
            this.cmbEmpPosition.Items.AddRange(new object[] {
            "Manager",
            "Salesman",
            "Cashier",
            "Technician",
            "Supporter",
            "Cleaner",
            "Other"});
            this.cmbEmpPosition.Location = new System.Drawing.Point(168, 19);
            this.cmbEmpPosition.Name = "cmbEmpPosition";
            this.cmbEmpPosition.Size = new System.Drawing.Size(216, 28);
            this.cmbEmpPosition.TabIndex = 66;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(168, 63);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpName.Multiline = true;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(216, 27);
            this.txtEmpName.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(401, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "City";
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCity.Location = new System.Drawing.Point(454, 19);
            this.txtEmpCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpCity.Multiline = true;
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(197, 27);
            this.txtEmpCity.TabIndex = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbEmpPosition);
            this.groupBox1.Controls.Add(this.btnEmpAdd);
            this.groupBox1.Controls.Add(this.txtEmpCity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmpAddL2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmpMob);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmpAddL1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(21, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 231);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Employee";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEmpID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnEmpDel);
            this.groupBox2.Location = new System.Drawing.Point(401, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 120);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Employee";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.White;
            this.lblEmpID.Location = new System.Drawing.Point(172, 17);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(46, 19);
            this.lblEmpID.TabIndex = 79;
            this.lblEmpID.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "Selected Employee ID - ";
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpDel.BackColor = System.Drawing.Color.Red;
            this.btnEmpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDel.ForeColor = System.Drawing.Color.White;
            this.btnEmpDel.Location = new System.Drawing.Point(53, 52);
            this.btnEmpDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(144, 60);
            this.btnEmpDel.TabIndex = 77;
            this.btnEmpDel.Text = "Remove Employee";
            this.btnEmpDel.UseVisualStyleBackColor = false;
            this.btnEmpDel.Click += new System.EventHandler(this.btnEmpDel_Click);
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmp.Location = new System.Drawing.Point(21, 79);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.Size = new System.Drawing.Size(668, 266);
            this.dataGridViewEmp.TabIndex = 78;
            this.dataGridViewEmp.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmp_CellMouseClick);
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(17, 7);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(263, 24);
            this.lblHeadingTxt.TabIndex = 79;
            this.lblHeadingTxt.Text = "Employee Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Employee Name";
            // 
            // txtEmpSrc
            // 
            this.txtEmpSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmpSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmpSrc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSrc.Location = new System.Drawing.Point(163, 43);
            this.txtEmpSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpSrc.Name = "txtEmpSrc";
            this.txtEmpSrc.Size = new System.Drawing.Size(397, 26);
            this.txtEmpSrc.TabIndex = 81;
            // 
            // btnEmpSrc
            // 
            this.btnEmpSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpSrc.BackColor = System.Drawing.Color.Gray;
            this.btnEmpSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpSrc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSrc.ForeColor = System.Drawing.Color.White;
            this.btnEmpSrc.Location = new System.Drawing.Point(584, 38);
            this.btnEmpSrc.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpSrc.Name = "btnEmpSrc";
            this.btnEmpSrc.Size = new System.Drawing.Size(88, 34);
            this.btnEmpSrc.TabIndex = 77;
            this.btnEmpSrc.Text = "Search";
            this.btnEmpSrc.UseVisualStyleBackColor = false;
            this.btnEmpSrc.Click += new System.EventHandler(this.btnEmpSrc_Click);
            this.btnEmpSrc.MouseHover += new System.EventHandler(this.btnEmpSrc_MouseHover);
            // 
            // AddEmployeeControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnEmpSrc);
            this.Controls.Add(this.txtEmpSrc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHeadingTxt);
            this.Controls.Add(this.dataGridViewEmp);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEmployeeControl1";
            this.Size = new System.Drawing.Size(720, 594);
            this.Load += new System.EventHandler(this.AddEmployeeControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmpAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpAddL2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpAddL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpMob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEmpPosition;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHeadingTxt;
        private System.Windows.Forms.Button btnEmpSrc;
        private System.Windows.Forms.TextBox txtEmpSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label9;
    }
}
