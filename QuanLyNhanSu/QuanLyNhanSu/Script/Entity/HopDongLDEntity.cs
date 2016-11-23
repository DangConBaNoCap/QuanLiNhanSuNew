using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Entity
{
    class HopDongLDEntity
    {
        private string _MaHD;

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private string _TenHD;

        public string TenHD
        {
            get { return _TenHD; }
            set { _TenHD = value; }
        }
        private string _LoaiHD;

        public string LoaiHD
        {
            get { return _LoaiHD; }
            set { _LoaiHD = value; }
        }
    }
}
