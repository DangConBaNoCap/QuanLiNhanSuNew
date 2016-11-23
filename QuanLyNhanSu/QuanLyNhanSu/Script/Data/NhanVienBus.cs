using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Entity;

namespace QuanLyNhanSu.Data
{
    class NhanVienBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, MaPB, MaChucVu, MaChuyenMon, GhiChu FROM  tblNhanVien " + dk);
        }
        public void Them(NhanVienEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblNhanVien(MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, MaPB, MaChucVu, MaChuyenMon, GhiChu) VALUES(@MaNV,@HoTen,@GioiTinh,@NgaySinh,@DiaChi,@MaPB,@MaChucVu,@MaChuyenMon,@GhiChu)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaNV", pb.MaNV);
            cdm.Parameters.AddWithValue("@HoTen", pb.HoTen);
            cdm.Parameters.AddWithValue("@GioiTinh", pb.GioiTinh);
            cdm.Parameters.AddWithValue("@NgaySinh", pb.NgaySinh);
            cdm.Parameters.AddWithValue("@MaPB", pb.MaPB);
            cdm.Parameters.AddWithValue("@DiaChi", pb.DiaChi);
            cdm.Parameters.AddWithValue("@MaChucVu", pb.MaChucVu);
            cdm.Parameters.AddWithValue("@MaChuyenMon", pb.MaChuyenMon);
            cdm.Parameters.AddWithValue("@GhiChu", pb.GhiChu);
            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(NhanVienEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE  tblNhanVien SET  HoTen =@HoTen, GioiTinh =@GioiTinh, NgaySinh =@NgaySinh, DiaChi =@DiaChi, MaPB =@MaPB, MaChucVu =@MaChucVu, MaChuyenMon =@MaChuyenMon, GhiChu =@GhiChu Where MaNV=@MaNV";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaNV", pb.MaNV);
            cdm.Parameters.AddWithValue("@HoTen", pb.HoTen);
            cdm.Parameters.AddWithValue("@GioiTinh", pb.GioiTinh);
            cdm.Parameters.AddWithValue("@NgaySinh", pb.NgaySinh);
            cdm.Parameters.AddWithValue("@MaPB", pb.MaPB);
            cdm.Parameters.AddWithValue("@DiaChi", pb.DiaChi);
            cdm.Parameters.AddWithValue("@MaChucVu", pb.MaChucVu);
            cdm.Parameters.AddWithValue("@MaChuyenMon", pb.MaChuyenMon);
            cdm.Parameters.AddWithValue("@GhiChu", pb.GhiChu);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(NhanVienEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblNhanVien WHERE MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("@MaNV", pb.MaNV);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public DataTable HienThiDanhSach(string dk)
        {
            string sql=@"SELECT tblNhanVien.MaNV, tblNhanVien.HoTen, tblNhanVien.GioiTinh, tblNhanVien.NgaySinh, tblNhanVien.GhiChu,"+ 
                "tblNhanVien.DiaChi, tblPhongBan.TenPB, tblChucVu.TenChucVu, tblChuyenMon.TenChuyenMon "+
                 "FROM tblNhanVien INNER JOIN tblChuyenMon ON tblNhanVien.MaChuyenMon = tblChuyenMon.MaChuyenMon "+
                 "INNER JOIN tblChucVu ON tblNhanVien.MaChucVu = tblChucVu.MaChucVu INNER JOIN tblPhongBan ON tblNhanVien.MaPB = tblPhongBan.MaPB " +dk;
            return con.GetDataTable(sql);
        }
        public DataTable HienThiDS(string dk)
        {
            string sql = @"SELECT tblNhanVien.MaNV,tblNhanVien.HoTen, tblHopDongLD.TenHD, tblChuyenMon.TenChuyenMon," +
                "tblChucVu.TenChucVu, tblPhongBan.TenPB FROM tblNhanVien INNER JOIN tblChucVu " +
                "ON tblNhanVien.MaChucVu = tblChucVu.MaChucVu INNER JOIN tblChuyenMon " +
                "ON tblNhanVien.MaChuyenMon = tblChuyenMon.MaChuyenMon INNER JOIN tblChiTietHopDong ON " +
                "tblNhanVien.MaNV = tblChiTietHopDong.MaNV INNER JOIN tblHopDongLD ON " +
            "tblChiTietHopDong.MaHD = tblHopDongLD.MaHD INNER JOIN tblPhongBan ON tblNhanVien.MaPB = tblPhongBan.MaPB " + dk;
            return con.GetDataTable(sql);
        }
    }
}
