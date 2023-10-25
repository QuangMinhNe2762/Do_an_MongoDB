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
    public partial class xacNhanMonAn : Form
    {
        public xacNhanMonAn()
        {
            InitializeComponent();
            
        }
        
        public void loadData()
        {
            if(btnEdit.Visible)
            {
                dtGVDSMonAn.DataSource = db.HoaDon.getDSMonAnDaDat();
                lb_tongtien.Text = db.HoaDon.getTongTienDaDat().ToString();
            }
            else
            {
                dtGVDSMonAn.DataSource = db.HoaDon.getDSMonAnTheoMakh();
                lb_tongtien.Text = db.HoaDon.getTongTien();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
                if (db.HoaDon.ThemHD())
                {
                    MessageBox.Show("Đặt hàng thành công", "đặt hàng");
            }
                else
                {
                    MessageBox.Show("Đặt hàng thất bại", "đặt hàng");
                }
                this.Dispose();   
        }

        private void xacNhanMonAn_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if(db.HoaDon.DaThanhToan())
            {
                MessageBox.Show("thanh toán thành công", "thanh toán");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("thanh toán thất bại", "thanh toán");
            }
        }
    }
}
