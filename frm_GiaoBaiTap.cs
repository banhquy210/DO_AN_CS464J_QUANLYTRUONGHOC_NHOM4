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
    public partial class frm_GiaoBaiTap : Form
    {
        LOPDUNGCHUNG l = new LOPDUNGCHUNG();
        string table_name = "BaiTap";
        public frm_GiaoBaiTap()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into BaiTap values('" + txt_mabaitap.Text+ "', '" +
                         txt_malophoc.Text + "', '" +
                         txt_noidung.Text + "');";
            l.thongbao(l.ketnoi(sql), "Thêm");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void frm_GiaoBaiTap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update BaiTap Set MaLopHoc = '" + txt_malophoc.Text +
                         "', NoiDung = '" + txt_noidung.Text + "' Where MaBaiTap = '" +
                         txt_mabaitap.Text + "';";
            l.thongbao(l.ketnoi(sql), "Sửa");
            dataGridView1.DataSource = l.capnhapData(table_name);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from BaiTap Where MaBaiTap = '" + txt_mabaitap.Text + "';";
            l.thongbao(l.ketnoi(sql), "Xóa");

            dataGridView1.DataSource = l.capnhapData(table_name);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_mabaitap.Text = row.Cells["MaBaiTap"].Value.ToString();
                txt_malophoc.Text = row.Cells["MalopHoc"].Value.ToString();
                txt_noidung.Text = row.Cells["NoiDung"].Value.ToString();
                
            }
        }

        private void txt_malophoc_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from LopHoc where MaLopHoc = '" + txt_malophoc.Text + "';";
            txt_ThongTin.Text = l.find_data(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_noidung_TextChanged(object sender, EventArgs e)
        {

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
