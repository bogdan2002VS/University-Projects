using DataL;
using DataL.DTO;
using DataL.interfaces;
using Logic.interfaces;
using Logic.Pool;

namespace Logic.ClassManagers
{
    public class DepartmentManager : IDepartment
    {
        private readonly IDepartmentRepository departmentRepository = new DepartmentRepository();

        public List<Department> Departments { get; set; }

        public DepartmentManager()
        {
        }

        public Department[] GetDepartments()
        {
            List<DepartmentDTO> departmentsDTO = departmentRepository.GetDepartments().ToList();

            Department[] departments = ConverterPool.GetConverter<Department, DepartmentDTO>().Convert(departmentsDTO);

            return departments.ToArray();
        }

        public Department GetDepartment(int id)
        {
            DepartmentDTO departmentDTO = departmentRepository.GetDepartment(id);

            Department department = ConverterPool.GetConverter<Department, DepartmentDTO>().Convert(departmentDTO);

            return department;
        }

        public bool AddDepartment(Department department)
        {
            DepartmentDTO departmentDTO = ConverterPool.GetConverter<Department, DepartmentDTO>().Convert(department);

            return departmentRepository.AddDepartment(departmentDTO);
        }

        public bool RemoveDepartment(int id)
        {
            return departmentRepository.RemoveDepartment(id);
        }

        public bool UpdateDepartment(Department department)
        {
            DepartmentDTO departmentDTO = ConverterPool.GetConverter<Department, DepartmentDTO>().Convert(department);

            return departmentRepository.UpdateDepartment(departmentDTO);
        }
    }
}