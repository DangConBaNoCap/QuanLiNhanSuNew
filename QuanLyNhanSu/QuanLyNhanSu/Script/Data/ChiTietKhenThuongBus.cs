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
    class ChiTietKhenThuongBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT MaKT, MaNV,NgayKhenThuong,TienKhenThuong,GhiChu FROM tblChiTietKhenThuong " + dk);
        }
        public void Them(ChiTietKhenThuongEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblChiTietKhenThuong(MaKT, MaNV,NgayKhenThuong,TienKhenThuong,GhiChu) VALUES(@MaPB,@TenPB,@DiaDiem,@SDT,@GhiChu)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaPB", pb.MaKT);
            cdm.Parameters.AddWithValue("@TenPB", pb.MaNV);
            cdm.Parameters.AddWithValue("@DiaDiem", pb.NgayKhenThuong);
            cdm.Parameters.AddWithValue("@SDT", pb.TienKhenThuong);
            cdm.Parameters.AddWithValue("@GhiChu", pb.GhiChu);
            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(ChiTietKhenThuongEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblChiTietKhenThuong SET NgayKhenThuong =@NgayBatDau, TienKhenThuong =@NgayKetThuc, GhiChu =@GhiChu Where MaKT=@MaHD and MaNV=@MaNV";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@NgayBatDau", pb.NgayKhenThuong);
            cdm.Parameters.AddWithValue("@NgayKetThuc", pb.TienKhenThuong);
            cdm.Parameters.AddWithValue("@GhiChu", pb.GhiChu);
            cdm.Parameters.AddWithValue("@MaHD", pb.MaKT);
            cdm.Parameters.AddWithValue("@MaNV", pb.MaNV);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(ChiTietKhenThuongEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblChiTietKhenThuong WHERE MaKT=@MaHD and MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("@MaHD", pb.MaKT);
            cmd.Parameters.AddWithValue("@MaNV", pb.MaNV);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
