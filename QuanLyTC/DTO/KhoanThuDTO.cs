using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTC.DTO
{
    class KhoanThuDTO
    {
        private int _MaKT;   
        private string _TenKT;
        private string _MoTa;     
        public int MaKT
        {
            get { return _MaKT; }
            set { _MaKT = value; }
        }
        public string TenKT
        {
            get { return _TenKT; }
            set { _TenKT = value; }
        }
        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        public KhoanThuDTO() { }
        public KhoanThuDTO(int MaKT,string TenKT,string MoTa) 
        {
            _MaKT = MaKT;
            _TenKT = TenKT;
            _MoTa = MoTa;
        }
             

    }
}
