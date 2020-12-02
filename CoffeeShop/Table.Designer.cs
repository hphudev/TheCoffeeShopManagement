namespace CoffeeShopManagement
{
    partial class Table
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
            this.lbTable = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTable
            // 
            this.lbTable.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTable.Font = new System.Drawing.Font("Segoe UI", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.ForeColor = System.Drawing.Color.Maroon;
            this.lbTable.Location = new System.Drawing.Point(0, 0);
            this.lbTable.Name = "lbTable";
            this.lbTable.Padding = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.lbTable.Size = new System.Drawing.Size(242, 245);
            this.lbTable.TabIndex = 0;
            this.lbTable.Text = "10";
            this.lbTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTable.Click += new System.EventHandler(this.LbTable_Click);
            this.lbTable.MouseEnter += new System.EventHandler(this.LbTable_MouseEnter);
            this.lbTable.MouseLeave += new System.EventHandler(this.LbTable_MouseLeave);
            // 
            // lbTongTien
            // 
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lbTongTien.ForeColor = System.Drawing.Color.Yellow;
            this.lbTongTien.Location = new System.Drawing.Point(0, 199);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(242, 46);
            this.lbTongTien.TabIndex = 1;
            this.lbTongTien.Text = "10.000.000";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbTable);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(242, 245);
            this.MouseEnter += new System.EventHandler(this.Table_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Table_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Label lbTongTien;
    }
}
