using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Entity
{
 class ChiTietHopDongEntity
    {
        private string _MaHD;

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _NgayBatDau;

        public string NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }
        private string _NgayKetThuc;

        public string NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set { _NgayKetThuc = value; }
        }
        private string _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

    }
}
