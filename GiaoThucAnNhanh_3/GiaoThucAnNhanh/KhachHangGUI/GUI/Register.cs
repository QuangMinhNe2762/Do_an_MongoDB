using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhachHangGUI.DTO;
using KhachHangGUI.DAO;
namespace KhachHangGUI.GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_dk_Click(object sender, EventArgs e)
        {
            if(txt_sdt.Text.Length == 0||txt_diachi.Text.Length==0||txt_hoten.Text.Length==0) {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "đăng ký");
                return;
            }
            DTO.KhachHang a=new DTO.KhachHang();
            a.Ma_kh = db.KhachHang.maKHLast();
            a.Ten_kh = txt_hoten.Text;
            a.Sdt = txt_sdt.Text;
            a.Dia_chi = txt_diachi.Text;
            a.password = txt_mk.Text;
            if(db.KhachHang.ThemKH(a))
            {
                MessageBox.Show("Đăng ký thành công", "Đăng ký");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại", "Đăng ký");
            }
            this.Dispose();
        }
        private string temp=string.Empty;
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Length > 10)
            {
                MessageBox.Show("số điện thoại chỉ có 10 số", "số điện thoại");
                txt_sdt.Text = temp;
                return;
            }
            temp = txt_sdt.Text;
        }
    }
}
