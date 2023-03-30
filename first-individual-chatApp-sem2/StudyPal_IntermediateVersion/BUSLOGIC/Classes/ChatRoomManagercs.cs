using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BUSLOGIC;
using DAL;
using DAL.DTO;
using BUSLOGIC.Exceptions;
using System.Linq;
using DAL.Exception;

namespace BUSLOGIC.Classes
{
    public class ChatRoomManagercs
    {
        private QueryExecutor queryExecutorMediator;
        public ChatRoomManagercs(QueryExecutor queryExecutorMediator)
        {
            this.queryExecutorMediator = queryExecutorMediator ?? throw new ArgumentNullException(nameof(queryExecutorMediator));
        }
        public List<ChatRoom> GetChatRooms(long subjectId)
        {
            List<ChatRoomDTO> chatRoomsDTOs = (List<ChatRoomDTO>)queryExecutorMediator.Execute(
                $"SELECT * FROM ChatRooms where SubjectID = {subjectId}",
               ProcessResult);

            List<ChatRoom> chatRooms = new List<ChatRoom>();

            foreach (var chatRoomDTO in chatRoomsDTOs)
            {
                chatRooms.Add(new ChatRoom(chatRoomDTO));
            }

            return chatRooms;

        }

        public ChatRoom GetChatRoomByName(string name)
        {
            ChatRoomDTO chatRoomDTO = (ChatRoomDTO)queryExecutorMediator.Execute(
                $"SELECT * FROM ChatRooms where Name = '{name}'",
               ProcessResultForSingleChatRoom);
            return new ChatRoom(chatRoomDTO);

        }
        public ChatRoomDTO ProcessResultForSingleChatRoom(SqlDataReader reader)
        {
            ChatRoomDTO chatRoomDTO = new ChatRoomDTO();
            if (reader.Read())
            {
                chatRoomDTO.ID = (int)Convert.ToInt64(reader["ID"]);
                chatRoomDTO.Name = reader["Name"].ToString();
                chatRoomDTO.Subject = (long)Convert.ToInt64(reader["SubjectID"]);
                chatRoomDTO.AdminID = (long)Convert.ToInt64(reader["AdminID"]);
            }
            else
            {
                throw new Exception("could not load chatrom from database");
            }
                   

            return chatRoomDTO;
        }


        public List<ChatRoomDTO> ProcessResult(SqlDataReader reader)
        {
            List<ChatRoomDTO> chatRoomDTOs = new List<ChatRoomDTO>();
            while (reader.Read())
            {
                ChatRoomDTO dto = new ChatRoomDTO();
                dto.ID = (int)Convert.ToInt64(reader["ID"]);
                dto.Name = reader["Name"].ToString();
                dto.Subject = (long)Convert.ToInt64(reader["SubjectID"]);


                chatRoomDTOs.Add(dto);
            }

            return chatRoomDTOs;
        }

        public long CreateChatRoom(long subjectID, string name, long AdminID)
        {

            return (long)queryExecutorMediator.Execute(
                 $"INSERT INTO ChatRooms (SubjectID,Name,AdminID) OUTPUT Inserted.ID Values({subjectID},'{name}',{AdminID})",
                CreateRoomProcessResult);

        }

        public object CreateRoomProcessResult(SqlDataReader reader)
        {
            
            if (reader.Read())
            {
                return (long)Convert.ToInt64(reader["ID"]);
            }
            throw new Exception("Create room failed!");
        }

        public long SendMessage(long ChatRoomID, string Message, string From)
        {
            return (long)queryExecutorMediator.Execute(
                 $"INSERT INTO Messages (ChatRoomID,Message,[From]) OUTPUT Inserted.ID Values({ChatRoomID},'{Message}','{From}')",
                SentMessageProcessResult);

        }
        public object SentMessageProcessResult(SqlDataReader reader)
        {

            if (reader.Read())
            {
                return (long)Convert.ToInt64(reader["ID"]);
            }
            throw new Exception("Create room failed!");
        }

        public List<Message> GetMessages(long chatRoomId)
        {
            List<MessageDTO> messagesDTOs = (List<MessageDTO>)queryExecutorMediator.Execute(
                $"SELECT * FROM Messages where ChatRoomID = {chatRoomId}",
               GetMessagesProcessResult);

            List<Message> messages = new List<Message>();

            foreach (var message in messagesDTOs)
            {
                messages.Add(new Message(message));
            }

            return messages;

        }

        public List<MessageDTO> GetMessagesProcessResult(SqlDataReader reader)
        {
            List<MessageDTO> messagesDTOs = new List<MessageDTO>();
            while (reader.Read())
            {
                MessageDTO dto = new MessageDTO();
                dto.ID = (long)Convert.ToInt64(reader["ID"]);
                dto.ChatRoomID= (long)Convert.ToInt64(reader["ChatRoomID"]);
                dto.Message = reader["Message"].ToString();
                dto.From = reader["From"].ToString();


                messagesDTOs.Add(dto);
            }

            return messagesDTOs;
        }

        public long DeleteChatRoom(long chatRoomId)
        {
            return (long)queryExecutorMediator.Execute(
                $"Delete From ChatRooms where ID = {chatRoomId}",
               DeleteChatRoomProcessResult);

        }
    

        public object DeleteChatRoomProcessResult(SqlDataReader reader)
        {
             return 1L;

        }


        public object DeleteMessage(long chatRoomId)
        {
            return (long)queryExecutorMediator.Execute(
                $"Delete From Messages where ChatRoomID = {chatRoomId}",
               DeleteMessagesProcessResult);

        }


        public object DeleteMessagesProcessResult(SqlDataReader reader)
        {

            return 1L;
        }

    }
}
