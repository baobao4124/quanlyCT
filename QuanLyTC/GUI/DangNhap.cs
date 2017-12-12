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
    public partial class DangNhap : Form
    {
        NguoiDungBUS ndb = new NguoiDungBUS();
        NguoiDungDTO ndd = new NguoiDungDTO();
        public DangNhap()
        {
            InitializeComponent();
        }
        private void dangnhap()
        {
            if (tbtaikhoan.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
                tbtaikhoan.Focus();
            }
            else
            {
                if (tbmatkhau.Text == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống");
                    tbmatkhau.Focus();
                }
                else
                {
                    ndd.TenDN = tbtaikhoan.Text;
                    ndd.MatKhau = tbmatkhau.Text;
                    DataTable da = ndb.laydsnddangnhap(ndd);
                    if (da.Rows.Count > 0)
                    {
                        fmain fm = new fmain(da.Rows[0][0].ToString());
                        fm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                        tbmatkhau.Focus();
                    }
                }
            }
        
        }
       
        private void btdangnhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void btdangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangnhap();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbdangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKi dk = new DangKi();
            dk.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
