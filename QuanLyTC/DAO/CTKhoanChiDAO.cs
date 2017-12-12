using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;

namespace QuanLyTC.DAO
{
    
    class CTKhoanChiDAO
    {
        Connect con = new Connect();
        public DataTable laydsctkctheomaND(int maND)
        {
            string sql = "select ct.MaCTKC as 'Mã chi tiền',kc.TenKC as 'Tên KC',nd.TenND as 'Tên ND',ct.NgayChi as 'Ngày chi',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả' from CTKhoanChi ct,KhoanChi kc,NguoiDung nd where kc.MaKC = ct.MaKC and nd.MaND = ct.MaND and ct.MaND = '" + maND + "'";
            DataTable da = con.table(sql);
            return da;
        }

        public DataTable timkiemtheongay(string ngay,int maND)
        {
            string sql = "select ct.NgayChi as 'Ngày Chi',kc.TenKC as 'Tên KC',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả'from CTKhoanChi ct,KhoanChi kc,NguoiDung nd where kc.MaKC = ct.MaKC and nd.MaND = ct.MaND and ct.MaND='"+maND+"' and ct.NgayChi ='"+ngay+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheothang(string thang,string nam,int maND)
        {
            string sql = "select ct.NgayChi as 'Ngày Chi',kc.TenKC as 'Tên KC',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả'from CTKhoanChi ct,KhoanChi kc,NguoiDung nd where kc.MaKC = ct.MaKC and nd.MaND = ct.MaND and ct.MaND='" + maND + "' and MONTH(ct.NgayChi)='"+thang+"' and YEAR(ct.NgayChi)='"+nam+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable timkiemtheokhoangngay(string tungay, string denngay, int maND)
        {
            string sql = "select ct.NgayChi as 'Ngày Chi',kc.TenKC as 'Tên KC',nd.TenND as 'Tên ND',ct.SoTien as 'Số tiền',ct.MoTa as 'Mô tả'from CTKhoanChi ct,KhoanChi kc,NguoiDung nd where kc.MaKC = ct.MaKC and nd.MaND = ct.MaND and ct.MaND='" + maND + "' and ct.NgayChi >= '"+tungay+"' and ct.NgayChi <= '"+denngay+"'";
            DataTable da = con.table(sql);
            return da;
        }


        public bool themchitien(CTKhoanChiDTO ct)
        {
            ct.MaCTKC = matutang();
            string sql = "insert into CTKhoanChi values('"+ct.MaCTKC+"',N'"+ct.MaKC+"',N'"+ct.MaND+"',N'"+ct.NgayChi+"','"+ct.SoTien+"',N'"+ct.MoTa+"')";
            bool kq = con.query(sql);
            return kq;
        }
        public bool xoachitien(CTKhoanChiDTO ct)
        {
            string sql = "delete from CTKhoanChi where MaCTKC='"+ct.MaCTKC+"'";
            bool kq = con.query(sql);
            return kq;
        }
        public int matutang()
        {
            string sql = "select*from CTKhoanChi ";
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
