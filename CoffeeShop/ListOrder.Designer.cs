namespace CoffeeShopManagement
{
    partial class ListOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btCong = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btTru = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbSoLuongMon = new System.Windows.Forms.TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSoTien
            // 
            this.lbSoTien.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lbSoTien.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSoTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSoTien.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbSoTien.Location = new System.Drawing.Point(0, 0);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(138, 57);
            this.lbSoTien.TabIndex = 12;
            this.lbSoTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTenMon
            // 
            this.lbTenMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbTenMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTenMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTenMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMon.ForeColor = System.Drawing.Color.Black;
            this.lbTenMon.Location = new System.Drawing.Point(138, 0);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(167, 57);
            this.lbTenMon.TabIndex = 11;
            this.lbTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btCong);
            this.guna2GradientPanel1.Controls.Add(this.btTru);
            this.guna2GradientPanel1.Controls.Add(this.tbSoLuongMon);
            this.guna2GradientPanel1.Controls.Add(this.lbTenMon);
            this.guna2GradientPanel1.Controls.Add(this.lbSoTien);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DimGray;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Salmon;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(534, 57);
            this.guna2GradientPanel1.TabIndex = 16;
            // 
            // btCong
            // 
            this.btCong.Animated = true;
            this.btCong.CheckedState.Parent = this.btCong;
            this.btCong.CustomImages.Parent = this.btCong;
            this.btCong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCong.FillColor = System.Drawing.Color.Sienna;
            this.btCong.FillColor2 = System.Drawing.Color.Silver;
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btCong.ForeColor = System.Drawing.Color.Lime;
            this.btCong.HoverState.Parent = this.btCong;
            this.btCong.Location = new System.Drawing.Point(450, 0);
            this.btCong.Name = "btCong";
            this.btCong.ShadowDecoration.Parent = this.btCong;
            this.btCong.Size = new System.Drawing.Size(80, 57);
            this.btCong.TabIndex = 17;
            this.btCong.Text = "Tăng";
            this.btCong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtCong_MouseDown);
            // 
            // btTru
            // 
            this.btTru.Animated = true;
            this.btTru.CheckedState.Parent = this.btTru;
            this.btTru.CustomImages.Parent = this.btTru;
            this.btTru.Dock = System.Windows.Forms.DockStyle.Left;
            this.btTru.FillColor = System.Drawing.Color.YellowGreen;
            this.btTru.FillColor2 = System.Drawing.Color.Silver;
            this.btTru.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btTru.ForeColor = System.Drawing.Color.Red;
            this.btTru.HoverState.Parent = this.btTru;
            this.btTru.Location = new System.Drawing.Point(370, 0);
            this.btTru.Name = "btTru";
            this.btTru.ShadowDecoration.Parent = this.btTru;
            this.btTru.Size = new System.Drawing.Size(80, 57);
            this.btTru.TabIndex = 18;
            this.btTru.Text = "Giảm";
            this.btTru.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtTru_MouseDown);
            // 
            // tbSoLuongMon
            // 
            this.tbSoLuongMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbSoLuongMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbSoLuongMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuongMon.Location = new System.Drawing.Point(305, 0);
            this.tbSoLuongMon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbSoLuongMon.Multiline = true;
            this.tbSoLuongMon.Name = "tbSoLuongMon";
            this.tbSoLuongMon.Size = new System.Drawing.Size(65, 57);
            this.tbSoLuongMon.TabIndex = 17;
            this.tbSoLuongMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSoLuongMon.TextChanged += new System.EventHandler(this.TbSoLuongMon_TextChanged);
            this.tbSoLuongMon.Enter += new System.EventHandler(this.TbSoLuongMon_Enter);
            this.tbSoLuongMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSoLuongMon_KeyPress);
            this.tbSoLuongMon.Leave += new System.EventHandler(this.TbSoLuongMon_Leave);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.guna2GradientPanel1;
            // 
            // ListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2GradientPanel1);
            this.DoubleBuffered = true;
            this.Name = "ListOrder";
            this.Size = new System.Drawing.Size(540, 60);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbTenMon;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btCong;
        private Guna.UI2.WinForms.Guna2GradientButton btTru;
        private System.Windows.Forms.TextBox tbSoLuongMon;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
