using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class ID
    {
        private string id;

        public ID(string id)
        {
            this.id = id;
        }

        public int FindID(string code)
        {
            char[] cCode = code.ToCharArray();
            string[] result = id.Split(cCode);
            return int.Parse(result[1]);
        }

        public void SetID(int id, string code, int iAmountNumber)
        {
            this.id = code;

            for (int i = 0; i < iAmountNumber - (id / 10 + 1); i++)
            {
                this.id += "0";
            }

            this.id += id.ToString();
        }

        public override string ToString()
        {
            return this.id;
        }
    }
}
