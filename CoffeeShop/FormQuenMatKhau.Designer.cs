namespace CoffeeShopManagement
{
    partial class FormQuenMatKhau
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bXacNhan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btGuiOTP = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tbOTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 86);
            this.label1.TabIndex = 113;
            this.label1.Text = "LẤY LẠI MẬT KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bXacNhan
            // 
            this.bXacNhan.Animated = true;
            this.bXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.bXacNhan.BorderRadius = 15;
            this.bXacNhan.CheckedState.Parent = this.bXacNhan;
            this.bXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bXacNhan.CustomImages.Parent = this.bXacNhan;
            this.bXacNhan.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bXacNhan.FillColor2 = System.Drawing.Color.Teal;
            this.bXacNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXacNhan.ForeColor = System.Drawing.Color.White;
            this.bXacNhan.HoverState.Parent = this.bXacNhan;
            this.bXacNhan.Location = new System.Drawing.Point(401, 203);
            this.bXacNhan.Name = "bXacNhan";
            this.bXacNhan.ShadowDecoration.Parent = this.bXacNhan;
            this.bXacNhan.Size = new System.Drawing.Size(107, 47);
            this.bXacNhan.TabIndex = 138;
            this.bXacNhan.Text = "Xác nhận";
            this.bXacNhan.Click += new System.EventHandler(this.BXacNhan_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Animated = true;
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.BorderRadius = 20;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.Transparent;
            this.bCancel.FillColor2 = System.Drawing.Color.Transparent;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(2, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(76, 61);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "THOÁT";
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.guna2ShadowPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 86);
            this.panel1.TabIndex = 141;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.bCancel);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(485, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(79, 64);
            this.guna2ShadowPanel1.TabIndex = 132;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.AutoScroll = true;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.bXacNhan);
            this.guna2GroupBox1.Controls.Add(this.lbTime);
            this.guna2GroupBox1.Controls.Add(this.btGuiOTP);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.tbOTP);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.tbEmail);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 123);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(552, 300);
            this.guna2GroupBox1.TabIndex = 142;
            this.guna2GroupBox1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(36, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 19);
            this.label2.TabIndex = 141;
            this.label2.Text = "Mã OTP chỉ có hiệu lực khi còn mở yêu cầu này và thời gian chờ > 0";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTime.Location = new System.Drawing.Point(485, 112);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(59, 28);
            this.lbTime.TabIndex = 140;
            this.lbTime.Text = "(60s)";
            this.lbTime.Visible = false;
            // 
            // btGuiOTP
            // 
            this.btGuiOTP.Animated = true;
            this.btGuiOTP.BackColor = System.Drawing.Color.Transparent;
            this.btGuiOTP.BorderRadius = 15;
            this.btGuiOTP.CheckedState.Parent = this.btGuiOTP;
            this.btGuiOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuiOTP.CustomImages.Parent = this.btGuiOTP;
            this.btGuiOTP.FillColor = System.Drawing.Color.Purple;
            this.btGuiOTP.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btGuiOTP.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btGuiOTP.ForeColor = System.Drawing.Color.White;
            this.btGuiOTP.HoverState.Parent = this.btGuiOTP;
            this.btGuiOTP.Location = new System.Drawing.Point(401, 107);
            this.btGuiOTP.Name = "btGuiOTP";
            this.btGuiOTP.ShadowDecoration.Parent = this.btGuiOTP;
            this.btGuiOTP.Size = new System.Drawing.Size(83, 40);
            this.btGuiOTP.TabIndex = 139;
            this.btGuiOTP.Text = "Gửi mã OTP";
            this.btGuiOTP.Click += new System.EventHandler(this.BtGuiOTP_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(10, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Mã OTP (2)";
            // 
            // tbOTP
            // 
            this.tbOTP.Animated = true;
            this.tbOTP.BackColor = System.Drawing.Color.Transparent;
            this.tbOTP.BorderColor = System.Drawing.Color.Bisque;
            this.tbOTP.BorderRadius = 5;
            this.tbOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOTP.DefaultText = "";
            this.tbOTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOTP.DisabledState.Parent = this.tbOTP;
            this.tbOTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOTP.FillColor = System.Drawing.Color.Ivory;
            this.tbOTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbOTP.FocusedState.Parent = this.tbOTP;
            this.tbOTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbOTP.ForeColor = System.Drawing.Color.Black;
            this.tbOTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbOTP.HoverState.Parent = this.tbOTP;
            this.tbOTP.IconLeft = global::CoffeeShopManagement.Properties.Resources.password;
            this.tbOTP.Location = new System.Drawing.Point(14, 203);
            this.tbOTP.Margin = new System.Windows.Forms.Padding(2);
            this.tbOTP.Name = "tbOTP";
            this.tbOTP.PasswordChar = '\0';
            this.tbOTP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbOTP.PlaceholderText = "";
            this.tbOTP.SelectedText = "";
            this.tbOTP.ShadowDecoration.Parent = this.tbOTP;
            this.tbOTP.Size = new System.Drawing.Size(382, 47);
            this.tbOTP.TabIndex = 13;
            this.tbOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbOTP_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email (1)";
            // 
            // tbEmail
            // 
            this.tbEmail.Animated = true;
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.BorderColor = System.Drawing.Color.Bisque;
            this.tbEmail.BorderRadius = 5;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FillColor = System.Drawing.Color.Ivory;
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.IconLeft = global::CoffeeShopManagement.Properties.Resources.user;
            this.tbEmail.Location = new System.Drawing.Point(14, 106);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(382, 47);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuenMatKhau";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuenMatKhau_FormClosed);
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected Guna.UI2.WinForms.Guna2GradientButton bXacNhan;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTime;
        protected Guna.UI2.WinForms.Guna2GradientButton btGuiOTP;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox tbOTP;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
    }
}