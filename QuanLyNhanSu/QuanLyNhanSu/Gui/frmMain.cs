using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu.Gui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        NhanVienBus bus = new NhanVienBus();
        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = bus.HienThiDS("");
        }
        private void toolDangxuat_Click(object sender, EventArgs e)
        {
            
            frmDangNhap dn = new frmDangNhap();
            this.Dispose();
            dn.ShowDialog();
        }

        private void toolDoiMK_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau dn = new FrmDoiMatKhau();
            dn.ShowDialog();
        }

        private void btnDanhsachNS_Click(object sender, EventArgs e)
        {
            frmDanhsachNhansu ns = new frmDanhsachNhansu();
            ns.ShowDialog();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaNV;
            MaNV = dgvNhanvien.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            string dk = txtTim.Text.ToString();
            if (dk == string.Empty) dgvNhanvien.DataSource = bus.HienThiDS("");
            else dgvNhanvien.DataSource = bus.HienThiDS(" where HoTen like N'%" + dk.Trim() + "%'");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
