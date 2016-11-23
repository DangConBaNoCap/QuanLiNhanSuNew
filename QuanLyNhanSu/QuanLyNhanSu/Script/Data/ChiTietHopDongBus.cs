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
    class ChiTietHopDongBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT MaHD, MaNV,NgayBatDau,NgayKetThuc,GhiChu FROM tblChiTietHopDong " + dk);
        }
        public void Them(ChiTietHopDongEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblChiTietHopDong(MaHD, MaNV,NgayBatDau,NgayKetThuc,GhiChu) VALUES(@MaPB,@TenPB,@DiaDiem,@SDT,@GhiChu)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaPB", pb.MaHD);
            cdm.Parameters.AddWithValue("@TenPB", pb.MaNV);
            cdm.Parameters.AddWithValue("@DiaDiem", pb.NgayBatDau);
            cdm.Parameters.AddWithValue("@SDT", pb.NgayKetThuc);
            cdm.Parameters.AddWithValue("@GhiChu", pb.GhiChu);
            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(ChiTietHopDongEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblPhongBan SET NgayBatDau =@NgayBatDau, NgayKetThuc =@NgayKetThuc, GhiChu =@GhiChu Where MaHD=@MaHD and MaNV=@MaNV";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@NgayBatDau", pb.NgayBatDau);
            cdm.Parameters.AddWithValue("@NgayKetThuc", pb.NgayKetThuc);
            cdm.Parameters.AddWithValue("@GhiChu", pb.GhiChu);
            cdm.Parameters.AddWithValue("@MaHD", pb.MaHD);
            cdm.Parameters.AddWithValue("@MaNV", pb.MaNV);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(ChiTietHopDongEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblPhongBan WHERE MaHD=@MaHD and MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("@MaHD", pb.MaHD);
            cmd.Parameters.AddWithValue("@MaNV", pb.MaNV);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
