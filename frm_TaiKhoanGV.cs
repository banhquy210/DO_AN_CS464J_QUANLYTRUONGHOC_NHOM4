using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTruongHoc
{
    public partial class frm_TaiKhoanGV : Form
    {
        LOPDUNGCHUNG l = new LOPDUNGCHUNG();
        string table_name = "TaiKhoanGiaoVien";
        public frm_TaiKhoanGV()
        {
            InitializeComponent();
        }

        private void frm_TaiKhoanGV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TaiKhoanGiaoVien values('" + txt_tentaikhoan.Text +
                         "', '" + txt_matkhau.Text + "', '" + txt_magv.Text + "');";
            l.thongbao(l.ketnoi(sql), "Tạo Tài Khoản");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update TaiKhoanGiaoVien Set MatKhau = '" +
                        txt_matkhau.Text + "', MaGiaoVien = '" +
                        txt_magv.Text + "' Where TenTaiKhoan = '" +
                        txt_tentaikhoan.Text + "';";
            l.thongbao(l.ketnoi(sql), "Sửa Tài Khoản");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from TaiKhoanGiaoVien Where TenTaiKhoan = '"
                + txt_tentaikhoan.Text + "';";
            l.thongbao(l.ketnoi(sql), "Xóa Tài Khoản");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void txt_magv_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from ThongTinGiaoVien where MaGiaoVien = '" + txt_magv.Text + "';";
            txt_ThongTin.Text = l.find_data(sql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_magv.Text = row.Cells["MaGiaoVien"].Value.ToString();
                txt_matkhau.Text = row.Cells["MatKhau"].Value.ToString();
                txt_tentaikhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
            };
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from TaiKhoanGiaoVien Where TenTaiKhoan like '" + txt_timkiem.Text + "%';";
            dataGridView1.DataSource = l.timkiem(sql);
        }

        private void txt_dong_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn đóng hay không??", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
