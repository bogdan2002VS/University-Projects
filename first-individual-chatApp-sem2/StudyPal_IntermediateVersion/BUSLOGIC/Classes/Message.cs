using System;
using System.Collections.Generic;
using System.Text;
using DAL.DTO;

namespace BUSLOGIC.Classes
{
    public class Message
    {
        long ID { get; set; }
        public string Text { get; set; }


        public string From { get; set; }

        public long ChatRoomID { get; set; }


        public Message(MessageDTO messageDTO)
        {
            ID = messageDTO.ID;
            ChatRoomID = messageDTO.ChatRoomID;
            Text = messageDTO.Message;
            From = messageDTO.From;
        }
    }
}
