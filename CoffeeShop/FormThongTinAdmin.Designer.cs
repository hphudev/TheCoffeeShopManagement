namespace CoffeeShopManagement
{
    partial class FormThongTinAdmin
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
            this.bOk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btThayDoiEmail = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btThayDoiMK = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label1.Size = new System.Drawing.Size(601, 86);
            this.label1.TabIndex = 113;
            this.label1.Text = "THÔNG TIN ADMIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bOk
            // 
            this.bOk.Animated = true;
            this.bOk.BackColor = System.Drawing.Color.Transparent;
            this.bOk.BorderRadius = 15;
            this.bOk.CheckedState.Parent = this.bOk;
            this.bOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOk.CustomImages.Parent = this.bOk;
            this.bOk.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bOk.FillColor2 = System.Drawing.Color.Teal;
            this.bOk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bOk.ForeColor = System.Drawing.Color.White;
            this.bOk.HoverState.Parent = this.bOk;
            this.bOk.Location = new System.Drawing.Point(478, 409);
            this.bOk.Name = "bOk";
            this.bOk.ShadowDecoration.Parent = this.bOk;
            this.bOk.Size = new System.Drawing.Size(107, 47);
            this.bOk.TabIndex = 138;
            this.bOk.Text = "OK";
            this.bOk.Click += new System.EventHandler(this.BOk_Click);
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
            this.panel1.Size = new System.Drawing.Size(601, 86);
            this.panel1.TabIndex = 139;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.bCancel);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(511, 12);
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
            this.guna2GroupBox1.Controls.Add(this.btThayDoiEmail);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.btThayDoiMK);
            this.guna2GroupBox1.Controls.Add(this.tbEmail);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.tbMatKhau);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 104);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(573, 299);
            this.guna2GroupBox1.TabIndex = 140;
            this.guna2GroupBox1.Text = "Thông tin quán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(407, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 164;
            this.label2.Text = "Thay đổi";
            // 
            // btThayDoiEmail
            // 
            this.btThayDoiEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThayDoiEmail.Animated = true;
            this.btThayDoiEmail.AutoRoundedCorners = true;
            this.btThayDoiEmail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btThayDoiEmail.CheckedState.BorderRadius = 10;
            this.btThayDoiEmail.CheckedState.FillColor = System.Drawing.Color.Brown;
            this.btThayDoiEmail.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btThayDoiEmail.CheckedState.InnerBorderRadius = 6;
            this.btThayDoiEmail.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btThayDoiEmail.CheckedState.Parent = this.btThayDoiEmail;
            this.btThayDoiEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThayDoiEmail.Location = new System.Drawing.Point(501, 176);
            this.btThayDoiEmail.Name = "btThayDoiEmail";
            this.btThayDoiEmail.ShadowDecoration.Parent = this.btThayDoiEmail;
            this.btThayDoiEmail.Size = new System.Drawing.Size(50, 22);
            this.btThayDoiEmail.TabIndex = 163;
            this.btThayDoiEmail.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btThayDoiEmail.UncheckedState.BorderRadius = 10;
            this.btThayDoiEmail.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btThayDoiEmail.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btThayDoiEmail.UncheckedState.InnerBorderRadius = 6;
            this.btThayDoiEmail.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.btThayDoiEmail.UncheckedState.Parent = this.btThayDoiEmail;
            this.btThayDoiEmail.CheckedChanged += new System.EventHandler(this.BtThayDoiEmail_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(407, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 162;
            this.label6.Text = "Thay đổi";
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
            this.label12.Size = new System.Drawing.Size(54, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Email";
            // 
            // btThayDoiMK
            // 
            this.btThayDoiMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThayDoiMK.Animated = true;
            this.btThayDoiMK.AutoRoundedCorners = true;
            this.btThayDoiMK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btThayDoiMK.CheckedState.BorderRadius = 10;
            this.btThayDoiMK.CheckedState.FillColor = System.Drawing.Color.Brown;
            this.btThayDoiMK.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btThayDoiMK.CheckedState.InnerBorderRadius = 6;
            this.btThayDoiMK.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btThayDoiMK.CheckedState.Parent = this.btThayDoiMK;
            this.btThayDoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThayDoiMK.Location = new System.Drawing.Point(501, 70);
            this.btThayDoiMK.Name = "btThayDoiMK";
            this.btThayDoiMK.ShadowDecoration.Parent = this.btThayDoiMK;
            this.btThayDoiMK.Size = new System.Drawing.Size(50, 22);
            this.btThayDoiMK.TabIndex = 161;
            this.btThayDoiMK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btThayDoiMK.UncheckedState.BorderRadius = 10;
            this.btThayDoiMK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btThayDoiMK.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btThayDoiMK.UncheckedState.InnerBorderRadius = 6;
            this.btThayDoiMK.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.btThayDoiMK.UncheckedState.Parent = this.btThayDoiMK;
            this.btThayDoiMK.CheckedChanged += new System.EventHandler(this.BtThayDoiMK_CheckedChanged);
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
            this.tbEmail.IconLeft = global::CoffeeShopManagement.Properties.Resources.email;
            this.tbEmail.Location = new System.Drawing.Point(14, 203);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(537, 47);
            this.tbEmail.TabIndex = 13;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mật khẩu";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Animated = true;
            this.tbMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.tbMatKhau.BorderColor = System.Drawing.Color.Bisque;
            this.tbMatKhau.BorderRadius = 5;
            this.tbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMatKhau.DefaultText = "";
            this.tbMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.DisabledState.Parent = this.tbMatKhau;
            this.tbMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.FillColor = System.Drawing.Color.Ivory;
            this.tbMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbMatKhau.FocusedState.Parent = this.tbMatKhau;
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbMatKhau.ForeColor = System.Drawing.Color.Black;
            this.tbMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhau.HoverState.Parent = this.tbMatKhau;
            this.tbMatKhau.IconLeft = global::CoffeeShopManagement.Properties.Resources.password;
            this.tbMatKhau.Location = new System.Drawing.Point(14, 106);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbMatKhau.PlaceholderText = "";
            this.tbMatKhau.SelectedText = "";
            this.tbMatKhau.ShadowDecoration.Parent = this.tbMatKhau;
            this.tbMatKhau.Size = new System.Drawing.Size(537, 47);
            this.tbMatKhau.TabIndex = 2;
            this.tbMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // FormThongTinAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(601, 475);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongTinAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongTinAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThongTinAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormThongTinAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected Guna.UI2.WinForms.Guna2GradientButton bOk;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbMatKhau;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch btThayDoiEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ToggleSwitch btThayDoiMK;
    }
}