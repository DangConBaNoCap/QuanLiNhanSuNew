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
    class KhenThuongBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT  MaKT,TenKT FROM tblKhenThuong " + dk);
        }
        public void Them(KhenThuongEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblKhenThuong(MaKT,TenKT) VALUES(@MaNN,@TenNN)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;

            cdm.Parameters.AddWithValue("@MaNN", tk.MaKT);
            cdm.Parameters.AddWithValue("@TenNN", tk.TenKT);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(KhenThuongEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblKhenThuong SET TenKT =@TenNN Where MaNN=@MaNN";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;

            cdm.Parameters.AddWithValue("@MaNN", tk.MaKT);
            cdm.Parameters.AddWithValue("@TenNN", tk.TenKT);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(KhenThuongEntity tk)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblKhenThuong WHERE MaKT=@MaNN";
            SqlCommand cdm = new SqlCommand(sql, KetNoiCSDL.connect);
            cdm.Parameters.AddWithValue("@MaNN", tk.MaKT);
            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
