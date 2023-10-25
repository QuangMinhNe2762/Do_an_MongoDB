
namespace GiaoThucAnNhanh.GUI
{
    partial class Nhanvien_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien_GUI));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.dtGV_Nhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_manv = new System.Windows.Forms.Label();
            this.txt_Manv = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_gt = new System.Windows.Forms.ComboBox();
            this.btn_vanban = new System.Windows.Forms.Button();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(643, 221);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 32);
            this.btnDelete.TabIndex = 189;
            this.btnDelete.Text = "xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.Crimson;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(482, 221);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 32);
            this.btnEdit.TabIndex = 188;
            this.btnEdit.Text = "chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.BackColor = System.Drawing.Color.Crimson;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(296, 221);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 32);
            this.btn_add.TabIndex = 187;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(378, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 183;
            this.label1.Text = "Số Điện Thoại";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sdt.BackColor = System.Drawing.Color.White;
            this.txt_sdt.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txt_sdt.ForeColor = System.Drawing.Color.Black;
            this.txt_sdt.Location = new System.Drawing.Point(376, 131);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(257, 40);
            this.txt_sdt.TabIndex = 184;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(111, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 179;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(378, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 180;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_hoten.BackColor = System.Drawing.Color.White;
            this.txt_hoten.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txt_hoten.ForeColor = System.Drawing.Color.Black;
            this.txt_hoten.Location = new System.Drawing.Point(382, 43);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_hoten.Multiline = true;
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(257, 40);
            this.txt_hoten.TabIndex = 182;
            this.txt_hoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hoten_KeyPress);
            // 
            // dtGV_Nhanvien
            // 
            this.dtGV_Nhanvien.AllowUserToAddRows = false;
            this.dtGV_Nhanvien.AllowUserToDeleteRows = false;
            this.dtGV_Nhanvien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGV_Nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_Nhanvien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_Nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_Nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_Nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtGV_Nhanvien.EnableHeadersVisualStyles = false;
            this.dtGV_Nhanvien.GridColor = System.Drawing.Color.Black;
            this.dtGV_Nhanvien.Location = new System.Drawing.Point(0, 313);
            this.dtGV_Nhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtGV_Nhanvien.Name = "dtGV_Nhanvien";
            this.dtGV_Nhanvien.ReadOnly = true;
            this.dtGV_Nhanvien.RowHeadersVisible = false;
            this.dtGV_Nhanvien.RowHeadersWidth = 51;
            this.dtGV_Nhanvien.RowTemplate.Height = 29;
            this.dtGV_Nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGV_Nhanvien.Size = new System.Drawing.Size(1008, 322);
            this.dtGV_Nhanvien.TabIndex = 190;
            this.dtGV_Nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_Nhanvien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Lương";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // lb_manv
            // 
            this.lb_manv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_manv.ForeColor = System.Drawing.Color.Crimson;
            this.lb_manv.Location = new System.Drawing.Point(111, 20);
            this.lb_manv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(140, 23);
            this.lb_manv.TabIndex = 191;
            this.lb_manv.Text = "Mã Nhân Viên";
            // 
            // txt_Manv
            // 
            this.txt_Manv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Manv.BackColor = System.Drawing.Color.White;
            this.txt_Manv.Enabled = false;
            this.txt_Manv.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txt_Manv.ForeColor = System.Drawing.Color.Black;
            this.txt_Manv.Location = new System.Drawing.Point(115, 43);
            this.txt_Manv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Manv.Multiline = true;
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.Size = new System.Drawing.Size(257, 40);
            this.txt_Manv.TabIndex = 192;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(678, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 197;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 35);
            this.panel1.TabIndex = 198;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 198;
            this.label4.Text = "Tìm kiếm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(223, 9);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(450, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(639, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 199;
            this.label5.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLuong.BackColor = System.Drawing.Color.White;
            this.txtLuong.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtLuong.ForeColor = System.Drawing.Color.Black;
            this.txtLuong.Location = new System.Drawing.Point(643, 131);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLuong.Multiline = true;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(257, 40);
            this.txtLuong.TabIndex = 200;
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(639, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 201;
            this.label6.Text = "Phái";
            // 
            // cb_gt
            // 
            this.cb_gt.FormattingEnabled = true;
            this.cb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gt.Location = new System.Drawing.Point(643, 43);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.Size = new System.Drawing.Size(257, 21);
            this.cb_gt.TabIndex = 202;
            // 
            // btn_vanban
            // 
            this.btn_vanban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_vanban.BackColor = System.Drawing.Color.Crimson;
            this.btn_vanban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vanban.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vanban.ForeColor = System.Drawing.Color.White;
            this.btn_vanban.Location = new System.Drawing.Point(126, 221);
            this.btn_vanban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_vanban.Name = "btn_vanban";
            this.btn_vanban.Size = new System.Drawing.Size(125, 32);
            this.btn_vanban.TabIndex = 203;
            this.btn_vanban.Text = "Xóa văn bản";
            this.btn_vanban.UseVisualStyleBackColor = false;
            this.btn_vanban.Click += new System.EventHandler(this.btn_vanban_Click);
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.CustomFormat = "";
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaysinh.Location = new System.Drawing.Point(115, 131);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(198, 20);
            this.dt_ngaysinh.TabIndex = 204;
            this.dt_ngaysinh.Value = new System.DateTime(2023, 10, 16, 0, 0, 0, 0);
            // 
            // Nhanvien_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 635);
            this.Controls.Add(this.dt_ngaysinh);
            this.Controls.Add(this.btn_vanban);
            this.Controls.Add(this.cb_gt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_manv);
            this.Controls.Add(this.txt_Manv);
            this.Controls.Add(this.dtGV_Nhanvien);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_hoten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Nhanvien_GUI";
            this.Text = "Nhanvien_GUI";
            this.Load += new System.EventHandler(this.Nhanvien_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.DataGridView dtGV_Nhanvien;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.TextBox txt_Manv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_gt;
        private System.Windows.Forms.Button btn_vanban;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
    }
}