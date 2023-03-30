using System;
using System.Collections.Generic;
using System.Text;
using DAL.DTO;
namespace BUSLOGIC.Classes
{
    public class ChatRoom
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public long Subject { get; set;}

        public long AdminID { get; set; }

        public ChatRoom(ChatRoomDTO chatRoomDTO)
        {
            ID = chatRoomDTO.ID;
            Name = chatRoomDTO.Name;
            Subject = chatRoomDTO.Subject;
            AdminID = chatRoomDTO.AdminID;
            //Messages = chatRoomDTO.Messages;
        }

        public ChatRoom()
        {
           
        }

        public override bool Equals(object obj)
        {
            return obj is ChatRoom room &&
                   ID == room.ID &&
                   Name == room.Name &&
                   Subject == room.Subject &&
                   AdminID == room.AdminID;
        }
    }
}
