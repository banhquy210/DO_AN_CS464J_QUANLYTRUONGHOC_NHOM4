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
    public partial class frm_QuanTriVien : Form
    {
        public frm_QuanTriVien()
        {
            InitializeComponent();
        }

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tảiKhoảnGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLyGiaoVien"] == null)
            {
                frm_QuanLyGiaoVien gv = new frm_QuanLyGiaoVien();
                gv.MdiParent = this;
                gv.Show();
            }
            else { Application.OpenForms["frm_QuanLyGiaoVien"].Activate(); }
        }

        private void tàiKhoảnSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLySinhVien"] == null)
            {
                frm_QuanLySinhVien sv = new frm_QuanLySinhVien();
                sv.MdiParent = this;
                sv.Show();
            }
            else { Application.OpenForms["frm_QuanLySinhVien"].Activate(); }
        }

        private void frm_QuanTriVien_Load(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TaiKhoanSV"] == null)
            {
                frm_TaiKhoanSV sv = new frm_TaiKhoanSV();
                sv.MdiParent = this;
                sv.Show();
            }
            else { Application.OpenForms["frm_TaiKhoanSV"].Activate(); }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TaiKhoanGV"] == null)
            {
                frm_TaiKhoanGV gv = new frm_TaiKhoanGV();
                gv.MdiParent = this;
                gv.Show();
            }
            else { Application.OpenForms["frm_TaiKhoanGV"].Activate(); }
        }

        private void tạoLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLyLopHoc"] == null)
            {
                frm_QuanLyLopHoc lh = new frm_QuanLyLopHoc();
                lh.MdiParent = this;
                lh.Show();
            }
            else { Application.OpenForms["frm_QuanLyLopHoc"].Activate(); }
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLySinhVien_LopHoc"] == null)
            {
                frm_QuanLySinhVien_LopHoc lh = new frm_QuanLySinhVien_LopHoc();
                lh.MdiParent = this;
                lh.Show();
            }
            else { Application.OpenForms["frm_QuanLySinhVien_LopHoc"].Activate(); }
        }

        private void quảnLýBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
