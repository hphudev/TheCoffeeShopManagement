namespace CoffeeShopManagement
{
    partial class FormQuanLyLoaiKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddObj = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bChangeInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bDeleteObj = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TENLKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENTICHLUY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 86);
            this.label1.TabIndex = 113;
            this.label1.Text = "QUẢN LÍ LOẠI KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bAddObj
            // 
            this.bAddObj.Animated = true;
            this.bAddObj.BackColor = System.Drawing.Color.Transparent;
            this.bAddObj.BorderRadius = 15;
            this.bAddObj.CheckedState.Parent = this.bAddObj;
            this.bAddObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddObj.CustomImages.Parent = this.bAddObj;
            this.bAddObj.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bAddObj.FillColor2 = System.Drawing.Color.Teal;
            this.bAddObj.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bAddObj.ForeColor = System.Drawing.Color.White;
            this.bAddObj.HoverState.Parent = this.bAddObj;
            this.bAddObj.Location = new System.Drawing.Point(434, 412);
            this.bAddObj.Name = "bAddObj";
            this.bAddObj.ShadowDecoration.Parent = this.bAddObj;
            this.bAddObj.Size = new System.Drawing.Size(107, 47);
            this.bAddObj.TabIndex = 126;
            this.bAddObj.Text = "Thêm";
            this.bAddObj.Click += new System.EventHandler(this.BAddObj_Click);
            // 
            // bChangeInfo
            // 
            this.bChangeInfo.Animated = true;
            this.bChangeInfo.BackColor = System.Drawing.Color.Transparent;
            this.bChangeInfo.BorderRadius = 15;
            this.bChangeInfo.CheckedState.Parent = this.bChangeInfo;
            this.bChangeInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChangeInfo.CustomImages.Parent = this.bChangeInfo;
            this.bChangeInfo.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bChangeInfo.FillColor2 = System.Drawing.Color.Teal;
            this.bChangeInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bChangeInfo.ForeColor = System.Drawing.Color.White;
            this.bChangeInfo.HoverState.Parent = this.bChangeInfo;
            this.bChangeInfo.Location = new System.Drawing.Point(568, 412);
            this.bChangeInfo.Name = "bChangeInfo";
            this.bChangeInfo.ShadowDecoration.Parent = this.bChangeInfo;
            this.bChangeInfo.Size = new System.Drawing.Size(107, 47);
            this.bChangeInfo.TabIndex = 125;
            this.bChangeInfo.Text = "Sửa";
            this.bChangeInfo.Click += new System.EventHandler(this.BChangeInfo_Click);
            // 
            // bDeleteObj
            // 
            this.bDeleteObj.Animated = true;
            this.bDeleteObj.BackColor = System.Drawing.Color.Transparent;
            this.bDeleteObj.BorderRadius = 15;
            this.bDeleteObj.CheckedState.Parent = this.bDeleteObj;
            this.bDeleteObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteObj.CustomImages.Parent = this.bDeleteObj;
            this.bDeleteObj.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bDeleteObj.FillColor2 = System.Drawing.Color.Teal;
            this.bDeleteObj.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bDeleteObj.ForeColor = System.Drawing.Color.White;
            this.bDeleteObj.HoverState.Parent = this.bDeleteObj;
            this.bDeleteObj.Location = new System.Drawing.Point(701, 412);
            this.bDeleteObj.Name = "bDeleteObj";
            this.bDeleteObj.ShadowDecoration.Parent = this.bDeleteObj;
            this.bDeleteObj.Size = new System.Drawing.Size(107, 47);
            this.bDeleteObj.TabIndex = 124;
            this.bDeleteObj.Text = "Xóa";
            this.bDeleteObj.Click += new System.EventHandler(this.BDeleteObj_Click);
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
            this.panel1.Size = new System.Drawing.Size(819, 86);
            this.panel1.TabIndex = 131;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.bCancel);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(729, 12);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(79, 64);
            this.guna2ShadowPanel1.TabIndex = 132;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENLKH,
            this.TIENTICHLUY});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMenu.Location = new System.Drawing.Point(0, 86);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(819, 301);
            this.dgvMenu.TabIndex = 132;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // TENLKH
            // 
            this.TENLKH.HeaderText = "Loại khách hàng";
            this.TENLKH.MinimumWidth = 6;
            this.TENLKH.Name = "TENLKH";
            this.TENLKH.ReadOnly = true;
            // 
            // TIENTICHLUY
            // 
            this.TIENTICHLUY.HeaderText = "Doanh số tối thiểu";
            this.TIENTICHLUY.MinimumWidth = 6;
            this.TIENTICHLUY.Name = "TIENTICHLUY";
            this.TIENTICHLUY.ReadOnly = true;
            // 
            // FormQuanLyLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(819, 487);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bAddObj);
            this.Controls.Add(this.bChangeInfo);
            this.Controls.Add(this.bDeleteObj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuanLyLoaiKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.FormQuanLyLoaiKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected Guna.UI2.WinForms.Guna2GradientButton bAddObj;
        protected Guna.UI2.WinForms.Guna2GradientButton bChangeInfo;
        protected Guna.UI2.WinForms.Guna2GradientButton bDeleteObj;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENTICHLUY;
    }
}