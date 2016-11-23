using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.Entity;
using QuanLyNhanSu.Data;
namespace QuanLyNhanSu.Gui
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBus dn = new TaiKhoanBus();
        public static string TenDangNhap;
        public static string MatKhau;
        public static int MaNV;
        public frmDangNhap()
        {
            InitializeComponent();
        }

      
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text != "")
            {
                DataTable user = dn.HienThi("where TaiKhoan= N'" + txtTaikhoan.Text.ToString()+"'");
                if (user.Rows.Count == 0)
                {
                    //MessageBox.Show("Sai tên tài khoản");
                    lbKT.Text = "Sai Tài Khoản!!!";
                }
                else if (user.Rows[0]["MatKhau"].ToString().Trim() != txtMatkhau.Text)
                {
                    // MessageBox.Show("Sai tên mật khẩu ");
                    lbKT.Text = "Sai mật khẩu!!!";
                }
                else
                {
                    MaNV = int.Parse(user.Rows[0]["MaNV"].ToString());
                    TenDangNhap = txtTaikhoan.Text;
                    MatKhau = txtMatkhau.Text;
                    frmMain main = new frmMain();
                    this.Hide();
                    main.ShowDialog();
                    
                }
            }
            else
            {
                lbKT.Text = "Bạn chưa nhập dữ liệu!!!";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatkhau.UseSystemPasswordChar = false;
            }
            else
                txtMatkhau.UseSystemPasswordChar = true;
        }

        private void txtMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap_Click(null, null);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
