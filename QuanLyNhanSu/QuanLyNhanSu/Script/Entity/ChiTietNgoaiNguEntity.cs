using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Entity
{
    class ChiTietNgoaiNguEntity
    {
        private string _MaNN;

        public string MaNN
        {
            get { return _MaNN; }
            set { _MaNN = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _ThoiGian;

        public string ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }
        private string _TrinhDo;

        public string TrinhDo
        {
            get { return _TrinhDo; }
            set { _TrinhDo = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
    }
}
