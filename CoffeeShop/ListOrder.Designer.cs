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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCong = new System.Windows.Forms.Button();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.lbSoLuongMon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btTru = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btCong);
            this.panel1.Controls.Add(this.lbSoTien);
            this.panel1.Controls.Add(this.lbTenMon);
            this.panel1.Controls.Add(this.lbSoLuongMon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btTru);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 59);
            this.panel1.TabIndex = 0;
            // 
            // btCong
            // 
            this.btCong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btCong.Location = new System.Drawing.Point(441, 0);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(77, 59);
            this.btCong.TabIndex = 13;
            this.btCong.Text = "Tăng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtCong_MouseDown);
            // 
            // lbSoTien
            // 
            this.lbSoTien.BackColor = System.Drawing.Color.White;
            this.lbSoTien.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSoTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSoTien.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbSoTien.Location = new System.Drawing.Point(317, 0);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(124, 59);
            this.lbSoTien.TabIndex = 12;
            this.lbSoTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTenMon
            // 
            this.lbTenMon.BackColor = System.Drawing.Color.White;
            this.lbTenMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTenMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTenMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMon.ForeColor = System.Drawing.Color.Black;
            this.lbTenMon.Location = new System.Drawing.Point(150, 0);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(167, 59);
            this.lbTenMon.TabIndex = 11;
            this.lbTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSoLuongMon
            // 
            this.lbSoLuongMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbSoLuongMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSoLuongMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSoLuongMon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbSoLuongMon.Location = new System.Drawing.Point(85, 0);
            this.lbSoLuongMon.Name = "lbSoLuongMon";
            this.lbSoLuongMon.Size = new System.Drawing.Size(65, 59);
            this.lbSoLuongMon.TabIndex = 10;
            this.lbSoLuongMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(75, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 59);
            this.panel2.TabIndex = 9;
            // 
            // btTru
            // 
            this.btTru.Dock = System.Windows.Forms.DockStyle.Left;
            this.btTru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btTru.Location = new System.Drawing.Point(0, 0);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 59);
            this.btTru.TabIndex = 8;
            this.btTru.Text = "Giảm";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtTru_MouseDown);
            // 
            // ListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "ListOrder";
            this.Size = new System.Drawing.Size(518, 59);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.Label lbSoLuongMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTru;
    }
}
