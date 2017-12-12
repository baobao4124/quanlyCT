using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DAO;
using QuanLyTC.DTO;
namespace QuanLyTC.BUS
{
    class CTKhoanThuBUS
    {
        CTKhoanThuDAO ctd = new CTKhoanThuDAO();

        public DataTable laydsctkttheomaND(int maND)
        {
            DataTable da = ctd.laydsctkttheomaND(maND);
            return da;
        }
        public DataTable timkiemtheongayTT(string ngay, int maND)
        {
            DataTable da = ctd.timkiemtheongayTT(ngay, maND);
            return da;

        }
        public DataTable timkiemtheothangTT(string thang, string nam, int maND)
        {
            DataTable da = ctd.timkiemtheothang(thang, nam, maND);
            return da;
        }
        public DataTable timkiemtheokhoangngayTT(string tungay, string denngay, int maND)
        {
            DataTable da = ctd.timkiemtheokhoangngay(tungay, denngay, maND);
            return da;
        }
        public bool themthutien(CTKhoanThuDTO ct)
        {
            bool kq = ctd.themthutien(ct);
            return kq;
        }
        public bool xoathutien(CTKhoanThuDTO ct)
        {
            bool kq = ctd.xoathutien(ct);
            return kq;

        }
    }
}
