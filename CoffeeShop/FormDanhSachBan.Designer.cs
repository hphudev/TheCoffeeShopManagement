namespace CoffeeShopManagement
{
    partial class FormDanhSachBan
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pTieuDe = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.bFind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flpTable = new CoffeeShopManagement.FlowLayoutPanelBuffered();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.pTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1304, 109);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.bCancel);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1213, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(79, 64);
            this.guna2ShadowPanel1.TabIndex = 127;
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
            this.bCancel.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1304, 109);
            this.label1.TabIndex = 113;
            this.label1.Text = "QUẢN LÍ BÀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pTieuDe
            // 
            this.pTieuDe.BackColor = System.Drawing.Color.White;
            this.pTieuDe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pTieuDe.Controls.Add(this.tbTimKiem);
            this.pTieuDe.Controls.Add(this.bFind);
            this.pTieuDe.Controls.Add(this.btDelete);
            this.pTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTieuDe.FillColor = System.Drawing.Color.Black;
            this.pTieuDe.FillColor2 = System.Drawing.Color.DimGray;
            this.pTieuDe.Location = new System.Drawing.Point(0, 109);
            this.pTieuDe.Name = "pTieuDe";
            this.pTieuDe.ShadowDecoration.Parent = this.pTieuDe;
            this.pTieuDe.Size = new System.Drawing.Size(1304, 70);
            this.pTieuDe.TabIndex = 123;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Animated = true;
            this.tbTimKiem.BackColor = System.Drawing.Color.Black;
            this.tbTimKiem.BorderColor = System.Drawing.Color.Bisque;
            this.tbTimKiem.BorderRadius = 5;
            this.tbTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimKiem.DefaultText = "";
            this.tbTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiem.DisabledState.Parent = this.tbTimKiem;
            this.tbTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimKiem.FillColor = System.Drawing.Color.LightYellow;
            this.tbTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbTimKiem.FocusedState.Parent = this.tbTimKiem;
            this.tbTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbTimKiem.ForeColor = System.Drawing.Color.Black;
            this.tbTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimKiem.HoverState.Parent = this.tbTimKiem;
            this.tbTimKiem.IconLeft = global::CoffeeShopManagement.Properties.Resources.Table;
            this.tbTimKiem.Location = new System.Drawing.Point(784, 14);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.PasswordChar = '\0';
            this.tbTimKiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbTimKiem.PlaceholderText = "";
            this.tbTimKiem.SelectedText = "";
            this.tbTimKiem.ShadowDecoration.Parent = this.tbTimKiem;
            this.tbTimKiem.Size = new System.Drawing.Size(295, 47);
            this.tbTimKiem.TabIndex = 10;
            this.tbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bFind
            // 
            this.bFind.Animated = true;
            this.bFind.BackColor = System.Drawing.Color.Transparent;
            this.bFind.BorderColor = System.Drawing.Color.Gainsboro;
            this.bFind.BorderRadius = 15;
            this.bFind.BorderThickness = 1;
            this.bFind.CheckedState.Parent = this.bFind;
            this.bFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFind.CustomImages.Parent = this.bFind;
            this.bFind.FillColor = System.Drawing.Color.DarkSlateGray;
            this.bFind.FillColor2 = System.Drawing.Color.SeaGreen;
            this.bFind.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bFind.ForeColor = System.Drawing.Color.White;
            this.bFind.HoverState.Parent = this.bFind;
            this.bFind.Location = new System.Drawing.Point(1124, 14);
            this.bFind.Name = "bFind";
            this.bFind.ShadowDecoration.Parent = this.bFind;
            this.bFind.Size = new System.Drawing.Size(104, 48);
            this.bFind.TabIndex = 9;
            this.bFind.Text = "THANH TOÁN";
            this.bFind.Click += new System.EventHandler(this.BtThanhToan_Click);
            // 
            // btDelete
            // 
            this.btDelete.Animated = true;
            this.btDelete.BackColor = System.Drawing.Color.Transparent;
            this.btDelete.BorderColor = System.Drawing.Color.White;
            this.btDelete.BorderThickness = 1;
            this.btDelete.CheckedState.Parent = this.btDelete;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.CustomImages.Parent = this.btDelete;
            this.btDelete.FillColor = System.Drawing.Color.Transparent;
            this.btDelete.FillColor2 = System.Drawing.Color.Transparent;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.HoverState.Parent = this.btDelete;
            this.btDelete.Location = new System.Drawing.Point(1084, 14);
            this.btDelete.Name = "btDelete";
            this.btDelete.ShadowDecoration.Parent = this.btDelete;
            this.btDelete.Size = new System.Drawing.Size(29, 46);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "X";
            // 
            // flpTable
            // 
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(0, 179);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1304, 540);
            this.flpTable.TabIndex = 124;
            // 
            // FormDanhSachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1304, 719);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.pTieuDe);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_DanhSachBan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_DanhSachBan_FormClosed);
            this.Load += new System.EventHandler(this.FormDanhSachBan_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.pTieuDe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private Guna.UI2.WinForms.Guna2GradientPanel pTieuDe;
        private Guna.UI2.WinForms.Guna2GradientButton bFind;
        private Guna.UI2.WinForms.Guna2GradientButton btDelete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private FlowLayoutPanelBuffered flpTable;
        private Guna.UI2.WinForms.Guna2TextBox tbTimKiem;
    }
}