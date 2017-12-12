using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyTC.DTO
{
    class CTKhoanThuDTO
    {
         private int _MaCTKT;
        private int _MaKT;      
        private int _MaND;    
        private DateTime _NgayThu;    
        private float _SoTien;     
        private string _MoTa;
        public int MaCTKT
        {
            get { return _MaCTKT; }
            set { _MaCTKT = value; }
        }
        public int MaKT
        {
            get { return _MaKT; }
            set { _MaKT = value; }
        }
        public int MaND
        {
            get { return _MaND; }
            set { _MaND = value; }
        }
        public DateTime NgayThu
        {
            get { return _NgayThu; }
            set { _NgayThu = value; }
        }
        public float SoTien
        {
            get { return _SoTien; }
            set { _SoTien = value; }
        }
        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

        public CTKhoanThuDTO() { }
        public CTKhoanThuDTO(int MaCTKT,int MaKT,int MaND,DateTime NgayThu,float SoTien,string MoTa) 
        {
            _MaCTKT = MaCTKT;
            _MaKT = MaKT;
            _MaND = MaND;
            _NgayThu = NgayThu;
            _SoTien = SoTien;
            _MoTa = MoTa;
        }

    }
}
