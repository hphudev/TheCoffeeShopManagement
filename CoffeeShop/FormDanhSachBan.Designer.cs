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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btThanhToan = new ns1.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btThoat = new ns1.BunifuThinButton2();
            this.flpTable = new CoffeeShopManagement.FlowLayoutPanelBuffered();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 88);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1304, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH BÀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbTimKiem);
            this.panel2.Controls.Add(this.btThanhToan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 48);
            this.panel2.TabIndex = 2;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.BackColor = System.Drawing.Color.Maroon;
            this.tbTimKiem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.ForeColor = System.Drawing.Color.White;
            this.tbTimKiem.Location = new System.Drawing.Point(881, 6);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(246, 41);
            this.tbTimKiem.TabIndex = 0;
            this.tbTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btThanhToan
            // 
            this.btThanhToan.ActiveBorderThickness = 1;
            this.btThanhToan.ActiveCornerRadius = 20;
            this.btThanhToan.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThanhToan.ActiveForecolor = System.Drawing.Color.White;
            this.btThanhToan.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThanhToan.BackColor = System.Drawing.Color.Maroon;
            this.btThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThanhToan.BackgroundImage")));
            this.btThanhToan.ButtonText = "THANH TOÁN";
            this.btThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThanhToan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.SeaGreen;
            this.btThanhToan.IdleBorderThickness = 1;
            this.btThanhToan.IdleCornerRadius = 10;
            this.btThanhToan.IdleFillColor = System.Drawing.Color.White;
            this.btThanhToan.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThanhToan.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThanhToan.Location = new System.Drawing.Point(1135, 0);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(169, 48);
            this.btThanhToan.TabIndex = 3;
            this.btThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThanhToan.Click += new System.EventHandler(this.BtThanhToan_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1304, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btThoat);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 654);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1304, 65);
            this.panel4.TabIndex = 4;
            // 
            // btThoat
            // 
            this.btThoat.ActiveBorderThickness = 1;
            this.btThoat.ActiveCornerRadius = 20;
            this.btThoat.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThoat.ActiveForecolor = System.Drawing.Color.Red;
            this.btThoat.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThoat.BackgroundImage")));
            this.btThoat.ButtonText = "THOÁT";
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.IdleBorderThickness = 1;
            this.btThoat.IdleCornerRadius = 20;
            this.btThoat.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btThoat.IdleForecolor = System.Drawing.Color.White;
            this.btThoat.IdleLineColor = System.Drawing.Color.White;
            this.btThoat.Location = new System.Drawing.Point(1123, 0);
            this.btThoat.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(181, 65);
            this.btThoat.TabIndex = 6;
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(0, 146);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1304, 508);
            this.flpTable.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(772, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID BÀN";
            // 
            // FormDanhSachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1304, 719);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_DanhSachBan";
            this.TransparencyKey = System.Drawing.Color.Azure;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_DanhSachBan_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuThinButton2 btThanhToan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private ns1.BunifuThinButton2 btThoat;
        private FlowLayoutPanelBuffered flpTable;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label2;
    }
}