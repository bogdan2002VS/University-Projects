using DAL.DTO;
using Logic.Account.Model;
using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CustomerModel : UserModel
    {
        public CustomerModel()
        {

        }
        public CustomerModel(UserDTO userDTO) : base(userDTO)
        {
        }
       
    }
}
