using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DTO
{
    public class ChatRoomDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public long Subject { get; set; }

        public long AdminID { get; set; }
    }
}
