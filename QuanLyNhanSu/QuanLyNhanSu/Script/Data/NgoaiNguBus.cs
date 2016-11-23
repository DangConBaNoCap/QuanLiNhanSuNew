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
    class NgoaiNguBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT  MaNN,TenNN FROM tblNgoaiNgu " + dk);
        }
        public void Them(NgoaiNguEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblNgoaiNgu(MaNN,TenNN) VALUES (@MaNN,@TenNN)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
         
            cdm.Parameters.AddWithValue("@MaNN", tk.MaNN);
            cdm.Parameters.AddWithValue("@TenNN", tk.TenNN);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(NgoaiNguEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblNgoaiNgu SET TenNN =@TenNN Where MaNN=@MaNN";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;

            cdm.Parameters.AddWithValue("@MaNN", tk.MaNN);
            cdm.Parameters.AddWithValue("@TenNN", tk.TenNN);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(NgoaiNguEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblNgoaiNgu WHERE MaNN=@MaNN";
            SqlCommand cdm = new SqlCommand(sql, KetNoiCSDL.connect);
            cdm.Parameters.AddWithValue("@MaNN", tk.MaNN);
            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
