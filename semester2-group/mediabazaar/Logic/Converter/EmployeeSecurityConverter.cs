using DataL.DTO;
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
    public class EmployeeSecurityConverter : IConverter<Security, EmployeeDTO>
    {
        public EmployeeDTO Convert(Security source_object)
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
                EmployeeType = 0,
                IsActive = source_object.IsActive,
                Username = source_object.EmployeeCredentials.Username,
            };

            return employeeDTO;
        }

        public Security Convert(EmployeeDTO source_object)
        {
            Address address = ConverterPool.GetConverter<Address, AddressDTO>().Convert(source_object.Address);

            Security security = new Security(source_object.Id, source_object.FirstName, source_object.LastName,
                source_object.Email, address, source_object.DateOfBirth,
                source_object.PhoneNumber, source_object.Bsn, source_object.IsActive);

            return security;
        }

        public EmployeeDTO[] Convert(List<Security> source_object)
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (Security item in CollectionsMarshal.AsSpan(source_object))
            {
                employeeDTOs.Add(Convert(item));
            }

            return employeeDTOs.ToArray();
        }

        public Security[] Convert(List<EmployeeDTO> source_object)
        {
            List<Security> security = new List<Security>();
            foreach (EmployeeDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                security.Add(Convert(item));
            }

            return security.ToArray();
        }
    }
}
