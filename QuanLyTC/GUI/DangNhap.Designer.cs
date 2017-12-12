namespace QuanLyTC.GUI
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.lbdangki = new System.Windows.Forms.LinkLabel();
            this.tbtaikhoan = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btdangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Quản Lý Tài Chính Cá Nhân";
            // 
            // lbdangki
            // 
            this.lbdangki.AutoSize = true;
            this.lbdangki.BackColor = System.Drawing.Color.Transparent;
            this.lbdangki.Location = new System.Drawing.Point(69, 360);
            this.lbdangki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdangki.Name = "lbdangki";
            this.lbdangki.Size = new System.Drawing.Size(155, 15);
            this.lbdangki.TabIndex = 1;
            this.lbdangki.TabStop = true;
            this.lbdangki.Text = "Đăng Kí Tài Khoản Mới";
            this.lbdangki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbdangki_LinkClicked);
            // 
            // tbtaikhoan
            // 
            this.tbtaikhoan.Location = new System.Drawing.Point(201, 121);
            this.tbtaikhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbtaikhoan.Name = "tbtaikhoan";
            this.tbtaikhoan.Size = new System.Drawing.Size(150, 21);
            this.tbtaikhoan.TabIndex = 3;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(201, 196);
            this.tbmatkhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(150, 21);
            this.tbmatkhau.TabIndex = 6;
            this.tbmatkhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Image = global::QuanLyTC.Properties.Resources._1454431661_lock;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(68, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "       Mật Khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Image = global::QuanLyTC.Properties.Resources._1456012516_user;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(64, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "       Tài Khoản:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btthoat
            // 
            this.btthoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btthoat.Image = global::QuanLyTC.Properties.Resources._1454431048_Log_Out1;
            this.btthoat.Location = new System.Drawing.Point(221, 274);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(130, 50);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "THOÁT";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btdangnhap.Image = global::QuanLyTC.Properties.Resources._1454431003_preferences_desktop_cryptography;
            this.btdangnhap.Location = new System.Drawing.Point(72, 274);
            this.btdangnhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(130, 50);
            this.btdangnhap.TabIndex = 2;
            this.btdangnhap.Text = "ĐĂNG NHẬP";
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            this.btdangnhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btdangnhap_KeyDown);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 408);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtaikhoan);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.lbdangki);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbdangki;
        private DevExpress.XtraEditors.SimpleButton btdangnhap;
        private System.Windows.Forms.TextBox tbtaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmatkhau;
        private DevExpress.XtraEditors.SimpleButton btthoat;
    }
}