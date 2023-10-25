namespace GiaoThucAnNhanh.GUI
{
    partial class themHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGV_Food = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_mon_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_mon_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_makh = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_manv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Food)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGV_Food
            // 
            this.dtGV_Food.AllowUserToAddRows = false;
            this.dtGV_Food.AllowUserToDeleteRows = false;
            this.dtGV_Food.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_Food.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_Food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_Food.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this.Ma_mon_an,
            this.Ten_mon_an,
            this.Gia,
            this.SL});
            this.dtGV_Food.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGV_Food.EnableHeadersVisualStyles = false;
            this.dtGV_Food.GridColor = System.Drawing.Color.White;
            this.dtGV_Food.Location = new System.Drawing.Point(0, 64);
            this.dtGV_Food.Margin = new System.Windows.Forms.Padding(2);
            this.dtGV_Food.Name = "dtGV_Food";
            this.dtGV_Food.RowHeadersVisible = false;
            this.dtGV_Food.RowHeadersWidth = 51;
            this.dtGV_Food.RowTemplate.Height = 29;
            this.dtGV_Food.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGV_Food.Size = new System.Drawing.Size(827, 393);
            this.dtGV_Food.TabIndex = 193;
            // 
            // _id
            // 
            this._id.DataPropertyName = "_id";
            this._id.HeaderText = "_id";
            this._id.MinimumWidth = 6;
            this._id.Name = "_id";
            // 
            // Ma_mon_an
            // 
            this.Ma_mon_an.DataPropertyName = "Ma_mon_an";
            this.Ma_mon_an.HeaderText = "Mã món ăn";
            this.Ma_mon_an.MinimumWidth = 6;
            this.Ma_mon_an.Name = "Ma_mon_an";
            // 
            // Ten_mon_an
            // 
            this.Ten_mon_an.DataPropertyName = "Ten_mon_an";
            this.Ten_mon_an.FillWeight = 150F;
            this.Ten_mon_an.HeaderText = "Tên món ăn";
            this.Ten_mon_an.MinimumWidth = 6;
            this.Ten_mon_an.Name = "Ten_mon_an";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_makh);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.lb_manv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 59);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            // 
            // cb_makh
            // 
            this.cb_makh.FormattingEnabled = true;
            this.cb_makh.Location = new System.Drawing.Point(167, 17);
            this.cb_makh.Name = "cb_makh";
            this.cb_makh.Size = new System.Drawing.Size(278, 21);
            this.cb_makh.TabIndex = 261;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.BackColor = System.Drawing.Color.Crimson;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(450, 11);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 32);
            this.btn_add.TabIndex = 260;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_manv.ForeColor = System.Drawing.Color.Crimson;
            this.lb_manv.Location = new System.Drawing.Point(5, 16);
            this.lb_manv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(156, 23);
            this.lb_manv.TabIndex = 192;
            this.lb_manv.Text = "Mã khách hàng";
            // 
            // themHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGV_Food);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "themHoaDon";
            this.Text = "Thêm Hóa Đơn";
            this.Load += new System.EventHandler(this.themHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Food)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGV_Food;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_mon_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_mon_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.ComboBox cb_makh;
    }
}