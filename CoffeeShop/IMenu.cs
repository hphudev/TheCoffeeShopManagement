using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public interface IMenu : IForm
    {
        void ClearMenu();

        void FindObjClicked(object sender, EventArgs e);

        void ClearContent(object sender, EventArgs e);

        void ChangeInfoObjClicked(object sender, EventArgs e);

        object GetSelectedObj();

        void LoadData(object sender, DoWorkEventArgs e);

        void ShowProgress(object sender, ProgressChangedEventArgs e);

        void LoadForm(object sender, EventArgs e);

    }
}
