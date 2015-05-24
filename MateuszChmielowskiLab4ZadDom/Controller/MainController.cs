using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Controller
{
    public static class MainController
    {

        public static decimal RandomLatitude()
        {
            Random random = new Random();
            return random.Next(510409621, 511621218) / 1000000;
        }

        public static decimal RandomLongitude()
        {
            Random random = new Random();
            return random.Next(1686573028, 1714914321) / 10000000;
            throw new NotImplementedException();
        }

        public static string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
 
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
