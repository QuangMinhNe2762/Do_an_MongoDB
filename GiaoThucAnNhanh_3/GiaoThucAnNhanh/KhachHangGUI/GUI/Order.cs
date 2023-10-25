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
using MongoDB.Bson;
using MongoDB.Driver;

namespace KhachHangGUI.GUI
{
    internal partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            define_Column_Table_NVPV();
            load_data();
        }

        private void Foods_GUI_Load(object sender, EventArgs e)
        {
        }
        private void define_Column_Table_NVPV()
        {
            dtGV_Food.ColumnCount = 4;
            dtGV_Food.Columns[0].HeaderText = "Mã món ăn";
            dtGV_Food.Columns[1].HeaderText = "Tên món ăn";
            dtGV_Food.Columns[2].HeaderText = "Giá";
            dtGV_Food.Columns[3].HeaderText = "Số lượng";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<DTO.HoaDon_ThucAn> list = new List<DTO.HoaDon_ThucAn>();
            foreach (DataGridViewRow row in dtGV_Food.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string temp = row.Cells[0].Value.ToString();
                    DTO.HoaDon_ThucAn a = new DTO.HoaDon_ThucAn();
                    a.Tenmon = row.Cells[3].Value.ToString();
                    a.Sl = int.Parse(temp);
                    a.Gia = int.Parse(row.Cells[4].Value.ToString());
                    a.thanh_tien = a.Gia * a.Sl;
                    list.Add(a);
                }
            }
            if(list.Count==0)
            {
                MessageBox.Show("vui lòng chọn món ăn", "chọn món ăn");
            }
            else
            {
                db.HoaDon.setDSMonAnDaDat(list);
                xacNhanMonAn form= new xacNhanMonAn();
                form.btnEdit.Visible = true;
                form.btn_thanhtoan.Visible = false;
                form.ShowDialog(this);
            }
        }
        private void load_data()
        {
            dtGV_Food.DataSource = db.ThucAn.DSMonAn();
            dtGV_Food.Columns["_id"].Visible= false;
        }

        

        private void dtGV_Food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        
        

       

        

        

        

        

        

        
        

        
    }
}
