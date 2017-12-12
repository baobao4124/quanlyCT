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
    public partial class SuaThongTinCaNhan : Form
    {
        NguoiDungBUS ndb = new NguoiDungBUS();
        NguoiDungDTO ndd = new NguoiDungDTO();
        int MaND;
        public SuaThongTinCaNhan(int maND)
        {
            InitializeComponent();
            MaND = maND;
            xemthongtinND();
        }


        private void SuaThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void xemthongtinND()
        {
             DataTable da = ndb.laydsndtheomaND(MaND);
             tbtennguoidung.Text = da.Rows[0][1].ToString();
             tbtendn.Text = da.Rows[0][2].ToString();
             tbmatkhau.Text = da.Rows[0][3].ToString();
             dtpngaysinh.Text = da.Rows[0][4].ToString();
             cbbgioitinh.Text = da.Rows[0][5].ToString();
             tbdiachi.Text = da.Rows[0][6].ToString();
        }
        private void luusuaTT()
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
                            if (tbdiachi.Text == "")
                            {
                                MessageBox.Show("Địa chỉ không được để trống");
                                tbdiachi.Focus();
                            }
                            else
                            {
                                ndd.MaND = MaND;
                                ndd.TenND = tbtennguoidung.Text;
                                ndd.TenDN = tbtendn.Text;
                                ndd.MatKhau = tbmatkhau.Text;
                                ndd.NgaySinh = DateTime.Parse(dtpngaysinh.Text);
                                ndd.GioiTinh = cbbgioitinh.Text;
                                ndd.DiaChi = tbdiachi.Text;
                                bool kq = ndb.suaND(ndd);
                                if (kq == false)
                                {
                                    MessageBox.Show("Sửa người dùng thất bại");
                                }
                                else
                                {
                                    MessageBox.Show("Sửa người dùng thành công");
                                    this.Close();
                                    
                                }

                            }
                        }
                    }
                }
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            luusuaTT();

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



    }
}
