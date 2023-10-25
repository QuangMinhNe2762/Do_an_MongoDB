
namespace KhachHangGUI.GUI
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.btn_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.dtGV_Food = new System.Windows.Forms.DataGridView();
            this.Ma_mon_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_mon_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimTheoTen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoTen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_submit.BackColor = System.Drawing.Color.Crimson;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(403, 112);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(125, 32);
            this.btn_submit.TabIndex = 187;
            this.btn_submit.Text = "Hoàn tất";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(211, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 179;
            this.label3.Text = "Tên món ăn :";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoodName.BackColor = System.Drawing.Color.White;
            this.txtFoodName.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.txtFoodName.ForeColor = System.Drawing.Color.Black;
            this.txtFoodName.Location = new System.Drawing.Point(340, 56);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodName.Multiline = true;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(226, 31);
            this.txtFoodName.TabIndex = 181;
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
            this.Ma_mon_an,
            this.Ten_mon_an,
            this.Gia,
            this.sl});
            this.dtGV_Food.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGV_Food.EnableHeadersVisualStyles = false;
            this.dtGV_Food.GridColor = System.Drawing.Color.White;
            this.dtGV_Food.Location = new System.Drawing.Point(0, 148);
            this.dtGV_Food.Margin = new System.Windows.Forms.Padding(2);
            this.dtGV_Food.Name = "dtGV_Food";
            this.dtGV_Food.RowHeadersVisible = false;
            this.dtGV_Food.RowHeadersWidth = 51;
            this.dtGV_Food.RowTemplate.Height = 29;
            this.dtGV_Food.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGV_Food.Size = new System.Drawing.Size(1008, 448);
            this.dtGV_Food.TabIndex = 190;
            this.dtGV_Food.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_Food_CellContentClick);
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
            // sl
            // 
            this.sl.HeaderText = "Số lượng";
            this.sl.Name = "sl";
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTheoTen.Image")));
            this.btnTimTheoTen.Location = new System.Drawing.Point(583, 56);
            this.btnTimTheoTen.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(30, 32);
            this.btnTimTheoTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTimTheoTen.TabIndex = 198;
            this.btnTimTheoTen.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 596);
            this.Controls.Add(this.btnTimTheoTen);
            this.Controls.Add(this.dtGV_Food);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoodName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Order";
            this.Text = "Foods_GUI";
            this.Load += new System.EventHandler(this.Foods_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimTheoTen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.DataGridView dtGV_Food;
        private System.Windows.Forms.PictureBox btnTimTheoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_mon_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_mon_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
    }
}