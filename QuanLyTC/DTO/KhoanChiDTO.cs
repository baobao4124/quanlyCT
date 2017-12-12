using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTC.DTO
{
    class KhoanChiDTO
    {
        private int _MaKC;
        private string _TenKC; 
        private string _MoTa;
        public int MaKC
        {
            get { return _MaKC; }
            set { _MaKC = value; }
        }
        public string TenKC
        {
            get { return _TenKC; }
            set { _TenKC = value; }
        }
        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        public KhoanChiDTO() { }
        public KhoanChiDTO(int MaKC,string TenKC,string MoTa)
        {
            _MaKC = MaKC;
            _TenKC = TenKC;
            _MoTa = MoTa;
        }
    }
}
