using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectTruongHoc
{
    public partial class frm_TaiKhoanSV : Form
    {
        LOPDUNGCHUNG l = new LOPDUNGCHUNG();
        string table_name = "TaiKhoanSinhVien";
        public frm_TaiKhoanSV()
        {
            InitializeComponent();
        }

        private void frm_TaiKhoanSV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void txt_masv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TaiKhoanSinhVien values('" + txt_tentaikhoan.Text +
                         "', '" + txt_matkhau.Text + "', '" + txt_masv.Text + "');";
            l.thongbao(l.ketnoi(sql), "Tạo Tài Khoản");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Update TaiKhoanSinhVien Set MatKhau = '" +
                        txt_matkhau.Text + "', MaSinhVien = '" +
                        txt_masv.Text + "' Where TenTaiKhoan = '" +
                        txt_tentaikhoan.Text + "';";
            l.thongbao(l.ketnoi(sql), "Sửa Tài Khoản");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_masv.Text = row.Cells["MaSinhVien"].Value.ToString();
                txt_matkhau.Text = row.Cells["MatKhau"].Value.ToString();
                txt_tentaikhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "Delete from TaiKhoanSinhVien Where TenTaiKhoan = '"
                + txt_tentaikhoan.Text + "';";
            l.thongbao(l.ketnoi(sql), "Xóa Tài Khoản");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void txt_masv_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "Select * from ThongTinSinhVien where MaSinhVien = '" + txt_masv.Text + "';";
            txt_ThongTin.Text =  l.find_data(sql);

            
        }

        private void txt_ThongTin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "Select * from TaiKhoanSinhVien Where TenTaiKhoan like '" + txt_timkiem.Text + "%';";
            dataGridView1.DataSource = l.timkiem(sql);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn đóng hay không??", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
