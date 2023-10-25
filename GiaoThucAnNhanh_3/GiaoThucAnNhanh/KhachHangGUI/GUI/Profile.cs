using KhachHangGUI.DAO;
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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private string temp = string.Empty;
        

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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(txt_hoten.Text.Length==0||txt_address.Text.Length==0||txt_password.Text.Length==0) {
                MessageBox.Show("vui lòng điền thông tin để cập nhập hồ sơ", "hồ sơ");
                return;
            }
            DTO.KhachHang a=new DTO.KhachHang();
            a.Ten_kh = txt_hoten.Text;
            a.password=txt_password.Text;
            a.Dia_chi = txt_address.Text;
            if(db.KhachHang.chinhSuaTT(a))
            {
                MessageBox.Show("Chỉnh sửa thông tin thành công", "chỉnh sửa thông tin");
            }
            else {
                MessageBox.Show("Chỉnh sửa thông tin thất bại", "chỉnh sửa thông tin");
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DTO.KhachHang a = db.KhachHang.getkh();
            txt_address.Text = a.Dia_chi;
            txt_hoten.Text = a.Ten_kh;
            txt_password.Text = a.password;
        }
    }
}
