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
        private FormLock Lock;
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
            this.Lock = new FormLock(this);
            Lock.Show();
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
            this.Lock.Close();
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

            if (e.Node != null && e.Node.Parent == this.tvHistory.Nodes[0])
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

            if (e.Node != null && e.Node == this.tvHistory.Nodes[1])
            {
                e.Node.Nodes.Clear();

                SqlConnection connection = Data.OpenConnection();
                SqlDataReader reader = Data.ReadData("CHITIEU", connection, " GROUP BY THOIGIAN " +
                    "ORDER BY THOIGIAN DESC", "THOIGIAN");
                DateTime tmp = new DateTime();

                while (reader.HasRows)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    e.Node.Nodes.Add(tmp.GetDate(reader.GetDateTime(0)),
                        tmp.GetDate(reader.GetDateTime(0)), this.imageKeys[1], this.imageKeys[1]);
                }

                e.Node.Expand();
                Data.CloseConnection(ref connection);
            }

            if (e.Node != null && e.Node.Parent == this.tvHistory.Nodes[1])
            {
                e.Node.Nodes.Clear();

                SqlConnection connection = Data.OpenConnection();
                Data.ExeQuery("SET DATEFORMAT DMY", connection);
                SqlDataReader reader = Data.ReadData("CHITIEU", connection, " WHERE THOIGIAN = '" +
                    e.Node.Text + "' ORDER BY ID", "*");
                DateTime tmp = new DateTime();
                Expense expense = null;

                while (reader.HasRows)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    try
                    {
                        expense = new Expense(reader.GetString(0), tmp.GetDate(reader.GetDateTime(1)),
                            reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException)
                    {
                        expense = new Expense(reader.GetString(0), tmp.GetDate(reader.GetDateTime(1)),
                            reader.GetString(2), "", reader.GetInt32(4));
                    }

                    e.Node.Nodes.Add(expense.id.ToString(), expense.id.ToString() + " - " +
                        expense.value.ToString(), this.imageKeys[1], this.imageKeys[1]);
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
                int receipt, expense;

                try
                {
                    receipt = (int)Data.Calculate("SUM", "TRIGIA", "HOADON", " WHERE NGHD >= '" +
                    tmp.GetDate(start) + "' AND NGHD <= '" + tmp.GetDate(end) + "'") -
                    (int)Data.Calculate("SUM", "GIAMGIA", "HOADON", " WHERE NGHD >= '" +
                    tmp.GetDate(start) + "' AND " + "NGHD <= '" + tmp.GetDate(end) + "'");
                }
                catch (Exception)
                {
                    receipt = 0;
                }

                try
                {
                    expense = (int)Data.Calculate("SUM", "SOTIEN", "CHITIEU", " WHERE THOIGIAN >= '" +
                    tmp.GetDate(start) + "' AND THOIGIAN <= '" + tmp.GetDate(end) + "'");
                }
                catch (Exception)
                {
                    expense = 0;
                }

                if (!(receipt == 0 && expense == 0))
                {
                    this.cChart.Series["Receipt - Expense"].Points.Clear();
                    this.cChart.Series["Receipt - Expense"].Points.AddXY("Thu", receipt);
                    this.cChart.Series["Receipt - Expense"].Points.AddXY("Chi", expense);
                    this.lReceipt.Text = receipt.ToString();
                    this.lExpense.Text = expense.ToString();
                    this.cChart.Visible = true;
                }
                else
                {
                    this.lReceipt.Text = this.lExpense.Text = "0";
                    this.cChart.Visible = false;
                }
            }
        }

        private void LoadChart(object sender, EventArgs e)
        {
            this.cChart.Series[0].ChartType = SeriesChartType.Pie;
            this.cChart.Visible = false;
            this.lReceipt.Text = "0";
            this.lExpense.Text = "0";
        }
    }
}
