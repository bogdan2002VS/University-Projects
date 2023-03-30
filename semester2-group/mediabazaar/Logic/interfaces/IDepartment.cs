using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.interfaces
{
    public interface IDepartment
    {
        Department[] GetDepartments();

        Department GetDepartment(int id);

        bool AddDepartment(Department department);

        bool RemoveDepartment(int id);

        bool UpdateDepartment(Department department);
    }
}
