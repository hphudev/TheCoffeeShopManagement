namespace CoffeeShopManagement
{
    partial class FormMenuStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.dgvtbcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcSoLanPhucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drvtbcLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bFind = new ns1.BunifuThinButton2();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btThoat = new ns1.BunifuThinButton2();
            this.bDeleteStaff = new ns1.BunifuThinButton2();
            this.bChangeInfoStaff = new ns1.BunifuThinButton2();
            this.bAddStaff = new ns1.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 747);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1210, 676);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1210, 622);
            this.panel5.TabIndex = 3;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcID,
            this.dgvtbcName,
            this.dgvtbcSize,
            this.dgvtbcPrice,
            this.dgvtbcUnit,
            this.dgvtbcNuocSX,
            this.dgvtbcSoLanPhucVu,
            this.drvtbcLuong,
            this.dgvtbcChucVu});
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(1210, 622);
            this.dgvMenu.TabIndex = 1;
            // 
            // dgvtbcID
            // 
            this.dgvtbcID.HeaderText = "Mã nhân viên";
            this.dgvtbcID.MinimumWidth = 6;
            this.dgvtbcID.Name = "dgvtbcID";
            this.dgvtbcID.ReadOnly = true;
            // 
            // dgvtbcName
            // 
            this.dgvtbcName.HeaderText = "Họ tên";
            this.dgvtbcName.MinimumWidth = 6;
            this.dgvtbcName.Name = "dgvtbcName";
            this.dgvtbcName.ReadOnly = true;
            // 
            // dgvtbcSize
            // 
            this.dgvtbcSize.HeaderText = "Địa chỉ";
            this.dgvtbcSize.MinimumWidth = 6;
            this.dgvtbcSize.Name = "dgvtbcSize";
            this.dgvtbcSize.ReadOnly = true;
            // 
            // dgvtbcPrice
            // 
            this.dgvtbcPrice.HeaderText = "Ngày vào làm";
            this.dgvtbcPrice.MinimumWidth = 6;
            this.dgvtbcPrice.Name = "dgvtbcPrice";
            this.dgvtbcPrice.ReadOnly = true;
            // 
            // dgvtbcUnit
            // 
            this.dgvtbcUnit.HeaderText = "SĐT";
            this.dgvtbcUnit.MinimumWidth = 6;
            this.dgvtbcUnit.Name = "dgvtbcUnit";
            this.dgvtbcUnit.ReadOnly = true;
            // 
            // dgvtbcNuocSX
            // 
            this.dgvtbcNuocSX.HeaderText = "CMND";
            this.dgvtbcNuocSX.MinimumWidth = 6;
            this.dgvtbcNuocSX.Name = "dgvtbcNuocSX";
            this.dgvtbcNuocSX.ReadOnly = true;
            // 
            // dgvtbcSoLanPhucVu
            // 
            this.dgvtbcSoLanPhucVu.HeaderText = "Giới tính";
            this.dgvtbcSoLanPhucVu.MinimumWidth = 6;
            this.dgvtbcSoLanPhucVu.Name = "dgvtbcSoLanPhucVu";
            this.dgvtbcSoLanPhucVu.ReadOnly = true;
            // 
            // drvtbcLuong
            // 
            this.drvtbcLuong.HeaderText = "Lương";
            this.drvtbcLuong.MinimumWidth = 6;
            this.drvtbcLuong.Name = "drvtbcLuong";
            this.drvtbcLuong.ReadOnly = true;
            // 
            // dgvtbcChucVu
            // 
            this.dgvtbcChucVu.HeaderText = "Chức vụ";
            this.dgvtbcChucVu.MinimumWidth = 6;
            this.dgvtbcChucVu.Name = "dgvtbcChucVu";
            this.dgvtbcChucVu.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.bFind);
            this.panel4.Controls.Add(this.cbFind);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1210, 54);
            this.panel4.TabIndex = 0;
            // 
            // bFind
            // 
            this.bFind.ActiveBorderThickness = 1;
            this.bFind.ActiveCornerRadius = 20;
            this.bFind.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bFind.ActiveForecolor = System.Drawing.Color.White;
            this.bFind.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bFind.BackColor = System.Drawing.Color.Maroon;
            this.bFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bFind.BackgroundImage")));
            this.bFind.ButtonText = "TÌM KIẾM";
            this.bFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFind.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFind.ForeColor = System.Drawing.Color.SeaGreen;
            this.bFind.IdleBorderThickness = 1;
            this.bFind.IdleCornerRadius = 20;
            this.bFind.IdleFillColor = System.Drawing.Color.White;
            this.bFind.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bFind.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bFind.Location = new System.Drawing.Point(665, 0);
            this.bFind.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(169, 54);
            this.bFind.TabIndex = 16;
            this.bFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFind
            // 
            this.cbFind.BackColor = System.Drawing.Color.Maroon;
            this.cbFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind.ForeColor = System.Drawing.Color.White;
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Location = new System.Drawing.Point(853, 0);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(357, 53);
            this.cbFind.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.Controls.Add(this.btThoat);
            this.panel6.Controls.Add(this.bDeleteStaff);
            this.panel6.Controls.Add(this.bChangeInfoStaff);
            this.panel6.Controls.Add(this.bAddStaff);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1210, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 676);
            this.panel6.TabIndex = 4;
            // 
            // btThoat
            // 
            this.btThoat.ActiveBorderThickness = 1;
            this.btThoat.ActiveCornerRadius = 20;
            this.btThoat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThoat.ActiveForecolor = System.Drawing.Color.White;
            this.btThoat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThoat.BackColor = System.Drawing.Color.Maroon;
            this.btThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThoat.BackgroundImage")));
            this.btThoat.ButtonText = "THOÁT";
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThoat.IdleBorderThickness = 1;
            this.btThoat.IdleCornerRadius = 20;
            this.btThoat.IdleFillColor = System.Drawing.Color.White;
            this.btThoat.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThoat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThoat.Location = new System.Drawing.Point(0, 219);
            this.btThoat.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(225, 73);
            this.btThoat.TabIndex = 3;
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // bDeleteStaff
            // 
            this.bDeleteStaff.ActiveBorderThickness = 1;
            this.bDeleteStaff.ActiveCornerRadius = 20;
            this.bDeleteStaff.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteStaff.ActiveForecolor = System.Drawing.Color.White;
            this.bDeleteStaff.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteStaff.BackColor = System.Drawing.Color.Maroon;
            this.bDeleteStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDeleteStaff.BackgroundImage")));
            this.bDeleteStaff.ButtonText = "XÓA";
            this.bDeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteStaff.IdleBorderThickness = 1;
            this.bDeleteStaff.IdleCornerRadius = 20;
            this.bDeleteStaff.IdleFillColor = System.Drawing.Color.White;
            this.bDeleteStaff.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteStaff.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteStaff.Location = new System.Drawing.Point(0, 146);
            this.bDeleteStaff.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bDeleteStaff.Name = "bDeleteStaff";
            this.bDeleteStaff.Size = new System.Drawing.Size(225, 73);
            this.bDeleteStaff.TabIndex = 2;
            this.bDeleteStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bChangeInfoStaff
            // 
            this.bChangeInfoStaff.ActiveBorderThickness = 1;
            this.bChangeInfoStaff.ActiveCornerRadius = 20;
            this.bChangeInfoStaff.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoStaff.ActiveForecolor = System.Drawing.Color.White;
            this.bChangeInfoStaff.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoStaff.BackColor = System.Drawing.Color.Maroon;
            this.bChangeInfoStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bChangeInfoStaff.BackgroundImage")));
            this.bChangeInfoStaff.ButtonText = "CHỈNH SỬA";
            this.bChangeInfoStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChangeInfoStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.bChangeInfoStaff.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChangeInfoStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoStaff.IdleBorderThickness = 1;
            this.bChangeInfoStaff.IdleCornerRadius = 20;
            this.bChangeInfoStaff.IdleFillColor = System.Drawing.Color.White;
            this.bChangeInfoStaff.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoStaff.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoStaff.Location = new System.Drawing.Point(0, 73);
            this.bChangeInfoStaff.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bChangeInfoStaff.Name = "bChangeInfoStaff";
            this.bChangeInfoStaff.Size = new System.Drawing.Size(225, 73);
            this.bChangeInfoStaff.TabIndex = 1;
            this.bChangeInfoStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bAddStaff
            // 
            this.bAddStaff.ActiveBorderThickness = 1;
            this.bAddStaff.ActiveCornerRadius = 20;
            this.bAddStaff.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddStaff.ActiveForecolor = System.Drawing.Color.White;
            this.bAddStaff.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddStaff.BackColor = System.Drawing.Color.Maroon;
            this.bAddStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAddStaff.BackgroundImage")));
            this.bAddStaff.ButtonText = "THÊM";
            this.bAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAddStaff.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddStaff.IdleBorderThickness = 1;
            this.bAddStaff.IdleCornerRadius = 20;
            this.bAddStaff.IdleFillColor = System.Drawing.Color.White;
            this.bAddStaff.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddStaff.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddStaff.Location = new System.Drawing.Point(0, 0);
            this.bAddStaff.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bAddStaff.Name = "bAddStaff";
            this.bAddStaff.Size = new System.Drawing.Size(225, 73);
            this.bAddStaff.TabIndex = 0;
            this.bAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1435, 71);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1435, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1435, 747);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuStaff_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private ns1.BunifuThinButton2 bDeleteStaff;
        private ns1.BunifuThinButton2 bChangeInfoStaff;
        private ns1.BunifuThinButton2 bAddStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNuocSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcSoLanPhucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn drvtbcLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcChucVu;
        private ns1.BunifuThinButton2 bFind;
        private ns1.BunifuThinButton2 btThoat;
        private System.Windows.Forms.ComboBox cbFind;
    }
}