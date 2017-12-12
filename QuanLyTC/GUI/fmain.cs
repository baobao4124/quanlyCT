using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTC.BUS;
using QuanLyTC.DTO;

namespace QuanLyTC
{
    public partial class fmain : Form
    {
        CTKhoanChiBUS ctkcb = new CTKhoanChiBUS();
        CTKhoanChiDTO ctkcd = new CTKhoanChiDTO();
        CTKhoanThuBUS ctktb = new CTKhoanThuBUS();
        CTKhoanThuDTO ctktd = new CTKhoanThuDTO();
        KhoanChiBUS kcb = new KhoanChiBUS();
        KhoanChiDTO kcd = new KhoanChiDTO();
        KhoanThuBUS ktb = new KhoanThuBUS();
        KhoanThuDTO ktd = new KhoanThuDTO();
        NguoiDungBUS ndb = new NguoiDungBUS();
        NguoiDungDTO ndd = new NguoiDungDTO();
        int MaND;
        public fmain(string maND)
        {
            InitializeComponent();
            MaND = int.Parse(maND);
            ndd.MaND = int.Parse(maND);
            duadsctkclendtgrv();
            duadsthutienlendtgrv();
            duadsNDlendtgrv();
            qltaikhoan();


        }

        private void fmain_Load(object sender, EventArgs e)
        {
            duadsKClendtgrv();
            duadsKTlendtgrv();
            duadstoanboNDlendtgrv();
        }
        private void btthemchitien_Click(object sender, EventArgs e)
        {
            GUI.ThemChiTien ct = new GUI.ThemChiTien(ndd.MaND);
            ct.Show();
        }
        private void duadsctkclendtgrv()
        {
            DataTable da = ctkcb.laydsctkctheomaND(ndd.MaND);
            dtgrvchitien.DataSource = da;
        }

        private void dtgrvchitien_Click(object sender, EventArgs e)
        {
            int idx = dtgrvchitien.CurrentRow.Index;
            lbkhoanchichitien.Text = dtgrvchitien.Rows[idx].Cells[1].Value.ToString();
            lbnguoichichitien.Text = dtgrvchitien.Rows[idx].Cells[2].Value.ToString();
            lbngaychichitien.Text = dtgrvchitien.Rows[idx].Cells[3].Value.ToString();
            lbsotienchitien.Text = dtgrvchitien.Rows[idx].Cells[4].Value.ToString() + "  VND";
            lbmotachitien.Text = dtgrvchitien.Rows[idx].Cells[5].Value.ToString();

        }

        private void btlammoichitien_Click(object sender, EventArgs e)
        {
            duadsctkclendtgrv();
        }
        private void xoachitien()
        {
            try
            {
                int idx = dtgrvchitien.CurrentRow.Index;
                ctkcd.MaCTKC = int.Parse(dtgrvchitien.Rows[idx].Cells[0].Value.ToString());
                bool kq = ctkcb.xoachitien(ctkcd);
                if (kq == false)
                {
                    MessageBox.Show("Xóa chi tiền thất bại");
                }
                else
                {
                    MessageBox.Show("Xóa chi tiền thành công");
                    duadsctkclendtgrv();
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa được");
            }
        }
        private void btxoachitien_Click(object sender, EventArgs e)
        {
            xoachitien();
        }

        private void duadsthutienlendtgrv()
        {
            DataTable da = ctktb.laydsctkttheomaND(ndd.MaND);
            dtgrvthutien.DataSource = da;
        }


        private void dtgrvthutien_Click(object sender, EventArgs e)
        {
            int idx = dtgrvthutien.CurrentRow.Index;
            lbkhoanthuthutien.Text = dtgrvthutien.Rows[idx].Cells[1].Value.ToString();
            lbnguoithuthutien.Text = dtgrvthutien.Rows[idx].Cells[2].Value.ToString();
            lbngaythuthutien.Text = dtgrvthutien.Rows[idx].Cells[3].Value.ToString();
            lbsotienthutien.Text = dtgrvthutien.Rows[idx].Cells[4].Value.ToString() + "  VND";
            lbmotathutien.Text = dtgrvthutien.Rows[idx].Cells[5].Value.ToString();
        }
        private void xoathutien()
        {
            try
            {
                int idx = dtgrvthutien.CurrentRow.Index;
                ctktd.MaCTKT = int.Parse(dtgrvthutien.Rows[idx].Cells[0].Value.ToString());
                bool kq = ctktb.xoathutien(ctktd);
                if (kq == false)
                {
                    MessageBox.Show("Xóa thu tiền thất bại");
                }
                else
                {
                    MessageBox.Show("Xóa thu tiền thành công");
                    duadsthutienlendtgrv();
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa được");
            }
        }
        private void btthemthutien_Click(object sender, EventArgs e)
        {
            GUI.ThemThuTien ttt = new GUI.ThemThuTien(ndd.MaND);
            ttt.Show();
        }

        private void btlammoithutien_Click(object sender, EventArgs e)
        {
            duadsthutienlendtgrv();
        }

        private void btxoathutien_Click(object sender, EventArgs e)
        {
            xoathutien();
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
            GUI.DangNhap dn = new GUI.DangNhap();
            dn.Show();
            this.Close();
        }

        #region khoản chi
        private void duadsKClendtgrv()
        {
            DataTable da = kcb.laydskc();
            dtgrvkhoanchi.DataSource = da;
        }

        private void dtgrvkhoanchi_Click(object sender, EventArgs e)
        {
            int idx = dtgrvkhoanchi.CurrentRow.Index;
            tbtenkckhoanchi.Text = dtgrvkhoanchi.Rows[idx].Cells[1].Value.ToString();
            tbmotakhoanchi.Text = dtgrvkhoanchi.Rows[idx].Cells[2].Value.ToString();
            tbtenkckhoanchi.Enabled = true;
            tbmotakhoanchi.Enabled = true;
        }

        private void suakhoanchi()
        {
            if (tbtenkckhoanchi.Text == "")
            {
                tbtenkckhoanchi.Enabled = false;
                tbmotakhoanchi.Enabled = false;
            }
            else
            {
                int idx = dtgrvkhoanchi.CurrentRow.Index;
                kcd.MaKC = int.Parse(dtgrvkhoanchi.Rows[idx].Cells[0].Value.ToString());
                kcd.TenKC = tbtenkckhoanchi.Text;
                kcd.MoTa = tbmotakhoanchi.Text;
                bool kq = kcb.suakhoanchi(kcd);
                if (kq == false)
                {
                    MessageBox.Show("Sửa khoản chi thất bại");
                }
                else
                {
                    MessageBox.Show("Sửa khoản chi thành công");
                    duadsKClendtgrv();
                }
            }
        }
        private void xoakhoanchi()
        {
            try
            {
                if (tbtenkckhoanchi.Text == "")
                {
                    tbtenkckhoanchi.Enabled = false;
                    tbmotakhoanchi.Enabled = false;
                }
                int idx = dtgrvkhoanchi.CurrentRow.Index;
                kcd.MaKC = int.Parse(dtgrvkhoanchi.Rows[idx].Cells[0].Value.ToString());
                bool kq = kcb.xoakhoanchi(kcd);
                if (kq == false)
                {
                    MessageBox.Show("Xóa khoản chi thất bại");
                }
                else
                {
                    MessageBox.Show("Xóa khoản chi thành công");
                    duadsKClendtgrv();
                }
            }
            catch
            {
                MessageBox.Show("Khoản chi đang được sử dụng , không thể xóa");
            }
        }
        private void btthemkhoanchi_Click(object sender, EventArgs e)
        {
            GUI.ThemKhoanChi kc = new GUI.ThemKhoanChi();
            kc.Show();
        }

        private void btsuakhoanchi_Click(object sender, EventArgs e)
        {
            suakhoanchi();
        }

        private void btxoakhoanchi_Click(object sender, EventArgs e)
        {
            xoakhoanchi();
        }

        private void btlammoiKC_Click(object sender, EventArgs e)
        {
            duadsKClendtgrv();
        }
        #endregion


        #region Khoản thu

        private void duadsKTlendtgrv()
        {
            DataTable da = ktb.laydskt();
            dtgrvkhoanthu.DataSource = da;
        }

        private void suakhoanthu()
        {
            if (tbtenktkhoanthu.Text == "")
            {
                tbtenktkhoanthu.Enabled = false;
                tbmotakhoanthu.Enabled = false;
            }
            else
            {
                int idx = dtgrvkhoanthu.CurrentRow.Index;
                kcd.MaKC = int.Parse(dtgrvkhoanthu.Rows[idx].Cells[0].Value.ToString());
                kcd.TenKC = tbtenktkhoanthu.Text;
                kcd.MoTa = tbmotakhoanthu.Text;
                bool kq = ktb.suakhoanthu(ktd);
                if (kq == false)
                {
                    MessageBox.Show("Sửa khoản thu thất bại");
                }
                else
                {
                    MessageBox.Show("Sửa khoản thu thành công");
                    duadsKTlendtgrv();
                }
            }
        }

        private void xoakhoanthu()
        {
            try
            {
                if (tbtenktkhoanthu.Text == "")
                {
                    tbtenktkhoanthu.Enabled = false;
                    tbmotakhoanthu.Enabled = false;
                }
                else
                {
                    int idx = dtgrvkhoanthu.CurrentRow.Index;
                    kcd.MaKC = int.Parse(dtgrvkhoanthu.Rows[idx].Cells[0].Value.ToString());
                    bool kq = ktb.xoakhoanthu(ktd);
                    if (kq == false)
                    {
                        MessageBox.Show("Xóa khoản thu thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Xóa khoản thu thành công");
                        duadsKTlendtgrv();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Khoản thu đang được sử dụng, không thể xóa");
            }
        }
        private void btthemkhoanthu_Click(object sender, EventArgs e)
        {
            GUI.ThemKhoanThu tk = new GUI.ThemKhoanThu();
            tk.Show();
        }

        private void btsuakhoanthu_Click(object sender, EventArgs e)
        {
            suakhoanthu();
        }

        private void btxoakhoanthu_Click(object sender, EventArgs e)
        {
            xoakhoanthu();
        }

        private void btlammoiKT_Click(object sender, EventArgs e)
        {
            duadsKTlendtgrv();
        }

        #endregion


        #region Người dùng

        private void duadsNDlendtgrv()
        {
            DataTable da = ndb.laydsndtheomaND(ndd.MaND);
            dtgrvtkcanhan.DataSource = da;
            lbtenndtkcanhan.Text = da.Rows[0][1].ToString();
            lbtendntkcanhan.Text = da.Rows[0][2].ToString();
            lbmatkhautkcanhan.Text = da.Rows[0][3].ToString();
            lbngaysinhtkcanhan.Text = da.Rows[0][4].ToString();
            lbgioitinhtkcanhan.Text = da.Rows[0][5].ToString();
            lbdiachitkcanhan.Text = da.Rows[0][6].ToString();
        }

        private void btsuatkcanhan_Click(object sender, EventArgs e)
        {
            GUI.SuaThongTinCaNhan sua = new GUI.SuaThongTinCaNhan(ndd.MaND);
            sua.Show();
        }

        private void btlammoicanhan_Click(object sender, EventArgs e)
        {
            duadsNDlendtgrv();
        }




        private void duadstoanboNDlendtgrv()
        {
            DataTable da = ndb.laydsnd();
            dtgrvqltaikhoan.DataSource = da;
        }

        private void dtgrvqltaikhoan_Click(object sender, EventArgs e)
        {
            int idx = dtgrvqltaikhoan.CurrentRow.Index;
            lbtenndqltaikhoan.Text = dtgrvqltaikhoan.Rows[idx].Cells[1].Value.ToString();
            lbtendnqltaikhoan.Text = dtgrvqltaikhoan.Rows[idx].Cells[2].Value.ToString();
            lbmatkhauqltaikhoan.Text = dtgrvqltaikhoan.Rows[idx].Cells[3].Value.ToString();
            lbngaysinhqltaikhoan.Text = dtgrvqltaikhoan.Rows[idx].Cells[4].Value.ToString();
            lbgioitinhqltaikhoan.Text = dtgrvqltaikhoan.Rows[idx].Cells[5].Value.ToString();
            lbdiachiqltaikhoan.Text = dtgrvqltaikhoan.Rows[idx].Cells[6].Value.ToString();
        }

        private void xoataikhoan()
        {
            try
            {
                int idx = dtgrvqltaikhoan.CurrentRow.Index;
                ndd.MaND = int.Parse(dtgrvqltaikhoan.Rows[idx].Cells[0].Value.ToString());
                bool kq = ndb.xoaND(ndd);
                if (kq == false)
                {
                    MessageBox.Show("Xóa người dùng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa người dùng thành công");
                    duadstoanboNDlendtgrv();
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản này đang được sử dụng,không thể xóa");
            }
        }

        private void btxoaqltaikhoan_Click(object sender, EventArgs e)
        {
            xoataikhoan();
        }
        private void qltaikhoan()
        {
            if (ndd.MaND == 1)
            {
                btxoaqltaikhoan.Visible = true;
                grbtaikhoan.Visible = true;
                grbcttaikhoan.Visible = true;
                lbthongbao.Text = "Chúc Bạn Có 1 Ngày Tốt Lành !";
            }
            else
            {
                lbthongbao.Text = "Chức năng này không khả dụng với tài khoản của bạn";
            }
        }


        #endregion

        private void dtgrvkhoanthu_Click(object sender, EventArgs e)
        {
            int idx = dtgrvkhoanthu.CurrentRow.Index;
            tbtenktkhoanthu.Text = dtgrvkhoanthu.Rows[idx].Cells[1].Value.ToString();
            tbmotakhoanthu.Text = dtgrvkhoanthu.Rows[idx].Cells[2].Value.ToString();
            tbtenktkhoanthu.Enabled = true;
            tbmotakhoanthu.Enabled = true;
        }

        #region Tìm kiếm
        private void timkiemtheongay()
        {
            string Ngay = dtpngayTK.Text;
            DataTable da = ctkcb.timkiemtheongay(Ngay, MaND);
            DataTable ds = ctktb.timkiemtheongayTT(Ngay, MaND);
            if (da.Rows.Count > 0)
            {
                dtgrvchitientimkiem.DataSource = da;
            }
            else
            {
                dtgrvchitientimkiem.DataSource = null;
                MessageBox.Show("Chi tiền không có dữ liệu");
            }
            if (ds.Rows.Count > 0)
            {
                dtgrvthutientimkiem.DataSource = ds;
            }
            else
            {
                dtgrvthutientimkiem.DataSource = null;
                MessageBox.Show("Thu tiền không có dữ liệu");
            }
        }

        private void bttimkiemtheongay_Click(object sender, EventArgs e)
        {
            timkiemtheongay();
            tiendu();
        }

        private void timkiemtheothang()
        {
           
            string thang = cbbthangTK.Text;
            string nam = tbnamTK.Text;
            if (int.Parse(thang) < 1 || int.Parse(thang) > 12)
            {
                MessageBox.Show("Tháng Phải có giá trị trong khoảng từ 1 đến 12");
                cbbthangTK.Focus();
            }
            else
            {
                if (int.Parse(nam) < 1900 || int.Parse(nam) > 2200)
                {
                    MessageBox.Show("Năm phải có giá trị trong khoảng 1900 đến 2200");
                    tbnamTK.Focus();
                }
                else
                {
                    DataTable da = ctkcb.timkiemtheothang(thang, nam, MaND);
                    DataTable ds = ctktb.timkiemtheothangTT(thang, nam, MaND);
                    if (da.Rows.Count > 0)
                    {
                        dtgrvchitientimkiem.DataSource = da;

                    }
                    else
                    {
                        dtgrvchitientimkiem.DataSource = null;
                        MessageBox.Show("Chi tiền không có dữ liệu");
                    }
                    if (ds.Rows.Count > 0)
                    {
                        dtgrvthutientimkiem.DataSource = ds;
                    }
                    else
                    {
                        dtgrvthutientimkiem.DataSource = null;
                        MessageBox.Show("Thu tiền không có dữ liệu");
                    }
                }
            }
        }
        private void bttimkiemtheothang_Click(object sender, EventArgs e)
        {
            timkiemtheothang();
            tiendu();

        }

        private void timkiemtheokhoangngay()
        {
            string tungay = dtptungayTK.Text;
            string denngay = dtpdenngayTK.Text;
            if (DateTime.Parse(tungay) > DateTime.Parse(denngay))
            {
                MessageBox.Show("'Từ ngày' phải có giá trị nhỏ hơn 'đến ngày'");
            }
            else
            {
                DataTable da = ctkcb.timkiemtheokhoangngay(tungay, denngay, MaND);
                DataTable ds = ctktb.timkiemtheokhoangngayTT(tungay, denngay, MaND);
                if (da.Rows.Count > 0)
                {
                    dtgrvchitientimkiem.DataSource = da;
                }
                else
                {
                    dtgrvchitientimkiem.DataSource = null;
                    MessageBox.Show("Chi tiền không có dữ liệu");
                }
                if (da.Rows.Count > 0)
                {
                    dtgrvthutientimkiem.DataSource = ds;
                }
                else
                {
                    dtgrvthutientimkiem.DataSource = null;
                    MessageBox.Show("Thu tiền không có dữ liệu");
                }
            }

        }


        private void bttimkiemtheokc_Click(object sender, EventArgs e)
        {
            timkiemtheokhoangngay();
            tiendu();
        }

        private void tiendu()
        {
            float tongtienchi = 0;
            float tongtienthu = 0;
            float tiendu = 0;
                for (int i = 0; i < dtgrvchitientimkiem.Rows.Count -1; i++)
                {
                    tongtienchi += float.Parse(dtgrvchitientimkiem.Rows[i].Cells[3].Value.ToString());
                }
                for (int i = 0; i < dtgrvthutientimkiem.Rows.Count-1 ; i++)
                {
                    tongtienthu += float.Parse(dtgrvthutientimkiem.Rows[i].Cells[3].Value.ToString());
                }
            
                tiendu = tongtienthu - tongtienchi;
                lbtongtienchi.Text = tongtienchi.ToString() + "  VND";
                lbtongtienthu.Text = tongtienthu.ToString() + "  VND";
                lbtongtiendu.Text = tiendu.ToString() + "  VND";
            
          

        }
        #endregion

        private void btlammoiall_Click(object sender, EventArgs e)
        {
            duadsctkclendtgrv();
            duadsthutienlendtgrv();
            duadsNDlendtgrv();
            duadsKClendtgrv();
            duadsKTlendtgrv();
            duadstoanboNDlendtgrv();
        }

    }
}
