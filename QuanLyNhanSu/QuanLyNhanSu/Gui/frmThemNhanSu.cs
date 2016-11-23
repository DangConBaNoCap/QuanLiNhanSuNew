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
    public partial class frmThemNhanSu : Form
    {
        public frmThemNhanSu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmThemNhanSu_Load(object sender, EventArgs e)
        {
            PhongBanBus pb=new PhongBanBus();
            cboPhongBan.DataSource = pb.HienThi("");
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";


            ChucVuBus cv = new ChucVuBus();
            cboChucVu.DataSource = cv.HienThi("");
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";

            ChuyenMonBus cm = new ChuyenMonBus();
            cboChuyenMon.DataSource = cm.HienThi("");
            cboChuyenMon.DisplayMember = "TenChuyenMon";
            cboChuyenMon.ValueMember = "MaChuyenMon";
        }
        private void Them()
        {
            NhanVienEntity nv = new NhanVienEntity();
            nv.HoTen = txtTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.GhiChu = txtGhiChu.Text;
            nv.MaChucVu =cboChucVu.SelectedValue.ToString();
            nv.MaPB = cboPhongBan.SelectedValue.ToString();
            nv.MaChuyenMon = cboChuyenMon.SelectedValue.ToString();
            nv.NgaySinh = dtNgaySinh.Value.ToString();
            if (ckNam.Checked == true) nv.GioiTinh = "Nam";
            else
                nv.GioiTinh = "Nữ";
            NhanVienBus nhanv = new NhanVienBus();
            nhanv.Them(nv);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Them();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
