namespace QuanLyTC.GUI
{
    partial class ThemKhoanThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemKhoanThu));
            this.tbmotakhoanthu = new System.Windows.Forms.RichTextBox();
            this.tbtenktkhoanthu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bthuy = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // tbmotakhoanthu
            // 
            this.tbmotakhoanthu.Location = new System.Drawing.Point(120, 86);
            this.tbmotakhoanthu.Name = "tbmotakhoanthu";
            this.tbmotakhoanthu.Size = new System.Drawing.Size(150, 104);
            this.tbmotakhoanthu.TabIndex = 30;
            this.tbmotakhoanthu.Text = "";
            // 
            // tbtenktkhoanthu
            // 
            this.tbtenktkhoanthu.Location = new System.Drawing.Point(120, 41);
            this.tbtenktkhoanthu.Name = "tbtenktkhoanthu";
            this.tbtenktkhoanthu.Size = new System.Drawing.Size(150, 20);
            this.tbtenktkhoanthu.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mô Tả:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Tên Khoản Thu:";
            // 
            // bthuy
            // 
            this.bthuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.bthuy.Image = ((System.Drawing.Image)(resources.GetObject("bthuy.Image")));
            this.bthuy.Location = new System.Drawing.Point(170, 221);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(100, 50);
            this.bthuy.TabIndex = 32;
            this.bthuy.Text = "HỦY";
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.Location = new System.Drawing.Point(25, 221);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(100, 50);
            this.btluu.TabIndex = 31;
            this.btluu.Text = "LƯU";
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // ThemKhoanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(294, 310);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.tbmotakhoanthu);
            this.Controls.Add(this.tbtenktkhoanthu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThemKhoanThu";
            this.Text = "Thêm Khoản Thu";
            this.Load += new System.EventHandler(this.ThemKhoanThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bthuy;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private System.Windows.Forms.RichTextBox tbmotakhoanthu;
        private System.Windows.Forms.TextBox tbtenktkhoanthu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
    }
}