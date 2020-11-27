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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pThanhDieuKhien = new System.Windows.Forms.Panel();
            this.jImageButton2 = new JImageButton.JImageButton();
            this.buttonThoatForm = new JImageButton.JImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTenPhanMem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.buttonThoat = new ns1.BunifuThinButton2();
            this.btDangNhap = new ns1.BunifuThinButton2();
            this.tbMatKhau = new JMaterialTextbox.JMaterialTextbox();
            this.tbTenDangNhap = new JMaterialTextbox.JMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.pThanhDieuKhien.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pThanhDieuKhien
            // 
            this.pThanhDieuKhien.BackColor = System.Drawing.SystemColors.Highlight;
            this.pThanhDieuKhien.Controls.Add(this.jImageButton2);
            this.pThanhDieuKhien.Controls.Add(this.buttonThoatForm);
            this.pThanhDieuKhien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pThanhDieuKhien.Location = new System.Drawing.Point(0, 0);
            this.pThanhDieuKhien.Name = "pThanhDieuKhien";
            this.pThanhDieuKhien.Size = new System.Drawing.Size(957, 51);
            this.pThanhDieuKhien.TabIndex = 3;
            // 
            // jImageButton2
            // 
            this.jImageButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.jImageButton2.CausesValidation = false;
            this.jImageButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton2.ErrorImage")));
            this.jImageButton2.Image = global::CoffeeShopManagement.Properties.Resources.Minimize;
            this.jImageButton2.ImageHover = null;
            this.jImageButton2.InitialImage = null;
            this.jImageButton2.Location = new System.Drawing.Point(860, 0);
            this.jImageButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jImageButton2.Name = "jImageButton2";
            this.jImageButton2.Size = new System.Drawing.Size(51, 51);
            this.jImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jImageButton2.TabIndex = 5;
            this.jImageButton2.Zoom = 4;
            // 
            // buttonThoatForm
            // 
            this.buttonThoatForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonThoatForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonThoatForm.CausesValidation = false;
            this.buttonThoatForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonThoatForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonThoatForm.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonThoatForm.ErrorImage")));
            this.buttonThoatForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoatForm.Image")));
            this.buttonThoatForm.ImageHover = null;
            this.buttonThoatForm.InitialImage = null;
            this.buttonThoatForm.Location = new System.Drawing.Point(906, 0);
            this.buttonThoatForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThoatForm.Name = "buttonThoatForm";
            this.buttonThoatForm.Size = new System.Drawing.Size(51, 51);
            this.buttonThoatForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonThoatForm.TabIndex = 4;
            this.buttonThoatForm.Zoom = 4;
            this.buttonThoatForm.Click += new System.EventHandler(this.ButtonThoatForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbTenPhanMem);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 653);
            this.panel1.TabIndex = 4;
            // 
            // lbTenPhanMem
            // 
            this.lbTenPhanMem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTenPhanMem.AutoSize = true;
            this.lbTenPhanMem.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhanMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTenPhanMem.Location = new System.Drawing.Point(5, 533);
            this.lbTenPhanMem.Name = "lbTenPhanMem";
            this.lbTenPhanMem.Size = new System.Drawing.Size(381, 31);
            this.lbTenPhanMem.TabIndex = 3;
            this.lbTenPhanMem.Text = "THE COFFEE SHOP MANAGEMENT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pbEye);
            this.panel2.Controls.Add(this.buttonThoat);
            this.panel2.Controls.Add(this.btDangNhap);
            this.panel2.Controls.Add(this.tbMatKhau);
            this.panel2.Controls.Add(this.tbTenDangNhap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(422, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 653);
            this.panel2.TabIndex = 1;
            // 
            // pbEye
            // 
            this.pbEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEye.Location = new System.Drawing.Point(478, 362);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(40, 40);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEye.TabIndex = 9;
            this.pbEye.TabStop = false;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.ActiveBorderThickness = 5;
            this.buttonThoat.ActiveCornerRadius = 30;
            this.buttonThoat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.buttonThoat.ActiveForecolor = System.Drawing.Color.White;
            this.buttonThoat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.buttonThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.buttonThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.BackgroundImage")));
            this.buttonThoat.ButtonText = "Thoát";
            this.buttonThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThoat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonThoat.IdleBorderThickness = 2;
            this.buttonThoat.IdleCornerRadius = 30;
            this.buttonThoat.IdleFillColor = System.Drawing.Color.MistyRose;
            this.buttonThoat.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.buttonThoat.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.buttonThoat.Location = new System.Drawing.Point(292, 465);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(206, 66);
            this.buttonThoat.TabIndex = 3;
            this.buttonThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonThoat.Click += new System.EventHandler(this.ButtonThoat_Click_1);
            // 
            // btDangNhap
            // 
            this.btDangNhap.ActiveBorderThickness = 5;
            this.btDangNhap.ActiveCornerRadius = 30;
            this.btDangNhap.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btDangNhap.ActiveForecolor = System.Drawing.Color.White;
            this.btDangNhap.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDangNhap.BackgroundImage")));
            this.btDangNhap.ButtonText = "Đăng nhập";
            this.btDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btDangNhap.IdleBorderThickness = 2;
            this.btDangNhap.IdleCornerRadius = 30;
            this.btDangNhap.IdleFillColor = System.Drawing.Color.MistyRose;
            this.btDangNhap.IdleForecolor = System.Drawing.SystemColors.Highlight;
            this.btDangNhap.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.btDangNhap.Location = new System.Drawing.Point(28, 465);
            this.btDangNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(206, 66);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Font_Size = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.ForeColors = System.Drawing.Color.Black;
            this.tbMatKhau.HintText = null;
            this.tbMatKhau.IsPassword = true;
            this.tbMatKhau.LineBackColor = System.Drawing.SystemColors.Highlight;
            this.tbMatKhau.LineThickness = 5;
            this.tbMatKhau.Location = new System.Drawing.Point(33, 366);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(8);
            this.tbMatKhau.MaxLength = 32767;
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tbMatKhau.OnFocusedTextColor = System.Drawing.Color.DarkBlue;
            this.tbMatKhau.ReadOnly = false;
            this.tbMatKhau.Size = new System.Drawing.Size(440, 42);
            this.tbMatKhau.TabIndex = 1;
            this.tbMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMatKhau.TextName = "";
            // 
            // tbTenDangNhap
            // 
            this.tbTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.tbTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDangNhap.Font_Size = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDangNhap.ForeColors = System.Drawing.Color.Black;
            this.tbTenDangNhap.HintText = null;
            this.tbTenDangNhap.IsPassword = false;
            this.tbTenDangNhap.LineBackColor = System.Drawing.SystemColors.Highlight;
            this.tbTenDangNhap.LineThickness = 5;
            this.tbTenDangNhap.Location = new System.Drawing.Point(33, 196);
            this.tbTenDangNhap.Margin = new System.Windows.Forms.Padding(8);
            this.tbTenDangNhap.MaxLength = 32767;
            this.tbTenDangNhap.Name = "tbTenDangNhap";
            this.tbTenDangNhap.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tbTenDangNhap.OnFocusedTextColor = System.Drawing.Color.DarkBlue;
            this.tbTenDangNhap.ReadOnly = false;
            this.tbTenDangNhap.Size = new System.Drawing.Size(440, 42);
            this.tbTenDangNhap.TabIndex = 0;
            this.tbTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTenDangNhap.TextName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CoffeeShopManagement.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pThanhDieuKhien;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pThanhDieuKhien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.pThanhDieuKhien.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pThanhDieuKhien;
        private JImageButton.JImageButton buttonThoatForm;
        private JImageButton.JImageButton jImageButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTenPhanMem;
        private JMaterialTextbox.JMaterialTextbox tbTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private JMaterialTextbox.JMaterialTextbox tbMatKhau;
        private ns1.BunifuThinButton2 buttonThoat;
        private ns1.BunifuThinButton2 btDangNhap;
        private System.Windows.Forms.PictureBox pbEye;
        private ns1.BunifuDragControl bunifuDragControl1;
    }
}