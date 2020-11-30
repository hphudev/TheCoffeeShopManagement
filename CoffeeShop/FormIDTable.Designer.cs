namespace CoffeeShopManagement
{
    partial class FormIDTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIDTable));
            this.lbNhanKhachHang = new System.Windows.Forms.Label();
            this.tbIDTable = new System.Windows.Forms.TextBox();
            this.bOK = new ns1.BunifuThinButton2();
            this.btThoat = new ns1.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lbNhanKhachHang
            // 
            this.lbNhanKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNhanKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNhanKhachHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbNhanKhachHang.Location = new System.Drawing.Point(0, 0);
            this.lbNhanKhachHang.Name = "lbNhanKhachHang";
            this.lbNhanKhachHang.Size = new System.Drawing.Size(389, 82);
            this.lbNhanKhachHang.TabIndex = 2;
            this.lbNhanKhachHang.Text = "ID BÀN";
            this.lbNhanKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIDTable
            // 
            this.tbIDTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbIDTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIDTable.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDTable.Location = new System.Drawing.Point(0, 82);
            this.tbIDTable.Name = "tbIDTable";
            this.tbIDTable.Size = new System.Drawing.Size(389, 70);
            this.tbIDTable.TabIndex = 10;
            this.tbIDTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIDTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbIDTable_KeyPress);
            // 
            // bOK
            // 
            this.bOK.ActiveBorderThickness = 1;
            this.bOK.ActiveCornerRadius = 20;
            this.bOK.ActiveFillColor = System.Drawing.Color.Green;
            this.bOK.ActiveForecolor = System.Drawing.Color.White;
            this.bOK.ActiveLineColor = System.Drawing.Color.Green;
            this.bOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bOK.BackgroundImage")));
            this.bOK.ButtonText = "ĐỒNG Ý";
            this.bOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.ForeColor = System.Drawing.Color.Green;
            this.bOK.IdleBorderThickness = 1;
            this.bOK.IdleCornerRadius = 20;
            this.bOK.IdleFillColor = System.Drawing.Color.White;
            this.bOK.IdleForecolor = System.Drawing.Color.Green;
            this.bOK.IdleLineColor = System.Drawing.Color.Green;
            this.bOK.Location = new System.Drawing.Point(4, 153);
            this.bOK.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(139, 73);
            this.bOK.TabIndex = 13;
            this.bOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // btThoat
            // 
            this.btThoat.ActiveBorderThickness = 1;
            this.btThoat.ActiveCornerRadius = 20;
            this.btThoat.ActiveFillColor = System.Drawing.Color.Green;
            this.btThoat.ActiveForecolor = System.Drawing.Color.White;
            this.btThoat.ActiveLineColor = System.Drawing.Color.Green;
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThoat.BackgroundImage")));
            this.btThoat.ButtonText = "THOÁT";
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Green;
            this.btThoat.IdleBorderThickness = 1;
            this.btThoat.IdleCornerRadius = 20;
            this.btThoat.IdleFillColor = System.Drawing.Color.White;
            this.btThoat.IdleForecolor = System.Drawing.Color.Green;
            this.btThoat.IdleLineColor = System.Drawing.Color.Green;
            this.btThoat.Location = new System.Drawing.Point(245, 153);
            this.btThoat.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(139, 73);
            this.btThoat.TabIndex = 14;
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // FormIDTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(389, 238);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.tbIDTable);
            this.Controls.Add(this.lbNhanKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIDTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIDTable_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhanKhachHang;
        private System.Windows.Forms.TextBox tbIDTable;
        private ns1.BunifuThinButton2 bOK;
        private ns1.BunifuThinButton2 btThoat;
    }
}