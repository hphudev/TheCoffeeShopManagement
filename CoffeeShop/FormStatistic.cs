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

namespace CoffeeShopManagement
{
    public partial class FormStatistic : Form
    {
        private FormSell parent;
        private string[] imageKeys = { "receipt", "expense" };

        private void InitTreeView()
        {
            TreeNode receipt = new TreeNode("Thu");
            TreeNode expense = new TreeNode("Chi");
            this.tvHistory.Nodes.Add(receipt);
            this.tvHistory.Nodes.Add(expense);
            this.tvHistory.ImageList = this.ilImageList;
            receipt.ImageKey = receipt.SelectedImageKey = this.imageKeys[0];
            expense.ImageKey = expense.SelectedImageKey = this.imageKeys[1];
        }

        public FormStatistic(FormSell parent)
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
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AfterSelectTreeView(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node == this.tvHistory.Nodes[0])
            {
                e.Node.Nodes.Clear();

                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("HOADON", connection, " GROUP BY NGHD " +
                    "ORDER BY NGHD DESC", "NGHD");
                DateTime tmp = new DateTime();

                while (reader.HasRows)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    e.Node.Nodes.Add(tmp.GetDate(reader.GetDateTime(0)),
                        tmp.GetDate(reader.GetDateTime(0)), this.imageKeys[0], this.imageKeys[0]);
                }

                e.Node.Expand();
                Data.CloseConnection(ref connection);
            }

            if (e.Node != null && e.Node != this.tvHistory.Nodes[0] &&
                e.Node != this.tvHistory.Nodes[1])
            {
                e.Node.Nodes.Clear();

                SqlConnection connection = Data.OpenConnection();
                Data.ExeQuery("SET DATEFORMAT DMY", connection);
                SqlDataReader reader = Data.ReadData("HOADON", connection, " WHERE NGHD = '" +
                    e.Node.Text + "' ORDER BY SOHD", "*");
                DateTime tmp = new DateTime();
                Bill bill = null;

                while (reader.HasRows)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    try
                    {
                        bill = new Bill(reader.GetString(0), tmp.GetDate(reader.GetDateTime(1)),
                            reader.GetString(2), reader.GetString(3), reader.GetInt32(4),
                            reader.GetInt32(5));
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException)
                    {
                        bill = new Bill(reader.GetString(0), tmp.GetDate(reader.GetDateTime(1)),
                            "", "", reader.GetInt32(4),
                            reader.GetInt32(5));
                    }

                    e.Node.Nodes.Add(bill.id.ToString(), bill.id.ToString() + " - " +
                        (bill.value - bill.discount).ToString(), this.imageKeys[0],
                        this.imageKeys[0]);
                }

                e.Node.Expand();
                Data.CloseConnection(ref connection);
            }
        }

        private void OKClicked(object sender, EventArgs e)
        {
            DateTime start = this.dtpStart.Value.AddSeconds(-1);
            DateTime end = this.dtpEnd.Value;

            if (start.CompareTo(end) > 0)
            {
                IO.ExportError("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc");
            }
            else
            {
                DateTime tmp = new DateTime();
                int receipt = Data.Calculate("SUM", "TRIGIA", "HOADON", " WHERE NGHD >= '" +
                    tmp.GetDate(start) + "' AND NGHD <= '" + tmp.GetDate(end) + "'") - Data.Calculate(
                    "SUM", "GIAMGIA", "HOADON", " WHERE NGHD >= '" + tmp.GetDate(start) + "' AND " +
                    "NGHD <= '" + tmp.GetDate(end) + "'");
                this.cChart.Series["Receipt - Expense"].Points.Clear();
                this.cChart.Series["Receipt - Expense"].Points.AddXY("Thu", receipt);
                this.cChart.Series["Receipt - Expense"].Points.AddXY("Chi", 100000);
                this.lReceipt.Text = receipt.ToString();
                this.lExpense.Text = "100000";
            }
        }

        private void LoadChart(object sender, EventArgs e)
        {
            int receipt = Data.Calculate("SUM", "TRIGIA", "HOADON", "") - Data.Calculate("SUM",
                "GIAMGIA", "HOADON", "");
            this.cChart.Series["Receipt - Expense"].Points.AddXY("Thu", receipt);
            this.cChart.Series["Receipt - Expense"].Points.AddXY("Chi", 100000);
            this.cChart.Series[0].ChartType = SeriesChartType.Pie;
            this.lReceipt.Text = receipt.ToString();
            this.lExpense.Text = "100000";
        }
    }
}
