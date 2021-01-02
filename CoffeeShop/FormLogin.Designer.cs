namespace CoffeeShopManagement
{
    partial class FormLogin
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLot = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lb = new System.Windows.Forms.Label();
            this.Restart = new CoffeeShopManagement.PictureboxBuffered();
            this.btThoat = new CoffeeShopManagement.PictureboxBuffered();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pUser = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.load = new CoffeeShopManagement.PictureboxBuffered();
            this.btQuenMatKhau = new System.Windows.Forms.Label();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.btDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.pnLot;
            // 
            // pnLot
            // 
            this.pnLot.Controls.Add(this.lb);
            this.pnLot.Controls.Add(this.Restart);
            this.pnLot.Controls.Add(this.btThoat);
            this.pnLot.Controls.Add(this.pictureBox1);
            this.pnLot.Controls.Add(this.label2);
            this.pnLot.Controls.Add(this.label1);
            this.pnLot.Controls.Add(this.pUser);
            this.pnLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLot.FillColor = System.Drawing.Color.Bisque;
            this.pnLot.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnLot.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.pnLot.Location = new System.Drawing.Point(0, 0);
            this.pnLot.Name = "pnLot";
            this.pnLot.ShadowDecoration.Parent = this.pnLot;
            this.pnLot.Size = new System.Drawing.Size(1059, 645);
            this.pnLot.TabIndex = 0;
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(973, 579);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(57, 23);
            this.lb.TabIndex = 14;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart.Image = global::CoffeeShopManagement.Properties.Resources.Restart;
            this.Restart.Location = new System.Drawing.Point(915, 12);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(61, 37);
            this.Restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restart.TabIndex = 13;
            this.Restart.TabStop = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Transparent;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Image = global::CoffeeShopManagement.Properties.Resources.Close_Login;
            this.btThoat.Location = new System.Drawing.Point(976, 12);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(61, 37);
            this.btThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btThoat.TabIndex = 12;
            this.btThoat.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CoffeeShopManagement.Properties.Resources.LogoLogin;
            this.pictureBox1.Location = new System.Drawing.Point(83, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 279);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cuộc sống là 10% những gì xảy ra với bạn và 90% là cách bạn phản ứng với nó – Cha" +
    "rles R. Swindoll";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(670, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            // 
            // pUser
            // 
            this.pUser.Controls.Add(this.load);
            this.pUser.Controls.Add(this.btQuenMatKhau);
            this.pUser.Controls.Add(this.pbEye);
            this.pUser.Controls.Add(this.btDangNhap);
            this.pUser.Controls.Add(this.tbMatKhau);
            this.pUser.Controls.Add(this.tbTenDangNhap);
            this.pUser.FillColor = System.Drawing.Color.Bisque;
            this.pUser.FillColor2 = System.Drawing.Color.Bisque;
            this.pUser.Location = new System.Drawing.Point(558, 198);
            this.pUser.Name = "pUser";
            this.pUser.ShadowDecoration.Parent = this.pUser;
            this.pUser.Size = new System.Drawing.Size(479, 332);
            this.pUser.TabIndex = 3;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Gainsboro;
            this.load.Image = global::CoffeeShopManagement.Properties.Resources._4RNk;
            this.load.Location = new System.Drawing.Point(-6, 0);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(488, 332);
            this.load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.load.TabIndex = 11;
            this.load.TabStop = false;
            this.load.Visible = false;
            // 
            // btQuenMatKhau
            // 
            this.btQuenMatKhau.AutoSize = true;
            this.btQuenMatKhau.BackColor = System.Drawing.Color.Bisque;
            this.btQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuenMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btQuenMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btQuenMatKhau.Location = new System.Drawing.Point(305, 281);
            this.btQuenMatKhau.Name = "btQuenMatKhau";
            this.btQuenMatKhau.Size = new System.Drawing.Size(151, 23);
            this.btQuenMatKhau.TabIndex = 11;
            this.btQuenMatKhau.Text = "Forgot Password?";
            this.btQuenMatKhau.Click += new System.EventHandler(this.BtQuenMatKhau_Click);
            // 
            // pbEye
            // 
            this.pbEye.BackColor = System.Drawing.Color.Transparent;
            this.pbEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEye.Image = global::CoffeeShopManagement.Properties.Resources.OpenEye;
            this.pbEye.Location = new System.Drawing.Point(456, 111);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(20, 20);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEye.TabIndex = 9;
            this.pbEye.TabStop = false;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.Bisque;
            this.btDangNhap.BorderRadius = 22;
            this.btDangNhap.CheckedState.Parent = this.btDangNhap;
            this.btDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDangNhap.CustomImages.Parent = this.btDangNhap;
            this.btDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDangNhap.FillColor2 = System.Drawing.Color.Red;
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.HoverState.Parent = this.btDangNhap;
            this.btDangNhap.Location = new System.Drawing.Point(13, 205);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.ShadowDecoration.Parent = this.btDangNhap;
            this.btDangNhap.Size = new System.Drawing.Size(443, 56);
            this.btDangNhap.TabIndex = 3;
            this.btDangNhap.Text = "Login";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.BackColor = System.Drawing.Color.Bisque;
            this.tbMatKhau.BorderColor = System.Drawing.Color.Bisque;
            this.tbMatKhau.BorderRadius = 15;
            this.tbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMatKhau.DefaultText = "Mật khẩu";
            this.tbMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.DisabledState.Parent = this.tbMatKhau;
            this.tbMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.FillColor = System.Drawing.Color.Ivory;
            this.tbMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbMatKhau.FocusedState.Parent = this.tbMatKhau;
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhau.HoverState.Parent = this.tbMatKhau;
            this.tbMatKhau.IconLeft = global::CoffeeShopManagement.Properties.Resources.password;
            this.tbMatKhau.Location = new System.Drawing.Point(13, 114);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '\0';
            this.tbMatKhau.PlaceholderText = "";
            this.tbMatKhau.SelectedText = "";
            this.tbMatKhau.SelectionStart = 8;
            this.tbMatKhau.ShadowDecoration.Parent = this.tbMatKhau;
            this.tbMatKhau.Size = new System.Drawing.Size(443, 57);
            this.tbMatKhau.TabIndex = 2;
            this.tbMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMatKhau.Enter += new System.EventHandler(this.TbMatKhau_Enter);
            this.tbMatKhau.Leave += new System.EventHandler(this.TbMatKhau_Leave);
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.BackColor = System.Drawing.Color.Bisque;
            this.tbTenDangNhap.BorderColor = System.Drawing.Color.Bisque;
            this.tbTenDangNhap.BorderRadius = 15;
            this.tbTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTenDangNhap.DefaultText = "Tên đăng nhập";
            this.tbTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenDangNhap.DisabledState.Parent = this.tbTenDangNhap;
            this.tbTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenDangNhap.FillColor = System.Drawing.Color.Ivory;
            this.tbTenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbTenDangNhap.FocusedState.Parent = this.tbTenDangNhap;
            this.tbTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenDangNhap.HoverState.Parent = this.tbTenDangNhap;
            this.tbTenDangNhap.IconLeft = global::CoffeeShopManagement.Properties.Resources.user;
            this.tbTenDangNhap.Location = new System.Drawing.Point(13, 44);
            this.tbTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.PasswordChar = '\0';
            this.tbTenDangNhap.PlaceholderText = "";
            this.tbTenDangNhap.SelectedText = "";
            this.tbTenDangNhap.SelectionStart = 13;
            this.tbTenDangNhap.ShadowDecoration.Parent = this.tbTenDangNhap;
            this.tbTenDangNhap.Size = new System.Drawing.Size(443, 57);
            this.tbTenDangNhap.TabIndex = 1;
            this.tbTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTenDangNhap.Enter += new System.EventHandler(this.TbTenDangNhap_Enter);
            this.tbTenDangNhap.Leave += new System.EventHandler(this.TbTenDangNhap_Leave);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.pUser;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 25;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgWorker_ProgressChanged);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 10;
            this.guna2Elipse4.TargetControl = this.lb;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1059, 645);
            this.Controls.Add(this.pnLot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.SystemColors.ControlLight;
            this.pnLot.ResumeLayout(false);
            this.pnLot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pUser.ResumeLayout(false);
            this.pUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnLot;
        private Guna.UI2.WinForms.Guna2GradientPanel pUser;
        private Guna.UI2.WinForms.Guna2TextBox tbTenDangNhap;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox tbMatKhau;
        private Guna.UI2.WinForms.Guna2GradientButton btDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PictureboxBuffered load;
        private System.Windows.Forms.Label btQuenMatKhau;
        private PictureboxBuffered Restart;
        private PictureboxBuffered btThoat;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lb;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}