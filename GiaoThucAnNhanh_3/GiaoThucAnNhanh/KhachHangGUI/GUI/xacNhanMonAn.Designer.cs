namespace KhachHangGUI.GUI
{
    partial class xacNhanMonAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGVDSMonAn = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDSMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVDSMonAn
            // 
            this.dtGVDSMonAn.AllowUserToAddRows = false;
            this.dtGVDSMonAn.AllowUserToDeleteRows = false;
            this.dtGVDSMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVDSMonAn.BackgroundColor = System.Drawing.Color.White;
            this.dtGVDSMonAn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDSMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGVDSMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtGVDSMonAn.EnableHeadersVisualStyles = false;
            this.dtGVDSMonAn.GridColor = System.Drawing.Color.White;
            this.dtGVDSMonAn.Location = new System.Drawing.Point(0, 0);
            this.dtGVDSMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dtGVDSMonAn.Name = "dtGVDSMonAn";
            this.dtGVDSMonAn.ReadOnly = true;
            this.dtGVDSMonAn.RowHeadersVisible = false;
            this.dtGVDSMonAn.RowHeadersWidth = 51;
            this.dtGVDSMonAn.RowTemplate.Height = 29;
            this.dtGVDSMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVDSMonAn.Size = new System.Drawing.Size(800, 360);
            this.dtGVDSMonAn.TabIndex = 254;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.Crimson;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(456, 364);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(197, 86);
            this.btnEdit.TabIndex = 255;
            this.btnEdit.Text = "Đặt hàng";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(-6, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 256;
            this.label1.Text = "Tổng tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.lb_tongtien.ForeColor = System.Drawing.Color.Crimson;
            this.lb_tongtien.Location = new System.Drawing.Point(117, 390);
            this.lb_tongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(110, 32);
            this.lb_tongtien.TabIndex = 257;
            this.lb_tongtien.Text = "đưaăđưa";
            this.lb_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_thanhtoan.BackColor = System.Drawing.Color.Crimson;
            this.btn_thanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.Location = new System.Drawing.Point(456, 364);
            this.btn_thanhtoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(197, 86);
            this.btn_thanhtoan.TabIndex = 258;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // xacNhanMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtGVDSMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "xacNhanMonAn";
            this.Load += new System.EventHandler(this.xacNhanMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDSMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVDSMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tongtien;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btn_thanhtoan;
    }
}