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
    public partial class frm_QuanLySinhVien : Form
    {
        LOPDUNGCHUNG l = new LOPDUNGCHUNG();
        public frm_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Update ThongTinSinhVien Set " +
                         "HoTen = '" + txt_hoten.Text +
                         "', GioiTinh = '" + cb_gioitinh.Text +
                         "', DiaChi = '" + txt_diachi.Text +
                         "', Lop = '" + cb_lop.Text +
                         "', NgaySinh = convert(datetime, '" + dp_ngaysinh.Text +
                         "', 103), Email = '" + txt_email.Text + "' Where MaSinhVien = '" +
                         txt_masv.Text + "';";
            MessageBox.Show(sql);
            l.thongbao(l.ketnoi(sql), "Sua");
            dataGridView1.DataSource = l.capnhapData("ThongTinSinhVien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO ThongTinSinhVien " +
                         "values ('" + txt_masv.Text + "', '" +
                         txt_hoten.Text + "', '" +
                         cb_gioitinh.Text +
                         "', '" + txt_diachi.Text +
                         "', '" + cb_lop.Text +
                         "', convert(datetime, '" +
                         dp_ngaysinh.Text + "', 103), '" + txt_email.Text + "');";    
                        

            MessageBox.Show(sql);
            l.thongbao(l.ketnoi(sql), "Them");
            dataGridView1.DataSource = l.capnhapData("ThongTinSinhVien");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_masv.Text = row.Cells["MaSinhVien"].Value.ToString();
                txt_hoten.Text = row.Cells["HoTen"].Value.ToString();
                txt_diachi.Text = row.Cells["DiaChi"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                cb_lop.Text = row.Cells["Lop"].Value.ToString();
                cb_gioitinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dp_ngaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
            };
        }

        private void frm_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = l.capnhapData("ThongTinSinhVien");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "Delete from ThongTinSinhVien where MaSinhVien = '" +
                                txt_masv.Text + "';";
            MessageBox.Show(sql);
            l.thongbao(l.ketnoi(sql), "Xoa");
            dataGridView1.DataSource = l.capnhapData("ThongTinSinhVien");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
