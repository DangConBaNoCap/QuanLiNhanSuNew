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
    public partial class frmDanhsachNhansu : Form
    {
        public frmDanhsachNhansu()
        {
            InitializeComponent();
        }
        NhanVienBus busnv = new NhanVienBus();
        NhanVienEntity ennv = new NhanVienEntity();
        private void frmDanhsachNhansu_Load(object sender, EventArgs e)
        {
            dgvNhanvien.DataSource = busnv.HienThiDanhSach("");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string dk = txtTim.Text.ToString();

            if (cboDanhmuc.SelectedItem.ToString() == "Họ tên")
            {
                if (dk == string.Empty) dgvNhanvien.DataSource = busnv.HienThiDanhSach("");
                else dgvNhanvien.DataSource = busnv.HienThiDanhSach(" where HoTen like N'%" + dk.Trim() + "%'");
            }
            if (cboDanhmuc.SelectedItem.ToString() == "Chức vụ")
            {
                 if(dk == string.Empty) dgvNhanvien.DataSource = busnv.HienThiDanhSach("");
                else dgvNhanvien.DataSource = busnv.HienThiDanhSach(" where TenChucVu like N'%" + dk.Trim() + "%'");
            }
            if (cboDanhmuc.SelectedItem.ToString() == "Chuyên môn")
            {
                if (dk == string.Empty) dgvNhanvien.DataSource = busnv.HienThiDanhSach("");
                else dgvNhanvien.DataSource = busnv.HienThiDanhSach(" where TenChuyenMon like N'%" + dk.Trim() + "%'");
            }
            if (cboDanhmuc.SelectedItem.ToString() == "Phòng ban")
            {
                if (dk == string.Empty) dgvNhanvien.DataSource = busnv.HienThiDanhSach("");
                else dgvNhanvien.DataSource = busnv.HienThiDanhSach(" where TenPB like N'%" + dk.Trim() + "%'");
            }
        }




        string MaXoa;
        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaXoa = dgvNhanvien.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ennv.MaNV = MaXoa;
            busnv.Xoa(ennv);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
