using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class EmployeeModel : UserModel
    {
        public EmployeeModel(UserDTO userDTO) : base(userDTO)
        {
        }
    }
}
