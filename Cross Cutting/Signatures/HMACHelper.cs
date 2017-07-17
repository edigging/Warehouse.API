using System;
using System.Security.Cryptography;
using System.Text;

namespace Warehouse.API.Cross_Cutting.Signatures
{
    public class HMACSHA1Helper
    {       

        public string ComputeHash(string hashKey, string message)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();

            var hash = new HMACSHA1(encoding.GetBytes(hashKey))
                .ComputeHash(encoding.GetBytes(message));

            return ByteArrayToString(hash);
        }

        private static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private static string ByteArrayToString2(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }
    }
}
