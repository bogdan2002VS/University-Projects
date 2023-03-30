using DataL.interfaces;
using Logic.interfaces;
using System.ComponentModel.DataAnnotations;

namespace Logic
{
    public class Credentials
    {
        private string username;
        private string? password;
        private RFIDControl rfid;

        [Required]
        public string Username { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? Salt { get; set; }
        public RFIDControl Rfid { get; set; }

        public Credentials(string username, string password, string salt)
        {
            Username = username;
            Password = password;
            Salt = salt;
        }

        public Credentials(string username, string password, RFIDControl rfid)
        {
            Username = username;
            Password = password;
            Rfid = rfid;
        }

        public Credentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Credentials()
        {

        }

        public void GetNewRfid(string id)
        {
            Rfid.SerialNumber = id;
        }
    }
}