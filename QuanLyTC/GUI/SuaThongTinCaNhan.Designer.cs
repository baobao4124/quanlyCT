namespace QuanLyTC.GUI
{
    partial class SuaThongTinCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaThongTinCaNhan));
            this.label26 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbtennguoidung = new System.Windows.Forms.TextBox();
            this.tbtendn = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbbgioitinh = new System.Windows.Forms.ComboBox();
            this.bthuy = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(39, 271);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Giới Tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ngày Sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Mật Khẩu :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Tên Đăng Nhập:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(39, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Tên Người Dùng:";
            // 
            // tbtennguoidung
            // 
            this.tbtennguoidung.Location = new System.Drawing.Point(171, 35);
            this.tbtennguoidung.Name = "tbtennguoidung";
            this.tbtennguoidung.Size = new System.Drawing.Size(150, 20);
            this.tbtennguoidung.TabIndex = 17;
            // 
            // tbtendn
            // 
            this.tbtendn.Location = new System.Drawing.Point(171, 83);
            this.tbtendn.Name = "tbtendn";
            this.tbtendn.Size = new System.Drawing.Size(150, 20);
            this.tbtendn.TabIndex = 18;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(171, 129);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(150, 20);
            this.tbmatkhau.TabIndex = 19;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(171, 268);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(150, 20);
            this.tbdiachi.TabIndex = 22;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(171, 173);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(150, 20);
            this.dtpngaysinh.TabIndex = 23;
            // 
            // cbbgioitinh
            // 
            this.cbbgioitinh.FormattingEnabled = true;
            this.cbbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbgioitinh.Location = new System.Drawing.Point(171, 219);
            this.cbbgioitinh.Name = "cbbgioitinh";
            this.cbbgioitinh.Size = new System.Drawing.Size(150, 21);
            this.cbbgioitinh.TabIndex = 24;
            // 
            // bthuy
            // 
            this.bthuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.bthuy.Image = ((System.Drawing.Image)(resources.GetObject("bthuy.Image")));
            this.bthuy.Location = new System.Drawing.Point(201, 317);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(120, 50);
            this.bthuy.TabIndex = 38;
            this.bthuy.Text = "HỦY";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.Location = new System.Drawing.Point(42, 317);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(120, 50);
            this.btluu.TabIndex = 37;
            this.btluu.Text = "LƯU";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // SuaThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 400);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.cbbgioitinh);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.tbdiachi);
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
            this.MaximizeBox = false;
            this.Name = "SuaThongTinCaNhan";
            this.Text = "Sửa Thông Tin Cá Nhân";
            this.Load += new System.EventHandler(this.SuaThongTinCaNhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbtennguoidung;
        private System.Windows.Forms.TextBox tbtendn;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.ComboBox cbbgioitinh;
        private DevExpress.XtraEditors.SimpleButton bthuy;
        private DevExpress.XtraEditors.SimpleButton btluu;
    }
}