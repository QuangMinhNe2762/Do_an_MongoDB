
namespace GiaoThucAnNhanh.GUI
{
    partial class HoaDon_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon_GUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimTheoTen = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtGVHoaDon = new System.Windows.Forms.DataGridView();
            this.dtGVDSMonAn = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnXoaMA = new System.Windows.Forms.Button();
            this.btnSuaMA = new System.Windows.Forms.Button();
            this.btnThemMA = new System.Windows.Forms.Button();
            this.txt_thanh_tien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_ten_ma = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_sumTienDaThanhToan = new System.Windows.Forms.Label();
            this.cb_trangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDSMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTheoTen.Image")));
            this.btnTimTheoTen.Location = new System.Drawing.Point(354, 302);
            this.btnTimTheoTen.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(30, 32);
            this.btnTimTheoTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTimTheoTen.TabIndex = 244;
            this.btnTimTheoTen.TabStop = false;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.ID.ForeColor = System.Drawing.Color.Crimson;
            this.ID.Location = new System.Drawing.Point(120, 73);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(130, 23);
            this.ID.TabIndex = 241;
            this.ID.Text = "Mã hóa đơn :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(528, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 235;
            this.label1.Text = "Tên món ăn :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(120, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 231;
            this.label3.Text = "Mã khách hàng :";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKH.BackColor = System.Drawing.Color.White;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtMaKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaKH.Location = new System.Drawing.Point(125, 165);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(226, 31);
            this.txtMaKH.TabIndex = 233;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(120, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 232;
            this.label2.Text = "Tổng tiền :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.Black;
            this.txtTongTien.Location = new System.Drawing.Point(124, 231);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(226, 31);
            this.txtTongTien.TabIndex = 234;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(528, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 248;
            this.label4.Text = "Số lượng :";
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSL.BackColor = System.Drawing.Color.White;
            this.txtSL.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtSL.ForeColor = System.Drawing.Color.Black;
            this.txtSL.Location = new System.Drawing.Point(532, 166);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL.Multiline = true;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(226, 31);
            this.txtSL.TabIndex = 249;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(528, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 251;
            this.label5.Text = "Giá :";
            // 
            // txtGia
            // 
            this.txtGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtGia.ForeColor = System.Drawing.Color.Black;
            this.txtGia.Location = new System.Drawing.Point(532, 229);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(226, 31);
            this.txtGia.TabIndex = 252;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(124, 345);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 246;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dtGVHoaDon
            // 
            this.dtGVHoaDon.AllowUserToAddRows = false;
            this.dtGVHoaDon.AllowUserToDeleteRows = false;
            this.dtGVHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dtGVHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVHoaDon.EnableHeadersVisualStyles = false;
            this.dtGVHoaDon.GridColor = System.Drawing.Color.White;
            this.dtGVHoaDon.Location = new System.Drawing.Point(125, 431);
            this.dtGVHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dtGVHoaDon.Name = "dtGVHoaDon";
            this.dtGVHoaDon.ReadOnly = true;
            this.dtGVHoaDon.RowHeadersVisible = false;
            this.dtGVHoaDon.RowHeadersWidth = 51;
            this.dtGVHoaDon.RowTemplate.Height = 29;
            this.dtGVHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVHoaDon.Size = new System.Drawing.Size(335, 193);
            this.dtGVHoaDon.TabIndex = 247;
            this.dtGVHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVHoaDon_CellContentClick);
            // 
            // dtGVDSMonAn
            // 
            this.dtGVDSMonAn.AllowUserToAddRows = false;
            this.dtGVDSMonAn.AllowUserToDeleteRows = false;
            this.dtGVDSMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVDSMonAn.BackgroundColor = System.Drawing.Color.White;
            this.dtGVDSMonAn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDSMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGVDSMonAn.EnableHeadersVisualStyles = false;
            this.dtGVDSMonAn.GridColor = System.Drawing.Color.White;
            this.dtGVDSMonAn.Location = new System.Drawing.Point(532, 385);
            this.dtGVDSMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dtGVDSMonAn.Name = "dtGVDSMonAn";
            this.dtGVDSMonAn.ReadOnly = true;
            this.dtGVDSMonAn.RowHeadersVisible = false;
            this.dtGVDSMonAn.RowHeadersWidth = 51;
            this.dtGVDSMonAn.RowTemplate.Height = 29;
            this.dtGVDSMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVDSMonAn.Size = new System.Drawing.Size(346, 193);
            this.dtGVDSMonAn.TabIndex = 253;
            this.dtGVDSMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVDSMonAn_CellContentClick);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHD.BackColor = System.Drawing.Color.White;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtMaHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaHD.Location = new System.Drawing.Point(124, 97);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(226, 31);
            this.txtMaHD.TabIndex = 254;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemHD.BackColor = System.Drawing.Color.Crimson;
            this.btnThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnThemHD.ForeColor = System.Drawing.Color.White;
            this.btnThemHD.Location = new System.Drawing.Point(162, 350);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(194, 32);
            this.btnThemHD.TabIndex = 255;
            this.btnThemHD.Text = "Thêm hóa đơn mới";
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaHD.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaHD.ForeColor = System.Drawing.Color.White;
            this.btnXoaHD.Location = new System.Drawing.Point(360, 350);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(99, 32);
            this.btnXoaHD.TabIndex = 257;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnXoaMA
            // 
            this.btnXoaMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaMA.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaMA.ForeColor = System.Drawing.Color.White;
            this.btnXoaMA.Location = new System.Drawing.Point(768, 349);
            this.btnXoaMA.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaMA.Name = "btnXoaMA";
            this.btnXoaMA.Size = new System.Drawing.Size(109, 32);
            this.btnXoaMA.TabIndex = 261;
            this.btnXoaMA.Text = "Xóa món";
            this.btnXoaMA.UseVisualStyleBackColor = false;
            this.btnXoaMA.Click += new System.EventHandler(this.btnXoaMA_Click);
            // 
            // btnSuaMA
            // 
            this.btnSuaMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaMA.BackColor = System.Drawing.Color.Crimson;
            this.btnSuaMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaMA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaMA.ForeColor = System.Drawing.Color.White;
            this.btnSuaMA.Location = new System.Drawing.Point(655, 349);
            this.btnSuaMA.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaMA.Name = "btnSuaMA";
            this.btnSuaMA.Size = new System.Drawing.Size(109, 32);
            this.btnSuaMA.TabIndex = 260;
            this.btnSuaMA.Text = "Sửa món";
            this.btnSuaMA.UseVisualStyleBackColor = false;
            this.btnSuaMA.Click += new System.EventHandler(this.btnSuaMA_Click);
            // 
            // btnThemMA
            // 
            this.btnThemMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemMA.BackColor = System.Drawing.Color.Crimson;
            this.btnThemMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnThemMA.ForeColor = System.Drawing.Color.White;
            this.btnThemMA.Location = new System.Drawing.Point(532, 349);
            this.btnThemMA.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMA.Name = "btnThemMA";
            this.btnThemMA.Size = new System.Drawing.Size(119, 32);
            this.btnThemMA.TabIndex = 259;
            this.btnThemMA.Text = "Thêm món";
            this.btnThemMA.UseVisualStyleBackColor = false;
            this.btnThemMA.Click += new System.EventHandler(this.btnThemMA_Click);
            // 
            // txt_thanh_tien
            // 
            this.txt_thanh_tien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_thanh_tien.BackColor = System.Drawing.Color.White;
            this.txt_thanh_tien.Enabled = false;
            this.txt_thanh_tien.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txt_thanh_tien.ForeColor = System.Drawing.Color.Black;
            this.txt_thanh_tien.Location = new System.Drawing.Point(532, 302);
            this.txt_thanh_tien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_thanh_tien.Multiline = true;
            this.txt_thanh_tien.Name = "txt_thanh_tien";
            this.txt_thanh_tien.Size = new System.Drawing.Size(226, 31);
            this.txt_thanh_tien.TabIndex = 262;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(528, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 263;
            this.label6.Text = "Thành tiền :";
            // 
            // cb_ten_ma
            // 
            this.cb_ten_ma.FormattingEnabled = true;
            this.cb_ten_ma.Location = new System.Drawing.Point(532, 97);
            this.cb_ten_ma.Name = "cb_ten_ma";
            this.cb_ten_ma.Size = new System.Drawing.Size(226, 21);
            this.cb_ten_ma.TabIndex = 264;
            this.cb_ten_ma.SelectedValueChanged += new System.EventHandler(this.cb_ten_ma_SelectedValueChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(124, 302);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(225, 32);
            this.txt_search.TabIndex = 265;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(121, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 266;
            this.label7.Text = "Tìm kiếm :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(120, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 28);
            this.label8.TabIndex = 267;
            this.label8.Text = "Tổng tiền đã thanh toán";
            // 
            // lb_sumTienDaThanhToan
            // 
            this.lb_sumTienDaThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_sumTienDaThanhToan.AutoSize = true;
            this.lb_sumTienDaThanhToan.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lb_sumTienDaThanhToan.ForeColor = System.Drawing.Color.Crimson;
            this.lb_sumTienDaThanhToan.Location = new System.Drawing.Point(353, 22);
            this.lb_sumTienDaThanhToan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sumTienDaThanhToan.Name = "lb_sumTienDaThanhToan";
            this.lb_sumTienDaThanhToan.Size = new System.Drawing.Size(23, 23);
            this.lb_sumTienDaThanhToan.TabIndex = 268;
            this.lb_sumTienDaThanhToan.Text = "đ";
            // 
            // cb_trangThai
            // 
            this.cb_trangThai.FormattingEnabled = true;
            this.cb_trangThai.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cb_trangThai.Location = new System.Drawing.Point(124, 387);
            this.cb_trangThai.Name = "cb_trangThai";
            this.cb_trangThai.Size = new System.Drawing.Size(336, 21);
            this.cb_trangThai.TabIndex = 269;
            this.cb_trangThai.SelectedValueChanged += new System.EventHandler(this.cb_trangThai_SelectedValueChanged_1);
            // 
            // HoaDon_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 635);
            this.Controls.Add(this.cb_trangThai);
            this.Controls.Add(this.lb_sumTienDaThanhToan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cb_ten_ma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_thanh_tien);
            this.Controls.Add(this.btnXoaMA);
            this.Controls.Add(this.btnSuaMA);
            this.Controls.Add(this.btnThemMA);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.dtGVDSMonAn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.dtGVHoaDon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTimTheoTen);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HoaDon_GUI";
            this.Text = "HoaDon_GUI";
            this.Load += new System.EventHandler(this.HoaDon_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDSMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnTimTheoTen;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dtGVHoaDon;
        private System.Windows.Forms.DataGridView dtGVDSMonAn;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnXoaMA;
        private System.Windows.Forms.Button btnSuaMA;
        private System.Windows.Forms.Button btnThemMA;
        private System.Windows.Forms.TextBox txt_thanh_tien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_ten_ma;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_sumTienDaThanhToan;
        private System.Windows.Forms.ComboBox cb_trangThai;
    }
}