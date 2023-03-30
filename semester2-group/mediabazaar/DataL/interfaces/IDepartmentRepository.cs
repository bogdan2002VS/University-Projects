using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataL.DTO;

namespace DataL.interfaces
{
    public interface IDepartmentRepository
    {
        DepartmentDTO[] GetDepartments();

        DepartmentDTO GetDepartment(int id);

        bool AddDepartment(DepartmentDTO department);

        bool RemoveDepartment(int id);

        bool UpdateDepartment(DepartmentDTO department);
    }
}
