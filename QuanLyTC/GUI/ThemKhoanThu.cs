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
    public partial class ThemKhoanThu : Form
    {
        KhoanThuBUS ktb = new KhoanThuBUS();
        KhoanThuDTO ktd = new KhoanThuDTO();
        public ThemKhoanThu()
        {
            InitializeComponent();
        }

        private void ThemKhoanThu_Load(object sender, EventArgs e)
        {

        }
        private void themkhoanthu()
        {
            if (tbtenktkhoanthu.Text == "")
            {
                MessageBox.Show("Tên khoản thu không được bỏ trống");
                tbtenktkhoanthu.Focus();
            }
            else
            {
                ktd.TenKT = tbtenktkhoanthu.Text;
                DataTable da = ktb.kttenkhoanthu(ktd);
                if (da.Rows.Count > 0)
                {
                    MessageBox.Show("Khoản thu này đã tồn tại");
                    tbtenktkhoanthu.Focus();
                }
                else
                {
                    ktd.TenKT = tbtenktkhoanthu.Text;
                    ktd.MoTa = tbmotakhoanthu.Text;
                    bool kq = ktb.themkhoanthu(ktd);
                    if (kq == false)
                    {
                        MessageBox.Show("Thêm khoản thu thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Thêm khoản thu thành công");
                        this.Close();
                    }

                }
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            themkhoanthu();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
