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

namespace GiaoThucAnNhanh.GUI
{
    public partial class HoaDon_GUI : Form
    {

        public HoaDon_GUI()
        {
            InitializeComponent();

        }

        private void HoaDon_GUI_Load(object sender, EventArgs e)
        {
            LoadHoaDonListToDataGridView();
            LoadCBThucAn();
            lb_sumTienDaThanhToan.Text = db.HoaDon.SumTienDaTT().ToString();
            Loadcb_trang_thai();
        }
        public void Loadcb_trang_thai()
        {
            if (cb_trangThai.SelectedIndex == -1)
            {
                dtGVHoaDon.DataSource = null;
                dtGVHoaDon.DataSource = db.HoaDon.GetHoaDonList();
                dtGVHoaDon.Columns["ID"].Visible = false;
                dtGVHoaDon.Columns["Trang_thai"].Visible = false;
                btnThemMA.Visible = false;
                btnSuaMA.Visible = false;
                btnXoaMA.Visible = false;
            }
        }
        public void LoadCBThucAn()
        {
            List<DTO.ThucAn> vttd = (List<DTO.ThucAn>)db.ThucAn.find();
            if (vttd is List<DTO.ThucAn>)
            {
                var thucAnList = (List<DTO.ThucAn>)vttd;
                var tenThucAnList = thucAnList.Select(thucAn => thucAn.Ten_mon_an).ToList();
                cb_ten_ma.DataSource = tenThucAnList;
            }
        }
        public void LoadHoaDonListToDataGridView()
        {
            List<DTO.HoaDon> hoaDonList = db.HoaDon.GetHoaDonList();
            dtGVHoaDon.DataSource = null;
            dtGVDSMonAn.DataSource=null;
            dtGVHoaDon.DataSource = hoaDonList;
            cb_trangThai.SelectedIndex = -1;
            dtGVHoaDon.Columns["Trang_thai"].Visible = false;
            dtGVHoaDon.Columns["ID"].Visible = false;
        }



        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            List<DTO.HoaDon> hoaDonList = db.HoaDon.GetHoaDonList();
            string maHoaDon = txtMaHD.Text.Trim();


            DTO.HoaDon hoaDon = hoaDonList.FirstOrDefault(hd => hd.Ma_hd == maHoaDon);

            if (hoaDon != null)
            {

                dtGVHoaDon.DataSource = new List<DTO.HoaDon> { hoaDon };


                dtGVDSMonAn.DataSource = hoaDon.Ds_mon_an;
                dtGVHoaDon.Columns["Trang_thai"].Visible = false;

                dtGVDSMonAn.Columns["ID"].Visible = false;
            }
            else
            {

                dtGVHoaDon.DataSource = null;
                dtGVDSMonAn.DataSource = null;

            }
        }

        private void dtGVHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtGVHoaDon.Rows.Count + 1)
            {
                DataGridViewRow row = dtGVHoaDon.Rows[e.RowIndex];


                string maHoaDon = row.Cells["Ma_hd"].Value.ToString();
                string maKhachHang = row.Cells["Ma_kh"].Value.ToString();
                string tongTien = row.Cells["Tong_tien"].Value.ToString();
                txtMaHD.Text = maHoaDon;
                txtMaKH.Text = maKhachHang;
                txtTongTien.Text = tongTien;
                // load bảng ds món ăn
                var ds_monan = db.HoaDon.DsMonAnTheoMHD(maHoaDon);
                dtGVDSMonAn.DataSource=ds_monan;
                //dtGVDSMonAn.Columns["ID"].Visible=false;
            }
        }

        private void dtGVDSMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtGVDSMonAn.Rows.Count + 1)
            {
                DataGridViewRow row = dtGVDSMonAn.Rows[e.RowIndex];
                string soLuong = row.Cells["Sl"].Value.ToString();
                string gia = row.Cells["Gia"].Value.ToString();
                string thanh_tien = row.Cells["thanh_tien"].Value.ToString();
                cb_ten_ma.Text = dtGVDSMonAn.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSL.Text = soLuong;
                txtGia.Text = gia;
                txt_thanh_tien.Text = thanh_tien;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadHoaDonListToDataGridView();
        }

        private void btnTimTheoGia_Click(object sender, EventArgs e)
        {
            //string tenMonAn = txtTenMA.Text.Trim();

            //List<DTO.HoaDon> hoaDonList = db.HoaDon.GetHoaDonList();


            //List<DTO.HoaDon_ThucAn> danhSachMonAn = new List<DTO.HoaDon_ThucAn>();

            //foreach (DTO.HoaDon hoaDon in hoaDonList)
            //{

            //    foreach (DTO.HoaDon_ThucAn monAn in hoaDon.Ds_mon_an)
            //    {
            //        if (monAn.Tenmon.ToLower().Contains(tenMonAn.ToLower()))
            //        {
            //            danhSachMonAn.Add(monAn);
            //        }
            //    }
            //}

            //if (danhSachMonAn.Count > 0)
            //{

            //    dtGVDSMonAn.DataSource = danhSachMonAn;
            //    dtGVDSMonAn.Columns["Id"].Visible = false;
            //}
            //else
            //{

            //    dtGVDSMonAn.DataSource = null;
            //}
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            #region
            //try
            //{
            //    string maHoaDon = GenerateMaHoaDon();
            //    string maKhachHang = GenerateMaKhachHang();


            //    var hoaDon = new DTO.HoaDon
            //    {
            //        Ma_hd = maHoaDon,
            //        Ma_kh = maKhachHang,
            //        Tong_tien = 0,
            //        Ds_mon_an = new List<DTO.HoaDon_ThucAn>()
            //    };


            //    db.HoaDon.Insert(hoaDon);


            //    if (dtGVHoaDon.DataSource == null)
            //    {
            //        dtGVHoaDon.DataSource = new List<DTO.HoaDon>();
            //    }




            //    ClearData();
            //    LoadHoaDonListToDataGridView();
            //    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion
            themHoaDon form = new themHoaDon(this);
            form.ShowDialog();
            string maHDmoi = db.HoaDon.GetMaHoaDonCuoi();
            db.HoaDon.ThemMaHoaDon(maHDmoi);
            string trang_thai = "Chưa thanh toán";
            if (db.HoaDon.ThemHoaDon())
            {
                if(cb_trangThai.SelectedItem!=null)
                {
                    if (trang_thai.Equals(cb_trangThai.SelectedItem.ToString()))
                    {
                        dtGVHoaDon.DataSource = null;
                        var ds_hoaDon = db.HoaDon.Trang_thai_HD(trang_thai);
                        dtGVHoaDon.DataSource = ds_hoaDon;
                        dtGVHoaDon.Columns["Trang_thai"].Visible = false;
                        dtGVHoaDon.Columns["ID"].Visible = false;
                    }
                    MessageBox.Show("Thêm hóa đơn thành công", "Thêm hóa đơn");
                }    
            }
        }
        private void ClearData()
        {
            txtMaHD.Text = "";
            txtTongTien.Text = "";
            txtMaKH.Text = "";
            dtGVDSMonAn.Rows.Clear();
        }
        private string GenerateMaHoaDon()
        {
            string maHoaDon = "hd";

            if (dtGVHoaDon.Rows.Count > 0)
            {
                string maHoaDonCuoi = dtGVHoaDon.Rows[dtGVHoaDon.Rows.Count - 1].Cells["Ma_hd"].Value.ToString();
                int soHoaDonCuoi = int.Parse(maHoaDonCuoi.Substring(2));

                soHoaDonCuoi++;

                maHoaDon += soHoaDonCuoi.ToString("D2");
            }
            else
            {
                maHoaDon += "01";
            }

            return maHoaDon;
        }
        private string GenerateMaKhachHang()
        {
            string maKhachHang = "kh";

            if (dtGVHoaDon.Rows.Count > 0)
            {
                string maKhachHangCuoi = dtGVHoaDon.Rows[dtGVHoaDon.Rows.Count - 1].Cells["Ma_kh"].Value.ToString();
                int soKhachHangCuoi = int.Parse(maKhachHangCuoi.Substring(2));

                soKhachHangCuoi++;

                maKhachHang += soKhachHangCuoi.ToString("D2");
            }
            else
            {
                maKhachHang += "01";
            }

            return maKhachHang;
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = txtMaHD.Text.Trim();

                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn có mã " + maHoaDon + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        db.HoaDon.DeleteByMaHoaDon(maHoaDon);
                        MessageBox.Show("Xóa hóa đơn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadHoaDonListToDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMA_Click(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = txtMaHD.Text.Trim();
                string tenMonAn = cb_ten_ma.SelectedItem.ToString();
                int soLuong = int.Parse(txtSL.Text);
                DTO.HoaDon_ThucAn monAn = new DTO.HoaDon_ThucAn
                {
                    Tenmon = tenMonAn,
                    Sl = soLuong,
                };

                db.HoaDon.AddMonAnToHoaDon(maHoaDon, monAn);

                // Cập nhật lại tổng tiền trong hóa đơn


                MessageBox.Show("Thêm món ăn vào hóa đơn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại danh sách món ăn trong hóa đơn
                dtGVDSMonAn.DataSource = null;
                var ds_monan = db.HoaDon.DsMonAnTheoMHD(maHoaDon);
                db.HoaDon.UpdateTongTien(maHoaDon);
                var tong_tien_hd=db.HoaDon.findTong_tienHD(maHoaDon);
                txtTongTien.Text=tong_tien_hd.Tong_tien.ToString();
                dtGVDSMonAn.DataSource = ds_monan;
                dtGVHoaDon.DataSource = null;
                dtGVHoaDon.DataSource = db.HoaDon.GetHoaDonList();
                dtGVHoaDon.Columns["ID"].Visible = false;

                dtGVHoaDon.Columns["Trang_thai"].Visible = false;

                //dtGVDSMonAn.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm món ăn vào hóa đơn thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaMA_Click(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = txtMaHD.Text.Trim();
                string tenMonAn = cb_ten_ma.SelectedItem.ToString();
                int soLuong = int.Parse(txtSL.Text);
                int gia = int.Parse(txtGia.Text);
                DTO.HoaDon_ThucAn monAn = new DTO.HoaDon_ThucAn
                {
                    Tenmon = tenMonAn,
                    Sl = soLuong,
                    Gia = gia,
                    thanh_tien = soLuong * gia,
                };
                int index = dtGVDSMonAn.CurrentCell.RowIndex;
                string tenMonCu = dtGVDSMonAn.Rows[index].Cells[0].Value.ToString();
                //db.HoaDon.UpdateMonAnInHoaDon(maHoaDon, tenMonAn, soLuong, gia,thanh_tien);
                db.HoaDon.UpdateMonAnInHoaDon(maHoaDon,monAn,index,tenMonCu);
                db.HoaDon.UpdateTongTien(maHoaDon);
                MessageBox.Show("Sửa món ăn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGVDSMonAn.DataSource = null;
                var ds_monan = db.HoaDon.DsMonAnTheoMHD(maHoaDon);
                var tong_tien_hd = db.HoaDon.findTong_tienHD(maHoaDon);
                txtTongTien.Text = tong_tien_hd.Tong_tien.ToString();
                dtGVDSMonAn.DataSource = ds_monan;
                dtGVHoaDon.Columns["Trang_thai"].Visible = false;

                //dtGVDSMonAn.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa món ăn thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMA_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHD.Text;
            string tenMonAn = cb_ten_ma.SelectedItem.ToString();

            // Gọi hàm DeleteByMaHoaDonAndTenMonAn trong tầng DAO
            db.HoaDon.DeleteByMaHoaDonAndTenMonAn(maHoaDon, tenMonAn);

            // Hiển thị thông báo thành công
            MessageBox.Show("Xóa món ăn thành công!");
            dtGVDSMonAn.DataSource = null;
            var ds_monan = db.HoaDon.DsMonAnTheoMHD(maHoaDon);
            var tong_tien_hd = db.HoaDon.findTong_tienHD(maHoaDon);
            txtTongTien.Text = tong_tien_hd.Tong_tien.ToString();
            dtGVDSMonAn.DataSource = ds_monan;
            dtGVHoaDon.DataSource = null;
            dtGVHoaDon.DataSource = db.HoaDon.GetHoaDonList();
            dtGVHoaDon.Columns["ID"].Visible = false;
            dtGVHoaDon.Columns["Trang_thai"].Visible = false;

            //dtGVDSMonAn.Columns["ID"].Visible = false;
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private string txtSLtemp = string.Empty;
        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if(txtSL.Text.Length > 100)
            {
                MessageBox.Show("số lượng quá lớn phải <100", "số lượng");
                txtSL.Text = txtSLtemp;
            }
            else
            {
                txtSLtemp = txtSL.Text;
            }
        }
        private void timKiemHd()
        {
            dtGVHoaDon.DataSource= null;
            List<DTO.HoaDon> result = db.HoaDon.findValues(txt_search.Text);
            dtGVHoaDon.DataSource = result;
            dtGVHoaDon.Columns["Trang_thai"].Visible = false;
            dtGVHoaDon.Columns["ID"].Visible = false;
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            timKiemHd();
        }

        private void cb_ten_ma_SelectedValueChanged(object sender, EventArgs e)
        {
           var result=db.ThucAn.TimMonAnTheoTen(cb_ten_ma.SelectedItem.ToString());
            if(result!=null)
            {
                txtGia.Text = result[0].Gia.ToString();
            }
        }
        private void cb_trangThai_SelectedValueChanged_1(object sender, EventArgs e)
        {
            string trang_thai = "Chưa thanh toán";
            if (cb_trangThai.SelectedIndex == -1)
            {
                dtGVHoaDon.DataSource = null;
                dtGVHoaDon.DataSource = db.HoaDon.GetHoaDonList();
                dtGVHoaDon.Columns["ID"].Visible = false;
                dtGVHoaDon.Columns["Trang_thai"].Visible = false;
                btnThemMA.Visible = false;
                btnSuaMA.Visible = false;
                btnXoaMA.Visible = false;
            }
            else
            {
                if (trang_thai.Equals(cb_trangThai.SelectedItem.ToString()))
                {
                    dtGVHoaDon.DataSource = null;
                    dtGVHoaDon.DataSource = db.HoaDon.Trang_thai_HD(cb_trangThai.SelectedItem.ToString());
                    dtGVHoaDon.Columns["ID"].Visible = false;
                    dtGVHoaDon.Columns["Trang_thai"].Visible = false;
                    btnThemMA.Visible = true;
                    btnSuaMA.Visible = true;
                    btnXoaMA.Visible = true;
                }
                else
                {
                    dtGVHoaDon.DataSource = null;
                    dtGVHoaDon.DataSource = db.HoaDon.Trang_thai_HD(cb_trangThai.SelectedItem.ToString());
                    dtGVHoaDon.Columns["ID"].Visible = false;
                    dtGVHoaDon.Columns["Trang_thai"].Visible = false;
                    btnThemMA.Visible = false;
                    btnSuaMA.Visible = false;
                    btnXoaMA.Visible = false;
                }
            }
        }
    }
}
