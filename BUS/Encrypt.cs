using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DAO;

namespace BUS
{
    public static class Encrypt
    {
        #region Operations
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
                IO.ExportError("Lỗi không xác định\n(Class Encrypt)");
                return null;
            }
        }
        #endregion
    }
}
