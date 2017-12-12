namespace QuanLyTC.GUI
{
    partial class DangKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKi));
            this.cbbgioitinh = new System.Windows.Forms.ComboBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbnhaplaimk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.tbtendn = new System.Windows.Forms.TextBox();
            this.tbtennguoidung = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.bthuy = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cbbgioitinh
            // 
            this.cbbgioitinh.FormattingEnabled = true;
            this.cbbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbgioitinh.Location = new System.Drawing.Point(162, 264);
            this.cbbgioitinh.Name = "cbbgioitinh";
            this.cbbgioitinh.Size = new System.Drawing.Size(150, 21);
            this.cbbgioitinh.TabIndex = 52;
            this.cbbgioitinh.Text = "Nam";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(162, 218);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(150, 20);
            this.dtpngaysinh.TabIndex = 51;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(162, 313);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(150, 20);
            this.tbdiachi.TabIndex = 50;
            // 
            // tbnhaplaimk
            // 
            this.tbnhaplaimk.Location = new System.Drawing.Point(162, 172);
            this.tbnhaplaimk.Name = "tbnhaplaimk";
            this.tbnhaplaimk.Size = new System.Drawing.Size(150, 20);
            this.tbnhaplaimk.TabIndex = 49;
            this.tbnhaplaimk.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nhập Lại Mật Khẩu :";
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(162, 127);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(150, 20);
            this.tbmatkhau.TabIndex = 47;
            this.tbmatkhau.UseSystemPasswordChar = true;
            // 
            // tbtendn
            // 
            this.tbtendn.Location = new System.Drawing.Point(162, 81);
            this.tbtendn.Name = "tbtendn";
            this.tbtendn.Size = new System.Drawing.Size(150, 20);
            this.tbtendn.TabIndex = 46;
            // 
            // tbtennguoidung
            // 
            this.tbtennguoidung.Location = new System.Drawing.Point(162, 33);
            this.tbtennguoidung.Name = "tbtennguoidung";
            this.tbtennguoidung.Size = new System.Drawing.Size(150, 20);
            this.tbtennguoidung.TabIndex = 45;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(30, 316);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 44;
            this.label26.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Giới Tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Ngày Sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Mật Khẩu :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Tên Đăng Nhập:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(30, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Tên Người Dùng:";
            // 
            // bthuy
            // 
            this.bthuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.bthuy.Image = ((System.Drawing.Image)(resources.GetObject("bthuy.Image")));
            this.bthuy.Location = new System.Drawing.Point(192, 350);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(120, 50);
            this.bthuy.TabIndex = 54;
            this.bthuy.Text = "HỦY";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.Location = new System.Drawing.Point(33, 350);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(120, 50);
            this.btluu.TabIndex = 53;
            this.btluu.Text = "LƯU";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 433);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.cbbgioitinh);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.tbnhaplaimk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtendn);
            this.Controls.Add(this.tbtennguoidung);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangKi";
            this.Text = "Đăng Kí tài Khoản";
            this.Load += new System.EventHandler(this.DangKi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bthuy;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private System.Windows.Forms.ComboBox cbbgioitinh;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.TextBox tbnhaplaimk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.TextBox tbtendn;
        private System.Windows.Forms.TextBox tbtennguoidung;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
    }
}