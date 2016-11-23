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
    class PhieuLuongBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT MaPhieuLuong, MaNV, LuongCoBan, HeSoLuong, TienThuong, PhuCap, TongLinh, NgayLinh FROM tblPhieuLuong " + dk);
        }
        public void Them(PhieuLuongEntity pl)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblPhieuLuong(MaPhieuLuong, MaNV, LuongCoBan, HeSoLuong, TienThuong, PhuCap, TongLinh, NgayLinh) VALUES(@MaPhieuLuong,@MaNV,@LuongCoBan,@HeSoLuong,@TienThuong,@PhuCap,@TongLinh,@NgayLinh)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaPhieuLuong", pl.MaPhieuLuong);
            cdm.Parameters.AddWithValue("@MaNV", pl.MaNV);
            cdm.Parameters.AddWithValue("@LuongCoBan", pl.LuongCoBan);
            cdm.Parameters.AddWithValue("@HeSoLuong", pl.HeSoLuong);
            cdm.Parameters.AddWithValue("@TienThuong", pl.TienThuong);
            cdm.Parameters.AddWithValue("@PhuCap", pl.PhuCap);
            cdm.Parameters.AddWithValue("@TongLinh", pl.TongLinh);
            cdm.Parameters.AddWithValue("@NgayLinh", pl.NgayLinh);
           

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(PhieuLuongEntity pl )
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblPhieuLuong SET  MaNV =@MaNV, LuongCoBan =@LuongCoBan, HeSoLuong =@HeSoLuong, TienThuong =@TienThuong, PhuCap =@PhuCap, TongLinh =@TongLinh, NgayLinh =@NgayLinh WHERE MaPhieuLuong=@MaPhieuLuong";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaNV", pl.MaNV);
            cdm.Parameters.AddWithValue("@LuongCoBan", pl.LuongCoBan);
            cdm.Parameters.AddWithValue("@HeSoLuong", pl.HeSoLuong);
            cdm.Parameters.AddWithValue("@TienThuong", pl.TienThuong);
            cdm.Parameters.AddWithValue("@PhuCap", pl.PhuCap);
            cdm.Parameters.AddWithValue("@TongLinh", pl.TongLinh);
            cdm.Parameters.AddWithValue("@NgayLinh", pl.NgayLinh);
            cdm.Parameters.AddWithValue("@MaPhieuLuong", pl.MaPhieuLuong);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(PhieuLuongEntity pl)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblPhieuLuong WHERE MaPhieuLuong=@MaPhieuLuong";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("@MaPhieuLuong", pl.MaPhieuLuong);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
