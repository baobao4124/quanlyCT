using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
namespace QuanLyTC.DAO
{
    class CTKhoanThuDAO
    {
        Connect con = new Connect();
        public DataTable laydsctkttheomaND(int maND)
        {
            string sql = "select ct.MaCTKT as 'Mã thu tiền',kt.TenKT as 'Tên KT',nd.TenND as 'Tên ND',ct.NgayThu as 'Ngày thu',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from CTKhoanThu ct,KhoanThu kt,NguoiDung nd where kt.MaKT = ct.MaKT and nd.MaND = ct.MaND and ct.MaND = '" + maND + "'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheongayTT(string ngay,int maND)
        {
            string sql = "select ct.NgayThu as 'Ngày thu',kt.TenKT as 'Tên KT',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from CTKhoanThu ct,KhoanThu kt,NguoiDung nd where kt.MaKT = ct.MaKT and nd.MaND = ct.MaND and ct.NgayThu = '" + ngay + "' and ct.MaND = '" + maND + "'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheothang(string thang,string nam,int maND)
        {
            string sql = "select ct.NgayThu as 'Ngày thu',kt.TenKT as 'Tên KT',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from CTKhoanThu ct,KhoanThu kt,NguoiDung nd where kt.MaKT = ct.MaKT and nd.MaND = ct.MaND and MONTH(ct.NgayThu) = '" + thang + "'and YEAR(ct.NgayThu) = '" + nam + "' and ct.MaND = '" + maND + "'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheokhoangngay(string tungay, string denngay, int maND)
        {
            string sql = "select ct.NgayThu as 'Ngày thu',kt.TenKT as 'Tên KT',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from CTKhoanThu ct,KhoanThu kt,NguoiDung nd where kt.MaKT = ct.MaKT and nd.MaND = ct.MaND and ct.NgayThu >= '" + tungay + "' and ct.NgayThu <= '" + denngay + "' and ct.MaND = '" + maND + "'";
            DataTable da = con.table(sql);
            return da;
        }
        public bool themthutien(CTKhoanThuDTO ct)
        {
            ct.MaCTKT = matutang();
            string sql = "insert into CTKhoanThu values('" + ct.MaCTKT + "',N'" + ct.MaKT + "',N'" + ct.MaND + "',N'" + ct.NgayThu + "','" + ct.SoTien + "',N'" + ct.MoTa + "')";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoathutien(CTKhoanThuDTO ct)
        {
            string sql = "delete from CTKhoanThu where MaCTKT='" + ct.MaCTKT + "'";
            bool kq = con.query(sql);
            return kq;
        }
        public int matutang()
        {
            string sql = "select*from CTKhoanThu ";
            DataTable da = con.table(sql);
            int ma = 1;
            for (int i = 0; i < da.Rows.Count; i++)
            {
                if (int.Parse(da.Rows[i][0].ToString()) != ma)
                {
                    return ma;
                }
                ma++;
            }
            return ma;
        }
    }
}
