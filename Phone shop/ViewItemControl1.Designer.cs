
namespace Phone_shop
{
    partial class ViewItemControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewInvView = new System.Windows.Forms.DataGridView();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.txtInvViewSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInvViewSrc = new System.Windows.Forms.Button();
            this.lblHeadingTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvView
            // 
            this.dataGridViewInvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInvView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInvView.Location = new System.Drawing.Point(28, 91);
            this.dataGridViewInvView.Name = "dataGridViewInvView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInvView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewInvView.Size = new System.Drawing.Size(662, 485);
            this.dataGridViewInvView.TabIndex = 63;
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
            this.cmbFind.Location = new System.Drawing.Point(92, 54);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(118, 25);
            this.cmbFind.TabIndex = 62;
            // 
            // txtInvViewSrc
            // 
            this.txtInvViewSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvViewSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtInvViewSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInvViewSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvViewSrc.Location = new System.Drawing.Point(230, 54);
            this.txtInvViewSrc.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvViewSrc.Name = "txtInvViewSrc";
            this.txtInvViewSrc.Size = new System.Drawing.Size(353, 26);
            this.txtInvViewSrc.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Find By";
            // 
            // BtnInvViewSrc
            // 
            this.BtnInvViewSrc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInvViewSrc.BackColor = System.Drawing.Color.Silver;
            this.BtnInvViewSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInvViewSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvViewSrc.ForeColor = System.Drawing.Color.White;
            this.BtnInvViewSrc.Location = new System.Drawing.Point(597, 51);
            this.BtnInvViewSrc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInvViewSrc.Name = "BtnInvViewSrc";
            this.BtnInvViewSrc.Size = new System.Drawing.Size(93, 33);
            this.BtnInvViewSrc.TabIndex = 59;
            this.BtnInvViewSrc.Text = "Search";
            this.BtnInvViewSrc.UseVisualStyleBackColor = false;
            this.BtnInvViewSrc.Click += new System.EventHandler(this.BtnInvViewSrc_Click);
            this.BtnInvViewSrc.MouseHover += new System.EventHandler(this.BtnInvViewSrc_MouseHover);
            // 
            // lblHeadingTxt
            // 
            this.lblHeadingTxt.AutoSize = true;
            this.lblHeadingTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTxt.ForeColor = System.Drawing.Color.White;
            this.lblHeadingTxt.Location = new System.Drawing.Point(24, 11);
            this.lblHeadingTxt.Name = "lblHeadingTxt";
            this.lblHeadingTxt.Size = new System.Drawing.Size(121, 24);
            this.lblHeadingTxt.TabIndex = 64;
            this.lblHeadingTxt.Text = "View Items";
            // 
            // ViewItemControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lblHeadingTxt);
            this.Controls.Add(this.dataGridViewInvView);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.txtInvViewSrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnInvViewSrc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewItemControl1";
            this.Size = new System.Drawing.Size(720, 594);
            this.Load += new System.EventHandler(this.ViewItemControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvView;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.TextBox txtInvViewSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnInvViewSrc;
        private System.Windows.Forms.Label lblHeadingTxt;
    }
}
