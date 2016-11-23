using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Entity
{
    class NgoaiNguEntity
    {
        private string _MaNN;

        public string MaNN
        {
            get { return _MaNN; }
            set { _MaNN = value; }
        }
        private string _TenNN;

        public string TenNN
        {
            get { return _TenNN; }
            set { _TenNN = value; }
        }
    }
}
