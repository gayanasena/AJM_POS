namespace Phone_shop
{
    partial class SelectSalesmanFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSSMSrc = new System.Windows.Forms.Button();
            this.txtSSmSrc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHeadingTxt = new System.Windows.Forms.Label();
            this.dataGridSelectSale = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSSMSel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectSale)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSSMSrc
            // 
            this.btnSSMSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSSMSrc.BackColor = System.Drawing.Color.Gray;
            this.btnSSMSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSMSrc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSMSrc.ForeColor = System.Drawing.Color.White;
            this.btnSSMSrc.Location = new System.Drawing.Point(413, 39);
            this.btnSSMSrc.Margin = new System.Windows.Forms.Padding(2);
            this.btnSSMSrc.Name = "btnSSMSrc";
            this.btnSSMSrc.Size = new System.Drawing.Size(88, 34);
            this.btnSSMSrc.TabIndex = 82;
            this.btnSSMSrc.Text = "Search";
            this.btnSSMSrc.UseVisualStyleBackColor = false;
            this.btnSSMSrc.Click += new System.EventHandler(this.btnSSMSrc_Click);
            // 
            // txtSSmSrc
            // 
            this.txtSSmSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSSmSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSSmSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSSmSrc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSmSrc.Location = new System.Drawing.Point(154, 44);
            this.txtSSmSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtSSmSrc.Name = "txtSSmSrc";
            this.txtSSmSrc.Size = new System.Drawing.Size(241, 26);
            this.txtSSmSrc.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 85;
            this.label6.Text = "Employee Name";
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(8, 12);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(179, 24);
            this.lblHeadingTxt.TabIndex = 84;
            this.lblHeadingTxt.Text = "Select Salesman";
            // 
            // dataGridSelectSale
            // 
            this.dataGridSelectSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSelectSale.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSelectSale.Location = new System.Drawing.Point(12, 84);
            this.dataGridSelectSale.Name = "dataGridSelectSale";
            this.dataGridSelectSale.Size = new System.Drawing.Size(489, 202);
            this.dataGridSelectSale.TabIndex = 83;
            this.dataGridSelectSale.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridSelectSale_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEmpID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnSSMSel);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 86);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Salesman";
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
            // btnSSMSel
            // 
            this.btnSSMSel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSSMSel.BackColor = System.Drawing.Color.Red;
            this.btnSSMSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSSMSel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSMSel.ForeColor = System.Drawing.Color.White;
            this.btnSSMSel.Location = new System.Drawing.Point(287, 17);
            this.btnSSMSel.Margin = new System.Windows.Forms.Padding(2);
            this.btnSSMSel.Name = "btnSSMSel";
            this.btnSSMSel.Size = new System.Drawing.Size(144, 60);
            this.btnSSMSel.TabIndex = 77;
            this.btnSSMSel.Text = "Select Salesman";
            this.btnSSMSel.UseVisualStyleBackColor = false;
            // 
            // SelectSalesmanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(512, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSSMSrc);
            this.Controls.Add(this.txtSSmSrc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHeadingTxt);
            this.Controls.Add(this.dataGridSelectSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectSalesmanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectSalesmanFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectSale)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSSMSrc;
        private System.Windows.Forms.TextBox txtSSmSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHeadingTxt;
        private System.Windows.Forms.DataGridView dataGridSelectSale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSSMSel;
    }
}