namespace CoffeeShopManagement
{
    partial class ListOrdering
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbID.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Brown;
            this.lbID.Location = new System.Drawing.Point(0, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(100, 57);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "10";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbThongTin
            // 
            this.lbThongTin.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lbThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbThongTin.Location = new System.Drawing.Point(100, 0);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(416, 57);
            this.lbThongTin.TabIndex = 1;
            this.lbThongTin.Text = "Anh Phương";
            this.lbThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbThongTin.Click += new System.EventHandler(this.LbThongTin_Click);
            // 
            // ListOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.lbID);
            this.Name = "ListOrdering";
            this.Size = new System.Drawing.Size(516, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbThongTin;
    }
}
