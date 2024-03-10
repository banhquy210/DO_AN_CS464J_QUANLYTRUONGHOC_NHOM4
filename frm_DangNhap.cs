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
    public partial class frm_DangNhap : Form
    {
        LOPDUNGCHUNG l = new LOPDUNGCHUNG();
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            
            string tb = "";
            if (rb_sinhvien.Checked == true)
            {
                tb = "TaiKhoanSinhVien";
            }
            else if (rb_giaovien.Checked == true)
            {
                tb = "TaiKhoanGiaoVien";
            }
            else if (rb_qtv.Checked == true)
            {
                tb = "TaiKhoanQTV";
            }
            else
            {
                MessageBox.Show("Hãy chọn quyền đăng nhập");
            }
            if (tb != "" && l.dangNhap(txt_taikhoan.Text, txt_matkhau.Text, tb) > 0)
            {
                this.Visible = false;
                if (tb == "TaiKhoanSinhVien")
                {
                    frm_SinhVien sv = new frm_SinhVien();
                    sv.Tentaikhoan_ = txt_taikhoan.Text;
                    sv.Show();
                }
                else if ( tb == "TaiKhoanGiaoVien")
                {
                    frm_GiaoVien sv = new frm_GiaoVien();
                    sv.Show();
                }
                else if (tb == "TaiKhoanQTV")
                {
                    frm_QuanTriVien qt = new frm_QuanTriVien();
                    qt.Show();
                }
            }
            else
            {
                if (count == 3)
                {
                    Application.Exit();
                }
                count++;                
                MessageBox.Show("Bạn nhập sai lần " + count.ToString());


            }
            
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            rb_sinhvien.Checked = true;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn đóng hay không??", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_giaovien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
