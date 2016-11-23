using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Entity
{
    class ChuyenMonEntity
    {
        private string _MaChuyenMon;

        public string MaChuyenMon
        {
            get { return _MaChuyenMon; }
            set { _MaChuyenMon = value; }
        }
        private string _TenChuyenMon;

        public string TenChuyenMon
        {
            get { return _TenChuyenMon; }
            set { _TenChuyenMon = value; }
        }
    }
}
