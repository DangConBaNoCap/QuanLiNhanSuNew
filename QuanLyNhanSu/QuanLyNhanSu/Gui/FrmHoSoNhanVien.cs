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
    public partial class FrmHoSoNhanVien : Form
    {
        private string MaNVien;
        private string MaHDong;
        public FrmHoSoNhanVien()
        {
            InitializeComponent();
        }
        ChiTietHopDongBus ct = new ChiTietHopDongBus();
        PhieuLuongBus pl = new PhieuLuongBus();
        KhenThuongBus kt = new KhenThuongBus();
        NgoaiNguBus nn = new NgoaiNguBus();
        private void LoadThongTinNhanVien()
        {
            NhanVienBus nv = new NhanVienBus();
            DataTable dt = nv.LayTenPBTheoNV(MaNVien);
            txtMaNV.Text = dt.Rows[0][0].ToString();
            txtTen.Text = dt.Rows[0][1].ToString();
            txtPhongBan.Text = dt.Rows[0][2].ToString();
            txtChucVu.Text = dt.Rows[0][3].ToString();
      
        }
        private void FrmHoSoNhanVien_Load(object sender, EventArgs e)
        {
            grdHopDong.DataSource = ct.HienThiTheoMaNV(MaNVien);
            grdPhieuLuong.DataSource = pl.HienThiTheoMaNV(MaNVien);
            string dk = " where MaNV=" + MaNVien;
            grdKhenThuong.DataSource = kt.HienThi(dk);
            grdNgoaiNgu.DataSource = nn.HienThi(dk);
            LoadThongTinNhanVien();
        }

        private void grdHopDong_Click(object sender, EventArgs e)
        {
            MaHDong = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
               try
            {
             
            ChiTietHopDongEntity ctp = new ChiTietHopDongEntity();
            ctp.MaHD = MaHDong; ctp.MaNV = MaNVien;       
            ct.Xoa(ctp);
            grdHopDong.DataSource = ct.HienThiTheoMaNV(MaNVien);
            }
               catch
               {
                   MessageBox.Show("Mời bạn chọn hợp đồng cần xóa");
               }
  
        }

        private void barBtbThemTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Sửa
            try
            {
                frmSuaHopDong frm = new frmSuaHopDong(MaNVien, MaHDong);
                frm.ShowDialog();
                grdHopDong.DataSource = ct.HienThiTheoMaNV(MaNVien);
            }
            catch
            {
                MessageBox.Show("Mời bạn chọn hợp đồng cần sửa");
            }
  
        }
        private string MaLuong;
        private void grdPhieuLuong_Click(object sender, EventArgs e)
        {
            MaLuong = gridView2.GetRowCellValue(gridView1.FocusedRowHandle, "MaPhieuLuong").ToString();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmSuaPhieuLuong frm = new FrmSuaPhieuLuong(MaLuong);
                frm.ShowDialog();
                grdPhieuLuong.DataSource = pl.HienThiTheoMaNV(MaNVien);
            }
            catch
            {
                MessageBox.Show("Mời bạn chọn phiếu lương cần sửa");
            }
        }

        private void barBtnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThemPhieuLuong frm = new FrmThemPhieuLuong(MaNVien);
            frm.ShowDialog();
            grdPhieuLuong.DataSource = pl.HienThiTheoMaNV(MaNVien);
        }

        private void barBtnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemHopDong frm = new frmThemHopDong(MaNVien);
            frm.ShowDialog();
            grdHopDong.DataSource = ct.HienThiTheoMaNV(MaNVien);

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
   
            try
            {

                PhieuLuongEntity pl = new PhieuLuongEntity();
                pl.MaPhieuLuong = MaLuong;
                PhieuLuongBus plg = new PhieuLuongBus();
                plg.Xoa(pl);
            }
            catch
            {
                MessageBox.Show("Mời bạn chọn phiếu lương cần xóa");
            }
        }
    }
}
