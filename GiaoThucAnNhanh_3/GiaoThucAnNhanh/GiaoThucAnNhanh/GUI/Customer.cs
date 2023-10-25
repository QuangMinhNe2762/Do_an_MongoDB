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

using Microsoft.VisualBasic;

using MongoDB.Bson;
using MongoDB.Driver;

namespace GiaoThucAnNhanh.GUI
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            DefineColumnTable();
            load_data();
        }


        private void DefineColumnTable()
        {
            dtGV_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGV_Customers.ColumnCount = 5;
            dtGV_Customers.Columns[0].HeaderText = "_id";
            dtGV_Customers.Columns[1].HeaderText = "Mã khách hàng";
            dtGV_Customers.Columns[2].HeaderText = "Tên khách hàng";
            dtGV_Customers.Columns[3].HeaderText = "Địa chỉ";
            dtGV_Customers.Columns[4].HeaderText = "Số điện thoại";
        }


        private void load_data()
        {
            dtGV_Customers.Rows.Clear();
            List<DTO.KhachHang> khList = (List<DTO.KhachHang>)db.kh.find();
            foreach (DTO.KhachHang kh in khList)
            {
                dtGV_Customers.Rows.Add(new String[]
                {
            kh._id.ToString(),
            kh.Ma_kh,
            kh.Ten_kh,
            kh.Dia_chi,
            kh.Sdt
                });
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            DTO.KhachHang khachHang = new DTO.KhachHang();
            khachHang.Ma_kh = txtMaKH.Text;
            khachHang.Ten_kh = txtTenKH.Text;
            khachHang.Dia_chi = txtDiaChi.Text;
            khachHang.Sdt = txtSdt.Text;

            DAO.KhachHang daoKhachHang = new DAO.KhachHang();
            daoKhachHang.Insert(khachHang);

            load_data();
        }
        private void dtGV_Customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGV_Customers.Rows[e.RowIndex];

                txtID.Text = row.Cells["_id"].Value.ToString();
                txtMaKH.Text = row.Cells["Ma_kh"].Value.ToString();
                txtTenKH.Text = row.Cells["Ten_kh"].Value.ToString();
                txtDiaChi.Text = row.Cells["Dia_chi"].Value.ToString();
                txtSdt.Text = row.Cells["Sdt"].Value.ToString();
            }

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtGV_Customers.SelectedRows.Count > 0)
            {
                int rowIndex = dtGV_Customers.SelectedRows[0].Index;
                string maKhachHang = dtGV_Customers.Rows[rowIndex].Cells["Ma_kh"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá khách hàng có mã {maKhachHang} không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DAO.KhachHang daoKhachHang = new DAO.KhachHang();
                    daoKhachHang.DeleteByMaKhachHang(maKhachHang);
                    dtGV_Customers.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtGV_Customers.SelectedRows.Count > 0)
            {
                int rowIndex = dtGV_Customers.SelectedRows[0].Index;
                string maKhachHang = dtGV_Customers.Rows[rowIndex].Cells["Ma_kh"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn cập nhật thông tin cho khách hàng có mã {maKhachHang} không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string updatedMaKH = txtMaKH.Text;
                        string updatedTenKH = txtTenKH.Text;
                        string updatedDiaChi = txtDiaChi.Text;
                        string updatedSdt = txtSdt.Text;

                        DTO.KhachHang updatedKhachHang = new DTO.KhachHang
                        {
                            _id = ObjectId.Parse(dtGV_Customers.Rows[rowIndex].Cells["_id"].Value.ToString()),
                            Ma_kh = updatedMaKH,
                            Ten_kh = updatedTenKH,
                            Dia_chi = updatedDiaChi,
                            Sdt = updatedSdt
                        };

                        DAO.KhachHang daoKhachHang = new DAO.KhachHang();
                        daoKhachHang.Edit(updatedKhachHang);

                        dtGV_Customers.Rows[rowIndex].SetValues(new object[]
                        {
                            updatedMaKH,
                            updatedTenKH,
                            updatedDiaChi,
                            updatedSdt
                        });

                        MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string maKhachHang = txtMaKH.Text;

            if (!string.IsNullOrEmpty(maKhachHang))
            {
                DAO.KhachHang daoKhachHang = new DAO.KhachHang();
                List<DTO.KhachHang> result = daoKhachHang.Find(maKhachHang, null, null, null);

                dtGV_Customers.Rows.Clear();

                foreach (DTO.KhachHang kh in result)
                {
                    dtGV_Customers.Rows.Add(new string[]
                    {
                kh._id.ToString(),
                kh.Ma_kh,
                kh.Ten_kh,
                kh.Dia_chi,
                kh.Sdt
                    });
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reload_data()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            load_data();
        }

        private void btnRL_Click(object sender, EventArgs e)
        {
            reload_data();
        }
    }
}
