using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoThucAnNhanh.GUI
{
    public partial class TrangChu_GUI : Form
    {
        public TrangChu_GUI()
        {
            InitializeComponent();
        }
        private Form currentformchild;
        private void OpenChildForm(Form child)
        {
            if (currentformchild != null)
                currentformchild.Close();
            currentformchild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            bunifuPanel_child.Controls.Add(child);
            bunifuPanel_child.Width = child.Width;
            
            bunifuPanel_child.BringToFront();
            child.Show();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            btn_Foods.Top = ((Control)sender).Top;
            OpenChildForm(new Foods_GUI());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btn_billing_Click(object sender, EventArgs e)
        {
            btn_billing.Top = ((Control)sender).Top;
            OpenChildForm(new HoaDon_GUI());
        }

        private void btn_Nhanvien_Click(object sender, EventArgs e)
        {
            btn_Nhanvien.Top = ((Control)sender).Top;
            OpenChildForm(new Nhanvien_GUI());
        }

        private void btn_Khachhang_Click(object sender, EventArgs e)
        {
            btn_Khachhang.Top = ((Control)sender).Top;
            OpenChildForm(new Customer());
        }
    }
}
