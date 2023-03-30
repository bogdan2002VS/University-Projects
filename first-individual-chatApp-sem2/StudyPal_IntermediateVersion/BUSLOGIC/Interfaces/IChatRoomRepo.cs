using System;
using System.Collections.Generic;
using System.Text;
using DAL.DTO;

namespace BUSLOGIC.Interfaces
{
    public interface IChatRoomRepo
    {
        public IEnumerable<ChatRoomDTO> GetAll();
    }
}
