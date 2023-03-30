using System.Data.SqlClient;
using DataL.DTO;

namespace DataL
{
    public class DBHelperDepartment
    {
        //Need implementation and never make a method and throw "new NotImplementedException();"
        //this is what Rafael said
        public bool SaveDepartment(List<DepartmentDTO> departmentDTOs)
        {
            throw new NotImplementedException();
            
        }

        public bool UpdateDepartment(int id, DepartmentDTO d)
        {
            throw new NotImplementedException();
        }

        public bool AddDepartment(DepartmentDTO d)
        {
            throw new NotImplementedException();
        }

        public DepartmentDTO GetDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentDTO> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public bool RemoveDepartment(int id)
        {
            throw new NotImplementedException();
        }
    }
}