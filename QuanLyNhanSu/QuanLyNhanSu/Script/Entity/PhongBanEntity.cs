using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Entity
{
    class PhongBanEntity
    {
        private string _MaPB;

        public string MaPB
        {
            get { return _MaPB; }
            set { _MaPB = value; }
        }
        private string _TenPB;

        public string TenPB
        {
            get { return _TenPB; }
            set { _TenPB = value; }
        }
        private string _DiaDiem;

        public string DiaDiem
        {
            get { return _DiaDiem; }
            set { _DiaDiem = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
    }
}
