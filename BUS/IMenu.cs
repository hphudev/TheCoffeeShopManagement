using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public interface IMenu
    {
        object GetSelectedObj(DataGridView dgvMenu);

        void AddRow(SqlDataReader reader, DataGridView menu, ComboBox finder, 
            AutoCompleteStringCollection sourceData);

    }
}
