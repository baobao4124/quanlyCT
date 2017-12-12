using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyTC.DTO;
namespace QuanLyTC.DAO
{
    class KhoanThuDAO
    {
        Connect con = new Connect();
        public DataTable laydskt()
        {
            string sql = "select MaKT as 'Mã KT',TenKT as 'Tên KT',MoTa as 'Mô Tả'from KhoanThu";
            DataTable da = con.table(sql);
            return da;
        }
        public DataTable kttenkhoanthu(KhoanThuDTO kt)
        {
            string sql = "select*from KhoanThu where TenKT = '"+kt.TenKT+"'";
            DataTable da = con.table(sql);
            return da;
        }
        public bool themkhoanthu(KhoanThuDTO kt)
        {
            kt.MaKT = matutang();
            string sql = "insert into KhoanThu values('" + kt.MaKT+ "',N'" + kt.TenKT + "',N'" + kt.MoTa + "')";
            bool kq = con.query(sql);
            return kq;
        }
        public bool suakhoanthu(KhoanThuDTO kt)
        {
            string sql = "update KhoanThu set TenKT = N'" + kt.TenKT + "',MoTa = N'" + kt.MoTa + "' where MaKT = '"+kt.MaKT+"'";
            bool kq = con.query(sql);
            return kq;

        }
        public bool xoakhoanthu(KhoanThuDTO kt)
        {
            string sql = "delete from KhoanThu where MaKt = '" + kt.MaKT + "'";
            bool kq = con.query(sql);
            return kq;
        }
        public int matutang()
        {
            string sql = "select*from KhoanThu";
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
