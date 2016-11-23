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
    public partial class FrmThemPhieuLuong : Form
    {
        private string MaNhanVien;
        public FrmThemPhieuLuong(string MaNV)
        {
            MaNhanVien = MaNV;
            InitializeComponent();
        }

        private void FrmThemPhieuLuong_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PhieuLuongEntity pl = new PhieuLuongEntity();
           // pl.MaPhieuLuong = maLG;
            pl.MaNV = MaNhanVien;
            pl.LuongCoBan = txtLuongCoBan.Text;
            pl.HeSoLuong = txthsl.Text;
            pl.PhuCap = txtPhuCap.Text;
            pl.TienThuong = txtTienThuong.Text;
            pl.TongLinh = txtTongLinh.Text;
            pl.NgayLinh = dtNgayLinh.Value.ToString();
            PhieuLuongBus plg = new PhieuLuongBus();
            plg.Them(pl);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
