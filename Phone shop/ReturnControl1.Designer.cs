namespace Phone_shop
{
    partial class ReturnControl1
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
            this.dataGridViewRtn = new System.Windows.Forms.DataGridView();
            this.cmbRetFind = new System.Windows.Forms.ComboBox();
            this.txtRetSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRtnSrc = new System.Windows.Forms.Button();
            this.lblHeadingTxt = new System.Windows.Forms.Label();
            this.BtnRetUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetReason = new System.Windows.Forms.TextBox();
            this.cmbRetStation = new System.Windows.Forms.ComboBox();
            this.lblInvModID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRetBarcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetImei = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRtn
            // 
            this.dataGridViewRtn.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRtn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRtn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRtn.GridColor = System.Drawing.Color.White;
            this.dataGridViewRtn.Location = new System.Drawing.Point(28, 98);
            this.dataGridViewRtn.Name = "dataGridViewRtn";
            this.dataGridViewRtn.Size = new System.Drawing.Size(662, 224);
            this.dataGridViewRtn.TabIndex = 102;
            this.dataGridViewRtn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRtn_CellContentClick);
            // 
            // cmbRetFind
            // 
            this.cmbRetFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRetFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbRetFind.DisplayMember = "1";
            this.cmbRetFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRetFind.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRetFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbRetFind.FormattingEnabled = true;
            this.cmbRetFind.Items.AddRange(new object[] {
            "IMEI"});
            this.cmbRetFind.Location = new System.Drawing.Point(92, 58);
            this.cmbRetFind.Name = "cmbRetFind";
            this.cmbRetFind.Size = new System.Drawing.Size(118, 25);
            this.cmbRetFind.TabIndex = 101;
            // 
            // txtRetSrc
            // 
            this.txtRetSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRetSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRetSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRetSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetSrc.Location = new System.Drawing.Point(230, 58);
            this.txtRetSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetSrc.Name = "txtRetSrc";
            this.txtRetSrc.Size = new System.Drawing.Size(353, 26);
            this.txtRetSrc.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 99;
            this.label2.Text = "Find By";
            // 
            // BtnRtnSrc
            // 
            this.BtnRtnSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRtnSrc.BackColor = System.Drawing.Color.DarkGray;
            this.BtnRtnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRtnSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRtnSrc.ForeColor = System.Drawing.Color.White;
            this.BtnRtnSrc.Location = new System.Drawing.Point(597, 56);
            this.BtnRtnSrc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRtnSrc.Name = "BtnRtnSrc";
            this.BtnRtnSrc.Size = new System.Drawing.Size(93, 31);
            this.BtnRtnSrc.TabIndex = 98;
            this.BtnRtnSrc.Text = "Search";
            this.BtnRtnSrc.UseVisualStyleBackColor = false;
            this.BtnRtnSrc.Click += new System.EventHandler(this.BtnRtnSrc_Click);
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(19, 28);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(137, 24);
            this.lblHeadingTxt.TabIndex = 97;
            this.lblHeadingTxt.Text = "Return Items";
            // 
            // BtnRetUpdate
            // 
            this.BtnRetUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRetUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRetUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRetUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnRetUpdate.Location = new System.Drawing.Point(521, 407);
            this.BtnRetUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRetUpdate.Name = "BtnRetUpdate";
            this.BtnRetUpdate.Size = new System.Drawing.Size(159, 62);
            this.BtnRetUpdate.TabIndex = 103;
            this.BtnRetUpdate.Text = "Return Item";
            this.BtnRetUpdate.UseVisualStyleBackColor = false;
            this.BtnRetUpdate.Click += new System.EventHandler(this.BtnRetUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRetReason);
            this.groupBox1.Controls.Add(this.cmbRetStation);
            this.groupBox1.Controls.Add(this.lblInvModID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRetBarcode);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRetImei);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 189);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Return Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 98;
            this.label3.Text = "Reason";
            // 
            // txtRetReason
            // 
            this.txtRetReason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRetReason.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetReason.Location = new System.Drawing.Point(131, 152);
            this.txtRetReason.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetReason.Multiline = true;
            this.txtRetReason.Name = "txtRetReason";
            this.txtRetReason.Size = new System.Drawing.Size(311, 27);
            this.txtRetReason.TabIndex = 97;
            // 
            // cmbRetStation
            // 
            this.cmbRetStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRetStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbRetStation.DisplayMember = "1";
            this.cmbRetStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRetStation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRetStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbRetStation.FormattingEnabled = true;
            this.cmbRetStation.Items.AddRange(new object[] {
            "OnSale",
            "Home",
            "Other Shop",
            "Repair",
            "OnCheck"});
            this.cmbRetStation.Location = new System.Drawing.Point(131, 120);
            this.cmbRetStation.Name = "cmbRetStation";
            this.cmbRetStation.Size = new System.Drawing.Size(311, 25);
            this.cmbRetStation.TabIndex = 96;
            // 
            // lblInvModID
            // 
            this.lblInvModID.AutoSize = true;
            this.lblInvModID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvModID.ForeColor = System.Drawing.Color.White;
            this.lblInvModID.Location = new System.Drawing.Point(131, 30);
            this.lblInvModID.Name = "lblInvModID";
            this.lblInvModID.Size = new System.Drawing.Size(0, 19);
            this.lblInvModID.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Item ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Barcode ";
            // 
            // txtRetBarcode
            // 
            this.txtRetBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRetBarcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetBarcode.Location = new System.Drawing.Point(131, 87);
            this.txtRetBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetBarcode.Multiline = true;
            this.txtRetBarcode.Name = "txtRetBarcode";
            this.txtRetBarcode.Size = new System.Drawing.Size(311, 27);
            this.txtRetBarcode.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 75;
            this.label10.Text = "Station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "IMEI";
            // 
            // txtRetImei
            // 
            this.txtRetImei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRetImei.Enabled = false;
            this.txtRetImei.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetImei.Location = new System.Drawing.Point(131, 54);
            this.txtRetImei.Margin = new System.Windows.Forms.Padding(2);
            this.txtRetImei.Multiline = true;
            this.txtRetImei.Name = "txtRetImei";
            this.txtRetImei.Size = new System.Drawing.Size(311, 27);
            this.txtRetImei.TabIndex = 73;
            // 
            // ReturnControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnRetUpdate);
            this.Controls.Add(this.dataGridViewRtn);
            this.Controls.Add(this.cmbRetFind);
            this.Controls.Add(this.txtRetSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRtnSrc);
            this.Controls.Add(this.lblHeadingTxt);
            this.Name = "ReturnControl1";
            this.Size = new System.Drawing.Size(720, 594);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRtn;
        private System.Windows.Forms.ComboBox cmbRetFind;
        private System.Windows.Forms.TextBox txtRetSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRtnSrc;
        private System.Windows.Forms.Label lblHeadingTxt;
        private System.Windows.Forms.Button BtnRetUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRetStation;
        private System.Windows.Forms.Label lblInvModID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRetBarcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRetImei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRetReason;
    }
}
