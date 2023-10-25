
namespace GiaoThucAnNhanh.GUI
{
    partial class Foods_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foods_GUI));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.dtGV_Food = new System.Windows.Forms.DataGridView();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_mon_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_mon_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnTimTheoMa = new System.Windows.Forms.PictureBox();
            this.btnTimTheoTen = new System.Windows.Forms.PictureBox();
            this.btnTimTheoGia = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnXoaText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(679, 292);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 39);
            this.btnDelete.TabIndex = 189;
            this.btnDelete.Text = "Xóa";
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
            this.btnEdit.Location = new System.Drawing.Point(506, 292);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 39);
            this.btnEdit.TabIndex = 188;
            this.btnEdit.Text = "Sửa";
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
            this.btn_add.Location = new System.Drawing.Point(333, 292);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(167, 39);
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
            this.label1.Location = new System.Drawing.Point(714, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 183;
            this.label1.Text = "Giá :";
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoodPrice.BackColor = System.Drawing.Color.White;
            this.txtFoodPrice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtFoodPrice.ForeColor = System.Drawing.Color.Black;
            this.txtFoodPrice.Location = new System.Drawing.Point(719, 200);
            this.txtFoodPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodPrice.Multiline = true;
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(300, 37);
            this.txtFoodPrice.TabIndex = 184;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(324, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 179;
            this.label3.Text = "Tên món ăn :";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoodName.BackColor = System.Drawing.Color.White;
            this.txtFoodName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtFoodName.ForeColor = System.Drawing.Color.Black;
            this.txtFoodName.Location = new System.Drawing.Point(329, 201);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodName.Multiline = true;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(300, 37);
            this.txtFoodName.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(714, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 180;
            this.label2.Text = "Mã món ăn :";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoodID.BackColor = System.Drawing.Color.White;
            this.txtFoodID.Enabled = false;
            this.txtFoodID.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtFoodID.ForeColor = System.Drawing.Color.Black;
            this.txtFoodID.Location = new System.Drawing.Point(719, 96);
            this.txtFoodID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodID.Multiline = true;
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(300, 37);
            this.txtFoodID.TabIndex = 182;
            this.txtFoodID.TextChanged += new System.EventHandler(this.txtFoodID_TextChanged_1);
            // 
            // dtGV_Food
            // 
            this.dtGV_Food.AllowUserToAddRows = false;
            this.dtGV_Food.AllowUserToDeleteRows = false;
            this.dtGV_Food.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV_Food.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_Food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGV_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV_Food.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this.Ma_mon_an,
            this.Ten_mon_an,
            this.Gia});
            this.dtGV_Food.EnableHeadersVisualStyles = false;
            this.dtGV_Food.GridColor = System.Drawing.Color.White;
            this.dtGV_Food.Location = new System.Drawing.Point(333, 423);
            this.dtGV_Food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGV_Food.Name = "dtGV_Food";
            this.dtGV_Food.ReadOnly = true;
            this.dtGV_Food.RowHeadersVisible = false;
            this.dtGV_Food.RowHeadersWidth = 51;
            this.dtGV_Food.RowTemplate.Height = 29;
            this.dtGV_Food.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGV_Food.Size = new System.Drawing.Size(697, 238);
            this.dtGV_Food.TabIndex = 190;
            this.dtGV_Food.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_Food_CellContentClick);
            // 
            // _id
            // 
            this._id.DataPropertyName = "_id";
            this._id.HeaderText = "_id";
            this._id.MinimumWidth = 6;
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            // 
            // Ma_mon_an
            // 
            this.Ma_mon_an.DataPropertyName = "Ma_mon_an";
            this.Ma_mon_an.HeaderText = "Mã món ăn";
            this.Ma_mon_an.MinimumWidth = 6;
            this.Ma_mon_an.Name = "Ma_mon_an";
            this.Ma_mon_an.ReadOnly = true;
            // 
            // Ten_mon_an
            // 
            this.Ten_mon_an.DataPropertyName = "Ten_mon_an";
            this.Ten_mon_an.FillWeight = 150F;
            this.Ten_mon_an.HeaderText = "Tên món ăn";
            this.Ten_mon_an.MinimumWidth = 6;
            this.Ten_mon_an.Name = "Ten_mon_an";
            this.Ten_mon_an.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.ID.ForeColor = System.Drawing.Color.Crimson;
            this.ID.Location = new System.Drawing.Point(324, 64);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(62, 28);
            this.ID.TabIndex = 191;
            this.ID.Text = "_ID :";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(329, 94);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(300, 37);
            this.txtID.TabIndex = 192;
            // 
            // btnTimTheoMa
            // 
            this.btnTimTheoMa.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTheoMa.Image")));
            this.btnTimTheoMa.Location = new System.Drawing.Point(1025, 94);
            this.btnTimTheoMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimTheoMa.Name = "btnTimTheoMa";
            this.btnTimTheoMa.Size = new System.Drawing.Size(40, 39);
            this.btnTimTheoMa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTimTheoMa.TabIndex = 197;
            this.btnTimTheoMa.TabStop = false;
            this.btnTimTheoMa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTheoTen.Image")));
            this.btnTimTheoTen.Location = new System.Drawing.Point(635, 198);
            this.btnTimTheoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(40, 39);
            this.btnTimTheoTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTimTheoTen.TabIndex = 198;
            this.btnTimTheoTen.TabStop = false;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // btnTimTheoGia
            // 
            this.btnTimTheoGia.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTheoGia.Image")));
            this.btnTimTheoGia.Location = new System.Drawing.Point(1025, 198);
            this.btnTimTheoGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimTheoGia.Name = "btnTimTheoGia";
            this.btnTimTheoGia.Size = new System.Drawing.Size(40, 39);
            this.btnTimTheoGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTimTheoGia.TabIndex = 199;
            this.btnTimTheoGia.TabStop = false;
            this.btnTimTheoGia.Click += new System.EventHandler(this.btnTimTheoGia_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(333, 373);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 229;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnXoaText
            // 
            this.btnXoaText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaText.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaText.ForeColor = System.Drawing.Color.White;
            this.btnXoaText.Location = new System.Drawing.Point(852, 292);
            this.btnXoaText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaText.Name = "btnXoaText";
            this.btnXoaText.Size = new System.Drawing.Size(167, 39);
            this.btnXoaText.TabIndex = 230;
            this.btnXoaText.Text = "Xóa text";
            this.btnXoaText.UseVisualStyleBackColor = false;
            this.btnXoaText.Click += new System.EventHandler(this.btnXoaText_Click);
            // 
            // Foods_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 782);
            this.Controls.Add(this.btnXoaText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTimTheoGia);
            this.Controls.Add(this.btnTimTheoTen);
            this.Controls.Add(this.btnTimTheoMa);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtGV_Food);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoodPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFoodID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Foods_GUI";
            this.Text = "Foods_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.DataGridView dtGV_Food;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_mon_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_mon_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.PictureBox btnTimTheoMa;
        private System.Windows.Forms.PictureBox btnTimTheoTen;
        private System.Windows.Forms.PictureBox btnTimTheoGia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnXoaText;
    }
}