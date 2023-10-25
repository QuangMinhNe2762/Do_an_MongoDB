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

namespace GiaoThucAnNhanh.GUI
{
    public partial class Foods_GUI : Form
    {
        public Foods_GUI()
        {
            InitializeComponent();
            define_Column_Table_NVPV();
            load_data();
        }

        private void define_Column_Table_NVPV()
        {
            dtGV_Food.ColumnCount = 4;
            dtGV_Food.Columns[0].HeaderText = "_id";
            dtGV_Food.Columns[1].HeaderText = "Mã món ăn";
            dtGV_Food.Columns[2].HeaderText = "Tên món ăn";
            dtGV_Food.Columns[3].HeaderText = "Giá";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã món ăn cuối cùng từ nguồn dữ liệu DataGridView
                string lastFoodId = string.Empty;
                if (dtGV_Food.Rows.Count > 0)
                {
                    lastFoodId = dtGV_Food.Rows[dtGV_Food.Rows.Count - 1].Cells["Ma_mon_an"].Value.ToString();
                }

                // Tạo mã món ăn mới dựa trên mã món ăn cuối cùng
                string newFoodId = db.ThucAn.GetMaMonAnCuoi();

                // Lấy thông tin món ăn từ các TextBox
                string tenMonAn = txtFoodName.Text;
                int gia = int.Parse(txtFoodPrice.Text);

                DTO.ThucAn monAn = new DTO.ThucAn
                {
                    Ma_mon_an = newFoodId,
                    Ten_mon_an = tenMonAn,
                    Gia = gia
                };

                // Thêm món ăn vào cơ sở dữ liệu
                db.ThucAn.Insert(monAn);

                // Thêm món ăn vào nguồn dữ liệu của DataGridView
                if (dtGV_Food.DataSource == null)
                {
                    dtGV_Food.DataSource = new List<DTO.ThucAn>();
                }
        ((List<DTO.ThucAn>)dtGV_Food.DataSource).Add(monAn);

                // Cập nhật hiển thị các cột
                dtGV_Food.Columns["_id"].HeaderText = "_id";
                dtGV_Food.Columns["Ma_mon_an"].HeaderText = "Mã món ăn";
                dtGV_Food.Columns["Ten_mon_an"].HeaderText = "Tên món ăn";
                dtGV_Food.Columns["Gia"].HeaderText = "Giá";

                // Autosize các cột để hiển thị đầy đủ dữ liệu
                dtGV_Food.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                load_data();
                XoaText();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string GenerateNewFoodId(string lastFoodId)
        {
            if (string.IsNullOrEmpty(lastFoodId))
            {
                return "m01";
            }

            string prefix = lastFoodId.Substring(0, lastFoodId.Length - 2);
            int lastNumber = int.Parse(lastFoodId.Substring(lastFoodId.Length - 2));
            int newNumber = lastNumber + 1;

            return prefix + newNumber.ToString("D2");
        }
        private void load_data()
        {
            // Clear existing data in the DataGridView
            dtGV_Food.DataSource = null;
            dtGV_Food.Rows.Clear();

            List<DTO.ThucAn> vttd = (List<DTO.ThucAn>)db.ThucAn.find();
            dtGV_Food.DataSource = vttd;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string maMonAn = txtFoodID.Text;
                string tenMonAn = txtFoodName.Text;
                int gia = int.Parse(txtFoodPrice.Text);
                //string id = txtID.Text;

                DTO.ThucAn monAn = new DTO.ThucAn
                {
                    _id = ObjectId.Parse(txtID.Text),
                    Ma_mon_an = maMonAn,
                    Ten_mon_an = tenMonAn,
                    Gia = gia
                };


                ThucAn thucAn = new ThucAn();
                thucAn.Edit(monAn);




                load_data();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dtGV_Food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGV_Food.Rows[e.RowIndex];

                txtID.Text = row.Cells["_id"].Value.ToString();
                txtFoodID.Text = row.Cells["Ma_mon_an"].Value.ToString();
                txtFoodName.Text = row.Cells["Ten_mon_an"].Value.ToString();
                txtFoodPrice.Text = row.Cells["Gia"].Value.ToString();
               
            }
           
        }

        

        private void txtFoodID_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string maMonAn = txtFoodID.Text.Trim();

            if (!string.IsNullOrEmpty(maMonAn))
            {
                List<DTO.ThucAn> monAnList = db.ThucAn.TimMonAnTheoMa(maMonAn);

                dtGV_Food.DataSource = null; // Xóa dữ liệu hiện tại trong DataGridView

                if (monAnList.Count > 0)
                {
                    dtGV_Food.DataSource = monAnList; // Gán danh sách món ăn mới vào DataSource

                    // Cập nhật hiển thị các cột
                    dtGV_Food.Columns["_id"].HeaderText = "_id";
                    dtGV_Food.Columns["Ma_mon_an"].HeaderText = "Mã món ăn";
                    dtGV_Food.Columns["Ten_mon_an"].HeaderText = "Tên món ăn";
                    dtGV_Food.Columns["Gia"].HeaderText = "Giá";

                    // Optional: Autosize các cột để hiển thị đầy đủ dữ liệu
                    dtGV_Food.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy món ăn có mã " + maMonAn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã món ăn để tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maMonAn = txtFoodID.Text.Trim();

                if (!string.IsNullOrEmpty(maMonAn))
                {

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn có mã " + maMonAn + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes)
                    {

                        db.ThucAn.DeleteByMaMonAn(maMonAn);

                        MessageBox.Show("Xóa món ăn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        RefreshMonAnList();
                        XoaText();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã món ăn để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RefreshMonAnList()
        {
            
            List<DTO.ThucAn> thucAnList = db.ThucAn.GetAll();
            dtGV_Food.DataSource = thucAnList;
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            string tenMonAn = txtFoodName.Text.Trim();

            if (!string.IsNullOrEmpty(tenMonAn))
            {
                List<DTO.ThucAn> monAnList = db.ThucAn.TimMonAnTheoTen(tenMonAn);

                dtGV_Food.DataSource = null; // Xóa dữ liệu hiện tại trong DataGridView

                if (monAnList.Count > 0)
                {
                    dtGV_Food.DataSource = monAnList; // Gán danh sách món ăn mới vào DataSource

                    // Cập nhật hiển thị các cột
                    dtGV_Food.Columns["_id"].HeaderText = "_id";
                    dtGV_Food.Columns["Ma_mon_an"].HeaderText = "Mã món ăn";
                    dtGV_Food.Columns["Ten_mon_an"].HeaderText = "Tên món ăn";
                    dtGV_Food.Columns["Gia"].HeaderText = "Giá";

                    // Optional: Autosize các cột để hiển thị đầy đủ dữ liệu
                    dtGV_Food.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy món ăn có tên " + tenMonAn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên món ăn để tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimTheoGia_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFoodPrice.Text.Trim(), out int giaMonAn))
            {
                List<DTO.ThucAn> monAnList = db.ThucAn.TimMonAnTheoGia(giaMonAn);

                dtGV_Food.DataSource = null; 

                if (monAnList.Count > 0)
                {
                    dtGV_Food.DataSource = monAnList; 

                   
                    dtGV_Food.Columns["_id"].HeaderText = "_id"; 
                    dtGV_Food.Columns["Ma_mon_an"].HeaderText = "Mã món ăn";
                    dtGV_Food.Columns["Ten_mon_an"].HeaderText = "Tên món ăn";
                    dtGV_Food.Columns["Gia"].HeaderText = "Giá";

                   
                    dtGV_Food.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy món ăn có giá " + giaMonAn.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá món ăn là một số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefreshMonAnList();
        }

        private void btnXoaText_Click(object sender, EventArgs e)
        {
            XoaText();
        }
        public void XoaText()
        {
            txtFoodID.Clear();
            txtFoodName.Clear();
            txtFoodPrice.Clear();
            txtID.Clear();
        }
       
    }
}
