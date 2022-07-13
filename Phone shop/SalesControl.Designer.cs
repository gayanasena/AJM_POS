namespace Phone_shop
{
    partial class SalesControl
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
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.txtLogSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogSrc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(24, 10);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(105, 24);
            this.lblHeadingTxt.TabIndex = 86;
            this.lblHeadingTxt.Text = "Sales Log";
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLog.GridColor = System.Drawing.Color.White;
            this.dataGridViewLog.Location = new System.Drawing.Point(28, 86);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.Size = new System.Drawing.Size(662, 479);
            this.dataGridViewLog.TabIndex = 91;
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
            "Date"});
            this.cmbFind.Location = new System.Drawing.Point(92, 46);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(118, 25);
            this.cmbFind.TabIndex = 90;
            // 
            // txtLogSrc
            // 
            this.txtLogSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLogSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLogSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogSrc.Location = new System.Drawing.Point(230, 46);
            this.txtLogSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogSrc.Name = "txtLogSrc";
            this.txtLogSrc.Size = new System.Drawing.Size(353, 26);
            this.txtLogSrc.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "Find By";
            // 
            // BtnLogSrc
            // 
            this.BtnLogSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogSrc.BackColor = System.Drawing.Color.DarkGray;
            this.BtnLogSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogSrc.ForeColor = System.Drawing.Color.White;
            this.BtnLogSrc.Location = new System.Drawing.Point(597, 44);
            this.BtnLogSrc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogSrc.Name = "BtnLogSrc";
            this.BtnLogSrc.Size = new System.Drawing.Size(93, 31);
            this.BtnLogSrc.TabIndex = 87;
            this.BtnLogSrc.Text = "Search";
            this.BtnLogSrc.UseVisualStyleBackColor = false;
            this.BtnLogSrc.Click += new System.EventHandler(this.BtnLogSrc_Click);
            this.BtnLogSrc.MouseHover += new System.EventHandler(this.BtnLogSrc_MouseHover);
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.dataGridViewLog);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.txtLogSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLogSrc);
            this.Controls.Add(this.lblHeadingTxt);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(720, 594);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingTxt;
        private System.Windows.Forms.DataGridView dataGridViewLog;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.TextBox txtLogSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogSrc;
    }
}
