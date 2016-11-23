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
    public partial class frmSuaHopDong : Form
    {
        private string MaNV;
        private string MaHD;
        public frmSuaHopDong(string MaNvien,string MaHopDong)
        {
            MaNV = MaNvien;
            MaHD = MaHopDong;
            InitializeComponent();
        }

        private void frmSuaHopDong_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = MaNV;
            txtHopDong.Text = MaHD;
            ChiTietHopDongBus ct = new ChiTietHopDongBus();
            string dk=" where MaHD="+MaHD;
            dk+="and MaNV="+MaNV;
            DataTable dt = ct.HienThi(dk);
            dtNgayBD.Value = DateTime.Parse(dt.Rows[0][2].ToString());
            dtNgayKT.Value = DateTime.Parse(dt.Rows[0][3].ToString());
            txtGhiChu.Text = dt.Rows[0][4].ToString();  
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ChiTietHopDongEntity ct = new ChiTietHopDongEntity();
            ct.MaHD = MaHD;
            ct.MaNV = MaNV;
            ct.NgayBatDau = dtNgayBD.Value.ToString();
            ct.NgayKetThuc = dtNgayKT.Value.ToString();
            ct.GhiChu = txtGhiChu.Text;
            ChiTietHopDongBus cthd = new ChiTietHopDongBus();
            cthd.Sua(ct);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
