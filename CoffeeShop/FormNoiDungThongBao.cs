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
    public partial class FormNoiDungThongBao : Form
    {
        FormSell parent;
        FormLock khoa;
        Timer check = new Timer();
        public FormNoiDungThongBao(FormSell parent)
        {
            InitializeComponent();
            this.parent = parent;
            check.Interval = 10000;
            check.Tick += (s, e) =>
            {
                FormNoiDungThongBao_Load(this, new EventArgs());
            };
            check.Start();
            //khoa = new FormLock(this);
            //khoa.Show();
            Data.UpdateData("THONGBAO", "TINHTRANGXEM = 1", "");
            
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            check.Stop();
            //this.parent.CheckThongBao.Start();
            khoa.Close();
            this.Close();
        }

        private void FormNoiDungThongBao_Load(object sender, EventArgs e)
        {
            SqlConnection con = Data.OpenConnection();
            SqlDataReader read = Data.ReadData("THONGBAO", con, "where TINHTRANG = 1", "NOIDUNG");
            while (read.HasRows)
            {
                if (!read.Read())
                    return;
                tbNoiDung.Text = read.GetString(0);
            }
            Data.CloseConnection(ref con);
        }

        public void SetLockForm(ref FormLock khoa)
        {
            this.khoa = khoa;
        }
    }
}
