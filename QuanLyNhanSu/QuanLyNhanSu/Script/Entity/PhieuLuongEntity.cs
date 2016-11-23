using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Entity
{
    class PhieuLuongEntity
    {
        private string _MaPhieuLuong;

        public string MaPhieuLuong
        {
            get { return _MaPhieuLuong; }
            set { _MaPhieuLuong = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _LuongCoBan;

        public string LuongCoBan
        {
            get { return _LuongCoBan; }
            set { _LuongCoBan = value; }
        }
        private string _HeSoLuong;

        public string HeSoLuong
        {
            get { return _HeSoLuong; }
            set { _HeSoLuong = value; }
        }
        private string _TienThuong;

        public string TienThuong
        {
            get { return _TienThuong; }
            set { _TienThuong = value; }
        }
        private string _PhuCap;

        public string PhuCap
        {
            get { return _PhuCap; }
            set { _PhuCap = value; }
        }
        private string _TongLinh;

        public string TongLinh
        {
            get { return _TongLinh; }
            set { _TongLinh = value; }
        }
        private string _NgayLinh;

        public string NgayLinh
        {
            get { return _NgayLinh; }
            set { _NgayLinh = value; }
        }
    }
}
