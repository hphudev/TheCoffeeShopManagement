using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
using DAO;
using DTO;

namespace GUI
{
    public partial class FormStatistic : Form
    {
        #region Atrributes
        private FormSell parent;
        private FormLock Lock;
        private string[] imageKeys = { "receipt", "expense" };
        #endregion

        #region Operations
        private void InitTreeView()
        {
            try
            {
                TreeNode receipt = new TreeNode("Thu");
                TreeNode expense = new TreeNode("Chi");
                this.tvHistory.Nodes.Add(receipt);
                this.tvHistory.Nodes.Add(expense);
                this.tvHistory.ImageList = this.ilImageList;
                receipt.ImageKey = receipt.SelectedImageKey = this.imageKeys[0];
                expense.ImageKey = expense.SelectedImageKey = this.imageKeys[1];
                //this.Lock = new FormLock(this);
                //Event.ShowForm(this.Lock);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 42 Form Statistic");
            }
        }

        public FormStatistic(FormSell parent)
        {
            try
            {
                InitializeComponent();
                this.parent = parent;
                this.ilImageList.Images.Add(imageKeys[0], Image.FromFile("./ImageItem/receipt.jpg"));
                this.ilImageList.Images.Add(imageKeys[1], Image.FromFile("./ImageItem/expense.jpg"));
                InitTreeView();
                this.StartPosition = FormStartPosition.CenterScreen;

                this.FormClosed += CloseForm;
                this.bOK.Click += OKClicked;
                this.bCancel.Click += CancelClicked;
                this.tvHistory.AfterSelect += AfterSelectTreeView;
                this.Load += LoadChart;
                MoveUI(false, 150);
                this.DoubleBuffered = true;
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 67 Form Statistic");
            }
        }

        public void MoveUI(bool isVisible, int value)
        {
            this.gbResult.Visible = isVisible;
            this.lReceipt.Visible = isVisible;
            this.lExpense.Visible = isVisible;
            this.lSumExpense.Visible = isVisible;
            this.lSumReceipt.Visible = isVisible;
            this.lHeader.Location = new Point(this.lHeader.Location.X, this.lHeader.Location.Y +
                value);
            this.gbChooseTimeSpan.Location = new Point(this.gbChooseTimeSpan.Location.X,
                this.gbChooseTimeSpan.Location.Y + value);
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Event.CloseForm(this.Lock);
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            Event.CloseForm(this);
        }

        private void AfterSelectTreeView(object sender, TreeViewEventArgs e)
        {
            try
            {
                Event.AfterSelectTreeView(e, this.tvHistory.Nodes, this.imageKeys);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 102 Form Statistic");
            }
        }

        private void OKClicked(object sender, EventArgs e)
        {
            try
            {
                DateTime start = this.dtpStart.Value.AddSeconds(-1);
                DateTime end = this.dtpEnd.Value;
                int receipt = 0, expense = 0;
                Event.Statistic(start, end, ref receipt, ref expense);
                this.cChart.Series["Receipt - Expense"].Points.Clear();
                this.cChart.Series["Receipt - Expense"].Points.AddXY("Thu", receipt);
                this.cChart.Series["Receipt - Expense"].Points.AddXY("Chi", expense);
                this.lReceipt.Text = receipt.ToString();
                this.lExpense.Text = expense.ToString();

                if (!this.cChart.Visible)
                {
                    this.cChart.Visible = true;
                    MoveUI(true, -150);
                }

                this.Invalidate();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 130 Form Statistic");
            }
        }

        private void LoadChart(object sender, EventArgs e)
        {
            try
            {
                this.cChart.Series[0].ChartType = SeriesChartType.Pie;
                this.cChart.Visible = false;
                this.lReceipt.Text = "0";
                this.lExpense.Text = "0";
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 145 Form Statistic");
            }
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.Lock = khoa;
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
