namespace QuanLyNhanSu.Gui
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnDanhsachNS = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolThemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 91);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTim);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Controls.Add(this.btnDanhsachNS);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(864, 51);
            this.panel4.TabIndex = 1;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(347, 16);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 20);
            this.txtTim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ khóa";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(471, 0);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(97, 51);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnDanhsachNS
            // 
            this.btnDanhsachNS.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDanhsachNS.Location = new System.Drawing.Point(101, 0);
            this.btnDanhsachNS.Name = "btnDanhsachNS";
            this.btnDanhsachNS.Size = new System.Drawing.Size(127, 51);
            this.btnDanhsachNS.TabIndex = 1;
            this.btnDanhsachNS.Text = "Danh sách nhân sự";
            this.btnDanhsachNS.UseVisualStyleBackColor = true;
            this.btnDanhsachNS.Click += new System.EventHandler(this.btnDanhsachNS_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 51);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm nhân sự";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 40);
            this.panel3.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.hệThốngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.quảnLýToolStripMenuItem.Text = "Hồ sơ nhân sự";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolThemUser,
            this.toolDoiMK,
            this.toolDangxuat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 36);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // toolThemUser
            // 
            this.toolThemUser.Name = "toolThemUser";
            this.toolThemUser.Size = new System.Drawing.Size(149, 22);
            this.toolThemUser.Text = "Thêm quản trị";
            // 
            // toolDoiMK
            // 
            this.toolDoiMK.Name = "toolDoiMK";
            this.toolDoiMK.Size = new System.Drawing.Size(149, 22);
            this.toolDoiMK.Text = "Đôi mật khẩu";
            this.toolDoiMK.Click += new System.EventHandler(this.toolDoiMK_Click);
            // 
            // toolDangxuat
            // 
            this.toolDangxuat.Name = "toolDangxuat";
            this.toolDangxuat.Size = new System.Drawing.Size(149, 22);
            this.toolDangxuat.Text = "Đăng xuất";
            this.toolDangxuat.Click += new System.EventHandler(this.toolDangxuat_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 228);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvNhanvien);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(568, 228);
            this.panel6.TabIndex = 2;
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanvien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.Size = new System.Drawing.Size(568, 228);
            this.dgvNhanvien.TabIndex = 0;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "HoTen";
            this.Column1.HeaderText = "Tên nhân viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenPB";
            this.Column2.HeaderText = "Phòng ban";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TenChucVu";
            this.Column3.HeaderText = "Chức vụ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TenChuyenMon";
            this.Column4.HeaderText = "Trình độ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TenHD";
            this.Column5.HeaderText = "Hơp đồng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaNV";
            this.Column6.HeaderText = "MaNV";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(568, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 228);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyNhanSu.Properties.Resources.Nhansu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(864, 319);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnDanhsachNS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolThemUser;
        private System.Windows.Forms.ToolStripMenuItem toolDoiMK;
        private System.Windows.Forms.ToolStripMenuItem toolDangxuat;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
    }
}