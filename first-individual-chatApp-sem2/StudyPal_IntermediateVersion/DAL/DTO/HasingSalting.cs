using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL.DTO
{
    public class HashingSalting
    {
        public static string CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public static string GenerateSHA256Hash(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed sha256hashstring = new SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            string result = Convert.ToBase64String(hash);

            return result;
        }
    }
}
