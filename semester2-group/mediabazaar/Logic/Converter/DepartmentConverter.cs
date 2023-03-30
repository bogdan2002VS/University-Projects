using DataL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class DepartmentConverter : IConverter<Department, DepartmentDTO>
    {
        public DepartmentDTO Convert(Department source_object)
        {
            DepartmentDTO departmentDTO = new DepartmentDTO()
            {
                Id= source_object.Id,
                Name = source_object.Name,
            };

            return departmentDTO;
        }

        public Department Convert(DepartmentDTO source_object)
        {
            Department department = new Department()
            {
                Id = source_object.Id,
                Name = source_object.Name,
            };

            return department;
        }

        public DepartmentDTO[] Convert(List<Department> source_object)
        {
            List<DepartmentDTO> result = new List<DepartmentDTO>();
            source_object.ForEach(d => result.Add(Convert(d)));

            return result.ToArray();
        }

        public Department[] Convert(List<DepartmentDTO> source_object)
        {
            List<Department> result = new List<Department>();
            source_object.ForEach(d => result.Add(Convert(d)));

            return result.ToArray();
        }
    }
}
