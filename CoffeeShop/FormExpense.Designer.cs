namespace CoffeeShopManagement
{
    partial class FormExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpense));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.epShowError = new System.Windows.Forms.ErrorProvider(this.components);
            this.bCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bOK = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbBackGround = new System.Windows.Forms.PictureBox();
            this.gbExpense = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lID = new System.Windows.Forms.Label();
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epShowError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGround)).BeginInit();
            this.gbExpense.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeeShopManagement.Properties.Resources.LineMenu;
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // epShowError
            // 
            this.epShowError.ContainerControl = this;
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
            this.bCancel.Location = new System.Drawing.Point(429, 609);
            this.bCancel.Name = "bCancel";
            this.bCancel.ShadowDecoration.Parent = this.bCancel;
            this.bCancel.Size = new System.Drawing.Size(119, 47);
            this.bCancel.TabIndex = 140;
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
            this.bOK.Location = new System.Drawing.Point(12, 609);
            this.bOK.Name = "bOK";
            this.bOK.ShadowDecoration.Parent = this.bOK;
            this.bOK.Size = new System.Drawing.Size(119, 47);
            this.bOK.TabIndex = 139;
            this.bOK.Text = "Đồng ý";
            // 
            // cbType
            // 
            this.cbType.Animated = true;
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderColor = System.Drawing.Color.Bisque;
            this.cbType.BorderRadius = 5;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FillColor = System.Drawing.Color.Ivory;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbType.FocusedState.Parent = this.cbType;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbType.ForeColor = System.Drawing.Color.Black;
            this.cbType.FormattingEnabled = true;
            this.cbType.HoverState.Parent = this.cbType;
            this.cbType.ItemHeight = 30;
            this.cbType.Items.AddRange(new object[] {
            "Trả lương",
            "Khác"});
            this.cbType.ItemsAppearance.Parent = this.cbType;
            this.cbType.Location = new System.Drawing.Point(14, 281);
            this.cbType.Name = "cbType";
            this.cbType.ShadowDecoration.Parent = this.cbType;
            this.cbType.Size = new System.Drawing.Size(245, 36);
            this.cbType.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(10, 246);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 23);
            this.label20.TabIndex = 16;
            this.label20.Text = "Loại chi tiêu";
            // 
            // tbValue
            // 
            this.tbValue.Animated = true;
            this.tbValue.BackColor = System.Drawing.Color.Transparent;
            this.tbValue.BorderColor = System.Drawing.Color.Bisque;
            this.tbValue.BorderRadius = 5;
            this.tbValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbValue.DefaultText = "";
            this.tbValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbValue.DisabledState.Parent = this.tbValue;
            this.tbValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbValue.FillColor = System.Drawing.Color.Ivory;
            this.tbValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbValue.FocusedState.Parent = this.tbValue;
            this.tbValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbValue.ForeColor = System.Drawing.Color.Black;
            this.tbValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbValue.HoverState.Parent = this.tbValue;
            this.tbValue.IconLeft = global::CoffeeShopManagement.Properties.Resources.Money;
            this.tbValue.Location = new System.Drawing.Point(14, 193);
            this.tbValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbValue.Name = "tbValue";
            this.tbValue.PasswordChar = '\0';
            this.tbValue.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbValue.PlaceholderText = "";
            this.tbValue.SelectedText = "";
            this.tbValue.ShadowDecoration.Parent = this.tbValue;
            this.tbValue.Size = new System.Drawing.Size(396, 47);
            this.tbValue.TabIndex = 15;
            this.tbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label21.Size = new System.Drawing.Size(66, 23);
            this.label21.TabIndex = 14;
            this.label21.Text = "Số tiền";
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
            this.label23.Size = new System.Drawing.Size(85, 23);
            this.label23.TabIndex = 9;
            this.label23.Text = "Nội dung";
            // 
            // tbContent
            // 
            this.tbContent.Animated = true;
            this.tbContent.BackColor = System.Drawing.Color.Transparent;
            this.tbContent.BorderColor = System.Drawing.Color.Bisque;
            this.tbContent.BorderRadius = 5;
            this.tbContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContent.DefaultText = "";
            this.tbContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbContent.DisabledState.Parent = this.tbContent;
            this.tbContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbContent.FillColor = System.Drawing.Color.Ivory;
            this.tbContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbContent.FocusedState.Parent = this.tbContent;
            this.tbContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbContent.ForeColor = System.Drawing.Color.Black;
            this.tbContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbContent.HoverState.Parent = this.tbContent;
            this.tbContent.IconLeft = global::CoffeeShopManagement.Properties.Resources.Info1;
            this.tbContent.Location = new System.Drawing.Point(14, 95);
            this.tbContent.Margin = new System.Windows.Forms.Padding(2);
            this.tbContent.Name = "tbContent";
            this.tbContent.PasswordChar = '\0';
            this.tbContent.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbContent.PlaceholderText = "";
            this.tbContent.SelectedText = "";
            this.tbContent.ShadowDecoration.Parent = this.tbContent;
            this.tbContent.Size = new System.Drawing.Size(396, 47);
            this.tbContent.TabIndex = 2;
            this.tbContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbBackGround
            // 
            this.pbBackGround.BackColor = System.Drawing.Color.Transparent;
            this.pbBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pbBackGround.Image")));
            this.pbBackGround.Location = new System.Drawing.Point(28, 46);
            this.pbBackGround.Name = "pbBackGround";
            this.pbBackGround.Size = new System.Drawing.Size(505, 378);
            this.pbBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackGround.TabIndex = 135;
            this.pbBackGround.TabStop = false;
            // 
            // gbExpense
            // 
            this.gbExpense.AutoScroll = true;
            this.gbExpense.BorderRadius = 10;
            this.gbExpense.Controls.Add(this.lID);
            this.gbExpense.Controls.Add(this.tbID);
            this.gbExpense.Controls.Add(this.cbType);
            this.gbExpense.Controls.Add(this.label20);
            this.gbExpense.Controls.Add(this.tbValue);
            this.gbExpense.Controls.Add(this.label21);
            this.gbExpense.Controls.Add(this.label23);
            this.gbExpense.Controls.Add(this.tbContent);
            this.gbExpense.Controls.Add(this.pbBackGround);
            this.gbExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbExpense.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbExpense.Location = new System.Drawing.Point(12, 158);
            this.gbExpense.Name = "gbExpense";
            this.gbExpense.ShadowDecoration.Parent = this.gbExpense;
            this.gbExpense.Size = new System.Drawing.Size(536, 445);
            this.gbExpense.TabIndex = 137;
            this.gbExpense.Text = "Thông tin chi tiêu";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.BackColor = System.Drawing.Color.Transparent;
            this.lID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lID.Location = new System.Drawing.Point(10, 326);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(117, 23);
            this.lID.TabIndex = 137;
            this.lID.Text = "Mã nhân viên";
            // 
            // tbID
            // 
            this.tbID.Animated = true;
            this.tbID.BackColor = System.Drawing.Color.Transparent;
            this.tbID.BorderColor = System.Drawing.Color.Bisque;
            this.tbID.BorderRadius = 5;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.DefaultText = "";
            this.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.DisabledState.Parent = this.tbID;
            this.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.FillColor = System.Drawing.Color.Ivory;
            this.tbID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbID.FocusedState.Parent = this.tbID;
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbID.ForeColor = System.Drawing.Color.Black;
            this.tbID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbID.HoverState.Parent = this.tbID;
            this.tbID.IconLeft = global::CoffeeShopManagement.Properties.Resources.CMND;
            this.tbID.Location = new System.Drawing.Point(14, 358);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbID.PlaceholderText = "";
            this.tbID.SelectedText = "";
            this.tbID.ShadowDecoration.Parent = this.tbID;
            this.tbID.Size = new System.Drawing.Size(245, 47);
            this.tbID.TabIndex = 136;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(193, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 41);
            this.label1.TabIndex = 112;
            this.label1.Text = "CHI TIÊU";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Goldenrod;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(565, 84);
            this.guna2GradientPanel1.TabIndex = 135;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this;
            // 
            // FormExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(565, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.gbExpense);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExpense";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epShowError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGround)).EndInit();
            this.gbExpense.ResumeLayout(false);
            this.gbExpense.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ErrorProvider epShowError;
        private Guna.UI2.WinForms.Guna2GradientButton bCancel;
        private Guna.UI2.WinForms.Guna2GradientButton bOK;
        private Guna.UI2.WinForms.Guna2GroupBox gbExpense;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox tbValue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private Guna.UI2.WinForms.Guna2TextBox tbContent;
        private System.Windows.Forms.PictureBox pbBackGround;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label lID;
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}