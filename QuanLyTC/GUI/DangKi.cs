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
    public partial class DangKi : Form
    {
        NguoiDungBUS ndb=new NguoiDungBUS();
        NguoiDungDTO ndd=new NguoiDungDTO();
        public DangKi()
        {
            InitializeComponent();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }
        private void luudangki()
        {
            if (tbtennguoidung.Text == "")
            {
                MessageBox.Show("Tên người dùng không được để trống");
                tbtennguoidung.Focus();
            }
            else
            {
                if (tbtendn.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập không được để trống");
                    tbtendn.Focus();
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
                        if (tbmatkhau.Text.Length < 3)
                        {
                            MessageBox.Show("Mật khẩu phải nhiều hơn 3 kí tự");
                            tbmatkhau.Focus();
                        }
                        else
                        {
                            if (tbnhaplaimk.Text == "")
                            {
                                MessageBox.Show("Nhập lại mật khẩu không được để trống");
                                tbnhaplaimk.Focus();
                            }
                            else
                            {
                                if (tbnhaplaimk.Text != tbmatkhau.Text)
                                {
                                    MessageBox.Show("Mật khẩu không giống nhau");
                                    tbnhaplaimk.Focus();
                                }
                                else
                                {
                                    if (tbdiachi.Text == "")
                                    {
                                        MessageBox.Show("Địa chỉ không được để trống");
                                        tbdiachi.Focus();
                                    }
                                    else
                                    {
                                        ndd.TenND = tbtennguoidung.Text;
                                        ndd.TenDN = tbtendn.Text;
                                        ndd.MatKhau = tbmatkhau.Text;
                                        ndd.NgaySinh = DateTime.Parse(dtpngaysinh.Text);
                                        ndd.GioiTinh = cbbgioitinh.Text;
                                        ndd.DiaChi = tbdiachi.Text;
                                        bool kq = ndb.themND(ndd);
                                        if (kq == false)
                                        {
                                            MessageBox.Show("Thêm người dùng thất bại");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Thêm người dùng thành công");
                                            this.Hide();
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            luudangki();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
