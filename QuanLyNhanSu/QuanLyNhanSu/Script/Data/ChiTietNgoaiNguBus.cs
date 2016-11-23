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
    class ChiTietNgoaiNguBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT MaNN, MaNV,ThoiGian,TrinhDo,GhiChu FROM tblChiTietNgoaiNgu " + dk);
        }
        public void Them(ChiTietNgoaiNguEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblChiTietNgoaiNgu(MaNN, MaNV,ThoiGian,TrinhDo,GhiChu) VALUES(@MaPB,@TenPB,@DiaDiem,@SDT,@GhiChu)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaPB", pb.MaNN);
            cdm.Parameters.AddWithValue("@TenPB", pb.MaNV);
            cdm.Parameters.AddWithValue("@DiaDiem", pb.ThoiGian);
            cdm.Parameters.AddWithValue("@SDT", pb.TrinhDo);
            cdm.Parameters.AddWithValue("@GhiChu", pb.GhiChu);
            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(ChiTietNgoaiNguEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblChiTietNgoaiNgu SET ThoiGian =@ThoiGian, TrinhDo =@TrinhDo, GhiChu =@GhiChu Where MaNN=@MaNN and MaNV=@MaNV";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@ThoiGian", pb.ThoiGian);
            cdm.Parameters.AddWithValue("@TrinhDo", pb.TrinhDo);
            cdm.Parameters.AddWithValue("@GhiChu", pb.GhiChu);
            cdm.Parameters.AddWithValue("@MaNN", pb.MaNN);
            cdm.Parameters.AddWithValue("@MaNV", pb.MaNV);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(ChiTietNgoaiNguEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblChiTietNgoaiNgu WHERE MaNN=@MaNN and MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("@MaNN", pb.MaNN);
            cmd.Parameters.AddWithValue("@MaNV", pb.MaNV);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
