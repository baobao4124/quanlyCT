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
    public partial class ThemKhoanChi : Form
    {
        KhoanChiBUS kcb = new KhoanChiBUS();
        KhoanChiDTO kcd = new KhoanChiDTO();
        public ThemKhoanChi()
        {
            InitializeComponent();
        }

        private void ThemKhoanChi_Load(object sender, EventArgs e)
        {

        }
        private void themkhoanchi()
        {
            if (tbtenkckhoanchi.Text == "")
            {
                MessageBox.Show("Tên khoản chi không được bỏ trống");
                tbtenkckhoanchi.Focus();
            }
            else
            {
                kcd.TenKC = tbtenkckhoanchi.Text;
                DataTable da = kcb.kttrungten(kcd);
                if (da.Rows.Count > 0)
                {
                    MessageBox.Show("Khoản chi này đã tồn tại");
                    tbtenkckhoanchi.Focus();
                }
                else
                {
                    kcd.TenKC = tbtenkckhoanchi.Text;
                    kcd.MoTa = tbmotakhoanchi.Text;
                    bool kq = kcb.themkhoanchi(kcd);
                    if (kq == false)
                    {
                        MessageBox.Show("Thêm khoản chi thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Thêm khoản chi thành công");
                        this.Close();
                    }

                }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            themkhoanchi();
        }

    }
}
