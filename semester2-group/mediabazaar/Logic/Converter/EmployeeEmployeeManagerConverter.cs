using DataL.DTO;
using Logic.ClassManagers;
using Logic.EmployeeTypes;
using Logic.Pool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class EmployeeEmployeeManagerConverter : IConverter<ManagerEmployees, EmployeeDTO>
    {
        public EmployeeDTO Convert(ManagerEmployees source_object)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO
            {
                Id = source_object.Id,
                FirstName = source_object.FirstName,
                LastName = source_object.LastName,
                Email = source_object.Email,
                Address = ConverterPool.GetConverter<Address, AddressDTO>().Convert(source_object.PersonAddress),
                DateOfBirth = source_object.DateOfBirth,
                PhoneNumber = source_object.PhoneNumber,
                Bsn = source_object.Bsn,
                EmployeeType = 4,
                IsActive = source_object.IsActive,
                Username = source_object.EmployeeCredentials.Username
            };

            return employeeDTO;
        }

        public ManagerEmployees Convert(EmployeeDTO source_object)
        {
            Address address = ConverterPool.GetConverter<Address, AddressDTO>().Convert(source_object.Address);

            ManagerEmployees employeeManager = new ManagerEmployees(source_object.Id, source_object.FirstName, source_object.LastName,
                source_object.Email, address, source_object.DateOfBirth,
                source_object.PhoneNumber, source_object.Bsn, source_object.IsActive);

            return employeeManager;
        }

        public EmployeeDTO[] Convert(List<ManagerEmployees> source_object)
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (ManagerEmployees item in CollectionsMarshal.AsSpan(source_object))
            {
                employeeDTOs.Add(Convert(item));
            }

            return employeeDTOs.ToArray();
        }

        public ManagerEmployees[] Convert(List<EmployeeDTO> source_object)
        {
            List<ManagerEmployees> employeeManagers = new List<ManagerEmployees>();
            foreach (EmployeeDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                employeeManagers.Add(Convert(item));
            }

            return employeeManagers.ToArray();
        }
    }
}
