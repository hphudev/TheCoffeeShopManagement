namespace CoffeeShopManagement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tvHistory = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ilImageList = new System.Windows.Forms.ImageList(this.components);
            this.lbNhanKhachHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lExpense = new System.Windows.Forms.Label();
            this.lReceipt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChart)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(123, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch sử";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xem kết quả thống kê";
            // 
            // ilImageList
            // 
            this.ilImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ilImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbNhanKhachHang
            // 
            this.lbNhanKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNhanKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNhanKhachHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanKhachHang.ForeColor = System.Drawing.Color.White;
            this.lbNhanKhachHang.Location = new System.Drawing.Point(0, 0);
            this.lbNhanKhachHang.Name = "lbNhanKhachHang";
            this.lbNhanKhachHang.Size = new System.Drawing.Size(1355, 69);
            this.lbNhanKhachHang.TabIndex = 16;
            this.lbNhanKhachHang.Text = "THỐNG KÊ TÀI CHÍNH";
            this.lbNhanKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.bCancel);
            this.groupBox1.Controls.Add(this.bOK);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(531, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 246);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian thống kê";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.lExpense);
            this.groupBox2.Controls.Add(this.lReceipt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cChart);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(531, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 388);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng thu và chi";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tổng thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng chi";
            // 
            // cChart
            // 
            this.cChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.cChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cChart.Legends.Add(legend1);
            this.cChart.Location = new System.Drawing.Point(249, 22);
            this.cChart.Name = "cChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Receipt - Expense";
            this.cChart.Series.Add(series1);
            this.cChart.Size = new System.Drawing.Size(371, 360);
            this.cChart.TabIndex = 16;
            this.cChart.Text = "chart1";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1355, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNhanKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvHistory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ilImageList;
        private System.Windows.Forms.Label lbNhanKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cChart;
        private System.Windows.Forms.Label lExpense;
        private System.Windows.Forms.Label lReceipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}