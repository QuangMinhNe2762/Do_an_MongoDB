using KhachHangGUI.DAO;
using KhachHangGUI.GUI;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register form=new Register();
            form.ShowDialog(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string temp = string.Empty;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Length > 10)
            {
                MessageBox.Show("số điện thoại chỉ có 10 số", "số điện thoại");
                txt_sdt.Text = temp;
                return;
            }
            temp = txt_sdt.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txt_sdt.Text.Length ==0||txt_mk.Text.Length==0) {
                MessageBox.Show("vui lòng điền thông tin đầy đủ", "đăng nhập");
                return;
            }
            if(db.KhachHang.xacNhanKH(txt_sdt.Text,txt_mk.Text))
            {
                MessageBox.Show("Đăng nhập thành công", "đăng nhập");
                TrangChu_GUI form = db.KhachHang.Mainform;
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "đăng nhập");
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
