namespace ProjectTruongHoc
{
    partial class frm_GiaoVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnBàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoBàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLớpHọcToolStripMenuItem,
            this.quảnBàiTậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem});
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý lớp học";
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.xemThôngTinToolStripMenuItem.Text = "Xem Thông Tin";
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            // 
            // quảnBàiTậpToolStripMenuItem
            // 
            this.quảnBàiTậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoBàiTậpToolStripMenuItem});
            this.quảnBàiTậpToolStripMenuItem.Name = "quảnBàiTậpToolStripMenuItem";
            this.quảnBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.quảnBàiTậpToolStripMenuItem.Text = "Quản Lý Bài Tập";
            this.quảnBàiTậpToolStripMenuItem.Click += new System.EventHandler(this.quảnBàiTậpToolStripMenuItem_Click);
            // 
            // giaoBàiTậpToolStripMenuItem
            // 
            this.giaoBàiTậpToolStripMenuItem.Name = "giaoBàiTậpToolStripMenuItem";
            this.giaoBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.giaoBàiTậpToolStripMenuItem.Text = "Giao Bài Tập";
            this.giaoBàiTậpToolStripMenuItem.Click += new System.EventHandler(this.giaoBàiTậpToolStripMenuItem_Click);
            // 
            // frm_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(879, 520);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_GiaoVien";
            this.Text = "frm_GiaoVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnBàiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoBàiTậpToolStripMenuItem;
    }
}