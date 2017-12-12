using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
namespace QuanLyTC.DAO
{
    class KhoanChiDAO
    {
        Connect con = new Connect();
        KhoanChiDTO kcd = new KhoanChiDTO();

        public DataTable laydskc()
        {
            string sql = "select MaKC as 'Mã KC',TenKC as 'Tên KC',MoTa as 'Mô Tả'from KhoanChi";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable kttrungten(KhoanChiDTO kc)
        {
            string sql = "select*from KhoanChi where TenKC='"+kc.TenKC+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public bool themkhoanchi(KhoanChiDTO kc)
        {
            kc.MaKC = matutang();
            string sql = "insert into KhoanChi values('"+kc.MaKC+"',N'"+kc.TenKC+"',N'"+kc.MoTa+"')";
            bool kq = con.query(sql);
            return kq;
        }
        public bool suakhoanchi(KhoanChiDTO kc)
        {
            string sql = "update KhoanChi set TenKC = N'"+kc.TenKC+"',MoTa = N'"+kc.MoTa+"'where MaKC = '"+kc.MaKC+"'";
            bool kq = con.query(sql);
            return kq;

        }
        public bool xoakhoanchi(KhoanChiDTO kc)
        {
            string sql = "delete from KhoanChi where MaKC='"+kc.MaKC+"'";
            bool kq = con.query(sql);
            return kq;
        }
        public int matutang()
        {
            string sql = "select*from KhoanChi";
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
