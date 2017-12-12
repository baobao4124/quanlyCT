namespace QuanLyTC.GUI
{
    partial class ThemKhoanChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemKhoanChi));
            this.tbmotakhoanchi = new System.Windows.Forms.RichTextBox();
            this.tbtenkckhoanchi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bthuy = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // tbmotakhoanchi
            // 
            this.tbmotakhoanchi.Location = new System.Drawing.Point(119, 85);
            this.tbmotakhoanchi.Name = "tbmotakhoanchi";
            this.tbmotakhoanchi.Size = new System.Drawing.Size(150, 104);
            this.tbmotakhoanchi.TabIndex = 14;
            this.tbmotakhoanchi.Text = "";
            // 
            // tbtenkckhoanchi
            // 
            this.tbtenkckhoanchi.Location = new System.Drawing.Point(119, 40);
            this.tbtenkckhoanchi.Name = "tbtenkckhoanchi";
            this.tbtenkckhoanchi.Size = new System.Drawing.Size(150, 20);
            this.tbtenkckhoanchi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mô Tả:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Tên Khoản Chi:";
            // 
            // bthuy
            // 
            this.bthuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.bthuy.Image = ((System.Drawing.Image)(resources.GetObject("bthuy.Image")));
            this.bthuy.Location = new System.Drawing.Point(169, 220);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(100, 50);
            this.bthuy.TabIndex = 26;
            this.bthuy.Text = "HỦY";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.Location = new System.Drawing.Point(24, 220);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(100, 50);
            this.btluu.TabIndex = 25;
            this.btluu.Text = "LƯU";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // ThemKhoanChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(290, 312);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.tbmotakhoanchi);
            this.Controls.Add(this.tbtenkckhoanchi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThemKhoanChi";
            this.Text = "Thêm Khoản Chi";
            this.Load += new System.EventHandler(this.ThemKhoanChi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbmotakhoanchi;
        private System.Windows.Forms.TextBox tbtenkckhoanchi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.SimpleButton bthuy;
        private DevExpress.XtraEditors.SimpleButton btluu;
    }
}