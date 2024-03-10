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
    public partial class frm_SinhVien : Form
    {
        LOPDUNGCHUNG l = new LOPDUNGCHUNG();
        string tentaikhoan_;
        string table_name_;

        public string Tentaikhoan_ { get => tentaikhoan_; set => tentaikhoan_ = value; }
        public string Table_name_ { get => table_name_; set => table_name_ = value; }

        public frm_SinhVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            string sql = "Select MaSinhVien from TaiKhoanSinhVien Where TenTaiKhoan = '" + tentaikhoan_ + "';";
            string sql2 = "Select * from ThongTinSinhVien Where MaSinhVien = '" + l.find_data2(sql).Trim() + "';";

            string kq = l.find_data2(sql2);
            string[] multiArray = kq.Split(new Char[] {'\t'});
            l_masv.Text = multiArray[0];
            l_hoten.Text = multiArray[1];
            l_gioitinh.Text = multiArray[2];
            l_diachi.Text = multiArray[3];
            l_lop.Text = multiArray[4];
            l_ngaysinh.Text = multiArray[5];
            l_email.Text = multiArray[6];


            // Lop hoc
            string sql_3 = "Select l1.MaLopHoc,l1.TenLopHoc,l1.MaGiaoVien,l1.MoTa " +
                           "from LopHoc as l1 " +"inner join SinhVien_LopHoc as l2 " +
                           "on l2.MaLopHoc = l1.MaLopHoc " +
                           "Where l2.MaSinhVien = '" + l.find_data2(sql).Trim() + "';";
            dataGridView1.DataSource = l.timkiem(sql_3);
        }

        private void l_gioitinh_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                l_malop.Text = row.Cells["MaLopHoc"].Value.ToString();
                l_magv.Text = row.Cells["MaGiaoVien"].Value.ToString();
                l_ten.Text = row.Cells["TenLopHoc"].Value.ToString();
                l_mota.Text = row.Cells["MoTa"].Value.ToString();

                string sql = "Select * from BaiTap Where MaLopHoc = '" + l_malop.Text + "';";
              //  dataGridView2.DataSource = l.timkiem(sql);
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
