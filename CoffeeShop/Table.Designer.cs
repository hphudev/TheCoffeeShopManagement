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
            this.SuspendLayout();
            // 
            // lbTable
            // 
            this.lbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTable.Font = new System.Drawing.Font("Segoe UI", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.Location = new System.Drawing.Point(0, 0);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(217, 217);
            this.lbTable.TabIndex = 0;
            this.lbTable.Text = "10";
            this.lbTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LbTable_MouseClick);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.lbTable);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(217, 217);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTable;
    }
}
