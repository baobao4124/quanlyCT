namespace QuanLyTC.GUI
{
    partial class ThemThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemThuTien));
            this.tbmota = new System.Windows.Forms.RichTextBox();
            this.tbsotien = new System.Windows.Forms.TextBox();
            this.dtpngaythu = new System.Windows.Forms.DateTimePicker();
            this.cbbkhoanthu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.bthuy = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // tbmota
            // 
            this.tbmota.Location = new System.Drawing.Point(141, 163);
            this.tbmota.Name = "tbmota";
            this.tbmota.Size = new System.Drawing.Size(150, 96);
            this.tbmota.TabIndex = 34;
            this.tbmota.Text = "";
            // 
            // tbsotien
            // 
            this.tbsotien.Location = new System.Drawing.Point(141, 120);
            this.tbsotien.Name = "tbsotien";
            this.tbsotien.Size = new System.Drawing.Size(150, 20);
            this.tbsotien.TabIndex = 33;
            // 
            // dtpngaythu
            // 
            this.dtpngaythu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaythu.Location = new System.Drawing.Point(141, 76);
            this.dtpngaythu.Name = "dtpngaythu";
            this.dtpngaythu.Size = new System.Drawing.Size(150, 20);
            this.dtpngaythu.TabIndex = 32;
            // 
            // cbbkhoanthu
            // 
            this.cbbkhoanthu.FormattingEnabled = true;
            this.cbbkhoanthu.Location = new System.Drawing.Point(141, 31);
            this.cbbkhoanthu.Name = "cbbkhoanthu";
            this.cbbkhoanthu.Size = new System.Drawing.Size(150, 21);
            this.cbbkhoanthu.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mô Tả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Số Tiền:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(43, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Ngày Thu:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(43, 34);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 13);
            this.label25.TabIndex = 25;
            this.label25.Text = "Tên Khoản Thu:";
            // 
            // bthuy
            // 
            this.bthuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.bthuy.Image = ((System.Drawing.Image)(resources.GetObject("bthuy.Image")));
            this.bthuy.Location = new System.Drawing.Point(191, 295);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(100, 50);
            this.bthuy.TabIndex = 36;
            this.bthuy.Text = "HỦY";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.Location = new System.Drawing.Point(46, 295);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(100, 50);
            this.btluu.TabIndex = 35;
            this.btluu.Text = "LƯU";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // ThemThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 383);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.tbmota);
            this.Controls.Add(this.tbsotien);
            this.Controls.Add(this.dtpngaythu);
            this.Controls.Add(this.cbbkhoanthu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label25);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThemThuTien";
            this.Text = "Thêm Thu Tiền";
            this.Load += new System.EventHandler(this.ThemThuTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bthuy;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private System.Windows.Forms.RichTextBox tbmota;
        private System.Windows.Forms.TextBox tbsotien;
        private System.Windows.Forms.DateTimePicker dtpngaythu;
        private System.Windows.Forms.ComboBox cbbkhoanthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
    }
}