namespace GUI
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tvHistory = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lHeader = new System.Windows.Forms.Label();
            this.ilImageList = new System.Windows.Forms.ImageList(this.components);
            this.gbChooseTimeSpan = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lEnd = new System.Windows.Forms.Label();
            this.lStart = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lExpense = new System.Windows.Forms.Label();
            this.lReceipt = new System.Windows.Forms.Label();
            this.lSumReceipt = new System.Windows.Forms.Label();
            this.lSumExpense = new System.Windows.Forms.Label();
            this.cChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.gbChooseTimeSpan.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChart)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvHistory
            // 
            this.tvHistory.BackColor = System.Drawing.Color.White;
            this.tvHistory.Location = new System.Drawing.Point(1, 119);
            this.tvHistory.Name = "tvHistory";
            this.tvHistory.Size = new System.Drawing.Size(383, 637);
            this.tvHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch sử";
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(684, 76);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(323, 37);
            this.lHeader.TabIndex = 2;
            this.lHeader.Text = "Xem kết quả thống kê";
            // 
            // ilImageList
            // 
            this.ilImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ilImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gbChooseTimeSpan
            // 
            this.gbChooseTimeSpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbChooseTimeSpan.Controls.Add(this.bCancel);
            this.gbChooseTimeSpan.Controls.Add(this.bOK);
            this.gbChooseTimeSpan.Controls.Add(this.dtpEnd);
            this.gbChooseTimeSpan.Controls.Add(this.dtpStart);
            this.gbChooseTimeSpan.Controls.Add(this.lEnd);
            this.gbChooseTimeSpan.Controls.Add(this.lStart);
            this.gbChooseTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChooseTimeSpan.Location = new System.Drawing.Point(531, 119);
            this.gbChooseTimeSpan.Name = "gbChooseTimeSpan";
            this.gbChooseTimeSpan.Size = new System.Drawing.Size(627, 246);
            this.gbChooseTimeSpan.TabIndex = 17;
            this.gbChooseTimeSpan.TabStop = false;
            this.gbChooseTimeSpan.Text = "Thời gian thống kê";
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.Location = new System.Drawing.Point(492, 180);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(87, 41);
            this.bCancel.TabIndex = 14;
            this.bCancel.Text = "Thoát";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // bOK
            // 
            this.bOK.BackColor = System.Drawing.Color.Lime;
            this.bOK.Location = new System.Drawing.Point(208, 180);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(101, 41);
            this.bOK.TabIndex = 13;
            this.bOK.Text = "Đồng ý";
            this.bOK.UseVisualStyleBackColor = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(212, 116);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(367, 26);
            this.dtpEnd.TabIndex = 12;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(212, 54);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(367, 26);
            this.dtpStart.TabIndex = 11;
            // 
            // lEnd
            // 
            this.lEnd.AutoSize = true;
            this.lEnd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnd.Location = new System.Drawing.Point(19, 114);
            this.lEnd.Name = "lEnd";
            this.lEnd.Size = new System.Drawing.Size(147, 27);
            this.lEnd.TabIndex = 10;
            this.lEnd.Text = "Ngày kết thúc";
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStart.Location = new System.Drawing.Point(19, 52);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(140, 27);
            this.lStart.TabIndex = 9;
            this.lStart.Text = "Ngày bắt đầu";
            // 
            // gbResult
            // 
            this.gbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbResult.Controls.Add(this.lExpense);
            this.gbResult.Controls.Add(this.lReceipt);
            this.gbResult.Controls.Add(this.lSumReceipt);
            this.gbResult.Controls.Add(this.lSumExpense);
            this.gbResult.Controls.Add(this.cChart);
            this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(531, 371);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(627, 388);
            this.gbResult.TabIndex = 18;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Tổng thu và chi";
            // 
            // lExpense
            // 
            this.lExpense.AutoSize = true;
            this.lExpense.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExpense.Location = new System.Drawing.Point(157, 166);
            this.lExpense.Name = "lExpense";
            this.lExpense.Size = new System.Drawing.Size(0, 27);
            this.lExpense.TabIndex = 20;
            // 
            // lReceipt
            // 
            this.lReceipt.AutoSize = true;
            this.lReceipt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReceipt.Location = new System.Drawing.Point(157, 98);
            this.lReceipt.Name = "lReceipt";
            this.lReceipt.Size = new System.Drawing.Size(0, 27);
            this.lReceipt.TabIndex = 19;
            // 
            // lSumReceipt
            // 
            this.lSumReceipt.AutoSize = true;
            this.lSumReceipt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSumReceipt.Location = new System.Drawing.Point(34, 98);
            this.lSumReceipt.Name = "lSumReceipt";
            this.lSumReceipt.Size = new System.Drawing.Size(98, 27);
            this.lSumReceipt.TabIndex = 18;
            this.lSumReceipt.Text = "Tổng thu";
            // 
            // lSumExpense
            // 
            this.lSumExpense.AutoSize = true;
            this.lSumExpense.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSumExpense.Location = new System.Drawing.Point(34, 166);
            this.lSumExpense.Name = "lSumExpense";
            this.lSumExpense.Size = new System.Drawing.Size(96, 27);
            this.lSumExpense.TabIndex = 17;
            this.lSumExpense.Text = "Tổng chi";
            // 
            // cChart
            // 
            this.cChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.cChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cChart.Legends.Add(legend3);
            this.cChart.Location = new System.Drawing.Point(249, 22);
            this.cChart.Name = "cChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Receipt - Expense";
            this.cChart.Series.Add(series3);
            this.cChart.Size = new System.Drawing.Size(371, 360);
            this.cChart.TabIndex = 16;
            this.cChart.Text = "chart1";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Teal;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Goldenrod;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1355, 76);
            this.guna2GradientPanel1.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(503, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 41);
            this.label5.TabIndex = 112;
            this.label5.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1355, 771);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbChooseTimeSpan);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.lHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvHistory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.gbChooseTimeSpan.ResumeLayout(false);
            this.gbChooseTimeSpan.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChart)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.ImageList ilImageList;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbChooseTimeSpan;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lEnd;
        private System.Windows.Forms.Label lStart;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart cChart;
        private System.Windows.Forms.Label lExpense;
        private System.Windows.Forms.Label lReceipt;
        private System.Windows.Forms.Label lSumReceipt;
        private System.Windows.Forms.Label lSumExpense;
    }
}