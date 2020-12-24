using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CoffeeShopManagement
{
    public static class Encrypt
    {
        public static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            try
            {
                Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                Byte[] hashBytes = algorithm.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes);
            }
            catch (Exception)
            {
                IO.ExportError("Lỗi không xác định\n(Line 22 Class Encrypt)");
                return null;
            }
        }
    }
}
