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
using QuanLyNhanSu.Entity;
namespace QuanLyNhanSu.Gui
{
    public partial class frmThemHopDong : Form
    {
        private string MaNV;
        public frmThemHopDong(string MaNhanVien)
        {
            MaNV = MaNhanVien;
            InitializeComponent();
        }

        private void frmThemHopDong_Load(object sender, EventArgs e)
        {
            ChiTietHopDongBus ct=new ChiTietHopDongBus();
            txtMaNV.Text = MaNV;
            cboHD.DataSource = ct.HienThi("");
            cboHD.DisplayMember = "TenHD";
            cboHD.ValueMember = "MaHD";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ChiTietHopDongEntity ct = new ChiTietHopDongEntity();
        //    ct.MaHD = MaHD;
            ct.MaNV = MaNV;
            ct.NgayBatDau = dtNgayBD.Value.ToString();
            ct.NgayKetThuc = dtNgayKT.Value.ToString();
            ct.GhiChu = txtGhiChu.Text;
            ChiTietHopDongBus cthd = new ChiTietHopDongBus();
            cthd.Them(ct);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
