namespace QuanLyTC.GUI
{
    partial class ThemChiTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemChiTien));
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbbkhoanchi = new System.Windows.Forms.ComboBox();
            this.dtpngaychi = new System.Windows.Forms.DateTimePicker();
            this.tbsotien = new System.Windows.Forms.TextBox();
            this.tbmota = new System.Windows.Forms.RichTextBox();
            this.bthuy = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mô Tả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số Tiền:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Ngày Chi:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(21, 34);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(81, 13);
            this.label25.TabIndex = 9;
            this.label25.Text = "Tên Khoản Chi:";
            // 
            // cbbkhoanchi
            // 
            this.cbbkhoanchi.FormattingEnabled = true;
            this.cbbkhoanchi.Location = new System.Drawing.Point(119, 31);
            this.cbbkhoanchi.Name = "cbbkhoanchi";
            this.cbbkhoanchi.Size = new System.Drawing.Size(150, 21);
            this.cbbkhoanchi.TabIndex = 17;
            // 
            // dtpngaychi
            // 
            this.dtpngaychi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaychi.Location = new System.Drawing.Point(119, 79);
            this.dtpngaychi.Name = "dtpngaychi";
            this.dtpngaychi.Size = new System.Drawing.Size(150, 20);
            this.dtpngaychi.TabIndex = 19;
            // 
            // tbsotien
            // 
            this.tbsotien.Location = new System.Drawing.Point(119, 123);
            this.tbsotien.Name = "tbsotien";
            this.tbsotien.Size = new System.Drawing.Size(150, 20);
            this.tbsotien.TabIndex = 20;
            // 
            // tbmota
            // 
            this.tbmota.Location = new System.Drawing.Point(119, 166);
            this.tbmota.Name = "tbmota";
            this.tbmota.Size = new System.Drawing.Size(150, 96);
            this.tbmota.TabIndex = 22;
            this.tbmota.Text = "";
            // 
            // bthuy
            // 
            this.bthuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.bthuy.Image = ((System.Drawing.Image)(resources.GetObject("bthuy.Image")));
            this.bthuy.Location = new System.Drawing.Point(169, 290);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(100, 50);
            this.bthuy.TabIndex = 24;
            this.bthuy.Text = "HỦY";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.Location = new System.Drawing.Point(24, 290);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(100, 50);
            this.btluu.TabIndex = 23;
            this.btluu.Text = "LƯU";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // ThemChiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 376);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.tbmota);
            this.Controls.Add(this.tbsotien);
            this.Controls.Add(this.dtpngaychi);
            this.Controls.Add(this.cbbkhoanchi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label25);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThemChiTien";
            this.Text = "Thêm Chi Tiền";
            this.Load += new System.EventHandler(this.ThemChiTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbbkhoanchi;
        private System.Windows.Forms.DateTimePicker dtpngaychi;
        private System.Windows.Forms.TextBox tbsotien;
        private System.Windows.Forms.RichTextBox tbmota;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private DevExpress.XtraEditors.SimpleButton bthuy;
    }
}