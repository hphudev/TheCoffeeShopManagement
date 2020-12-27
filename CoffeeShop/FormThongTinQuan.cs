using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CoffeeShopManagement
{
    public partial class FormThongTinQuan : Form
    {
        FormLock khoa;
        string name, link, address, loichao, wifi;
        public FormThongTinQuan()
        {
            InitializeComponent();
            //khoa = new FormLock(this);
            //khoa.Show();
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            tbName.Text = name;
            tbWeb.Text = link;
            tbAddress.Text = address;
            tbLoiChao.Text = loichao;
            tbWifi.Text = wifi;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            khoa.Close();
        }

        private void FormThongTinQuan_Load(object sender, EventArgs e)
        {
            SqlConnection con = Data.OpenConnection();
            SqlDataReader read = Data.ReadData("QUAN", con, "", "*");
            while (read.HasRows)
            {
                if (!read.Read())
                    break;
                name = tbName.Text = read.GetString(0);
                link = tbWeb.Text = read.GetString(1);
                address = tbAddress.Text = read.GetString(2);
                loichao = tbLoiChao.Text = read.GetString(3);
                wifi = tbWifi.Text = read.GetString(4);
            }
            Data.CloseConnection(ref con);
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            Data.UpdateData("QUAN", $"TENQUAN = N'{tbName.Text}', LINK = N'{tbWeb.Text}', DIACHI = N'{tbAddress.Text}', LOICHAO = N'{tbLoiChao.Text}', WIFI = '{tbWifi.Text}'", "");
            IO.ExportSuccess("Cập nhật thành công");
            BCancel_Click(this, new EventArgs());
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }
    }
}
