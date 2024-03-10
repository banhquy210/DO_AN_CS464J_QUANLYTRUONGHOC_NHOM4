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
    public partial class frm_QuanLySinhVien_LopHoc : Form
    {
        LOPDUNGCHUNG l = new LOPDUNGCHUNG();
        string table_name = "SinhVien_LopHoc";
        public frm_QuanLySinhVien_LopHoc()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_QuanLySinhVien_LopHoc_Load(object sender, EventArgs e)
        {
            dataGridView4.DataSource = l.capnhapData(table_name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SinhVien_LopHoc values('" + txt_malop.Text +
                         "', '" + txt_magv.Text +
                         "', '" + txt_masinhvien.Text + "');";

            l.thongbao(l.ketnoi(sql), "Them");
            dataGridView4.DataSource = l.capnhapData(table_name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Update SinhVien_LopHoc Set MaLopHoc = '" + txt_magv.Text +
                       "', MaSinhVien = '" + txt_masinhvien.Text + "' Where MaSinhVienLopHoc = '" +
                       txt_malop.Text + "';";

            l.thongbao(l.ketnoi(sql), "Sua");
            dataGridView4.DataSource = l.capnhapData(table_name);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_malop_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from SinhVien_LopHoc Where MaSinhVienLopHoc like '" + txt_malop.Text + "%';";
            dataGridView4.DataSource = l.timkiem(sql);
        }

        private void txt_magv_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from LopHoc Where MaLopHoc like '" + txt_magv.Text + "%';";
            dataGridView2.DataSource = l.timkiem(sql);
        }

        private void txt_masinhvien_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from ThongTinSinhVien Where MaSinhVien like '" + txt_masinhvien.Text + "%';";
            dataGridView1.DataSource = l.timkiem(sql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_masinhvien.Text = row.Cells["MaSinhVien"].Value.ToString();             
            };
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txt_magv.Text = row.Cells["MaLopHoc"].Value.ToString();
            };
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
                txt_malop.Text = row.Cells["MaSinhVienLopHoc"].Value.ToString();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn đóng hay không??", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
