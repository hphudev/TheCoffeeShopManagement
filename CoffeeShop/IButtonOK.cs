using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public interface IButtonOK : IButton
    {
        void OKClicked(object sender, EventArgs e);

    }
}
