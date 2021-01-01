using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public abstract class ChangeObj : Obj
    {
        public abstract void ChangeInfoObj(object arg1, object arg2 = null);

    }
}
