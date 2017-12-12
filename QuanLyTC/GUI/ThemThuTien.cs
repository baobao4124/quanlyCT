using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTC.DTO;
using QuanLyTC.BUS;

namespace QuanLyTC.GUI
{
    public partial class ThemThuTien : Form
    {
        CTKhoanThuBUS ctb = new CTKhoanThuBUS();
        CTKhoanThuDTO ctd = new CTKhoanThuDTO();
        KhoanThuBUS ktb = new KhoanThuBUS();
        int MaND;
        public ThemThuTien(int maND)
        {
            InitializeComponent();
            MaND = maND;
        }

        private void ThemThuTien_Load(object sender, EventArgs e)
        {
            duadskhoathulencbb();
        }
        private void duadskhoathulencbb()
        {
            DataTable da = ktb.laydskt();
            cbbkhoanthu.DataSource = da;
            cbbkhoanthu.ValueMember = "Mã KT";
            cbbkhoanthu.DisplayMember = "Tên KT";
        }
        private void themthutien()
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
                        ctd.MaKT = int.Parse(cbbkhoanthu.SelectedValue.ToString());
                        ctd.MaND = MaND; 
                            //int.Parse(label1.Text);
                        ctd.NgayThu = DateTime.Parse(dtpngaythu.Text);
                        ctd.SoTien = float.Parse(tbsotien.Text);
                        ctd.MoTa = tbmota.Text;
                        bool kq = ctb.themthutien(ctd);
                        if (kq == false)
                        {
                            MessageBox.Show("Thêm thu tiền thất bại");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thu tiền thành công");
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
            themthutien();
            this.Hide();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
