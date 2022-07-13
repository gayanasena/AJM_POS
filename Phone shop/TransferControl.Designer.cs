namespace Phone_shop
{
    partial class TransferControl
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
            this.dataGridViewTrans = new System.Windows.Forms.DataGridView();
            this.cmbTransFind = new System.Windows.Forms.ComboBox();
            this.txtTransSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogSrc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTransCurStation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransNotes = new System.Windows.Forms.TextBox();
            this.cmbTransStation = new System.Windows.Forms.ComboBox();
            this.lblInvModID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransBarcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransImei = new System.Windows.Forms.TextBox();
            this.BtnTransUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(22, 9);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(147, 24);
            this.lblHeadingTxt.TabIndex = 86;
            this.lblHeadingTxt.Text = "Transfer Items";
            this.lblHeadingTxt.Click += new System.EventHandler(this.lblHeadingTxt_Click);
            // 
            // dataGridViewTrans
            // 
            this.dataGridViewTrans.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTrans.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTrans.GridColor = System.Drawing.Color.White;
            this.dataGridViewTrans.Location = new System.Drawing.Point(31, 79);
            this.dataGridViewTrans.Name = "dataGridViewTrans";
            this.dataGridViewTrans.Size = new System.Drawing.Size(662, 224);
            this.dataGridViewTrans.TabIndex = 96;
            this.dataGridViewTrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrans_CellContentClick);
            // 
            // cmbTransFind
            // 
            this.cmbTransFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTransFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTransFind.DisplayMember = "1";
            this.cmbTransFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTransFind.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTransFind.FormattingEnabled = true;
            this.cmbTransFind.Items.AddRange(new object[] {
            "IMEI"});
            this.cmbTransFind.Location = new System.Drawing.Point(95, 39);
            this.cmbTransFind.Name = "cmbTransFind";
            this.cmbTransFind.Size = new System.Drawing.Size(118, 25);
            this.cmbTransFind.TabIndex = 95;
            this.cmbTransFind.SelectedIndexChanged += new System.EventHandler(this.cmbTransFind_SelectedIndexChanged);
            // 
            // txtTransSrc
            // 
            this.txtTransSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTransSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTransSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransSrc.Location = new System.Drawing.Point(233, 39);
            this.txtTransSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransSrc.Name = "txtTransSrc";
            this.txtTransSrc.Size = new System.Drawing.Size(353, 26);
            this.txtTransSrc.TabIndex = 94;
            this.txtTransSrc.TextChanged += new System.EventHandler(this.txtTransSrc_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 93;
            this.label2.Text = "Find By";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnLogSrc
            // 
            this.BtnLogSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogSrc.BackColor = System.Drawing.Color.DarkGray;
            this.BtnLogSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogSrc.ForeColor = System.Drawing.Color.White;
            this.BtnLogSrc.Location = new System.Drawing.Point(600, 37);
            this.BtnLogSrc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogSrc.Name = "BtnLogSrc";
            this.BtnLogSrc.Size = new System.Drawing.Size(93, 31);
            this.BtnLogSrc.TabIndex = 92;
            this.BtnLogSrc.Text = "Search";
            this.BtnLogSrc.UseVisualStyleBackColor = false;
            this.BtnLogSrc.Click += new System.EventHandler(this.BtnLogSrc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.lblTransCurStation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTransNotes);
            this.groupBox1.Controls.Add(this.cmbTransStation);
            this.groupBox1.Controls.Add(this.lblInvModID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTransBarcode);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTransImei);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 243);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Current Station";
            // 
            // lblTransCurStation
            // 
            this.lblTransCurStation.AutoSize = true;
            this.lblTransCurStation.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransCurStation.ForeColor = System.Drawing.Color.White;
            this.lblTransCurStation.Location = new System.Drawing.Point(131, 16);
            this.lblTransCurStation.Name = "lblTransCurStation";
            this.lblTransCurStation.Size = new System.Drawing.Size(46, 19);
            this.lblTransCurStation.TabIndex = 99;
            this.lblTransCurStation.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 98;
            this.label3.Text = "Current Station";
            // 
            // txtTransNotes
            // 
            this.txtTransNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTransNotes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransNotes.Location = new System.Drawing.Point(135, 166);
            this.txtTransNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransNotes.Multiline = true;
            this.txtTransNotes.Name = "txtTransNotes";
            this.txtTransNotes.Size = new System.Drawing.Size(311, 27);
            this.txtTransNotes.TabIndex = 97;
            // 
            // cmbTransStation
            // 
            this.cmbTransStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTransStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTransStation.DisplayMember = "1";
            this.cmbTransStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTransStation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTransStation.FormattingEnabled = true;
            this.cmbTransStation.Items.AddRange(new object[] {
            "OnSale",
            "Home",
            "Other Shop",
            "Repair",
            "OnCheck"});
            this.cmbTransStation.Location = new System.Drawing.Point(135, 134);
            this.cmbTransStation.Name = "cmbTransStation";
            this.cmbTransStation.Size = new System.Drawing.Size(311, 25);
            this.cmbTransStation.TabIndex = 96;
            // 
            // lblInvModID
            // 
            this.lblInvModID.AutoSize = true;
            this.lblInvModID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvModID.ForeColor = System.Drawing.Color.White;
            this.lblInvModID.Location = new System.Drawing.Point(131, 45);
            this.lblInvModID.Name = "lblInvModID";
            this.lblInvModID.Size = new System.Drawing.Size(0, 19);
            this.lblInvModID.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Item ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 82;
            this.label7.Text = "Notes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Barcode ";
            // 
            // txtTransBarcode
            // 
            this.txtTransBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTransBarcode.Enabled = false;
            this.txtTransBarcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransBarcode.Location = new System.Drawing.Point(135, 102);
            this.txtTransBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransBarcode.Multiline = true;
            this.txtTransBarcode.Name = "txtTransBarcode";
            this.txtTransBarcode.Size = new System.Drawing.Size(311, 27);
            this.txtTransBarcode.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 138);
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
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "IMEI";
            // 
            // txtTransImei
            // 
            this.txtTransImei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTransImei.Enabled = false;
            this.txtTransImei.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransImei.Location = new System.Drawing.Point(135, 70);
            this.txtTransImei.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransImei.Multiline = true;
            this.txtTransImei.Name = "txtTransImei";
            this.txtTransImei.Size = new System.Drawing.Size(311, 27);
            this.txtTransImei.TabIndex = 73;
            // 
            // BtnTransUpdate
            // 
            this.BtnTransUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTransUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnTransUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTransUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnTransUpdate.Location = new System.Drawing.Point(534, 420);
            this.BtnTransUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTransUpdate.Name = "BtnTransUpdate";
            this.BtnTransUpdate.Size = new System.Drawing.Size(159, 62);
            this.BtnTransUpdate.TabIndex = 98;
            this.BtnTransUpdate.Text = "UPDATE";
            this.BtnTransUpdate.UseVisualStyleBackColor = false;
            this.BtnTransUpdate.Click += new System.EventHandler(this.BtnTransUpdate_Click);
            // 
            // TransferControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.BtnTransUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTrans);
            this.Controls.Add(this.cmbTransFind);
            this.Controls.Add(this.txtTransSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLogSrc);
            this.Controls.Add(this.lblHeadingTxt);
            this.Name = "TransferControl";
            this.Size = new System.Drawing.Size(720, 594);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingTxt;
        private System.Windows.Forms.DataGridView dataGridViewTrans;
        private System.Windows.Forms.ComboBox cmbTransFind;
        private System.Windows.Forms.TextBox txtTransSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogSrc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTransNotes;
        private System.Windows.Forms.ComboBox cmbTransStation;
        private System.Windows.Forms.Label lblInvModID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransBarcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransImei;
        private System.Windows.Forms.Button BtnTransUpdate;
        private System.Windows.Forms.Label lblTransCurStation;
        private System.Windows.Forms.Label label3;
    }
}
