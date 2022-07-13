
namespace Phone_shop
{
    partial class AttendanceControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeadingTxt = new System.Windows.Forms.Label();
            this.btnEmpAtteSrc = new System.Windows.Forms.Button();
            this.txtEmpSrc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewEmpView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEmpAtteStamp = new System.Windows.Forms.Button();
            this.dateTimePickerAtteData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpAtteView = new System.Windows.Forms.Button();
            this.dataGridViewAtteData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtteData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(22, 20);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(135, 24);
            this.lblHeadingTxt.TabIndex = 12;
            this.lblHeadingTxt.Text = "Attendance";
            // 
            // btnEmpAtteSrc
            // 
            this.btnEmpAtteSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpAtteSrc.BackColor = System.Drawing.Color.Gray;
            this.btnEmpAtteSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAtteSrc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAtteSrc.ForeColor = System.Drawing.Color.White;
            this.btnEmpAtteSrc.Location = new System.Drawing.Point(584, 54);
            this.btnEmpAtteSrc.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpAtteSrc.Name = "btnEmpAtteSrc";
            this.btnEmpAtteSrc.Size = new System.Drawing.Size(88, 34);
            this.btnEmpAtteSrc.TabIndex = 82;
            this.btnEmpAtteSrc.Text = "Search";
            this.btnEmpAtteSrc.UseVisualStyleBackColor = false;
            this.btnEmpAtteSrc.Click += new System.EventHandler(this.btnEmpAtteSrc_Click);
            this.btnEmpAtteSrc.MouseHover += new System.EventHandler(this.btnEmpAtteSrc_MouseHover);
            // 
            // txtEmpSrc
            // 
            this.txtEmpSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmpSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmpSrc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSrc.Location = new System.Drawing.Point(166, 59);
            this.txtEmpSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpSrc.Multiline = true;
            this.txtEmpSrc.Name = "txtEmpSrc";
            this.txtEmpSrc.Size = new System.Drawing.Size(397, 27);
            this.txtEmpSrc.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 84;
            this.label6.Text = "Employee Name";
            // 
            // dataGridViewEmpView
            // 
            this.dataGridViewEmpView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmpView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmpView.Location = new System.Drawing.Point(21, 97);
            this.dataGridViewEmpView.Name = "dataGridViewEmpView";
            this.dataGridViewEmpView.Size = new System.Drawing.Size(668, 135);
            this.dataGridViewEmpView.TabIndex = 83;
            this.dataGridViewEmpView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmpView_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEmpName);
            this.groupBox2.Controls.Add(this.lblEmpID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnEmpAtteStamp);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(21, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 91);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attendance Stamp";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.Color.White;
            this.lblEmpName.Location = new System.Drawing.Point(242, 35);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(74, 19);
            this.lblEmpName.TabIndex = 80;
            this.lblEmpName.Text = "No Name";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.White;
            this.lblEmpID.Location = new System.Drawing.Point(190, 35);
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
            this.label9.Location = new System.Drawing.Point(24, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "Selected Employee ID - ";
            // 
            // btnEmpAtteStamp
            // 
            this.btnEmpAtteStamp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpAtteStamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmpAtteStamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAtteStamp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAtteStamp.ForeColor = System.Drawing.Color.White;
            this.btnEmpAtteStamp.Location = new System.Drawing.Point(385, 24);
            this.btnEmpAtteStamp.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpAtteStamp.Name = "btnEmpAtteStamp";
            this.btnEmpAtteStamp.Size = new System.Drawing.Size(232, 43);
            this.btnEmpAtteStamp.TabIndex = 77;
            this.btnEmpAtteStamp.Text = "Create Attendance Stamp";
            this.btnEmpAtteStamp.UseVisualStyleBackColor = false;
            this.btnEmpAtteStamp.Click += new System.EventHandler(this.btnEmpAtteStamp_Click);
            // 
            // dateTimePickerAtteData
            // 
            this.dateTimePickerAtteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAtteData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAtteData.Location = new System.Drawing.Point(166, 345);
            this.dateTimePickerAtteData.Name = "dateTimePickerAtteData";
            this.dateTimePickerAtteData.Size = new System.Drawing.Size(397, 23);
            this.dateTimePickerAtteData.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 88;
            this.label1.Text = "Record Date";
            // 
            // btnEmpAtteView
            // 
            this.btnEmpAtteView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpAtteView.BackColor = System.Drawing.Color.Gray;
            this.btnEmpAtteView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAtteView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAtteView.ForeColor = System.Drawing.Color.White;
            this.btnEmpAtteView.Location = new System.Drawing.Point(584, 341);
            this.btnEmpAtteView.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpAtteView.Name = "btnEmpAtteView";
            this.btnEmpAtteView.Size = new System.Drawing.Size(88, 30);
            this.btnEmpAtteView.TabIndex = 89;
            this.btnEmpAtteView.Text = "View";
            this.btnEmpAtteView.UseVisualStyleBackColor = false;
            this.btnEmpAtteView.Click += new System.EventHandler(this.btnEmpAtteView_Click);
            // 
            // dataGridViewAtteData
            // 
            this.dataGridViewAtteData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAtteData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAtteData.Location = new System.Drawing.Point(21, 387);
            this.dataGridViewAtteData.Name = "dataGridViewAtteData";
            this.dataGridViewAtteData.Size = new System.Drawing.Size(668, 192);
            this.dataGridViewAtteData.TabIndex = 90;
            // 
            // AttendanceControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.dataGridViewAtteData);
            this.Controls.Add(this.btnEmpAtteView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAtteData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEmpAtteSrc);
            this.Controls.Add(this.txtEmpSrc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewEmpView);
            this.Controls.Add(this.lblHeadingTxt);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AttendanceControl1";
            this.Size = new System.Drawing.Size(720, 594);
            this.Load += new System.EventHandler(this.AttendanceControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtteData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingTxt;
        private System.Windows.Forms.Button btnEmpAtteSrc;
        private System.Windows.Forms.TextBox txtEmpSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewEmpView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEmpAtteStamp;
        private System.Windows.Forms.DateTimePicker dateTimePickerAtteData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpAtteView;
        private System.Windows.Forms.DataGridView dataGridViewAtteData;
        private System.Windows.Forms.Label lblEmpName;
    }
}
