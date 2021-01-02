namespace CoffeeShopManagement
{
    partial class FormMenuCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pCheck = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.bPrint = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pTieuDe = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tbTimKiemSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bChangeInfoCus = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bDeleteCus = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.MAKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDANGKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLANDENQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOANHSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XOA = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.guna2ShadowPanel1.SuspendLayout();
            this.pCheck.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.pTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.bCancel);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1332, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(79, 64);
            this.guna2ShadowPanel1.TabIndex = 129;
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
            this.bCancel.Location = new System.Drawing.Point(-4, 5);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(88, 56);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "THOÁT";
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1182, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 128;
            this.label2.Text = "IN DANH SÁCH";
            // 
            // pCheck
            // 
            this.pCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pCheck.BackColor = System.Drawing.Color.Transparent;
            this.pCheck.Controls.Add(this.bPrint);
            this.pCheck.FillColor = System.Drawing.Color.Transparent;
            this.pCheck.Location = new System.Drawing.Point(1210, 12);
            this.pCheck.Name = "pCheck";
            this.pCheck.Radius = 5;
            this.pCheck.ShadowColor = System.Drawing.Color.Black;
            this.pCheck.Size = new System.Drawing.Size(79, 64);
            this.pCheck.TabIndex = 127;
            // 
            // bPrint
            // 
            this.bPrint.CheckedState.ImageSize = new System.Drawing.Size(34, 34);
            this.bPrint.CheckedState.Parent = this.bPrint;
            this.bPrint.HoverState.ImageSize = new System.Drawing.Size(31, 31);
            this.bPrint.HoverState.Parent = this.bPrint;
            this.bPrint.Image = global::CoffeeShopManagement.Properties.Resources.Print;
            this.bPrint.ImageSize = new System.Drawing.Size(32, 32);
            this.bPrint.Location = new System.Drawing.Point(4, 6);
            this.bPrint.Name = "bPrint";
            this.bPrint.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.bPrint.PressedState.Parent = this.bPrint;
            this.bPrint.Size = new System.Drawing.Size(70, 51);
            this.bPrint.TabIndex = 124;
            this.bPrint.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.pCheck);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1435, 113);
            this.guna2GradientPanel1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1435, 113);
            this.label1.TabIndex = 112;
            this.label1.Text = "QUẢN LÍ KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this;
            // 
            // pTieuDe
            // 
            this.pTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.pTieuDe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pTieuDe.Controls.Add(this.tbTimKiemSDT);
            this.pTieuDe.Controls.Add(this.progressBar);
            this.pTieuDe.Controls.Add(this.bChangeInfoCus);
            this.pTieuDe.Controls.Add(this.guna2GradientButton2);
            this.pTieuDe.Controls.Add(this.bDeleteCus);
            this.pTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTieuDe.FillColor = System.Drawing.Color.Black;
            this.pTieuDe.FillColor2 = System.Drawing.Color.DimGray;
            this.pTieuDe.Location = new System.Drawing.Point(0, 113);
            this.pTieuDe.Name = "pTieuDe";
            this.pTieuDe.ShadowDecoration.Parent = this.pTieuDe;
            this.pTieuDe.Size = new System.Drawing.Size(1435, 70);
            this.pTieuDe.TabIndex = 130;
            // 
            // tbTimKiemSDT
            // 
            this.tbTimKiemSDT.Animated = true;
            this.tbTimKiemSDT.BackColor = System.Drawing.Color.Transparent;
            this.tbTimKiemSDT.BorderColor = System.Drawing.Color.Bisque;
            this.tbTimKiemSDT.BorderRadius = 5;
            this.tbTimKiemSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimKiemSDT.DefaultText = "Số điện thoại";
            this.tbTimKiemSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimKiemSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimKiemSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiemSDT.DisabledState.Parent = this.tbTimKiemSDT;
            this.tbTimKiemSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiemSDT.FillColor = System.Drawing.Color.Ivory;
            this.tbTimKiemSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbTimKiemSDT.FocusedState.Parent = this.tbTimKiemSDT;
            this.tbTimKiemSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbTimKiemSDT.ForeColor = System.Drawing.Color.Black;
            this.tbTimKiemSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimKiemSDT.HoverState.Parent = this.tbTimKiemSDT;
            this.tbTimKiemSDT.IconLeft = global::CoffeeShopManagement.Properties.Resources.Phone;
            this.tbTimKiemSDT.Location = new System.Drawing.Point(1014, 14);
            this.tbTimKiemSDT.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimKiemSDT.Name = "tbTimKiemSDT";
            this.tbTimKiemSDT.PasswordChar = '\0';
            this.tbTimKiemSDT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbTimKiemSDT.PlaceholderText = "";
            this.tbTimKiemSDT.SelectedText = "";
            this.tbTimKiemSDT.SelectionStart = 13;
            this.tbTimKiemSDT.ShadowDecoration.Parent = this.tbTimKiemSDT;
            this.tbTimKiemSDT.Size = new System.Drawing.Size(354, 47);
            this.tbTimKiemSDT.TabIndex = 128;
            this.tbTimKiemSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTimKiemSDT.TextChanged += new System.EventHandler(this.TbTimKiemSDT_TextChanged);
            this.tbTimKiemSDT.Enter += new System.EventHandler(this.TbTimKiemSDT_Enter);
            this.tbTimKiemSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTimKiemSDT_KeyPress);
            this.tbTimKiemSDT.Leave += new System.EventHandler(this.TbTimKiemSDT_Leave);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.progressBar.ForeColor = System.Drawing.Color.SpringGreen;
            this.progressBar.Location = new System.Drawing.Point(26, 24);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(266, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 127;
            // 
            // bChangeInfoCus
            // 
            this.bChangeInfoCus.Animated = true;
            this.bChangeInfoCus.BackColor = System.Drawing.Color.Transparent;
            this.bChangeInfoCus.BorderRadius = 15;
            this.bChangeInfoCus.CheckedState.Parent = this.bChangeInfoCus;
            this.bChangeInfoCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChangeInfoCus.CustomImages.Parent = this.bChangeInfoCus;
            this.bChangeInfoCus.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bChangeInfoCus.FillColor2 = System.Drawing.Color.Teal;
            this.bChangeInfoCus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bChangeInfoCus.ForeColor = System.Drawing.Color.White;
            this.bChangeInfoCus.HoverState.Parent = this.bChangeInfoCus;
            this.bChangeInfoCus.Location = new System.Drawing.Point(513, 14);
            this.bChangeInfoCus.Name = "bChangeInfoCus";
            this.bChangeInfoCus.ShadowDecoration.Parent = this.bChangeInfoCus;
            this.bChangeInfoCus.Size = new System.Drawing.Size(107, 47);
            this.bChangeInfoCus.TabIndex = 120;
            this.bChangeInfoCus.Text = "Sửa";
            this.bChangeInfoCus.Click += new System.EventHandler(this.BChangeInfoCus_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton2.BorderThickness = 1;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(1370, 14);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(29, 46);
            this.guna2GradientButton2.TabIndex = 8;
            this.guna2GradientButton2.Text = "X";
            // 
            // bDeleteCus
            // 
            this.bDeleteCus.Animated = true;
            this.bDeleteCus.BackColor = System.Drawing.Color.Transparent;
            this.bDeleteCus.BorderRadius = 15;
            this.bDeleteCus.CheckedState.Parent = this.bDeleteCus;
            this.bDeleteCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteCus.CustomImages.Parent = this.bDeleteCus;
            this.bDeleteCus.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bDeleteCus.FillColor2 = System.Drawing.Color.Teal;
            this.bDeleteCus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bDeleteCus.ForeColor = System.Drawing.Color.White;
            this.bDeleteCus.HoverState.Parent = this.bDeleteCus;
            this.bDeleteCus.Location = new System.Drawing.Point(651, 14);
            this.bDeleteCus.Name = "bDeleteCus";
            this.bDeleteCus.ShadowDecoration.Parent = this.bDeleteCus;
            this.bDeleteCus.Size = new System.Drawing.Size(107, 47);
            this.bDeleteCus.TabIndex = 119;
            this.bDeleteCus.Text = "Xóa";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKHACHHANG,
            this.HOTEN,
            this.GIOITINH,
            this.NGAYSINH,
            this.SODIENTHOAI,
            this.DIACHI,
            this.THANHVIEN,
            this.NGAYDANGKY,
            this.SOLANDENQUAN,
            this.DOANHSO,
            this.XOA});
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(0, 183);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(1435, 564);
            this.dgvMenu.TabIndex = 131;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMenu_CellContentClick);
            // 
            // MAKHACHHANG
            // 
            this.MAKHACHHANG.HeaderText = "Mã KH";
            this.MAKHACHHANG.MinimumWidth = 6;
            this.MAKHACHHANG.Name = "MAKHACHHANG";
            this.MAKHACHHANG.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "Họ và tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.MinimumWidth = 6;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // SODIENTHOAI
            // 
            this.SODIENTHOAI.HeaderText = "Số điện thoại";
            this.SODIENTHOAI.MinimumWidth = 6;
            this.SODIENTHOAI.Name = "SODIENTHOAI";
            this.SODIENTHOAI.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // THANHVIEN
            // 
            this.THANHVIEN.HeaderText = "Thành viên";
            this.THANHVIEN.MinimumWidth = 6;
            this.THANHVIEN.Name = "THANHVIEN";
            this.THANHVIEN.ReadOnly = true;
            // 
            // NGAYDANGKY
            // 
            this.NGAYDANGKY.HeaderText = "Ngày đăng ký";
            this.NGAYDANGKY.MinimumWidth = 6;
            this.NGAYDANGKY.Name = "NGAYDANGKY";
            this.NGAYDANGKY.ReadOnly = true;
            // 
            // SOLANDENQUAN
            // 
            this.SOLANDENQUAN.HeaderText = "Số lần đến quán";
            this.SOLANDENQUAN.MinimumWidth = 6;
            this.SOLANDENQUAN.Name = "SOLANDENQUAN";
            this.SOLANDENQUAN.ReadOnly = true;
            // 
            // DOANHSO
            // 
            this.DOANHSO.HeaderText = "Doanh số";
            this.DOANHSO.MinimumWidth = 6;
            this.DOANHSO.Name = "DOANHSO";
            this.DOANHSO.ReadOnly = true;
            // 
            // XOA
            // 
            this.XOA.HeaderText = "";
            this.XOA.MinimumWidth = 6;
            this.XOA.Name = "XOA";
            this.XOA.ReadOnly = true;
            this.XOA.Text = "Xóa";
            this.XOA.UseColumnTextForButtonValue = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            // 
            // FormMenuCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 747);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.pTieuDe);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuCustomer";
            this.Load += new System.EventHandler(this.FormMenuCustomer_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.pCheck.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.pTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton bPrint;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pCheck;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.DataGridView dgvMenu;
        private Guna.UI2.WinForms.Guna2GradientPanel pTieuDe;
        private System.Windows.Forms.ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2GradientButton bChangeInfoCus;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton bDeleteCus;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Guna.UI2.WinForms.Guna2TextBox tbTimKiemSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDANGKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLANDENQUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOANHSO;
        private System.Windows.Forms.DataGridViewButtonColumn XOA;
    }
}