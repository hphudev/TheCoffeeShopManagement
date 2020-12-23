namespace CoffeeShopManagement
{
    partial class FormImageStaff
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pbImageItem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageItem)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // bCancel
            // 
            this.bCancel.Animated = true;
            this.bCancel.BackColor = System.Drawing.Color.SeaShell;
            this.bCancel.BorderRadius = 18;
            this.bCancel.CheckedState.Parent = this.bCancel;
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.CustomImages.Parent = this.bCancel;
            this.bCancel.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bCancel.FillColor2 = System.Drawing.Color.Teal;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bCancel.ForeColor = System.Drawing.Color.White;
            this.bCancel.HoverState.Parent = this.bCancel;
            this.bCancel.Location = new System.Drawing.Point(428, 576);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(119, 47);
            this.bCancel.TabIndex = 140;
            this.bCancel.Text = "Thoát";
            // 
            // pbImageItem
            // 
            this.pbImageItem.BackColor = System.Drawing.Color.Bisque;
            this.pbImageItem.Image = global::CoffeeShopManagement.Properties.Resources.LogoLogin;
            this.pbImageItem.Location = new System.Drawing.Point(17, 12);
            this.pbImageItem.Name = "pbImageItem";
            this.pbImageItem.Size = new System.Drawing.Size(511, 448);
            this.pbImageItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageItem.TabIndex = 12;
            this.pbImageItem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(257, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 112;
            this.label1.Text = "ẢNH NHÂN VIÊN";
            // 
            // lID
            // 
            this.lID.BackColor = System.Drawing.Color.Transparent;
            this.lID.Dock = System.Windows.Forms.DockStyle.Left;
            this.lID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lID.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lID.ForeColor = System.Drawing.Color.White;
            this.lID.Image = global::CoffeeShopManagement.Properties.Resources.Info;
            this.lID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lID.Location = new System.Drawing.Point(0, 0);
            this.lID.Name = "lID";
            this.lID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lID.Size = new System.Drawing.Size(195, 84);
            this.lID.TabIndex = 111;
            this.lID.Text = "NV-0001";
            this.lID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.lID);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Goldenrod;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(563, 84);
            this.guna2GradientPanel1.TabIndex = 135;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.pbImageItem;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbImageItem);
            this.panel2.Location = new System.Drawing.Point(9, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 474);
            this.panel2.TabIndex = 136;
            // 
            // FormImageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(563, 629);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormImageStaff";
            this.Load += new System.EventHandler(this.FormImageStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageItem)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private System.Windows.Forms.PictureBox pbImageItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lID;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel2;
    }
}