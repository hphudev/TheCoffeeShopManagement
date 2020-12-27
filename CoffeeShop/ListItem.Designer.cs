namespace CoffeeShopManagement
{
    partial class ListItem
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
            this.lbTenMon = new System.Windows.Forms.Label();
            this.pbAnhMon = new System.Windows.Forms.PictureBox();
            this.lbCost = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhMon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenMon
            // 
            this.lbTenMon.BackColor = System.Drawing.Color.DarkSalmon;
            this.lbTenMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTenMon.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMon.ForeColor = System.Drawing.Color.Honeydew;
            this.lbTenMon.Location = new System.Drawing.Point(0, 207);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(304, 108);
            this.lbTenMon.TabIndex = 0;
            this.lbTenMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTenMon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LbTenMon_MouseClick);
            this.lbTenMon.MouseEnter += new System.EventHandler(this.lbTenMon_MouseEnter);
            this.lbTenMon.MouseLeave += new System.EventHandler(this.lbTenMon_MouseLeave);
            // 
            // pbAnhMon
            // 
            this.pbAnhMon.BackColor = System.Drawing.Color.Transparent;
            this.pbAnhMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAnhMon.Location = new System.Drawing.Point(0, 0);
            this.pbAnhMon.Name = "pbAnhMon";
            this.pbAnhMon.Size = new System.Drawing.Size(304, 207);
            this.pbAnhMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnhMon.TabIndex = 1;
            this.pbAnhMon.TabStop = false;
            this.pbAnhMon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAnhMon_MouseClick);
            this.pbAnhMon.MouseEnter += new System.EventHandler(this.pbAnhMon_MouseEnter);
            this.pbAnhMon.MouseLeave += new System.EventHandler(this.pbAnhMon_MouseLeave);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbCost.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbCost.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCost.Location = new System.Drawing.Point(199, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(105, 41);
            this.lbCost.TabIndex = 2;
            this.lbCost.Text = "3000K";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.lbCost;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.pbAnhMon);
            this.Controls.Add(this.lbTenMon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(304, 315);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.PictureBox pbAnhMon;
        private System.Windows.Forms.Label lbCost;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
