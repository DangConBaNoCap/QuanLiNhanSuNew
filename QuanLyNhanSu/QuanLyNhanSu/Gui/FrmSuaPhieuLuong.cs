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
    public partial class FrmSuaPhieuLuong : Form
    {
        private string maLG;
        public FrmSuaPhieuLuong(string Mal)
        {
            maLG = Mal;
            InitializeComponent();
        }
        
           PhieuLuongBus pl = new PhieuLuongBus();
        private void FrmSuaPhieuLuong_Load(object sender, EventArgs e)
        {
            string dk = " where MaPhieuLuong =" + maLG;
            DataTable dt = pl.HienThi(dk);
            txtPL.Text = maLG;
            txtLuongCoBan.Text = dt.Rows[0][2].ToString();
            txthsl.Text=dt.Rows[0][3].ToString();
            txtPhuCap.Text=dt.Rows[0][5].ToString();
            txtTienThuong.Text=dt.Rows[0][4].ToString();
            txtTongLinh.Text=dt.Rows[0][6].ToString();
            dtNgayLinh.Value = DateTime.Parse(dt.Rows[0][7].ToString());

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PhieuLuongEntity pl = new PhieuLuongEntity();
            pl.MaPhieuLuong = maLG;
            pl.LuongCoBan = txtLuongCoBan.Text;
            pl.HeSoLuong = txthsl.Text;
            pl.PhuCap = txtPhuCap.Text;
            pl.TienThuong = txtTienThuong.Text;
            pl.TongLinh = txtTongLinh.Text;
            pl.NgayLinh = dtNgayLinh.Value.ToString();
            PhieuLuongBus plg = new PhieuLuongBus();
            plg.Sua(pl);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
