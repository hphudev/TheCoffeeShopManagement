﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class FormTienKhachDua : Form
    {
        FormOrder parent;
        FormLock Lock;
        public FormTienKhachDua(FormOrder parent)
        {
            InitializeComponent();
            this.parent = parent;
            Lock = new FormLock(this);
            tbManHinh.Text = "";
            this.Lock.Show();
            this.Show();
        }

        private void Bt00_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "00";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt0_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "0";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "1";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "2";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "3";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "4";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "5";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "6";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "7";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "8";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            tbManHinh.Text += "9";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void BtAC_Click(object sender, EventArgs e)
        {
            tbManHinh.Text = "";
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void BtCE_Click(object sender, EventArgs e)
        {
            if (tbManHinh.Text.Length == 0)
                return;
            tbManHinh.Text = tbManHinh.Text.Remove(tbManHinh.Text.Length - 1, 1);
            tbManHinh.SelectionStart = tbManHinh.Text.Length;
            tbManHinh.SelectionLength = 0;
        }

        private void BtXacNhan_Click(object sender, EventArgs e)
        {
            if (tbManHinh.Text == "")
                return;
            if (int.Parse(tbManHinh.Text) < this.parent.sumOrders)
            {
                MessageBox.Show("Khách đưa tiền còn thiếu " + (this.parent.sumOrders - int.Parse(tbManHinh.Text)));
                return;
            }
            this.parent.tienKhachDua = int.Parse(tbManHinh.Text);
            this.Close();
        }

        private void FormTienKhachDua_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Lock.Close();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.parent.tienKhachDua = -1;
            this.Close();
        }

        private void TbManHinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
