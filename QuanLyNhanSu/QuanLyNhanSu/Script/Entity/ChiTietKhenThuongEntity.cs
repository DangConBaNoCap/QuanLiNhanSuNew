using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Entity
{
    class ChiTietKhenThuongEntity
    {
        private string _MaKT;

        public string MaKT
        {
            get { return _MaKT; }
            set { _MaKT = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _NgayKhenThuong;

        public string NgayKhenThuong
        {
            get { return _NgayKhenThuong; }
            set { _NgayKhenThuong = value; }
        }
        private string _TienKhenThuong;

        public string TienKhenThuong
        {
            get { return _TienKhenThuong; }
            set { _TienKhenThuong = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
