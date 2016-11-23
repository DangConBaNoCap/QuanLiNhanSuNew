using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyNhanSu.Entity;

namespace QuanLyNhanSu.Data
{
    class PhongBanBus
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable HienThi(string dk)
        {
            return con.GetDataTable("SELECT MaPB, TenPB, DiaDiem, SDT FROM tblPhongBan " + dk);
        }
        public void Them(PhongBanEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"INSERT INTO tblPhongBan (MaPB, TenPB, DiaDiem, SDT) VALUES(@MaPB,@TenPB,@DiaDiem,@SDT)";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaPB",pb.MaPB);
            cdm.Parameters.AddWithValue("@TenPB", pb.TenPB);
            cdm.Parameters.AddWithValue("@DiaDiem", pb.DiaDiem);
            cdm.Parameters.AddWithValue("@SDT",pb.SDT);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Sua(PhongBanEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string themhd = @"UPDATE tblPhongBan SET TenPB =@TenPB, DiaDiem =@DiaDiem, SDT =@SDT Where MaPB=@MaPB";
            SqlCommand cdm = new SqlCommand(themhd, KetNoiCSDL.connect);
            // cdm.CommandType = CommandType.StoredProcedure;
            cdm.Parameters.AddWithValue("@MaPB", pb.MaPB);
            cdm.Parameters.AddWithValue("@TenPB", pb.TenPB);
            cdm.Parameters.AddWithValue("@DiaDiem", pb.DiaDiem);
            cdm.Parameters.AddWithValue("@SDT", pb.SDT);

            cdm.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
        public void Xoa(PhongBanEntity pb)
        {
            KetNoiCSDL.MoKetNoi();
            string sql = @"DELETE tblPhongBan WHERE MaPB=@MaPB";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("@MaPB", pb.MaPB);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.DongKetNoi();
        }
    }
}
