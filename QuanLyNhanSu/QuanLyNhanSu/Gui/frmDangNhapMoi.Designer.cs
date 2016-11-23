namespace QuanLyNhanSu.Gui
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKT = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập quản lý nhân sự";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản";
            // 
            // lbKT
            // 
            this.lbKT.AutoSize = true;
            this.lbKT.ForeColor = System.Drawing.Color.Red;
            this.lbKT.Location = new System.Drawing.Point(136, 239);
            this.lbKT.Name = "lbKT";
            this.lbKT.Size = new System.Drawing.Size(0, 13);
            this.lbKT.TabIndex = 3;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(139, 59);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(191, 20);
            this.txtTaikhoan.TabIndex = 4;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(139, 99);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(191, 20);
            this.txtMatkhau.TabIndex = 5;
            this.txtMatkhau.UseSystemPasswordChar = true;
            this.txtMatkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatkhau_KeyDown);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(139, 170);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(93, 42);
            this.btnDangnhap.TabIndex = 6;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(238, 170);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 42);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(41, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.lbKT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập hệ thống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbKT;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}