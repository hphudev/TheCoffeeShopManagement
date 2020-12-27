namespace GUI
{
    partial class FormAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddItem));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbImageItem = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bAddImage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bOK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageItem)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(718, 84);
            this.guna2GradientPanel1.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(346, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 41);
            this.label1.TabIndex = 112;
            this.label1.Text = "THÊM MÓN";
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbImageItem);
            this.panel2.Location = new System.Drawing.Point(12, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 314);
            this.panel2.TabIndex = 121;
            // 
            // pbImageItem
            // 
            this.pbImageItem.BackColor = System.Drawing.Color.Bisque;
            this.pbImageItem.Image = global::CoffeeShopManagement.Properties.Resources.LogoLogin;
            this.pbImageItem.Location = new System.Drawing.Point(15, 12);
            this.pbImageItem.Name = "pbImageItem";
            this.pbImageItem.Size = new System.Drawing.Size(272, 284);
            this.pbImageItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageItem.TabIndex = 12;
            this.pbImageItem.TabStop = false;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.AutoScroll = true;
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.cbUnit);
            this.guna2GroupBox2.Controls.Add(this.label20);
            this.guna2GroupBox2.Controls.Add(this.tbPrice);
            this.guna2GroupBox2.Controls.Add(this.label21);
            this.guna2GroupBox2.Controls.Add(this.label23);
            this.guna2GroupBox2.Controls.Add(this.tbName);
            this.guna2GroupBox2.Controls.Add(this.pictureBox2);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2GroupBox2.Location = new System.Drawing.Point(320, 212);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(386, 350);
            this.guna2GroupBox2.TabIndex = 122;
            this.guna2GroupBox2.Text = "Thông tin món";
            // 
            // cbUnit
            // 
            this.cbUnit.Animated = true;
            this.cbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cbUnit.BorderColor = System.Drawing.Color.Bisque;
            this.cbUnit.BorderRadius = 5;
            this.cbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FillColor = System.Drawing.Color.Ivory;
            this.cbUnit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbUnit.FocusedState.Parent = this.cbUnit;
            this.cbUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbUnit.ForeColor = System.Drawing.Color.Black;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.HoverState.Parent = this.cbUnit;
            this.cbUnit.ItemHeight = 30;
            this.cbUnit.Items.AddRange(new object[] {
            "Ly",
            "Lon",
            "Chai",
            "Cái",
            "Cốc",
            "Dĩa",
            "Tô",
            "Chén"});
            this.cbUnit.ItemsAppearance.Parent = this.cbUnit;
            this.cbUnit.Location = new System.Drawing.Point(14, 192);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.ShadowDecoration.Parent = this.cbUnit;
            this.cbUnit.Size = new System.Drawing.Size(177, 36);
            this.cbUnit.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(10, 242);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 23);
            this.label20.TabIndex = 16;
            this.label20.Text = "Giá";
            // 
            // tbPrice
            // 
            this.tbPrice.Animated = true;
            this.tbPrice.BackColor = System.Drawing.Color.Transparent;
            this.tbPrice.BorderColor = System.Drawing.Color.Bisque;
            this.tbPrice.BorderRadius = 5;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.Parent = this.tbPrice;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FillColor = System.Drawing.Color.Ivory;
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbPrice.FocusedState.Parent = this.tbPrice;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbPrice.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.HoverState.Parent = this.tbPrice;
            this.tbPrice.IconLeft = global::CoffeeShopManagement.Properties.Resources.Money;
            this.tbPrice.Location = new System.Drawing.Point(14, 275);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.SelectedText = "";
            this.tbPrice.ShadowDecoration.Parent = this.tbPrice;
            this.tbPrice.Size = new System.Drawing.Size(350, 47);
            this.tbPrice.TabIndex = 15;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(10, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 14;
            this.label21.Text = "Đơn vị tính";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(10, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 23);
            this.label23.TabIndex = 9;
            this.label23.Text = "Tên món";
            // 
            // tbName
            // 
            this.tbName.Animated = true;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BorderColor = System.Drawing.Color.Bisque;
            this.tbName.BorderRadius = 5;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FillColor = System.Drawing.Color.Ivory;
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.IconLeft = global::CoffeeShopManagement.Properties.Resources.Food;
            this.tbName.Location = new System.Drawing.Point(14, 95);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(350, 47);
            this.tbName.TabIndex = 2;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 293);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 135;
            this.pictureBox2.TabStop = false;
            // 
            // bAddImage
            // 
            this.bAddImage.Animated = true;
            this.bAddImage.BackColor = System.Drawing.Color.SeaShell;
            this.bAddImage.BorderRadius = 13;
            this.bAddImage.CheckedState.Parent = this.bAddImage;
            this.bAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddImage.CustomImages.Parent = this.bAddImage;
            this.bAddImage.FillColor = System.Drawing.Color.DimGray;
            this.bAddImage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bAddImage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bAddImage.ForeColor = System.Drawing.Color.White;
            this.bAddImage.HoverState.Parent = this.bAddImage;
            this.bAddImage.Location = new System.Drawing.Point(320, 155);
            this.bAddImage.Name = "bAddImage";
            this.bAddImage.ShadowDecoration.Parent = this.bAddImage;
            this.bAddImage.Size = new System.Drawing.Size(102, 42);
            this.bAddImage.TabIndex = 123;
            this.bAddImage.Text = "Thêm ảnh";
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
            this.bCancel.Location = new System.Drawing.Point(198, 505);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(119, 47);
            this.bCancel.TabIndex = 126;
            this.bCancel.Text = "Thoát";
            // 
            // bOK
            // 
            this.bOK.Animated = true;
            this.bOK.BackColor = System.Drawing.Color.SeaShell;
            this.bOK.BorderRadius = 18;
            this.bOK.CheckedState.Parent = this.bOK;
            this.bOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOK.CustomImages.Parent = this.bOK;
            this.bOK.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.bOK.FillColor2 = System.Drawing.Color.Teal;
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.bOK.ForeColor = System.Drawing.Color.White;
            this.bOK.HoverState.Parent = this.bOK;
            this.bOK.Location = new System.Drawing.Point(9, 504);
            this.bOK.Name = "bOK";
            this.bOK.ShadowDecoration.Parent = this.bOK;
            this.bOK.Size = new System.Drawing.Size(119, 47);
            this.bOK.TabIndex = 124;
            this.bOK.Text = "Đồng ý";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.pbImageItem;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeShopManagement.Properties.Resources.LineMenu;
            this.pictureBox1.Location = new System.Drawing.Point(33, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(718, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bAddImage);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageItem)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbImageItem;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2GradientButton bAddImage;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private Guna.UI2.WinForms.Guna2GradientButton bOK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ComboBox cbUnit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}