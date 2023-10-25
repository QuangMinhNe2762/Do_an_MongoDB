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

using MongoDB.Bson;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GiaoThucAnNhanh.GUI
{
    public partial class Nhanvien_GUI : Form
    {
        public Nhanvien_GUI()
        {
            InitializeComponent();
            load_data();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_hoten.TextLength == 0 || dt_ngaysinh.Text.Length == 0 || txt_sdt.TextLength == 0 || txtLuong.TextLength == 0||cb_gt.Text.Length==0)
            {
                MessageBox.Show("vui lòng điền thông tin vào để tiếp tục", "thêm nhân viên");
                return;
            }    
            string manvcuoi = dtGV_Nhanvien.Rows[dtGV_Nhanvien.Rows.Count-1].Cells[0].Value.ToString();
            int sonvmoi = int.Parse(manvcuoi[manvcuoi.Length - 1].ToString());
            if (sonvmoi==0)
            {
                sonvmoi = int.Parse(manvcuoi[manvcuoi.Length - 2].ToString()+1);
            }
            sonvmoi += 1;
            string manvmoi = "nv00" + sonvmoi;
            var nhanVienMoi = new DTO.NhanVien()
            {
                Manv = manvmoi,
                Hoten = txt_hoten.Text,
                Phai = cb_gt.Text,
                Ngay_sinh = dt_ngaysinh.Value.ToString(),
                Sdt = txt_sdt.Text,
                Luong = int.Parse(txtLuong.Text)
            };
            if(!db.NhanVien.Insert(nhanVienMoi))
            {
                MessageBox.Show("thêm nhân viên thất bại");
                return;
            }
            MessageBox.Show("thêm nhân viên thành công");
            deletetext();
            load_data();
        }
        
        private void load_data()
        {
            dtGV_Nhanvien.Rows.Clear();
            List<DTO.NhanVien> result = (List<DTO.NhanVien>)db.NhanVien.find();
            cb_gt.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DTO.NhanVien item in result)
            {
                dtGV_Nhanvien.Rows.Add(new String[]
                {
                    //item._id.ToString(),
                    item.Manv.ToString(),
                    item.Hoten.ToString(),
                    item.Phai.ToString(),
                    item.Ngay_sinh.ToString(),
                    item.Sdt.ToString(),
                    item.Luong.ToString()
                });
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txt_hoten.TextLength == 0 || txt_sdt.TextLength == 0 || txtLuong.TextLength == 0 || cb_gt.Text.Length == 0)
            {
                MessageBox.Show("vui lòng điền thông tin vào để tiếp tục", "chỉnh sửa thông tin nhân viên");
                return;
            }
            var nhanVienMoi = new DTO.NhanVien()
            {
                Manv = txt_Manv.Text,
                Hoten = txt_hoten.Text,
                Phai = cb_gt.Text,
                Ngay_sinh = dt_ngaysinh.Value.ToString(),
                Sdt = txt_sdt.Text,
                Luong = int.Parse(txtLuong.Text)
            };
            if (!db.NhanVien.Update(nhanVienMoi))
            {
                MessageBox.Show("chỉnh sửa thông tin nhân viên thất bại");
                return;
            }
            MessageBox.Show("chỉnh sửa thông tin nhân viên thành công");
            deletetext();
            load_data();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timKiemNhanVien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txt_Manv.Text.Length==0)
            {
                MessageBox.Show("vui lòng chọn nhân viên để thực hiện xóa", "xóa nhân viên");
                return;
            }
            string manv = txt_Manv.Text;
            string tennv = txt_hoten.Text;
            if (MessageBox.Show
             ("Bạn có chắc muốn xóa nhân viên "+tennv+" không ?", "Thông báo", MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                if (!db.NhanVien.Delete(manv))
                {
                    MessageBox.Show("xóa nhân viên thất bại");
                    return;
                }
                MessageBox.Show("xóa nhân viên thành công");
                load_data();
                deletetext();
            }
        }
        private void dtGV_Nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Manv.Text = dtGV_Nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_hoten.Text = dtGV_Nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_gt.Text = dtGV_Nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            string dateString = dtGV_Nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            DateTime result;
            dt_ngaysinh.Value = DateTime.TryParse(dateString, out result) ? result : DateTime.Now;
            //dt_ngaysinh.Value =DateTime.Parse(dtGV_Nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString());
            txt_sdt.Text = dtGV_Nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtLuong.Text = dtGV_Nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_vanban_Click(object sender, EventArgs e)
        {
            deletetext();
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_ngaysinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void deletetext()
        {
            txtLuong.Text = "";
            txt_hoten.Text = "";
            txt_Manv.Text = "";
            txt_sdt.Text = "";
            cb_gt.SelectedIndex = -1;
        }
        private void timKiemNhanVien()
        {
            dtGV_Nhanvien.Rows.Clear();
            List<DTO.NhanVien> result = db.NhanVien.findValues(txt_search.Text);
            foreach (DTO.NhanVien item in result)
            {
                dtGV_Nhanvien.Rows.Add(new String[]
                {
                    //item._id.ToString(),
                    item.Manv.ToString(),
                    item.Hoten.ToString(),
                    item.Phai.ToString(),
                    item.Ngay_sinh.ToString(),
                    item.Sdt.ToString(),
                    item.Luong.ToString()
                });
            }
        }
        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                timKiemNhanVien();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            timKiemNhanVien();
        }

        private string temp = string.Empty;
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Length > 10)
            {
                MessageBox.Show("số điện thoại chỉ có 10 số", "số điện thoại");
                txt_sdt.Text=temp;
                return;
            }
            temp = txt_sdt.Text;
        }

        private void txt_hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nhanvien_GUI_Load(object sender, EventArgs e)
        {

        }
        private string temp2 = string.Empty;
        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtLuong.Text.Length > 8)
            {
                MessageBox.Show("lương tối đa chỉ có 8 số", "Lương");
                txtLuong.Text = temp2;
                return;
            }
            temp2 = txtLuong.Text;
        }
    }
}
