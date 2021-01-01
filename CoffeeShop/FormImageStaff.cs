using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;

namespace CoffeeShopManagement
{
    public partial class FormImageStaff : FormMain
    {
        #region Operations
        public FormImageStaff(Image image, ID id)
        {
            try
            {
                InitializeComponent();
                this.pbImageItem.Image = image;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.bCancel.Click += CancelClicked;
                this.lID.Text = id.ToString();
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Form Image Staff)");
            }
        }
        #endregion
    }
}
