using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachHangGUI.GUI
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btn_billing_Click(object sender, EventArgs e)
        {
            btn_billing.Top = ((Control)sender).Top;
            OpenChildForm(new HoaDon());
        }

        //private void btn_Nhanvien_Click(object sender, EventArgs e)
        //{
        //    btn_Nhanvien.Top = ((Control)sender).Top;
        //    OpenChildForm(new Nhanvien_GUI());
        //}

        private void btn_Khachhang_Click(object sender, EventArgs e)
        {
            btn_profile.Top = ((Control)sender).Top;
            OpenChildForm(new Profile());
        }

        private void TrangChu_GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            btn_order.Top = ((Control)sender).Top;
            OpenChildForm(new Order());
        }
    }
}
