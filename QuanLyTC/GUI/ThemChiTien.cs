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

namespace QuanLyTC.GUI
{
    public partial class ThemChiTien : Form
    {
        CTKhoanChiBUS ctb = new CTKhoanChiBUS();
        CTKhoanChiDTO ctd = new CTKhoanChiDTO();
        KhoanChiBUS kcb = new KhoanChiBUS();
        int MaND;
        public ThemChiTien(int maND)
        {
            InitializeComponent();
            MaND = maND;
        }
        private void ThemChiTien_Load(object sender, EventArgs e)
        {
            duadskhoanchilencbb();
        }
        private void duadskhoanchilencbb()
        {
            DataTable da = kcb.laydskc();
            cbbkhoanchi.DataSource = da;
            cbbkhoanchi.ValueMember = "Mã KC";
            cbbkhoanchi.DisplayMember = "Tên KC";
        }
        
        private void themchitien()
        {
            if (tbsotien.Text == "")
            {
                MessageBox.Show("Số tiền không được để trống");
                tbsotien.Focus();
            }
            else
            {
                try
                {
                    float sotien = float.Parse(tbsotien.Text);
                    if (sotien < 0)
                    {
                        MessageBox.Show("Số tiền phải lớn hơn 0");
                        tbsotien.Focus();
                    }
                    else
                    {
                        ctd.MaKC = int.Parse(cbbkhoanchi.SelectedValue.ToString());
                        ctd.MaND = MaND;
                        ctd.NgayChi = DateTime.Parse(dtpngaychi.Text);
                        ctd.SoTien = float.Parse(tbsotien.Text);
                        ctd.MoTa = tbmota.Text;
                        bool kq = ctb.themchitien(ctd);
                        if (kq == false)
                        {
                            MessageBox.Show("Thêm chi tiền thất bại");
                        }
                        else
                        {
                            MessageBox.Show("Thêm chi tiền thành công");
                            this.Hide();
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Số tiền không đúng định dạng" + e);
                    tbsotien.Focus();
                }
            }

        }

        private void btluu_Click(object sender, EventArgs e)
        {
            themchitien();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       
    }
}
