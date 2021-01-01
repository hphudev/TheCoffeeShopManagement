using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public abstract class AddObj : Obj
    {
        public abstract bool AddNewObj(object arg1, object arg2 = null);

    }
}
