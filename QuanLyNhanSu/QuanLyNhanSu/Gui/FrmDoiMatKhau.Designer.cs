namespace QuanLyNhanSu.Gui
{
    partial class FrmDoiMatKhau
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
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.txtMKlai = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDongy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(149, 106);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(172, 20);
            this.txtMKcu.TabIndex = 3;
            // 
            // txtMKlai
            // 
            this.txtMKlai.Location = new System.Drawing.Point(149, 182);
            this.txtMKlai.Name = "txtMKlai";
            this.txtMKlai.Size = new System.Drawing.Size(172, 20);
            this.txtMKlai.TabIndex = 4;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(149, 140);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(172, 20);
            this.txtMKmoi.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(187, 240);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(53, 240);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(100, 42);
            this.btnDongy.TabIndex = 7;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên tài khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(149, 63);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(172, 20);
            this.txtTenTK.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đổi mật khẩu người dùng";
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMKlai);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoiMatKhau";
            this.Text = "FrmDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.TextBox txtMKlai;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label5;
    }
}