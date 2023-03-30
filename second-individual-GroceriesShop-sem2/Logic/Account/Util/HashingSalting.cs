using System.Security.Cryptography;
using System.Text;

namespace Logic.Account.Util
{
    public class HashingSalting
    {
        public static string CreateSalt(int size)
        {
            try
            {
                var rng = new RNGCryptoServiceProvider();
                var buff = new byte[size];
                rng.GetBytes(buff);
                return Convert.ToBase64String(buff);
            }
            catch (Exception ex)
            {

                throw new Exception("Sorry could not create salt for the password",ex);
            }
           
        }

        public static string GenerateSHA256Hash(string password, string salt)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
                SHA256Managed sha256hashstring = new SHA256Managed();
                byte[] hash = sha256hashstring.ComputeHash(bytes);

                string result = Convert.ToBase64String(hash);

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Sorry could not generate hash for the password", ex);
            }
           

        }
    }
}
