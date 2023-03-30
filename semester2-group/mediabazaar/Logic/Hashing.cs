using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Hashing
    {
        public static string Salt { get; set; }
        public static string[] HashPassword(string password)
        {
            //byte[] salt = CreateSalt();

            Guid guid = Guid.NewGuid();
            byte[] salt = Encoding.UTF8.GetBytes(guid.ToString());

            string passwordHashed = Convert.ToBase64String(HashPassword(password, salt));

            string saltBase64String = Convert.ToBase64String(salt);

            Salt = saltBase64String;
            string[] password_Salt = new string[2];

            password_Salt[0] = passwordHashed;
            password_Salt[1] = saltBase64String;

            return password_Salt;
        }

        public static string HashPassword(string password, string saltBase64String)
        {
            //convert base64 string to normal string 
            byte[] bytes = Convert.FromBase64String(saltBase64String);
            string saltString = Encoding.UTF8.GetString(bytes);

            //encoding it back to byte UTF8
            byte[] salt = Encoding.UTF8.GetBytes(saltString);
            string passwordHashed = Convert.ToBase64String(HashPassword(password, salt));

            StringBuilder passwordHashSalt = new StringBuilder();

            passwordHashSalt.Append(passwordHashed);

            return passwordHashSalt.ToString();
        }

        private static byte[] HashPassword(string password, byte[] salt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));

            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 4; // four cores
            argon2.Iterations = 2;
            argon2.MemorySize = 1024 * 1024; // 1 GB

            return argon2.GetBytes(16);
        }
    }
}
