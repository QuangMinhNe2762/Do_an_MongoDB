using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoThucAnNhanh.DAO;
using GiaoThucAnNhanh.DTO;
namespace GiaoThucAnNhanh.GUI
{
    public partial class themHoaDon : Form
    {
        HoaDon_GUI hoadonform;
        public themHoaDon(HoaDon_GUI form)
        {
            InitializeComponent();
            hoadonform = form;
            
        }

        private void themHoaDon_Load(object sender, EventArgs e)
        {
            cb_makh.DataSource = getAllMaKH();
            dtGV_Food.DataSource=db.ThucAn.GetAll();
            dtGV_Food.Columns["_id"].Visible= false;
        }
        private List<string>getAllMaKH()
        {
            List<string> list = new List<string>();
            var dskh=db.kh.GetAll();
            foreach (var item in dskh)
            {
                list.Add(item.Ma_kh);
            }
            return list;
        }

        private string temp_sdt = string.Empty;
        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void btn_add_Click(object sender, EventArgs e)
        {
            List<DTO.HoaDon_ThucAn> list = new List<DTO.HoaDon_ThucAn>();
            foreach (DataGridViewRow row in dtGV_Food.Rows)
            {
                if(row.Cells[0].Value!=null)
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
            DTO.HoaDon b = new DTO.HoaDon();
            b.Ma_kh = cb_makh.SelectedItem.ToString();
            b.Ds_mon_an = list;
            db.HoaDon.ThemTTConLai(b);
        }
    }
}
