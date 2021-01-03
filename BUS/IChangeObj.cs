using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface IChangeObj : IObj
    {
        bool ChangeInfoObj(object arg1, object arg2 = null);

    }
}
