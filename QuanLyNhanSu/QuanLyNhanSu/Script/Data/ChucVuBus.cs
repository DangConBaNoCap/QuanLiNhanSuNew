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
    class ChucVuBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT  MaChucVu, TenChucVu, PhuCap FROM tblTaiKhoan " + dk);
        }
        public void Them(ChucVuEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblTaiKhoan(MaChucVu, TenChucVu, PhuCap) VALUES (@TaiKhoan,@MatKhau,@MaNV)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@TaiKhoan", tk.MaChucVu);
            cdm.Parameters.AddWithValue("@MatKhau", tk.TenChucVu);
            cdm.Parameters.AddWithValue("@MaNV", tk.PhuCap);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(ChucVuEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblTaiKhoan SET TenChucVu =@MatKhau, PhuCap =@TaiKhoan Where MaChucVu=@MaNV";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@TaiKhoan", tk.PhuCap);
            cdm.Parameters.AddWithValue("@MatKhau", tk.TenChucVu);
            cdm.Parameters.AddWithValue("@MaNV", tk.MaChucVu);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(ChucVuEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblChucVu WHERE MaChucVu=@MaNV";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("@MaNV", tk.MaChucVu);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
