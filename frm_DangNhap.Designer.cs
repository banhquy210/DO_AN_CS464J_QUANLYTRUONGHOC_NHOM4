namespace ProjectTruongHoc
{
    partial class frm_DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.rb_sinhvien = new System.Windows.Forms.RadioButton();
            this.rb_giaovien = new System.Windows.Forms.RadioButton();
            this.rb_qtv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_taikhoan
            // 
            resources.ApplyResources(this.txt_taikhoan, "txt_taikhoan");
            this.txt_taikhoan.Name = "txt_taikhoan";
            // 
            // txt_matkhau
            // 
            resources.ApplyResources(this.txt_matkhau, "txt_matkhau");
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // btn_dangnhap
            // 
            resources.ApplyResources(this.btn_dangnhap, "btn_dangnhap");
            this.btn_dangnhap.BackColor = System.Drawing.Color.Black;
            this.btn_dangnhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_dong
            // 
            resources.ApplyResources(this.btn_dong, "btn_dong");
            this.btn_dong.BackColor = System.Drawing.Color.Black;
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // rb_sinhvien
            // 
            resources.ApplyResources(this.rb_sinhvien, "rb_sinhvien");
            this.rb_sinhvien.Name = "rb_sinhvien";
            this.rb_sinhvien.TabStop = true;
            this.rb_sinhvien.UseVisualStyleBackColor = true;
            // 
            // rb_giaovien
            // 
            resources.ApplyResources(this.rb_giaovien, "rb_giaovien");
            this.rb_giaovien.Name = "rb_giaovien";
            this.rb_giaovien.TabStop = true;
            this.rb_giaovien.UseVisualStyleBackColor = true;
            this.rb_giaovien.CheckedChanged += new System.EventHandler(this.rb_giaovien_CheckedChanged);
            // 
            // rb_qtv
            // 
            resources.ApplyResources(this.rb_qtv, "rb_qtv");
            this.rb_qtv.Name = "rb_qtv";
            this.rb_qtv.TabStop = true;
            this.rb_qtv.UseVisualStyleBackColor = true;
            this.rb_qtv.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // frm_DangNhap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.rb_qtv);
            this.Controls.Add(this.rb_giaovien);
            this.Controls.Add(this.rb_sinhvien);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frm_DangNhap";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.RadioButton rb_sinhvien;
        private System.Windows.Forms.RadioButton rb_giaovien;
        private System.Windows.Forms.RadioButton rb_qtv;
    }
}