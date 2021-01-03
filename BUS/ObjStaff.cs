using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public abstract class ObjStaff : Obj
    {
        public ObjStaff()
        {
            path = Application.LocalUserAppDataPath + "/ImageStaff/";
        }

    }
}
