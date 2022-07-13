
namespace Phone_shop
{
    partial class DeleteItemControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItemControl1));
            this.txtInvModSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInvModSrc = new System.Windows.Forms.Button();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.dataGridViewInvMod = new System.Windows.Forms.DataGridView();
            this.BtnInvModDel = new System.Windows.Forms.Button();
            this.BtnInvModUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInvModQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvModPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvModBarcode = new System.Windows.Forms.TextBox();
            this.txtInvModColor = new System.Windows.Forms.TextBox();
            this.cmbInvModCapacity = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvModImei = new System.Windows.Forms.TextBox();
            this.lblHeadingTxt = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInvModID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvMod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInvModSrc
            // 
            this.txtInvModSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvModSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtInvModSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInvModSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvModSrc.Location = new System.Drawing.Point(231, 55);
            this.txtInvModSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvModSrc.Name = "txtInvModSrc";
            this.txtInvModSrc.Size = new System.Drawing.Size(353, 26);
            this.txtInvModSrc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Find By";
            // 
            // BtnInvModSrc
            // 
            this.BtnInvModSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInvModSrc.BackColor = System.Drawing.Color.DarkGray;
            this.BtnInvModSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInvModSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvModSrc.ForeColor = System.Drawing.Color.White;
            this.BtnInvModSrc.Location = new System.Drawing.Point(598, 53);
            this.BtnInvModSrc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInvModSrc.Name = "BtnInvModSrc";
            this.BtnInvModSrc.Size = new System.Drawing.Size(93, 29);
            this.BtnInvModSrc.TabIndex = 13;
            this.BtnInvModSrc.Text = "Search";
            this.BtnInvModSrc.UseVisualStyleBackColor = false;
            this.BtnInvModSrc.Click += new System.EventHandler(this.BtnInvModSrc_Click);
            this.BtnInvModSrc.MouseHover += new System.EventHandler(this.BtnInvModSrc_MouseHover);
            // 
            // cmbFind
            // 
            this.cmbFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbFind.DisplayMember = "1";
            this.cmbFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFind.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Items.AddRange(new object[] {
            "IMEI",
            "Model",
            "Item Code"});
            this.cmbFind.Location = new System.Drawing.Point(93, 55);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(118, 25);
            this.cmbFind.TabIndex = 57;
            // 
            // dataGridViewInvMod
            // 
            this.dataGridViewInvMod.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvMod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewInvMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInvMod.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewInvMod.GridColor = System.Drawing.Color.White;
            this.dataGridViewInvMod.Location = new System.Drawing.Point(29, 93);
            this.dataGridViewInvMod.Name = "dataGridViewInvMod";
            this.dataGridViewInvMod.Size = new System.Drawing.Size(662, 249);
            this.dataGridViewInvMod.TabIndex = 58;
            this.dataGridViewInvMod.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewInvMod_CellMouseClick);
            // 
            // BtnInvModDel
            // 
            this.BtnInvModDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInvModDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnInvModDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInvModDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvModDel.ForeColor = System.Drawing.Color.White;
            this.BtnInvModDel.Location = new System.Drawing.Point(532, 397);
            this.BtnInvModDel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInvModDel.Name = "BtnInvModDel";
            this.BtnInvModDel.Size = new System.Drawing.Size(159, 62);
            this.BtnInvModDel.TabIndex = 59;
            this.BtnInvModDel.Text = "DELETE";
            this.BtnInvModDel.UseVisualStyleBackColor = false;
            this.BtnInvModDel.Click += new System.EventHandler(this.BtnInvModDel_Click);
            // 
            // BtnInvModUpdate
            // 
            this.BtnInvModUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInvModUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnInvModUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInvModUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvModUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnInvModUpdate.Location = new System.Drawing.Point(532, 492);
            this.BtnInvModUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInvModUpdate.Name = "BtnInvModUpdate";
            this.BtnInvModUpdate.Size = new System.Drawing.Size(159, 62);
            this.BtnInvModUpdate.TabIndex = 60;
            this.BtnInvModUpdate.Text = "UPDATE";
            this.BtnInvModUpdate.UseVisualStyleBackColor = false;
            this.BtnInvModUpdate.Click += new System.EventHandler(this.BtnInvModUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.lblInvModID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtInvModQty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtInvModPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtInvModBarcode);
            this.groupBox1.Controls.Add(this.txtInvModColor);
            this.groupBox1.Controls.Add(this.cmbInvModCapacity);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtInvModImei);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 242);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Fiealds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 84;
            this.label9.Text = "Quantity";
            // 
            // txtInvModQty
            // 
            this.txtInvModQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvModQty.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvModQty.Location = new System.Drawing.Point(136, 200);
            this.txtInvModQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvModQty.Multiline = true;
            this.txtInvModQty.Name = "txtInvModQty";
            this.txtInvModQty.Size = new System.Drawing.Size(219, 27);
            this.txtInvModQty.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 82;
            this.label7.Text = "Selling Price (Rs)";
            // 
            // txtInvModPrice
            // 
            this.txtInvModPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvModPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvModPrice.Location = new System.Drawing.Point(136, 139);
            this.txtInvModPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvModPrice.Multiline = true;
            this.txtInvModPrice.Name = "txtInvModPrice";
            this.txtInvModPrice.Size = new System.Drawing.Size(219, 27);
            this.txtInvModPrice.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Barcode ";
            // 
            // txtInvModBarcode
            // 
            this.txtInvModBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvModBarcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvModBarcode.Location = new System.Drawing.Point(136, 74);
            this.txtInvModBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvModBarcode.Multiline = true;
            this.txtInvModBarcode.Name = "txtInvModBarcode";
            this.txtInvModBarcode.Size = new System.Drawing.Size(311, 27);
            this.txtInvModBarcode.TabIndex = 79;
            // 
            // txtInvModColor
            // 
            this.txtInvModColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvModColor.AutoCompleteCustomSource.AddRange(new string[] {
            "White",
            "Red",
            "Black",
            "Jet Black",
            "Matt Black",
            "Blue",
            "Light Blue",
            "Ocen Blue",
            "Yellow",
            "Pink",
            "Green",
            "Gray",
            "Space Gray",
            "Gold",
            "Rose Gold",
            "Silver",
            "Midnight Green",
            "Orange",
            "Brown"});
            this.txtInvModColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtInvModColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInvModColor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvModColor.Location = new System.Drawing.Point(136, 170);
            this.txtInvModColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvModColor.Name = "txtInvModColor";
            this.txtInvModColor.Size = new System.Drawing.Size(219, 26);
            this.txtInvModColor.TabIndex = 78;
            // 
            // cmbInvModCapacity
            // 
            this.cmbInvModCapacity.DisplayMember = "1";
            this.cmbInvModCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInvModCapacity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvModCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbInvModCapacity.FormattingEnabled = true;
            this.cmbInvModCapacity.Items.AddRange(new object[] {
            "8GB",
            "16GB",
            "32GB",
            "64GB",
            "128GB",
            "256GB",
            "512GB",
            "1TB",
            "2TB"});
            this.cmbInvModCapacity.Location = new System.Drawing.Point(136, 106);
            this.cmbInvModCapacity.Name = "cmbInvModCapacity";
            this.cmbInvModCapacity.Size = new System.Drawing.Size(219, 28);
            this.cmbInvModCapacity.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 19);
            this.label11.TabIndex = 76;
            this.label11.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 75;
            this.label10.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "IMEI";
            // 
            // txtInvModImei
            // 
            this.txtInvModImei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvModImei.Enabled = false;
            this.txtInvModImei.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvModImei.Location = new System.Drawing.Point(136, 43);
            this.txtInvModImei.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvModImei.Multiline = true;
            this.txtInvModImei.Name = "txtInvModImei";
            this.txtInvModImei.Size = new System.Drawing.Size(311, 27);
            this.txtInvModImei.TabIndex = 73;
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(25, 10);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(197, 24);
            this.lblHeadingTxt.TabIndex = 62;
            this.lblHeadingTxt.Text = "Edit / Delete Items";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(617, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 30);
            this.btnRefresh.TabIndex = 135;
            this.btnRefresh.Text = "      Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Item ID";
            // 
            // lblInvModID
            // 
            this.lblInvModID.AutoSize = true;
            this.lblInvModID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvModID.ForeColor = System.Drawing.Color.White;
            this.lblInvModID.Location = new System.Drawing.Point(132, 19);
            this.lblInvModID.Name = "lblInvModID";
            this.lblInvModID.Size = new System.Drawing.Size(0, 19);
            this.lblInvModID.TabIndex = 86;
            // 
            // DeleteItemControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblHeadingTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnInvModUpdate);
            this.Controls.Add(this.BtnInvModDel);
            this.Controls.Add(this.dataGridViewInvMod);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.txtInvModSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnInvModSrc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeleteItemControl1";
            this.Size = new System.Drawing.Size(720, 594);
            this.Load += new System.EventHandler(this.DeleteItemControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvMod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvModSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnInvModSrc;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.DataGridView dataGridViewInvMod;
        private System.Windows.Forms.Button BtnInvModDel;
        private System.Windows.Forms.Button BtnInvModUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInvModColor;
        private System.Windows.Forms.ComboBox cmbInvModCapacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvModImei;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInvModQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInvModPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvModBarcode;
        private System.Windows.Forms.Label lblHeadingTxt;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblInvModID;
        private System.Windows.Forms.Label label1;
    }
}
