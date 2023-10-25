
namespace KhachHangGUI.GUI
{
    partial class TrangChu_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu_GUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPanel_child = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_order);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 596);
            this.panel1.TabIndex = 14;
            // 
            // btn_profile
            // 
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(0, 126);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(201, 70);
            this.btn_profile.TabIndex = 20;
            this.btn_profile.Text = "   Hồ sơ";
            this.btn_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_Khachhang_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 504);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 70);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.FlatAppearance.BorderSize = 0;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.btn_billing.ForeColor = System.Drawing.Color.White;
            this.btn_billing.Image = ((System.Drawing.Image)(resources.GetObject("btn_billing.Image")));
            this.btn_billing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_billing.Location = new System.Drawing.Point(-3, 378);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(201, 70);
            this.btn_billing.TabIndex = 20;
            this.btn_billing.Text = "      Hóa đơn";
            this.btn_billing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_billing.UseVisualStyleBackColor = true;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // btn_order
            // 
            this.btn_order.FlatAppearance.BorderSize = 0;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.btn_order.ForeColor = System.Drawing.Color.White;
            this.btn_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_order.Image")));
            this.btn_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_order.Location = new System.Drawing.Point(-3, 262);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(221, 70);
            this.btn_order.TabIndex = 17;
            this.btn_order.Text = "   Đặt hàng";
            this.btn_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 60);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fast Food \r\nOrder\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuPanel_child
            // 
            this.bunifuPanel_child.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuPanel_child.Location = new System.Drawing.Point(206, 0);
            this.bunifuPanel_child.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel_child.Name = "bunifuPanel_child";
            this.bunifuPanel_child.Size = new System.Drawing.Size(1008, 596);
            this.bunifuPanel_child.TabIndex = 18;
            // 
            // TrangChu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 596);
            this.Controls.Add(this.bunifuPanel_child);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrangChu_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu_GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrangChu_GUI_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel bunifuPanel_child;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_billing;
    }
}