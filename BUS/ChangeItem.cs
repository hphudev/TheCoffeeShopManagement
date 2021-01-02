using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace BUS
{
    public class ChangeItem : ObjItem, IChangeObj
    {
        public override void AddImageClicked(ref PictureBox pbImageItem, object item = null)
        {
            AddImage(ref pbImageItem, "./ImageItem/", ((Item)item).id.ToString());
        }

        public void ChangeInfoObj(object item, object arg = null)
        {
            Item updatedItem = (Item)item;
            Data.UpdateData("MON", "DVT = '" + updatedItem.unit + "', GIA = '" + updatedItem.price +
                "'", " WHERE MAMON = '" + updatedItem.id.ToString() + "'");
            IO.ExportSuccess("Sửa món thành công");
        }

    }
}
