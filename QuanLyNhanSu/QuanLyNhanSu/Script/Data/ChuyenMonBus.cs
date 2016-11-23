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
    class ChuyenMonBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT  MaChuyenMon,TenChuyenMon FROM tblChuyenMon " + dk);
        }
        public void Them(ChuyenMonEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblChuyenMon(MaChuyenMon,TenChuyenMon) VALUES(@MaNN,@TenNN)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;

            cdm.Parameters.AddWithValue("@MaNN", tk.MaChuyenMon);
            cdm.Parameters.AddWithValue("@TenNN", tk.TenChuyenMon);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(ChuyenMonEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblChuyenMon SET TenChuyenMon=@TenNN Where MaChuyenMon=@MaNN";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;

            cdm.Parameters.AddWithValue("@MaNN", tk.MaChuyenMon);
            cdm.Parameters.AddWithValue("@TenNN", tk.TenChuyenMon);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(ChuyenMonEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblChuyenMon WHERE MaChuyenMon=@MaNN";
            SqlCommand cdm = new SqlCommand(sql, KetNoiCSDL.connect);
            cdm.Parameters.AddWithValue("@MaNN", tk.MaChuyenMon);
            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
