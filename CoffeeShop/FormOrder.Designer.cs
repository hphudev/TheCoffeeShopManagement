namespace CoffeeShopManagement
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThoat = new ns1.BunifuThinButton2();
            this.btLuuOrder = new ns1.BunifuThinButton2();
            this.btThemBan = new ns1.BunifuThinButton2();
            this.btThanhToan = new ns1.BunifuThinButton2();
            this.printBill = new System.Drawing.Printing.PrintDocument();
            this.printPreviewBill = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btLuuOrder);
            this.panel1.Controls.Add(this.btThemBan);
            this.panel1.Controls.Add(this.btThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 248);
            this.panel1.TabIndex = 0;
            // 
            // btThoat
            // 
            this.btThoat.ActiveBorderThickness = 1;
            this.btThoat.ActiveCornerRadius = 20;
            this.btThoat.ActiveFillColor = System.Drawing.Color.White;
            this.btThoat.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btThoat.ActiveLineColor = System.Drawing.Color.White;
            this.btThoat.BackColor = System.Drawing.Color.Gray;
            this.btThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThoat.BackgroundImage")));
            this.btThoat.ButtonText = "THOÁT";
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.IdleBorderThickness = 1;
            this.btThoat.IdleCornerRadius = 20;
            this.btThoat.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btThoat.IdleForecolor = System.Drawing.Color.White;
            this.btThoat.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btThoat.Location = new System.Drawing.Point(801, 0);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(267, 248);
            this.btThoat.TabIndex = 6;
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLuuOrder
            // 
            this.btLuuOrder.ActiveBorderThickness = 1;
            this.btLuuOrder.ActiveCornerRadius = 20;
            this.btLuuOrder.ActiveFillColor = System.Drawing.Color.White;
            this.btLuuOrder.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btLuuOrder.ActiveLineColor = System.Drawing.Color.White;
            this.btLuuOrder.BackColor = System.Drawing.Color.Gray;
            this.btLuuOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLuuOrder.BackgroundImage")));
            this.btLuuOrder.ButtonText = "LƯU ORDER";
            this.btLuuOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLuuOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btLuuOrder.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuuOrder.ForeColor = System.Drawing.Color.White;
            this.btLuuOrder.IdleBorderThickness = 1;
            this.btLuuOrder.IdleCornerRadius = 20;
            this.btLuuOrder.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btLuuOrder.IdleForecolor = System.Drawing.Color.White;
            this.btLuuOrder.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btLuuOrder.Location = new System.Drawing.Point(534, 0);
            this.btLuuOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btLuuOrder.Name = "btLuuOrder";
            this.btLuuOrder.Size = new System.Drawing.Size(267, 248);
            this.btLuuOrder.TabIndex = 5;
            this.btLuuOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btThemBan
            // 
            this.btThemBan.ActiveBorderThickness = 1;
            this.btThemBan.ActiveCornerRadius = 20;
            this.btThemBan.ActiveFillColor = System.Drawing.Color.White;
            this.btThemBan.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btThemBan.ActiveLineColor = System.Drawing.Color.White;
            this.btThemBan.BackColor = System.Drawing.Color.Gray;
            this.btThemBan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThemBan.BackgroundImage")));
            this.btThemBan.ButtonText = "THÊM BÀN";
            this.btThemBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btThemBan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemBan.ForeColor = System.Drawing.Color.White;
            this.btThemBan.IdleBorderThickness = 1;
            this.btThemBan.IdleCornerRadius = 20;
            this.btThemBan.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btThemBan.IdleForecolor = System.Drawing.Color.White;
            this.btThemBan.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btThemBan.Location = new System.Drawing.Point(267, 0);
            this.btThemBan.Margin = new System.Windows.Forms.Padding(5);
            this.btThemBan.Name = "btThemBan";
            this.btThemBan.Size = new System.Drawing.Size(267, 248);
            this.btThemBan.TabIndex = 4;
            this.btThemBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThemBan.Click += new System.EventHandler(this.BtThemBan_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.ActiveBorderThickness = 1;
            this.btThanhToan.ActiveCornerRadius = 20;
            this.btThanhToan.ActiveFillColor = System.Drawing.Color.White;
            this.btThanhToan.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThanhToan.ActiveLineColor = System.Drawing.Color.White;
            this.btThanhToan.BackColor = System.Drawing.Color.Gray;
            this.btThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThanhToan.BackgroundImage")));
            this.btThanhToan.ButtonText = "THANH TOÁN";
            this.btThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThanhToan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btThanhToan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.White;
            this.btThanhToan.IdleBorderThickness = 1;
            this.btThanhToan.IdleCornerRadius = 20;
            this.btThanhToan.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThanhToan.IdleForecolor = System.Drawing.Color.White;
            this.btThanhToan.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThanhToan.Location = new System.Drawing.Point(0, 0);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(267, 248);
            this.btThanhToan.TabIndex = 3;
            this.btThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThanhToan.Click += new System.EventHandler(this.BtThanhToan_Click);
            // 
            // printBill
            // 
            this.printBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintBill_PrintPage);
            // 
            // printPreviewBill
            // 
            this.printPreviewBill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewBill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewBill.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewBill.Enabled = true;
            this.printPreviewBill.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewBill.Icon")));
            this.printPreviewBill.Name = "printPreviewBill";
            this.printPreviewBill.Visible = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1076, 248);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Order";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Order_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuThinButton2 btThoat;
        private ns1.BunifuThinButton2 btLuuOrder;
        private ns1.BunifuThinButton2 btThemBan;
        private ns1.BunifuThinButton2 btThanhToan;
        private System.Drawing.Printing.PrintDocument printBill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewBill;
    }
}