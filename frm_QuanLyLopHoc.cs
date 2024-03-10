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
    public partial class frm_QuanLyLopHoc : Form
    {
        LOPDUNGCHUNG l = new LOPDUNGCHUNG();
        string table_name = "LopHoc";
        public frm_QuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into LopHoc values('" +
                   txt_malophoc.Text + "', '" +
                   txt_tenlophoc.Text + "', '" +
                   txt_magv.Text + "', '" +
                   txt_mota.Text + "');";
            l.thongbao(l.ketnoi(sql),"Thêm");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void frm_QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void txt_magv_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from ThongTinGiaoVien Where MaGiaoVien = '" + txt_magv.Text + "';";
            txt_ThongTin.Text = l.find_data(sql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_magv.Text = row.Cells["MaGiaoVien"].Value.ToString();
                txt_malophoc.Text = row.Cells["MaLopHoc"].Value.ToString();
                txt_tenlophoc.Text = row.Cells["TenLopHoc"].Value.ToString();
                txt_mota.Text = row.Cells["MoTa"].Value.ToString();
            };
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update LopHoc Set TenLopHoc = '" + txt_tenlophoc.Text +
                         "', MaGiaoVien = '" + txt_magv.Text +
                         "', MoTa = '" + txt_mota.Text + "' Where MaLopHoc='" +
                         txt_malophoc.Text + "';";

            l.thongbao(l.ketnoi(sql), "Sửa");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from LopHoc Where MaLopHoc = '" + txt_malophoc.Text + "';";
            l.thongbao(l.ketnoi(sql), "Xóa");

            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from LopHoc Where MaLopHoc like '" + txt_timkiem.Text + "%';";

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
