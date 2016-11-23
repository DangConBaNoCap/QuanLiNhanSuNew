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
    class TaiKhoanBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT  TaiKhoan, MatKhau, MaNV FROM tblTaiKhoan "+ dk);
        }
        public void Them(TaiKhoanEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblTaiKhoan(TaiKhoan, MatKhau, MaNV) VALUES (@TaiKhoan,@MatKhau,@MaNV)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@TaiKhoan", tk.TaiKhoan);
            cdm.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
            cdm.Parameters.AddWithValue("@MaNV", tk.MaNV);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(TaiKhoanEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblTaiKhoan SET MatKhau =@MatKhau, TaiKhoan =@TaiKhoan Where MaNV=@MaNV";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@TaiKhoan", tk.TaiKhoan);
            cdm.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
            cdm.Parameters.AddWithValue("@MaNV", tk.MaNV);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(TaiKhoanEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblTaiKhoan WHERE MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("@MaNV", tk.MaNV);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }

    }
}
