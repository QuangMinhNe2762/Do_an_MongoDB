namespace KhachHangGUI.GUI
{
    partial class HoaDon
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
            this.dtGVHoaDon = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVHoaDon
            // 
            this.dtGVHoaDon.AllowUserToAddRows = false;
            this.dtGVHoaDon.AllowUserToDeleteRows = false;
            this.dtGVHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dtGVHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtGVHoaDon.EnableHeadersVisualStyles = false;
            this.dtGVHoaDon.GridColor = System.Drawing.Color.White;
            this.dtGVHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dtGVHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dtGVHoaDon.Name = "dtGVHoaDon";
            this.dtGVHoaDon.ReadOnly = true;
            this.dtGVHoaDon.RowHeadersVisible = false;
            this.dtGVHoaDon.RowHeadersWidth = 51;
            this.dtGVHoaDon.RowTemplate.Height = 29;
            this.dtGVHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVHoaDon.Size = new System.Drawing.Size(1008, 472);
            this.dtGVHoaDon.TabIndex = 248;
            this.dtGVHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVHoaDon_CellClick);
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_submit.BackColor = System.Drawing.Color.Crimson;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(369, 509);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(286, 96);
            this.btn_submit.TabIndex = 249;
            this.btn_submit.Text = "Thanh toán hóa đơn";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 635);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dtGVHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDon";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVHoaDon;
        private System.Windows.Forms.Button btn_submit;
    }
}