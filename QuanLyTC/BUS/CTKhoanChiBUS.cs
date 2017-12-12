using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
using QuanLyTC.DAO;
namespace QuanLyTC.BUS
{
    class CTKhoanChiBUS
    {
        CTKhoanChiDAO ctd = new CTKhoanChiDAO();

        public DataTable laydsctkctheomaND(int maND)
        {
            DataTable da = ctd.laydsctkctheomaND(maND);
            return da;
        }
        public DataTable timkiemtheongay(string ngay,int maND)
        {
            DataTable da = ctd.timkiemtheongay(ngay,maND);
            return da;
        }
        public DataTable timkiemtheothang(string thang, string nam, int maND)
        {
            DataTable da = ctd.timkiemtheothang(thang, nam, maND);
            return da;
        }
        public DataTable timkiemtheokhoangngay(string tungay, string denngay, int maND)
        {
            DataTable da = ctd.timkiemtheokhoangngay(tungay, denngay, maND);
            return da;
        }
        public bool themchitien(CTKhoanChiDTO ct)
        {
            bool kq = ctd.themchitien(ct);
            return kq;
        }
        public bool xoachitien(CTKhoanChiDTO ct)
        {
            bool kq = ctd.xoachitien(ct);
            return kq;
 
        }
    }
}
