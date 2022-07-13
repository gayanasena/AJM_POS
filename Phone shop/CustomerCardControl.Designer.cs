namespace Phone_shop
{
    partial class CustomerCardControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnCusCardSrc = new System.Windows.Forms.Button();
            this.txtCusCardSrc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewCusCard = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCusCardName = new System.Windows.Forms.Label();
            this.lblCusCardID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetForCusCard = new Phone_shop.DataSetForCusCard();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerTableAdapter = new Phone_shop.DataSetForCusCardTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCusCard)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForCusCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCusCardSrc
            // 
            this.btnCusCardSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCusCardSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCusCardSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusCardSrc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusCardSrc.ForeColor = System.Drawing.Color.White;
            this.btnCusCardSrc.Location = new System.Drawing.Point(590, 23);
            this.btnCusCardSrc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCusCardSrc.Name = "btnCusCardSrc";
            this.btnCusCardSrc.Size = new System.Drawing.Size(88, 34);
            this.btnCusCardSrc.TabIndex = 88;
            this.btnCusCardSrc.Text = "Search";
            this.btnCusCardSrc.UseVisualStyleBackColor = false;
            this.btnCusCardSrc.Click += new System.EventHandler(this.btnCusCardSrc_Click);
            this.btnCusCardSrc.MouseHover += new System.EventHandler(this.btnCusCardSrc_MouseHover);
            // 
            // txtCusCardSrc
            // 
            this.txtCusCardSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusCardSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCusCardSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCusCardSrc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusCardSrc.Location = new System.Drawing.Point(165, 28);
            this.txtCusCardSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusCardSrc.Name = "txtCusCardSrc";
            this.txtCusCardSrc.Size = new System.Drawing.Size(397, 26);
            this.txtCusCardSrc.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 90;
            this.label6.Text = "Customer Name";
            // 
            // dataGridViewCusCard
            // 
            this.dataGridViewCusCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCusCard.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCusCard.Location = new System.Drawing.Point(27, 66);
            this.dataGridViewCusCard.Name = "dataGridViewCusCard";
            this.dataGridViewCusCard.Size = new System.Drawing.Size(668, 147);
            this.dataGridViewCusCard.TabIndex = 89;
            this.dataGridViewCusCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCusCard_CellContentClick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(392, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 46);
            this.button2.TabIndex = 92;
            this.button2.Text = "Generate Shipping Card";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCusCardName);
            this.groupBox2.Controls.Add(this.lblCusCardID);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(27, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 82);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attendance Stamp";
            // 
            // lblCusCardName
            // 
            this.lblCusCardName.AutoSize = true;
            this.lblCusCardName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusCardName.ForeColor = System.Drawing.Color.White;
            this.lblCusCardName.Location = new System.Drawing.Point(242, 35);
            this.lblCusCardName.Name = "lblCusCardName";
            this.lblCusCardName.Size = new System.Drawing.Size(74, 19);
            this.lblCusCardName.TabIndex = 80;
            this.lblCusCardName.Text = "No Name";
            // 
            // lblCusCardID
            // 
            this.lblCusCardID.AutoSize = true;
            this.lblCusCardID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusCardID.ForeColor = System.Drawing.Color.White;
            this.lblCusCardID.Location = new System.Drawing.Point(191, 35);
            this.lblCusCardID.Name = "lblCusCardID";
            this.lblCusCardID.Size = new System.Drawing.Size(46, 19);
            this.lblCusCardID.TabIndex = 79;
            this.lblCusCardID.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 19);
            this.label9.TabIndex = 79;
            this.label9.Text = "Selected Customer ID - ";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.CustomerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Phone_shop.ReportCusCard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(27, 320);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(668, 259);
            this.reportViewer1.TabIndex = 95;
            // 
            // DataSetForCusCard
            // 
            this.DataSetForCusCard.DataSetName = "DataSetForCusCard";
            this.DataSetForCusCard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataMember = "Customer";
            this.CustomerBindingSource.DataSource = this.DataSetForCusCard;
            // 
            // CustomerTableAdapter
            // 
            this.CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCusCardSrc);
            this.Controls.Add(this.txtCusCardSrc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewCusCard);
            this.Name = "CustomerCardControl";
            this.Size = new System.Drawing.Size(720, 594);
            this.Load += new System.EventHandler(this.CustomerCardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCusCard)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetForCusCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCusCardSrc;
        private System.Windows.Forms.TextBox txtCusCardSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewCusCard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCusCardName;
        private System.Windows.Forms.Label lblCusCardID;
        private System.Windows.Forms.Label label9;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private DataSetForCusCard DataSetForCusCard;
        private DataSetForCusCardTableAdapters.CustomerTableAdapter CustomerTableAdapter;
    }
}
