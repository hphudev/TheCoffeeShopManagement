namespace CoffeeShopManagement
{
    partial class FormMenuItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.dgvtbcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcSoLanPhucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bFind = new ns1.BunifuThinButton2();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bCancel = new ns1.BunifuThinButton2();
            this.bDeleteItem = new ns1.BunifuThinButton2();
            this.bChangeInfoItem = new ns1.BunifuThinButton2();
            this.bAddItem = new ns1.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMenu);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 803);
            this.panel1.TabIndex = 0;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcID,
            this.dgvtbcName,
            this.dgvtbcUnit,
            this.dgvtbcSoLanPhucVu,
            this.dgvtbcPrice});
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(0, 131);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(1084, 672);
            this.dgvMenu.TabIndex = 7;
            // 
            // dgvtbcID
            // 
            this.dgvtbcID.HeaderText = "Mã món";
            this.dgvtbcID.MinimumWidth = 6;
            this.dgvtbcID.Name = "dgvtbcID";
            this.dgvtbcID.ReadOnly = true;
            // 
            // dgvtbcName
            // 
            this.dgvtbcName.HeaderText = "Tên món";
            this.dgvtbcName.MinimumWidth = 6;
            this.dgvtbcName.Name = "dgvtbcName";
            this.dgvtbcName.ReadOnly = true;
            // 
            // dgvtbcUnit
            // 
            this.dgvtbcUnit.HeaderText = "Đơn vị tính";
            this.dgvtbcUnit.MinimumWidth = 6;
            this.dgvtbcUnit.Name = "dgvtbcUnit";
            this.dgvtbcUnit.ReadOnly = true;
            // 
            // dgvtbcSoLanPhucVu
            // 
            this.dgvtbcSoLanPhucVu.HeaderText = "Số lần phục vụ";
            this.dgvtbcSoLanPhucVu.MinimumWidth = 6;
            this.dgvtbcSoLanPhucVu.Name = "dgvtbcSoLanPhucVu";
            this.dgvtbcSoLanPhucVu.ReadOnly = true;
            // 
            // dgvtbcPrice
            // 
            this.dgvtbcPrice.HeaderText = "Giá";
            this.dgvtbcPrice.MinimumWidth = 6;
            this.dgvtbcPrice.Name = "dgvtbcPrice";
            this.dgvtbcPrice.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.bFind);
            this.panel4.Controls.Add(this.cbFind);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1084, 60);
            this.panel4.TabIndex = 6;
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
            this.bFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.bFind.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFind.ForeColor = System.Drawing.Color.SeaGreen;
            this.bFind.IdleBorderThickness = 1;
            this.bFind.IdleCornerRadius = 20;
            this.bFind.IdleFillColor = System.Drawing.Color.White;
            this.bFind.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bFind.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bFind.Location = new System.Drawing.Point(539, 0);
            this.bFind.Margin = new System.Windows.Forms.Padding(6);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(186, 58);
            this.bFind.TabIndex = 18;
            this.bFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFind
            // 
            this.cbFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.cbFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFind.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFind.ForeColor = System.Drawing.Color.White;
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Location = new System.Drawing.Point(725, 0);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(357, 58);
            this.cbFind.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.bCancel);
            this.panel6.Controls.Add(this.bDeleteItem);
            this.panel6.Controls.Add(this.bChangeInfoItem);
            this.panel6.Controls.Add(this.bAddItem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1084, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 732);
            this.panel6.TabIndex = 5;
            // 
            // bCancel
            // 
            this.bCancel.ActiveBorderThickness = 1;
            this.bCancel.ActiveCornerRadius = 20;
            this.bCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bCancel.ActiveForecolor = System.Drawing.Color.White;
            this.bCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bCancel.BackColor = System.Drawing.Color.Maroon;
            this.bCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCancel.BackgroundImage")));
            this.bCancel.ButtonText = "THOÁT";
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bCancel.IdleBorderThickness = 1;
            this.bCancel.IdleCornerRadius = 20;
            this.bCancel.IdleFillColor = System.Drawing.Color.White;
            this.bCancel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bCancel.Location = new System.Drawing.Point(0, 216);
            this.bCancel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(253, 72);
            this.bCancel.TabIndex = 3;
            this.bCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // bDeleteItem
            // 
            this.bDeleteItem.ActiveBorderThickness = 1;
            this.bDeleteItem.ActiveCornerRadius = 20;
            this.bDeleteItem.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteItem.ActiveForecolor = System.Drawing.Color.White;
            this.bDeleteItem.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteItem.BackColor = System.Drawing.Color.Maroon;
            this.bDeleteItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDeleteItem.BackgroundImage")));
            this.bDeleteItem.ButtonText = "XÓA MÓN";
            this.bDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDeleteItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteItem.IdleBorderThickness = 1;
            this.bDeleteItem.IdleCornerRadius = 20;
            this.bDeleteItem.IdleFillColor = System.Drawing.Color.White;
            this.bDeleteItem.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteItem.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bDeleteItem.Location = new System.Drawing.Point(0, 144);
            this.bDeleteItem.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bDeleteItem.Name = "bDeleteItem";
            this.bDeleteItem.Size = new System.Drawing.Size(253, 72);
            this.bDeleteItem.TabIndex = 2;
            this.bDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bChangeInfoItem
            // 
            this.bChangeInfoItem.ActiveBorderThickness = 1;
            this.bChangeInfoItem.ActiveCornerRadius = 20;
            this.bChangeInfoItem.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoItem.ActiveForecolor = System.Drawing.Color.White;
            this.bChangeInfoItem.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoItem.BackColor = System.Drawing.Color.Maroon;
            this.bChangeInfoItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bChangeInfoItem.BackgroundImage")));
            this.bChangeInfoItem.ButtonText = "SỬA MÓN";
            this.bChangeInfoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChangeInfoItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.bChangeInfoItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChangeInfoItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoItem.IdleBorderThickness = 1;
            this.bChangeInfoItem.IdleCornerRadius = 20;
            this.bChangeInfoItem.IdleFillColor = System.Drawing.Color.White;
            this.bChangeInfoItem.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoItem.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bChangeInfoItem.Location = new System.Drawing.Point(0, 72);
            this.bChangeInfoItem.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bChangeInfoItem.Name = "bChangeInfoItem";
            this.bChangeInfoItem.Size = new System.Drawing.Size(253, 72);
            this.bChangeInfoItem.TabIndex = 1;
            this.bChangeInfoItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bChangeInfoItem.Click += new System.EventHandler(this.BChangeInfoItem_Click);
            // 
            // bAddItem
            // 
            this.bAddItem.ActiveBorderThickness = 1;
            this.bAddItem.ActiveCornerRadius = 20;
            this.bAddItem.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddItem.ActiveForecolor = System.Drawing.Color.White;
            this.bAddItem.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddItem.BackColor = System.Drawing.Color.Maroon;
            this.bAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAddItem.BackgroundImage")));
            this.bAddItem.ButtonText = "THÊM MÓN";
            this.bAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.bAddItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddItem.IdleBorderThickness = 1;
            this.bAddItem.IdleCornerRadius = 20;
            this.bAddItem.IdleFillColor = System.Drawing.Color.White;
            this.bAddItem.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddItem.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.bAddItem.Location = new System.Drawing.Point(0, 0);
            this.bAddItem.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bAddItem.Name = "bAddItem";
            this.bAddItem.Size = new System.Drawing.Size(253, 72);
            this.bAddItem.TabIndex = 0;
            this.bAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1339, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THỰC ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1339, 803);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thực đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuItem_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private ns1.BunifuThinButton2 bAddItem;
        private System.Windows.Forms.Panel panel4;
        private ns1.BunifuThinButton2 bChangeInfoItem;
        private ns1.BunifuThinButton2 bCancel;
        private ns1.BunifuThinButton2 bDeleteItem;
        private ns1.BunifuThinButton2 bFind;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcSoLanPhucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPrice;
    }
}