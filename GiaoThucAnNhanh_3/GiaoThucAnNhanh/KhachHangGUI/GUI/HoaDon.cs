using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhachHangGUI.DAO;

using Microsoft.VisualBasic;

using MongoDB.Bson;
using MongoDB.Driver;

namespace KhachHangGUI.GUI
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            load_data();
            DefineColumnTable();
        }


        private void DefineColumnTable()
        {
            dtGVHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGVHoaDon.Columns[0].Visible = false;
            dtGVHoaDon.Columns[4].Visible = false;
        }


        private void load_data()
        {
            dtGVHoaDon.DataSource = db.HoaDon.GetHoaDonList();
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (db.HoaDon.getMaHoaDon() != null)
            {
                xacNhanMonAn form = new xacNhanMonAn();
                form.btnEdit.Visible = false;
                form.btn_thanhtoan.Visible = true;
                form.ShowDialog(this);
                dtGVHoaDon.DataSource = null;
                load_data();
                DefineColumnTable();
            }
            else
            {
                MessageBox.Show("vui lòng chọn hóa đơn để thanh toán","thanh toán");
            }
        }

        private void dtGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db.HoaDon.setMaHoaDon(dtGVHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
